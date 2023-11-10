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
        public bool CredencialesValidas {  get; private set; }
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            CredencialesValidas = true;
            this.Close();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            new FrmRegistro().Show();
        }
    }
}
