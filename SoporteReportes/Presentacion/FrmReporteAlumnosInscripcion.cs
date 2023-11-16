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

        private void FrmReporteAlumnosInscripcion_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSAlumnosInscripcion.PA_REPORTE_ALUMNOS_INSCRIPCION' Puede moverla o quitarla según sea necesario.
            this.pA_REPORTE_ALUMNOS_INSCRIPCIONTableAdapter.Fill(this.dSAlumnosInscripcion.PA_REPORTE_ALUMNOS_INSCRIPCION,1);

            this.rpvAlumnos.RefreshReport();
        }
    }
}
