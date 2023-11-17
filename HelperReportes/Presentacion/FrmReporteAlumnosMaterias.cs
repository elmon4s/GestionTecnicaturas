using Back.Dominio;
using HelperReportes.Cliente;
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

namespace HelperReportes.Presentacion
{
    public partial class FrmReporteAlumnosMaterias : Form
    {
        public FrmReporteAlumnosMaterias()
        {
            InitializeComponent();
        }

        private async void FrmReporteAlumnosMaterias_Load(object sender, EventArgs e)
        {
            cboComisiones.DropDownStyle = ComboBoxStyle.DropDownList;
            await CargarComisionesAsync();
        }

        private async Task CargarComisionesAsync()
        {
            var resultado = await ClienteSingleton.GetInstance().GetAsync("https://localhost:7031/comisiones");
            List<Comision> lst = JsonConvert.DeserializeObject<List<Comision>>(resultado);

            cboComisiones.DataSource = lst;
            cboComisiones.DisplayMember = "DescripcionComision";
            cboComisiones.ValueMember = "IdComision";
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            Comision auxComision = new Comision();
            try
            {
                auxComision = (Comision)cboComisiones.SelectedItem;
            }
            catch
            {
                MessageBox.Show("Elija una comision valida!", "Error", MessageBoxButtons.OK);
                return;
            }
            // TODO: esta línea de código carga datos en la tabla 'dSAlumnosMaterias.PA_REPORTE_ALUMNOS_MATERIAS' Puede moverla o quitarla según sea necesario.
            this.pA_REPORTE_ALUMNOS_MATERIASTableAdapter.Fill(this.dSAlumnosMaterias.PA_REPORTE_ALUMNOS_MATERIAS, auxComision.IdComision);

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
