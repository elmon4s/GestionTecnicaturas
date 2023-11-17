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
    public partial class FrmReporteAlumnosCantExamenes : Form
    {
        public FrmReporteAlumnosCantExamenes()
        {
            InitializeComponent();
        }

        private async void FrmReporteAlumnosCantExamenes_Load(object sender, EventArgs e)
        {
            cboSituacionLaboral.DropDownStyle = ComboBoxStyle.DropDownList;
            await CargarSituacionesAsync();
        }

        private async Task CargarSituacionesAsync()
        {
            var resultado = await ClienteSingleton.GetInstance().GetAsync("https://localhost:7031/situacioneslab");
            List<SituacionLaboral> lst = JsonConvert.DeserializeObject<List<SituacionLaboral>>(resultado);

            cboSituacionLaboral.DataSource = lst;
            cboSituacionLaboral.DisplayMember = "Situacion";
            cboSituacionLaboral.ValueMember = "IdSituacion";
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            SituacionLaboral auxSituacion = new SituacionLaboral();
            try
            {
                auxSituacion = (SituacionLaboral)cboSituacionLaboral.SelectedItem;
            }
            catch
            {
                MessageBox.Show("Elija una situacion laboral valida!", "Error", MessageBoxButtons.OK);
                return;
            }
            // TODO: esta línea de código carga datos en la tabla 'dSAlumnosCantExamenes.PA_REPORTE_ALUMNOS_CANT_EXAMENES' Puede moverla o quitarla según sea necesario.
            this.pA_REPORTE_ALUMNOS_CANT_EXAMENESTableAdapter.Fill(this.dSAlumnosCantExamenes.PA_REPORTE_ALUMNOS_CANT_EXAMENES, txtNombre.Text, auxSituacion.IdSituacion);

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
