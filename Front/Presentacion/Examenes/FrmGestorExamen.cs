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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Front.Presentacion.Examenes
{
    public partial class FrmGestorExamen : Form
    {
        private Examen examenNuevo;
        private Examen examenExistente;
        private bool esModoEdicion;

        private async void ExamenFrm_Load(object sender, EventArgs e)
        {
            if (examenNuevo != null)
                await CargarDatosAsync<Materia>(Properties.Resources.URL + "/materias", cboMaterias, "NombreMateria", "IdMateria");

            if (examenExistente != null)
            {
                CargarComponentesExamen();
            }
            cboMaterias.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAlumnos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDocentes.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        #region Logica para crear un Examen Nuevo
        public FrmGestorExamen()
        {
            InitializeComponent();
            examenNuevo = new Examen();
            Habilitar(false);
            esModoEdicion = false;
            btnEditar.Enabled = false;
            btnEditar.Visible = false;
            btnAceptar.Location = new Point(442, 376);
        }

        private async Task<bool> CrearExamenAsync(Examen examen)
        {
            string url = $"{Properties.Resources.URL}/examen";
            string examenJson = JsonConvert.SerializeObject(examen);
            var dataJson = await ClienteSingleton.GetInstance().PostAsync(url, examenJson);

            return dataJson.Equals("true");
        }
        #endregion

        #region Logica para Editar un Examen
        public FrmGestorExamen(Examen examen)
        {
            InitializeComponent();
            examenExistente = examen;
            HabilitarExamenExistente(false);
            dgvDetalles.Enabled = true;
            esModoEdicion = true;
        }
        private void CargarComponentesExamen()
        {
            if (examenExistente != null)
            {
                dtpFecha.Value = examenExistente.FechaExamen;

                cboMaterias.DataSource = new List<Materia> { examenExistente.MateriaExamen };
                cboMaterias.DisplayMember = "NombreMateria";
                cboMaterias.ValueMember = "IdMateria";

                cboDocentes.DataSource = new List<Docente> { examenExistente.DocenteExamen };
                cboDocentes.DisplayMember = "Apellido";
                cboDocentes.ValueMember = "IdDocente";


                foreach (DetalleAlumnoExamen detalle in examenExistente.DetallesExamen)
                {
                    dgvDetalles.Rows.Add(new object[] { detalle.AlumnoDetalle.IdAlumno,detalle.AlumnoDetalle.Nombre,
                                detalle.AlumnoDetalle.Apellido, detalle.NotaDetalle});
                }
            }
        }
        private async void btnEditar_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            await CargarDatosAsync<Materia>(Properties.Resources.URL + "/materias", cboMaterias, "NombreMateria", "IdMateria");
        }

        private async Task<bool> EditarExamenAsync(Examen examen)
        {
            string url = $"{Properties.Resources.URL}/examen";
            string examenJson = JsonConvert.SerializeObject(examen);
            var dataJson = await ClienteSingleton.GetInstance().PutAsync(url, examenJson);

            return dataJson.Equals("true");
        }
        #endregion

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

            if (esModoEdicion)
            {
                GrabarExamenAsync(examenExistente);
            }
            else
            {
                GrabarExamenAsync(examenNuevo);
            }
        }

        private async void GrabarExamenAsync(Examen examen)
        {
            examen.FechaExamen = dtpFecha.Value;
            examen.MateriaExamen = (Materia)cboMaterias.SelectedItem;
            examen.DocenteExamen = (Docente)cboDocentes.SelectedItem;

            if (esModoEdicion)
            {
                if (await EditarExamenAsync(examenExistente))
                {
                    MessageBox.Show("Se actualizo con éxito!!!");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el examen...");
                }
            }
            else
            {
                if (await CrearExamenAsync(examenNuevo))
                {
                    MessageBox.Show("Se registró con éxito!!!");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el examen...");
                }
            }
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
            if (cboAlumnos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar al menos un alumno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

            if (esModoEdicion)
            {
                examenExistente.AgregarDetalle(detalle);
            }
            else
            {

                examenNuevo.AgregarDetalle(detalle);
            }

            dgvDetalles.Rows.Add(new object[] { detalle.AlumnoDetalle.IdAlumno,detalle.AlumnoDetalle.Nombre,
                                detalle.AlumnoDetalle.Apellido, detalle.NotaDetalle, "Quitar"});
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 4)
            {
                if (esModoEdicion)
                {
                    examenExistente.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                }
                else
                {
                    examenNuevo.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                }

                dgvDetalles.Rows.RemoveAt(dgvDetalles.CurrentRow.Index);
            }
        }

        #region Habilitar y Desahabilitar Componentes
        private void Habilitar(bool x)
        {
            pnlExamen.Enabled = x;
            btnAceptar.Enabled = x;
            btnConfirmar.Enabled = !x;
            cboMaterias.Enabled = !x;
        }
        private void HabilitarExamenExistente(bool x)
        {
            Habilitar(x);
            dtpFecha.Enabled = x;
            cboMaterias.Enabled = x;
            btnConfirmar.Enabled = x;
        }
        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                this.Dispose();
        }
    }
}
