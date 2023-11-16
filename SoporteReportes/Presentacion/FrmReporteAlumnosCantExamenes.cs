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
    public partial class FrmReporteAlumnosCantExamenes : Form
    {
        public FrmReporteAlumnosCantExamenes()
        {
            InitializeComponent();
        }

        private void FrmReporteAlumnosCantExamenes_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string auxNombre = txtNombre.Text;
            //Agregar Combo
            // TODO: esta línea de código carga datos en la tabla 'dSAlumnosCantExamenes.PA_REPORTE_ALUMNOS_CANT_EXAMENES' Puede moverla o quitarla según sea necesario.
            this.pA_REPORTE_ALUMNOS_CANT_EXAMENESTableAdapter.Fill(this.dSAlumnosCantExamenes.PA_REPORTE_ALUMNOS_CANT_EXAMENES,auxNombre,1);

            this.rpvAlumnos.RefreshReport();
        }
    }
}
