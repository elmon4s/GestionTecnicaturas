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
    public partial class FrmReporteAlumnosCantAprobados : Form
    {
        public FrmReporteAlumnosCantAprobados()
        {
            InitializeComponent();
        }

        private async void FrmReporteAlumnosCantAprobados_Load(object sender, EventArgs e)
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
            int aux = 0;
            if (string.IsNullOrEmpty(txtAño.Text))
            {
                //Revisa que no este vacio el textbox
                MessageBox.Show("Ingrese un año!", "Error", MessageBoxButtons.OK);
                return;
            }
            try
            {
                //Se fija que se pueda parsear el texto
                aux = (int.Parse(txtAño.Text));
            }
            catch
            {
                MessageBox.Show("Ingrese un año valido!", "Error", MessageBoxButtons.OK);
                return;
            }
            if (aux <= 2000 && aux > DateTime.Now.Year)
            {
                //Revisa que sea una fecha valida, es decir no sea previo al 2000 y no sea mayor que el año actual
                MessageBox.Show("Ingrese un año valido!", "Error", MessageBoxButtons.OK);
                return;
            }
            SituacionLaboral auxSituacion = new SituacionLaboral();
            try
            {
                auxSituacion = (SituacionLaboral)cboSituacionLaboral.SelectedItem;
            }
            catch
            {
                MessageBox.Show("Ingrese una situacion laboral valida!", "Error", MessageBoxButtons.OK);
                return;
            }
            // TODO: esta línea de código carga datos en la tabla 'dSAlumnosCantAprobados.PA_REPORTE_ALUMNOS_CANT_APROBADOS' Puede moverla o quitarla según sea necesario.
            this.pA_REPORTE_ALUMNOS_CANT_APROBADOSTableAdapter.Fill(this.dSAlumnosCantAprobados.PA_REPORTE_ALUMNOS_CANT_APROBADOS, aux, auxSituacion.IdSituacion);

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
