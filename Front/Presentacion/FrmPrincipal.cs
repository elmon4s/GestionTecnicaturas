using Front.Presentacion.Alumnos;
using Front.Presentacion.Docentes;
using Front.Presentacion.Examenes;
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
    public partial class FrmPrincipal : Form
    {
        //TODO: Agregar reportes
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void nuevoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmGestorDocente(0).ShowDialog();
        }

        private void consultarDocentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmConsultaDocentes().ShowDialog();
        }

        private void nueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmGestorExamen().ShowDialog();
        }

        private void consultarExamenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmConsultarExamenes().ShowDialog();
        }

        private void nuevoAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmGestorAlumno(0).ShowDialog();
        }

        private void consultarAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmConsultaAlumnos().ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Dispose();
            }
        }
    }
}
