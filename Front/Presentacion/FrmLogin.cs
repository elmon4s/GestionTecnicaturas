using Back.Login;
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
    public partial class FrmLogin : Form
    {
        //TODO: Implementar lógica completa
        public bool CredencialesValidas { get; private set; }
        public FrmLogin()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Debe Ingresar el nombre de usuario", "Error", MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("Debe Ingresar el nombre de usuario", "Error", MessageBoxButtons.OK);
                return;
            }
            Usuario oUsuario = new Usuario(txtUsuario.Text, txtContraseña.Text);
            if (await ValidarUsuarioAsync(oUsuario))
            {
                MessageBox.Show("Logueado Exitosamente", "Bienvenido", MessageBoxButtons.OK);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Credenciales Incorrectas", "Incorrecto", MessageBoxButtons.OK);
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            new FrmRegistro().Show();
        }

        private void chkMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarContraseña.Checked == false)
            {
                txtContraseña.UseSystemPasswordChar = true;
            }
            else if (chkMostrarContraseña.Checked)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private async Task<bool> ValidarUsuarioAsync(Usuario oUsuario)
        {
            string url = $"{Properties.Resources.URL}/verificar";
            string usuarioJson = JsonConvert.SerializeObject(oUsuario);
            var dataJson = await ClienteSingleton.GetInstance().PostAsync(url, usuarioJson);

            return dataJson.Equals("true");
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
        }
    }
}
