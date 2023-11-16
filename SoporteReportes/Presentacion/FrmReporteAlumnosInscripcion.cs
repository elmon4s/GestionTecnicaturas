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
    public partial class FrmReporteAlumnosInscripcion : Form
    {
        public FrmReporteAlumnosInscripcion()
        {
            InitializeComponent();
        }

        private async void FrmReporteAlumnosInscripcion_Load(object sender, EventArgs e)
        {
            await CargarDatosAsync($"{Properties.Resources.URL}/comisiones", cboComision);
        }

        private async Task CargarDatosAsync(string apiUrl, ComboBox comboBox)
        {
            var resultado = await ClienteSingleton.GetInstance().GetAsync(apiUrl);
            List<Comision> lst = JsonConvert.DeserializeObject<List<Comision>>(resultado);

            comboBox.DataSource = lst;
            comboBox.DisplayMember = "DescripcionComision";
            comboBox.ValueMember = "IdComision";
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSAlumnosInscripcion.PA_REPORTE_ALUMNOS_INSCRIPCION' Puede moverla o quitarla según sea necesario.
            this.pA_REPORTE_ALUMNOS_INSCRIPCIONTableAdapter.Fill(this.dSAlumnosInscripcion.PA_REPORTE_ALUMNOS_INSCRIPCION, 1);

            this.rpvAlumnos.RefreshReport();
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
