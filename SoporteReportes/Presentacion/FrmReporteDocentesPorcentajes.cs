using Back.Dominio;
using Newtonsoft.Json;
using SoporteReportes.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoporteReportes.Presentacion
{
    public partial class FrmReporteDocentesPorcentajes : Form
    {
        public FrmReporteDocentesPorcentajes()
        {
            InitializeComponent();
        }

        private async void FrmReporteDocentesPorcentajes_Load(object sender, EventArgs e)
        {
            await CargarDatosAsync($"{Properties.Resources.URL}/titulosDocentes", cboTitulos);
        }

        private async Task CargarDatosAsync(string apiUrl, ComboBox comboBox)
        {
            var resultado = await ClienteSingleton.GetInstance().GetAsync(apiUrl);
            List<Titulo> lst = JsonConvert.DeserializeObject<List<Titulo>>(resultado);

            comboBox.DataSource = lst;
            comboBox.DisplayMember = "DescripcionTitulo";
            comboBox.ValueMember = "IdTitulo";
        }
        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDocentesPorcentajes.PA_REPORTE_DOCENTES_PORCENTAJES' Puede moverla o quitarla según sea necesario.
            this.pA_REPORTE_DOCENTES_PORCENTAJESTableAdapter.Fill(this.dSDocentesPorcentajes.PA_REPORTE_DOCENTES_PORCENTAJES, 1);

            this.rpvDocentes.RefreshReport();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "Salir", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Dispose();
            }
        }
    }
}
