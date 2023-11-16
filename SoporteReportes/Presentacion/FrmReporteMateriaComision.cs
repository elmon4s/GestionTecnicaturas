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
    public partial class FrmReporteMateriaComision : Form
    {
        public FrmReporteMateriaComision()
        {
            InitializeComponent();
        }

        private async void FrmReporteMateriaComision_Load(object sender, EventArgs e)
        {
            await CargarDatosAsync($"{Properties.Resources.URL}/tecnicaturas", cboCarrera);
        }

        private async Task CargarDatosAsync(string apiUrl, ComboBox comboBox)
        {
            var resultado = await ClienteSingleton.GetInstance().GetAsync(apiUrl);
            List<Tecnicatura> lst = JsonConvert.DeserializeObject<List<Tecnicatura>>(resultado);

            comboBox.DataSource = lst;
            comboBox.DisplayMember = "NombreTecnicatura";
            comboBox.ValueMember = "IdTecnicatura";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int auxDesde = 0;
            int auxHasta = 0;
            if (string.IsNullOrEmpty(txtAñoDesde.Text))
            {
                //Revisa que no este vacio el textbox
                MessageBox.Show("Ingrese un Año Desde!", "Error", MessageBoxButtons.OK);
                return;
            }
            try
            {
                //Se fija que se pueda parsear el texto
                auxDesde = (int.Parse(txtAñoDesde.Text));
            }
            catch
            {
                MessageBox.Show("Ingrese un Año Desde valido!", "Error", MessageBoxButtons.OK);
                return;
            }
            if (auxDesde <= 2000 && auxDesde > DateTime.Now.Year)
            {
                //Revisa que sea una fecha valida, es decir no sea previo al 2000 y no sea mayor que el año actual
                MessageBox.Show("Ingrese un Año Desde valido!", "Error", MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrEmpty(txtAñoHasta.Text))
            {
                //Revisa que no este vacio el textbox
                MessageBox.Show("Ingrese un Año Hasta!", "Error", MessageBoxButtons.OK);
                return;
            }
            try
            {
                //Se fija que se pueda parsear el texto
                auxHasta = (int.Parse(txtAñoHasta.Text));
            }
            catch
            {
                MessageBox.Show("Ingrese un Año Hasta valido!", "Error", MessageBoxButtons.OK);
                return;
            }
            if (auxHasta <= 2000 && auxHasta > DateTime.Now.Year)
            {
                //Revisa que sea una fecha valida, es decir no sea previo al 2000 y no sea mayor que el año actual
                MessageBox.Show("Ingrese un Año Hasta valido!", "Error", MessageBoxButtons.OK);
                return;
            }
            if (auxHasta < auxDesde)
            {
                MessageBox.Show("El año hasta no puede ser menor al año desde!", "Error", MessageBoxButtons.OK);
                return;
            }
            // TODO: esta línea de código carga datos en la tabla 'dSMateriaComision.PA_REPORTE_MATERIA_COMISION' Puede moverla o quitarla según sea necesario.
            this.pA_REPORTE_MATERIA_COMISIONTableAdapter.Fill(this.dSMateriaComision.PA_REPORTE_MATERIA_COMISION, auxDesde, auxHasta, 1);

            this.rpvMateriaComision.RefreshReport();
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
