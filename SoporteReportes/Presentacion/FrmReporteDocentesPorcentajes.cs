﻿using System;
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

        private void FrmReporteDocentesPorcentajes_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDocentesPorcentajes.PA_REPORTE_DOCENTES_PORCENTAJES' Puede moverla o quitarla según sea necesario.
            this.pA_REPORTE_DOCENTES_PORCENTAJESTableAdapter.Fill(this.dSDocentesPorcentajes.PA_REPORTE_DOCENTES_PORCENTAJES,1);

            this.rpvDocentes.RefreshReport();
        }
    }
}