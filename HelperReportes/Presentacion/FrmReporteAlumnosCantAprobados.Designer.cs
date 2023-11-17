namespace HelperReportes.Presentacion
{
    partial class FrmReporteAlumnosCantAprobados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteAlumnosCantAprobados));
            PA_REPORTE_ALUMNOS_CANT_APROBADOSBindingSource = new System.Windows.Forms.BindingSource(components);
            dSAlumnosCantAprobados = new DataSets.DSAlumnosCantAprobados();
            rpvAlumnos = new Microsoft.Reporting.WinForms.ReportViewer();
            pAREPORTEALUMNOSCANTAPROBADOSBindingSource = new System.Windows.Forms.BindingSource(components);
            pA_REPORTE_ALUMNOS_CANT_APROBADOSTableAdapter = new DataSets.DSAlumnosCantAprobadosTableAdapters.PA_REPORTE_ALUMNOS_CANT_APROBADOSTableAdapter();
            lblAño = new System.Windows.Forms.Label();
            txtAño = new System.Windows.Forms.TextBox();
            lblSituacionLaboral = new System.Windows.Forms.Label();
            cboSituacionLaboral = new System.Windows.Forms.ComboBox();
            btnGenerarReporte = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)PA_REPORTE_ALUMNOS_CANT_APROBADOSBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dSAlumnosCantAprobados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pAREPORTEALUMNOSCANTAPROBADOSBindingSource).BeginInit();
            SuspendLayout();
            // 
            // PA_REPORTE_ALUMNOS_CANT_APROBADOSBindingSource
            // 
            PA_REPORTE_ALUMNOS_CANT_APROBADOSBindingSource.DataMember = "PA_REPORTE_ALUMNOS_CANT_APROBADOS";
            PA_REPORTE_ALUMNOS_CANT_APROBADOSBindingSource.DataSource = dSAlumnosCantAprobados;
            // 
            // dSAlumnosCantAprobados
            // 
            dSAlumnosCantAprobados.DataSetName = "DSAlumnosCantAprobados";
            dSAlumnosCantAprobados.Namespace = "http://tempuri.org/DSAlumnosCantAprobados.xsd";
            dSAlumnosCantAprobados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvAlumnos
            // 
            reportDataSource1.Name = "DataSetReportAlumnosCantAprobados";
            reportDataSource1.Value = PA_REPORTE_ALUMNOS_CANT_APROBADOSBindingSource;
            rpvAlumnos.LocalReport.DataSources.Add(reportDataSource1);
            rpvAlumnos.LocalReport.ReportEmbeddedResource = "HelperReportes.Reportes.ReportAlumnosCantAprobados.rdlc";
            rpvAlumnos.Location = new System.Drawing.Point(14, 66);
            rpvAlumnos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rpvAlumnos.Name = "rpvAlumnos";
            rpvAlumnos.ServerReport.BearerToken = null;
            rpvAlumnos.Size = new System.Drawing.Size(837, 389);
            rpvAlumnos.TabIndex = 6;
            // 
            // pAREPORTEALUMNOSCANTAPROBADOSBindingSource
            // 
            pAREPORTEALUMNOSCANTAPROBADOSBindingSource.DataMember = "PA_REPORTE_ALUMNOS_CANT_APROBADOS";
            pAREPORTEALUMNOSCANTAPROBADOSBindingSource.DataSource = dSAlumnosCantAprobados;
            // 
            // pA_REPORTE_ALUMNOS_CANT_APROBADOSTableAdapter
            // 
            pA_REPORTE_ALUMNOS_CANT_APROBADOSTableAdapter.ClearBeforeFill = true;
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblAño.Location = new System.Drawing.Point(37, 10);
            lblAño.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAño.Name = "lblAño";
            lblAño.Size = new System.Drawing.Size(34, 17);
            lblAño.TabIndex = 0;
            lblAño.Text = "Año:";
            // 
            // txtAño
            // 
            txtAño.Location = new System.Drawing.Point(84, 10);
            txtAño.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtAño.Name = "txtAño";
            txtAño.Size = new System.Drawing.Size(158, 23);
            txtAño.TabIndex = 1;
            // 
            // lblSituacionLaboral
            // 
            lblSituacionLaboral.AutoSize = true;
            lblSituacionLaboral.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSituacionLaboral.Location = new System.Drawing.Point(265, 10);
            lblSituacionLaboral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSituacionLaboral.Name = "lblSituacionLaboral";
            lblSituacionLaboral.Size = new System.Drawing.Size(111, 17);
            lblSituacionLaboral.TabIndex = 2;
            lblSituacionLaboral.Text = "Situacion Laboral:";
            // 
            // cboSituacionLaboral
            // 
            cboSituacionLaboral.FormattingEnabled = true;
            cboSituacionLaboral.Location = new System.Drawing.Point(401, 9);
            cboSituacionLaboral.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboSituacionLaboral.Name = "cboSituacionLaboral";
            cboSituacionLaboral.Size = new System.Drawing.Size(178, 23);
            cboSituacionLaboral.TabIndex = 3;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.Location = new System.Drawing.Point(604, 8);
            btnGenerarReporte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new System.Drawing.Size(112, 27);
            btnGenerarReporte.TabIndex = 4;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = true;
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new System.Drawing.Point(741, 8);
            btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(112, 27);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmReporteAlumnosCantAprobados
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(867, 478);
            Controls.Add(btnSalir);
            Controls.Add(btnGenerarReporte);
            Controls.Add(cboSituacionLaboral);
            Controls.Add(lblSituacionLaboral);
            Controls.Add(txtAño);
            Controls.Add(lblAño);
            Controls.Add(rpvAlumnos);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FrmReporteAlumnosCantAprobados";
            Text = "Reporte Alumnos Cantidad Examenes Aprobados";
            Load += FrmReporteAlumnosCantAprobados_Load;
            ((System.ComponentModel.ISupportInitialize)PA_REPORTE_ALUMNOS_CANT_APROBADOSBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dSAlumnosCantAprobados).EndInit();
            ((System.ComponentModel.ISupportInitialize)pAREPORTEALUMNOSCANTAPROBADOSBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvAlumnos;
        private System.Windows.Forms.BindingSource pAREPORTEALUMNOSCANTAPROBADOSBindingSource;
        private DataSets.DSAlumnosCantAprobados dSAlumnosCantAprobados;
        private DataSets.DSAlumnosCantAprobadosTableAdapters.PA_REPORTE_ALUMNOS_CANT_APROBADOSTableAdapter pA_REPORTE_ALUMNOS_CANT_APROBADOSTableAdapter;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label lblSituacionLaboral;
        private System.Windows.Forms.ComboBox cboSituacionLaboral;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.BindingSource PA_REPORTE_ALUMNOS_CANT_APROBADOSBindingSource;
    }
}