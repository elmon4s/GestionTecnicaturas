namespace HelperReportes.Presentacion
{
    partial class FrmReporteAlumnosMaterias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteAlumnosMaterias));
            PA_REPORTE_ALUMNOS_MATERIASBindingSource = new System.Windows.Forms.BindingSource(components);
            dSAlumnosMaterias = new DataSets.DSAlumnosMaterias();
            rpvAlumnos = new Microsoft.Reporting.WinForms.ReportViewer();
            pAREPORTEALUMNOSMATERIASBindingSource = new System.Windows.Forms.BindingSource(components);
            pA_REPORTE_ALUMNOS_MATERIASTableAdapter = new DataSets.DSAlumnosMateriasTableAdapters.PA_REPORTE_ALUMNOS_MATERIASTableAdapter();
            lblComision = new System.Windows.Forms.Label();
            cboComisiones = new System.Windows.Forms.ComboBox();
            btnGenerarReporte = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)PA_REPORTE_ALUMNOS_MATERIASBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dSAlumnosMaterias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pAREPORTEALUMNOSMATERIASBindingSource).BeginInit();
            SuspendLayout();
            // 
            // PA_REPORTE_ALUMNOS_MATERIASBindingSource
            // 
            PA_REPORTE_ALUMNOS_MATERIASBindingSource.DataMember = "PA_REPORTE_ALUMNOS_MATERIAS";
            PA_REPORTE_ALUMNOS_MATERIASBindingSource.DataSource = dSAlumnosMaterias;
            // 
            // dSAlumnosMaterias
            // 
            dSAlumnosMaterias.DataSetName = "DSAlumnosMaterias";
            dSAlumnosMaterias.Namespace = "http://tempuri.org/DSAlumnosMaterias.xsd";
            dSAlumnosMaterias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvAlumnos
            // 
            reportDataSource1.Name = "DataSetReportAlumnosMaterias";
            reportDataSource1.Value = PA_REPORTE_ALUMNOS_MATERIASBindingSource;
            rpvAlumnos.LocalReport.DataSources.Add(reportDataSource1);
            rpvAlumnos.LocalReport.ReportEmbeddedResource = "HelperReportes.Reportes.ReportAlumnosMaterias.rdlc";
            rpvAlumnos.Location = new System.Drawing.Point(18, 69);
            rpvAlumnos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rpvAlumnos.Name = "rpvAlumnos";
            rpvAlumnos.ServerReport.BearerToken = null;
            rpvAlumnos.Size = new System.Drawing.Size(823, 398);
            rpvAlumnos.TabIndex = 4;
            // 
            // pAREPORTEALUMNOSMATERIASBindingSource
            // 
            pAREPORTEALUMNOSMATERIASBindingSource.DataMember = "PA_REPORTE_ALUMNOS_MATERIAS";
            pAREPORTEALUMNOSMATERIASBindingSource.DataSource = dSAlumnosMaterias;
            // 
            // pA_REPORTE_ALUMNOS_MATERIASTableAdapter
            // 
            pA_REPORTE_ALUMNOS_MATERIASTableAdapter.ClearBeforeFill = true;
            // 
            // lblComision
            // 
            lblComision.AutoSize = true;
            lblComision.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblComision.Location = new System.Drawing.Point(26, 10);
            lblComision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblComision.Name = "lblComision";
            lblComision.Size = new System.Drawing.Size(65, 17);
            lblComision.TabIndex = 0;
            lblComision.Text = "Comision:";
            // 
            // cboComisiones
            // 
            cboComisiones.FormattingEnabled = true;
            cboComisiones.Location = new System.Drawing.Point(108, 10);
            cboComisiones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboComisiones.Name = "cboComisiones";
            cboComisiones.Size = new System.Drawing.Size(162, 23);
            cboComisiones.TabIndex = 1;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.Location = new System.Drawing.Point(293, 8);
            btnGenerarReporte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new System.Drawing.Size(131, 27);
            btnGenerarReporte.TabIndex = 2;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = true;
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new System.Drawing.Point(710, 8);
            btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(131, 27);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmReporteAlumnosMaterias
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(855, 481);
            Controls.Add(btnSalir);
            Controls.Add(btnGenerarReporte);
            Controls.Add(cboComisiones);
            Controls.Add(lblComision);
            Controls.Add(rpvAlumnos);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FrmReporteAlumnosMaterias";
            Text = "Reporte Alumnos Materias Aprobadas por Comision";
            Load += FrmReporteAlumnosMaterias_Load;
            ((System.ComponentModel.ISupportInitialize)PA_REPORTE_ALUMNOS_MATERIASBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dSAlumnosMaterias).EndInit();
            ((System.ComponentModel.ISupportInitialize)pAREPORTEALUMNOSMATERIASBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvAlumnos;
        private System.Windows.Forms.BindingSource PA_REPORTE_ALUMNOS_MATERIASBindingSource;
        private DataSets.DSAlumnosMaterias dSAlumnosMaterias;
        private System.Windows.Forms.BindingSource pAREPORTEALUMNOSMATERIASBindingSource;
        private DataSets.DSAlumnosMateriasTableAdapters.PA_REPORTE_ALUMNOS_MATERIASTableAdapter pA_REPORTE_ALUMNOS_MATERIASTableAdapter;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.ComboBox cboComisiones;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Button btnSalir;
    }
}