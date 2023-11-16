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
            components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            PA_REPORTE_ALUMNOS_INSCRIPCIONBindingSource = new System.Windows.Forms.BindingSource(components);
            dSAlumnosInscripcion = new DataSets.DSAlumnosInscripcion();
            rpvAlumnos = new Microsoft.Reporting.WinForms.ReportViewer();
            pAREPORTEALUMNOSINSCRIPCIONBindingSource = new System.Windows.Forms.BindingSource(components);
            pA_REPORTE_ALUMNOS_INSCRIPCIONTableAdapter = new DataSets.DSAlumnosInscripcionTableAdapters.PA_REPORTE_ALUMNOS_INSCRIPCIONTableAdapter();
            lblComision = new System.Windows.Forms.Label();
            cboComision = new System.Windows.Forms.ComboBox();
            btnGenerarReporte = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)PA_REPORTE_ALUMNOS_INSCRIPCIONBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dSAlumnosInscripcion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pAREPORTEALUMNOSINSCRIPCIONBindingSource).BeginInit();
            SuspendLayout();
            // 
            // PA_REPORTE_ALUMNOS_INSCRIPCIONBindingSource
            // 
            PA_REPORTE_ALUMNOS_INSCRIPCIONBindingSource.DataMember = "PA_REPORTE_ALUMNOS_INSCRIPCION";
            PA_REPORTE_ALUMNOS_INSCRIPCIONBindingSource.DataSource = dSAlumnosInscripcion;
            // 
            // dSAlumnosInscripcion
            // 
            dSAlumnosInscripcion.DataSetName = "DSAlumnosInscripcion";
            dSAlumnosInscripcion.Namespace = "http://tempuri.org/DSAlumnosInscripcion.xsd";
            dSAlumnosInscripcion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvAlumnos
            // 
            reportDataSource1.Name = "DataSetReportAlumnosInscripcion";
            reportDataSource1.Value = PA_REPORTE_ALUMNOS_INSCRIPCIONBindingSource;
            rpvAlumnos.LocalReport.DataSources.Add(reportDataSource1);
            rpvAlumnos.LocalReport.ReportEmbeddedResource = "SoporteReportes.Reportes.ReportAlumnosInscripcion.rdlc";
            rpvAlumnos.Location = new System.Drawing.Point(14, 67);
            rpvAlumnos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rpvAlumnos.Name = "rpvAlumnos";
            rpvAlumnos.ServerReport.BearerToken = null;
            rpvAlumnos.Size = new System.Drawing.Size(822, 344);
            rpvAlumnos.TabIndex = 0;
            rpvAlumnos.Load += reportViewer1_Load;
            // 
            // pAREPORTEALUMNOSINSCRIPCIONBindingSource
            // 
            pAREPORTEALUMNOSINSCRIPCIONBindingSource.DataMember = "PA_REPORTE_ALUMNOS_INSCRIPCION";
            pAREPORTEALUMNOSINSCRIPCIONBindingSource.DataSource = dSAlumnosInscripcion;
            // 
            // pA_REPORTE_ALUMNOS_INSCRIPCIONTableAdapter
            // 
            pA_REPORTE_ALUMNOS_INSCRIPCIONTableAdapter.ClearBeforeFill = true;
            // 
            // lblComision
            // 
            lblComision.AutoSize = true;
            lblComision.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblComision.Location = new System.Drawing.Point(22, 15);
            lblComision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblComision.Name = "lblComision";
            lblComision.Size = new System.Drawing.Size(65, 17);
            lblComision.TabIndex = 1;
            lblComision.Text = "Comision:";
            // 
            // cboComision
            // 
            cboComision.FormattingEnabled = true;
            cboComision.Location = new System.Drawing.Point(105, 13);
            cboComision.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboComision.Name = "cboComision";
            cboComision.Size = new System.Drawing.Size(165, 23);
            cboComision.TabIndex = 2;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.Location = new System.Drawing.Point(286, 12);
            btnGenerarReporte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new System.Drawing.Size(145, 27);
            btnGenerarReporte.TabIndex = 3;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new System.Drawing.Point(739, 15);
            btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(100, 27);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmReporteAlumnosInscripcion
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(852, 425);
            Controls.Add(btnSalir);
            Controls.Add(btnGenerarReporte);
            Controls.Add(cboComision);
            Controls.Add(lblComision);
            Controls.Add(rpvAlumnos);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FrmReporteAlumnosInscripcion";
            Text = "FrmReporteAlumnosInscripcion";
            Load += FrmReporteAlumnosInscripcion_Load;
            ((System.ComponentModel.ISupportInitialize)PA_REPORTE_ALUMNOS_INSCRIPCIONBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dSAlumnosInscripcion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pAREPORTEALUMNOSINSCRIPCIONBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Button btnSalir;
    }
}