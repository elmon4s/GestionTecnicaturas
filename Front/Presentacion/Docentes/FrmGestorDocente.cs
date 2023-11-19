using Back.Datos.Implementacion;
using Back.Datos.Interfaz;
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

namespace Front
{
    public partial class FrmGestorDocente : Form
    {
        IDocentesDAO dao;
        Docente d;
        public FrmGestorDocente(int codDocente)
        {
            InitializeComponent();
            dao = new DocentesDAO();
            if (codDocente != 0)
            {
                lblABM.Text = "Modificar Docente";
                d = new Docente(codDocente);
            }
            else d = new Docente();
        }
        private async void FrmNuevoDocente_Load_1(object sender, EventArgs e)
        {
            await CargarBarrios();
            await CargarTitulos();
            btnEliminar.Enabled = false;
            if (lblABM.Text == "Modificar Docente")
            {
                btnEliminar.Enabled = true;
                await TraerDocenteAsync();

            }
            cboBarrio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTitulo.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private async Task CargarBarrios()
        {
            string url = "https://localhost:7031/barrios"; //agregar url de api
            var dtosJson = await ClienteSingleton.GetInstance().GetAsync(url);
            List<Barrio> lBarrio = JsonConvert.DeserializeObject<List<Barrio>>(dtosJson);
            cboBarrio.DataSource = lBarrio;
            cboBarrio.DisplayMember = "NombreBarrio";
            cboBarrio.ValueMember = "IdBarrio";
        }
        private async Task CargarTitulos()
        {
            string url = "https://localhost:7031/titulos"; //agegar url de api
            var dtosJson = await ClienteSingleton.GetInstance().GetAsync(url);
            List<Titulo> lTitulo = JsonConvert.DeserializeObject<List<Titulo>>(dtosJson);
            cboTitulo.DataSource = lTitulo;
            cboTitulo.DisplayMember = "DescripcionTitulo";
            cboTitulo.ValueMember = "IdTitulo";
        }

        private bool Validar()
        {
            bool x = true;
            if (txtApe.Text == string.Empty)
            { x = false; MessageBox.Show("Debe ingresar un apellido"); txtApe.Focus(); }
            if (txtNom.Text == string.Empty)
            { x = false; MessageBox.Show("Debe ingresar un Nombre"); txtNom.Focus(); }
            if (txtMail.Text == string.Empty)
            { x = false; MessageBox.Show("Debe ingresar un E-Mail"); txtMail.Focus(); }
            if (txtDirec.Text == string.Empty)
            { x = false; MessageBox.Show("Debe ingresar una Dirección"); txtApe.Focus(); }
            if (txtTel.Text == string.Empty || EsInt(txtTel.Text) == false)
            { x = false; MessageBox.Show("Debe indicar número de Telefono valido"); txtTel.Focus(); }
            if (txtAlt.Text == string.Empty || EsInt(txtAlt.Text) == false)
            { x = false; MessageBox.Show("Debe indicar una Altura valida"); txtAlt.Focus(); }
            if (cboBarrio.SelectedIndex == -1)
            { x = false; MessageBox.Show("Debe seleccionar un barrio"); cboBarrio.Focus(); }
            if (cboTitulo.SelectedIndex == -1)
            { x = false; MessageBox.Show("Debe seleccionar un titulo"); cboTitulo.Focus(); }
            return x;
        }

        private bool EsInt(string txt) //metodo para veriifcar que el texto sean numeros
        {
            bool aux = true;
            try
            {
                int.Parse(txt);
            }
            catch
            {
                aux = false;
            }
            return aux;
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea limpiar el formulario?", "Limpiar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                txtAlt.Text = String.Empty;
                txtTel.Text = String.Empty;
                txtApe.Text = String.Empty;
                txtDirec.Text = String.Empty;
                txtMail.Text = String.Empty;
                txtNom.Text = String.Empty;
                cboBarrio.SelectedIndex = -1;
                cboTitulo.SelectedIndex = -1;
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                this.Close();
        }

        private async void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if (lblABM.Text == "Creando Docente")
            {
                if (Validar() == true)
                {
                    await GrabarDocente();
                }
                else
                {
                    MessageBox.Show("Datos invalidos");
                }
            }
            else
            {
                await EditarDocenteAsync(d.IdDocente);
            }
        }

        private async Task<bool> EditarDocenteAsync(int idDocente)
        {
            string url = "https://localhost:7031/docente"; //agregar url de api
            var docenteJson = JsonConvert.SerializeObject(d);
            var dataJson = await ClienteSingleton.GetInstance().PutAsync(url, docenteJson);
            return dataJson.Equals(true);
        }

        private async Task TraerDocenteAsync()
        {
            var datosJson = await ClienteSingleton.GetInstance().GetAsync(UrlCompleta("/docente?nroDocente=" + d.IdDocente));
            d = JsonConvert.DeserializeObject<Docente>(datosJson);
            if (d == null) { MessageBox.Show("Error interno"); }
            
            txtAlt.Text = d.Altura.ToString();
            txtApe.Text = d.Apellido.ToString();
            txtDirec.Text = d.Direccion.ToString();
            txtId.Text = d.IdDocente.ToString();
            txtMail.Text = d.Email.ToString();
            txtNom.Text = d.Nombre.ToString();
            txtTel.Text = d.Telefono.ToString();
            cboBarrio.SelectedValue = d.Barrio.IdBarrio;
            cboTitulo.SelectedValue = d.TituloDocente.IdTitulo;
        }

        private async Task GrabarDocente()
        {
            if (await CrearDocenteAsync(CrearDocente()))
            {
                MessageBox.Show("Se Registro el Nuevo Docente");
                this.Close();
            }
            else
            {
                MessageBox.Show("No pudo registrarse el Nuevo Docente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Docente CrearDocente()
        {
            d.Nombre = txtNom.Text;
            d.Apellido = txtApe.Text;
            d.Direccion = txtDirec.Text;
            d.Altura = int.Parse(txtAlt.Text);
            //d.IdDocente = int.Parse(txtId.Text);
            d.Telefono = txtTel.Text;
            d.Email = txtMail.Text;
            d.Barrio.IdBarrio = int.Parse(cboBarrio.SelectedIndex.ToString());
            d.TituloDocente.IdTitulo = int.Parse(cboTitulo.SelectedIndex.ToString());
            return d;
        }
        private async Task<bool> CrearDocenteAsync(Docente d)
        {
            string url = "https://localhost:7031/docente"; //agregar url de api
            var docenteJson = JsonConvert.SerializeObject(d);
            var dataJson = await ClienteSingleton.GetInstance().PostAsync(url, docenteJson);
            return dataJson.Equals("true");
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere eliminar este Docente?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string confirmar = await ClienteSingleton.GetInstance().DeleteAsync(UrlCompleta($"/docente?nroDocente={d.IdDocente}"));

                if (JsonConvert.DeserializeObject<bool>(confirmar))
                {
                    MessageBox.Show("Docente borrado con éxito", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al borrar Docente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private string UrlCompleta(string location)
        {
            return Properties.Resources.URL + location;
        }
    }
}
