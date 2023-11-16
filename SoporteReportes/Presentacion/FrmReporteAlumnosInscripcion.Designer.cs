namespace SoporteReportes.Presentacion
{
    partial class FrmReporteAlumnosInscripcion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpvAlumnos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSAlumnosInscripcion = new SoporteReportes.DataSets.DSAlumnosInscripcion();
            this.pAREPORTEALUMNOSINSCRIPCIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pA_REPORTE_ALUMNOS_INSCRIPCIONTableAdapter = new SoporteReportes.DataSets.DSAlumnosInscripcionTableAdapters.PA_REPORTE_ALUMNOS_INSCRIPCIONTableAdapter();
            this.PA_REPORTE_ALUMNOS_INSCRIPCIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblComision = new System.Windows.Forms.Label();
            this.cboComision = new System.Windows.Forms.ComboBox();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dSAlumnosInscripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAREPORTEALUMNOSINSCRIPCIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_REPORTE_ALUMNOS_INSCRIPCIONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvAlumnos
            // 
            reportDataSource1.Name = "DataSetReportAlumnosInscripcion";
            reportDataSource1.Value = this.PA_REPORTE_ALUMNOS_INSCRIPCIONBindingSource;
            this.rpvAlumnos.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvAlumnos.LocalReport.ReportEmbeddedResource = "SoporteReportes.Reportes.ReportAlumnosInscripcion.rdlc";
            this.rpvAlumnos.Location = new System.Drawing.Point(12, 58);
            this.rpvAlumnos.Name = "rpvAlumnos";
            this.rpvAlumnos.ServerReport.BearerToken = null;
            this.rpvAlumnos.Size = new System.Drawing.Size(705, 298);
            this.rpvAlumnos.TabIndex = 0;
            this.rpvAlumnos.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dSAlumnosInscripcion
            // 
            this.dSAlumnosInscripcion.DataSetName = "DSAlumnosInscripcion";
            this.dSAlumnosInscripcion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pAREPORTEALUMNOSINSCRIPCIONBindingSource
            // 
            this.pAREPORTEALUMNOSINSCRIPCIONBindingSource.DataMember = "PA_REPORTE_ALUMNOS_INSCRIPCION";
            this.pAREPORTEALUMNOSINSCRIPCIONBindingSource.DataSource = this.dSAlumnosInscripcion;
            // 
            // pA_REPORTE_ALUMNOS_INSCRIPCIONTableAdapter
            // 
            this.pA_REPORTE_ALUMNOS_INSCRIPCIONTableAdapter.ClearBeforeFill = true;
            // 
            // PA_REPORTE_ALUMNOS_INSCRIPCIONBindingSource
            // 
            this.PA_REPORTE_ALUMNOS_INSCRIPCIONBindingSource.DataMember = "PA_REPORTE_ALUMNOS_INSCRIPCION";
            this.PA_REPORTE_ALUMNOS_INSCRIPCIONBindingSource.DataSource = this.dSAlumnosInscripcion;
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComision.Location = new System.Drawing.Point(174, 15);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(65, 17);
            this.lblComision.TabIndex = 1;
            this.lblComision.Text = "Comision:";
            // 
            // cboComision
            // 
            this.cboComision.FormattingEnabled = true;
            this.cboComision.Location = new System.Drawing.Point(245, 13);
            this.cboComision.Name = "cboComision";
            this.cboComision.Size = new System.Drawing.Size(142, 21);
            this.cboComision.TabIndex = 2;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(400, 12);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(124, 23);
            this.btnGenerarReporte.TabIndex = 3;
            this.btnGenerarReporte.Text = "GenerarReporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            // 
            // FrmReporteAlumnosInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 368);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.cboComision);
            this.Controls.Add(this.lblComision);
            this.Controls.Add(this.rpvAlumnos);
            this.Name = "FrmReporteAlumnosInscripcion";
            this.Text = "FrmReporteAlumnosInscripcion";
            this.Load += new System.EventHandler(this.FrmReporteAlumnosInscripcion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSAlumnosInscripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAREPORTEALUMNOSINSCRIPCIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_REPORTE_ALUMNOS_INSCRIPCIONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvAlumnos;
        private System.Windows.Forms.BindingSource PA_REPORTE_ALUMNOS_INSCRIPCIONBindingSource;
        private DataSets.DSAlumnosInscripcion dSAlumnosInscripcion;
        private System.Windows.Forms.BindingSource pAREPORTEALUMNOSINSCRIPCIONBindingSource;
        private DataSets.DSAlumnosInscripcionTableAdapters.PA_REPORTE_ALUMNOS_INSCRIPCIONTableAdapter pA_REPORTE_ALUMNOS_INSCRIPCIONTableAdapter;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.ComboBox cboComision;
        private System.Windows.Forms.Button btnGenerarReporte;
    }
}