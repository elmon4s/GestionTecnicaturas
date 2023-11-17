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
    public partial class FrmReporteDocentesPorcentaje : Form
    {
        public FrmReporteDocentesPorcentaje()
        {
            InitializeComponent();
        }

        private async void FrmReporteDocentesPorcentaje_Load(object sender, EventArgs e)
        {
            cboTitulos.DropDownStyle = ComboBoxStyle.DropDownList;
            await CargarTitulosAsync();
        }

        private async Task CargarTitulosAsync()
        {
            var resultado = await ClienteSingleton.GetInstance().GetAsync("https://localhost:7031/titulos");
            List<Titulo> lst = JsonConvert.DeserializeObject<List<Titulo>>(resultado);

            cboTitulos.DataSource = lst;
            cboTitulos.DisplayMember = "DescripcionTitulo";
            cboTitulos.ValueMember = "IdTitulo";
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            Titulo auxTitulo = new Titulo();
            try
            {
                auxTitulo = (Titulo)cboTitulos.SelectedItem;
            }
            catch
            {
                MessageBox.Show("Elija un titulo valido!", "Error", MessageBoxButtons.OK);
                return;
            }
            // TODO: esta línea de código carga datos en la tabla 'dSDocentesPorcentajes.PA_REPORTE_DOCENTES_PORCENTAJES' Puede moverla o quitarla según sea necesario.
            this.pA_REPORTE_DOCENTES_PORCENTAJESTableAdapter.Fill(this.dSDocentesPorcentajes.PA_REPORTE_DOCENTES_PORCENTAJES, auxTitulo.IdTitulo);

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
