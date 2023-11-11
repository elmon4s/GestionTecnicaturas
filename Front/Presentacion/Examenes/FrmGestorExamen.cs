using Back.Dominio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Front.Cliente;

namespace Front.Presentacion.Examenes
{
    public partial class FrmGestorExamen : Form
    {
        private Examen nuevoExamen;
        public FrmGestorExamen()
        {
            InitializeComponent();
            nuevoExamen = new Examen();
            Habilitar(false);
        }

        private async void ExamenFrm_Load(object sender, EventArgs e)
        {
            await CargarDatosAsync<Materia>(Properties.Resources.URL + "/materias", cboMaterias, "NombreMateria", "IdMateria");
            cboMaterias.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAlumnos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDocentes.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async Task CargarDatosAsync<T>(string apiUrl, ComboBox comboBox, string displayMember, string valueMember)
        {
            var resultado = await ClienteSingleton.GetInstance().GetAsync(apiUrl);
            List<T> lst = JsonConvert.DeserializeObject<List<T>>(resultado);

            comboBox.DataSource = lst;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }
        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea confirmar la Materia?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                            , MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                return;
            }
            int idMateria = (int)cboMaterias.SelectedValue;
            await CargarDatosAsync<Alumno>($"{Properties.Resources.URL}/alumnosExamen?materia={idMateria}", cboAlumnos, "Apellido", "IdAlumno");
            await CargarDatosAsync<Docente>($"{Properties.Resources.URL}/docentesExamen?materia={idMateria}", cboDocentes, "Apellido", "IdDocente");
            Habilitar(true);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (nudNota.Value < 1 || nudNota.Value > 10)
            {
                MessageBox.Show("Debe seleccionar una nota del 1 al 10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataGridViewRow fila in dgvDetalles.Rows)
            {
                Alumno a = (Alumno)cboAlumnos.SelectedItem;
                if ((int)fila.Cells["ColID"].Value == a.IdAlumno)
                {
                    MessageBox.Show("Este Alumno ya fue seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            Alumno alumno = (Alumno)cboAlumnos.SelectedItem;

            DetalleAlumnoExamen detalle = new DetalleAlumnoExamen();
            detalle.AlumnoDetalle = alumno;
            detalle.NotaDetalle = (int)nudNota.Value;
            nuevoExamen.AgregarDetalle(detalle);

            dgvDetalles.Rows.Add(new object[] { detalle.AlumnoDetalle.IdAlumno,detalle.AlumnoDetalle.Nombre,
                                detalle.AlumnoDetalle.Apellido, detalle.NotaDetalle, "Quitar"});
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dtpFecha.Value > DateTime.Now)
            {
                MessageBox.Show("Debe ingresar una fecha valida!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgvDetalles.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un alumno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            GrabarExamenAsync();
        }

        private async void GrabarExamenAsync()
        {
            nuevoExamen.FechaExamen = dtpFecha.Value;
            nuevoExamen.MateriaExamen = (Materia)cboMaterias.SelectedItem;
            nuevoExamen.DocenteExamen = (Docente)cboDocentes.SelectedItem;

            if (await CrearExamenAsync(nuevoExamen))
            {
                MessageBox.Show("Se registró con éxito!!!");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("No se pudo registrar el examen...");
            }
        }

        private async Task<bool> CrearExamenAsync(Examen examen)
        {
            string url = $"{Properties.Resources.URL}/examen";
            string examenJson = JsonConvert.SerializeObject(examen);
            var dataJson = await ClienteSingleton.GetInstance().PostAsync(url, examenJson);

            return dataJson.Equals("true");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                this.Dispose();
        }

        private void Habilitar(bool x)
        {
            pnlExamen.Enabled = x;
            btnAceptar.Enabled = x;
            btnConfirmar.Enabled = !x;
            cboMaterias.Enabled = !x;
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 4)
            {
                nuevoExamen.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.RemoveAt(dgvDetalles.CurrentRow.Index);
            }
        }
    }
}
