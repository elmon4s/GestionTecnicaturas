using Back.Dominio;
using Back.Login;
using Front.Cliente;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front
{
    public partial class FrmRegistro : Form
    {
        //TODO: Implementar lógica
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Debe ingresar un nombre de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("Debe ingresar una contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtRepetirContraseña.Text))
            {
                MessageBox.Show("Debe confirmar la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtContraseña.Text != txtRepetirContraseña.Text)
            {
                MessageBox.Show("La contraseña debe coincidir!", "Error", MessageBoxButtons.OK);
                return;
            }
            Usuario nUsuario = new Usuario(txtUsuario.Text, txtContraseña.Text);
            if (await CrearUsuarioAsync(nUsuario))
            {
                MessageBox.Show("Usuario Registrado exitosamente", "Registro Exitoso", MessageBoxButtons.OK);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("El Usuario no pudo registrarse", "Error", MessageBoxButtons.OK);
            }
        }


        private async Task<bool> CrearUsuarioAsync(Usuario oUsuario)
        {
            string url = $"{Properties.Resources.URL}/usuario";
            string usuarioJson = JsonConvert.SerializeObject(oUsuario);
            var dataJson = await ClienteSingleton.GetInstance().PostAsync(url, usuarioJson);

            return dataJson.Equals("true");
        }
    }
}
