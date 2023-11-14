using Back.Dominio;
using Front.Cliente;
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

namespace Front.Presentacion.Alumnos
{
    public partial class FrmGestorAlumno : Form
    {
        Alumno oAlumno;
        bool nuevo = true;
        DetalleMateriaComision dmc;
        public FrmGestorAlumno(int codAlumno)
        {
            InitializeComponent();

            oAlumno = new Alumno();
            oAlumno.IdAlumno = codAlumno;
        }

        private async void FrmGestorAlumno_Load(object sender, EventArgs e)
        {
            numId.Controls[0].Visible = false;
            numAltura.Controls[0].Visible = false;

            await CargarComboAsync<Barrio>(UrlCompleta("/barrios"), cboBarrio);
            await CargarComboAsync<EstadoCivil>(UrlCompleta("/estadosciviles"), cboEstadoCivil);
            await CargarComboAsync<SituacionLaboral>(UrlCompleta("/situacioneslab"), cboSituacionLaboral);
            await CargarComboAsync<EstadoAcademico>(UrlCompleta("/estadosacademicos"), cboEstado);


            if (oAlumno.IdAlumno != 0)
            {
                var res = await ClienteSingleton.GetInstance().GetAsync(UrlCompleta("/alumno?nroAlumno=" + oAlumno.IdAlumno));
                oAlumno = JsonConvert.DeserializeObject<Alumno>(res);

                nuevo = false;

                numId.Enabled = false;

                numId.Value = oAlumno.IdAlumno;
                txtNombre.Text = oAlumno.Nombre;
                txtApellido.Text = oAlumno.Apellido;
                cboEstadoCivil.SelectedItem = oAlumno.EstadoCivilAlumno;
                cboSituacionLaboral.SelectedItem = oAlumno.SituacionAlumno;
                cboBarrio.SelectedItem = oAlumno.Barrio;
                txtDireccion.Text = oAlumno.Direccion;
                numAltura.Value = oAlumno.Altura;
                txtTel.Text = oAlumno.Telefono;
                txtEmail.Text = oAlumno.Email;

                ActualizarDgv();
            }
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            var alumnoTexto = await ClienteSingleton.GetInstance().GetAsync(UrlCompleta("/alumno?nroAlumno=" + numId.Value));
            Alumno alumnoObjeto = JsonConvert.DeserializeObject<Alumno>(alumnoTexto);

            if (numId.Value < 1)
                MessageBox.Show("Se debe ingresar un legajo mayor o igual a 1", "LEGAJO INVALIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (alumnoObjeto.IdAlumno != 0)
                MessageBox.Show("El legajo ingresado ya existe", "LEGAJO INVALIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtNombre.Text.Length < 1)
                MessageBox.Show("Se debe ingresar un nombre", "NOMBRE INVALIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtApellido.Text.Length < 1)
                MessageBox.Show("Se debe ingresar un apellido", "APELLIDO INVALIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                oAlumno.IdAlumno = Convert.ToInt32(numId.Value);
                oAlumno.Nombre = txtNombre.Text;
                oAlumno.Apellido = txtApellido.Text;
                oAlumno.EstadoCivilAlumno = (EstadoCivil)cboEstadoCivil.SelectedItem;
                oAlumno.SituacionAlumno = (SituacionLaboral)cboSituacionLaboral.SelectedItem;
                oAlumno.Barrio = (Barrio)cboBarrio.SelectedItem;
                oAlumno.Direccion = txtDireccion.Text;
                oAlumno.Altura = Convert.ToInt32(numAltura.Value);
                oAlumno.Telefono = txtTel.Text;
                oAlumno.Email = txtEmail.Text;

                string confirmar;

                if (nuevo)
                    confirmar = await ClienteSingleton.GetInstance().PostAsync(UrlCompleta("/alumno"), JsonConvert.SerializeObject(oAlumno));
                else
                    confirmar = await ClienteSingleton.GetInstance().PutAsync(UrlCompleta("/alumno"), JsonConvert.SerializeObject(oAlumno));
                if (JsonConvert.DeserializeObject<bool>(confirmar))
                {
                    MessageBox.Show("Éxito al cargar alumno", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Error al cargar alumno", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMateriaComision_Click(object sender, EventArgs e)
        {
            FrmConsultarDetalleMateriaComision form = new FrmConsultarDetalleMateriaComision();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                lblMateriaComSel.Text = form.Result.ToString();
                dmc = form.Result;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dmc == null)
            {
                MessageBox.Show("Se debe seleccionar una Materia Comision");
            }
            else
            {
                DetalleAlumnoMateria dam = new DetalleAlumnoMateria(oAlumno.DetallesAlumno.Count, dmc, (EstadoAcademico)cboEstado.SelectedItem, dtpFechaInsc.Value, dtpFechaEstado.Value, new List<Evaluacion>());
                oAlumno.DetallesAlumno.Add(dam);
                ActualizarDgv();
                dmc = null;
            }
        }

        private async Task CargarComboAsync<T>(string url, ComboBox comboBox)
        {
            var res = await ClienteSingleton.GetInstance().GetAsync(url);

            List<T> lst = JsonConvert.DeserializeObject<List<T>>(res);

            comboBox.DataSource = lst;
        }

        private string UrlCompleta(string location)
        {
            return Properties.Resources.URL + location;
        }

        private void ActualizarDgv()
        {
            dgvMaterias.Rows.Clear();
            foreach (DetalleAlumnoMateria dam in oAlumno.DetallesAlumno)
            {
                dgvMaterias.Rows.Add(new object[] {
                    dam.IdDetalleAlumnoMateria.ToString(),
                    dam.DetalleMateriaComision.MateriaDetalle.NombreMateria,
                    dam.FechaInscripcionDetalle.ToString("dd/MM/yyyy"),
                    dam.EstadoDetalle.DescEstadoAcademico,
                    dam.FechaEstadoDetalle.ToString("dd/MM/yyyy"),
                    dam.DetalleMateriaComision.ComisionDetalle.DescripcionComision,
                    dam.DetalleMateriaComision.DocenteMateriaComision.ToString(),
                    "Eliminar"
                });
            }
        }

        private void dgvMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMaterias.CurrentCell.ColumnIndex == 7)
            {
                for (int i = 0; i < oAlumno.DetallesAlumno.Count(); i++)
                {
                    if (oAlumno.DetallesAlumno[i].IdDetalleAlumnoMateria == Convert.ToInt32(dgvMaterias.CurrentRow.Cells[0].Value))
                        oAlumno.DetallesAlumno.RemoveAt(i);
                }
                dgvMaterias.Rows.RemoveAt(dgvMaterias.CurrentRow.Index);
            }
        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = txtTel.SelectionStart;
            txtTel.Text = txtTel.Text.Replace("[^0-9]", "");
            txtTel.SelectionStart = selectionStart;
        }
    }
}
