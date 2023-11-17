namespace HelperReportes.Presentacion
{
    partial class FrmReporteAlumnosCantExamenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteAlumnosCantExamenes));
            PA_REPORTE_ALUMNOS_CANT_EXAMENESBindingSource = new System.Windows.Forms.BindingSource(components);
            dSAlumnosCantExamenes = new DataSets.DSAlumnosCantExamenes();
            rpvAlumnos = new Microsoft.Reporting.WinForms.ReportViewer();
            pAREPORTEALUMNOSCANTEXAMENESBindingSource = new System.Windows.Forms.BindingSource(components);
            pA_REPORTE_ALUMNOS_CANT_EXAMENESTableAdapter = new DataSets.DSAlumnosCantExamenesTableAdapters.PA_REPORTE_ALUMNOS_CANT_EXAMENESTableAdapter();
            txtNombre = new System.Windows.Forms.TextBox();
            lblNombre = new System.Windows.Forms.Label();
            lblSituacionLaboral = new System.Windows.Forms.Label();
            cboSituacionLaboral = new System.Windows.Forms.ComboBox();
            btnGenerarReporte = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)PA_REPORTE_ALUMNOS_CANT_EXAMENESBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dSAlumnosCantExamenes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pAREPORTEALUMNOSCANTEXAMENESBindingSource).BeginInit();
            SuspendLayout();
            // 
            // PA_REPORTE_ALUMNOS_CANT_EXAMENESBindingSource
            // 
            PA_REPORTE_ALUMNOS_CANT_EXAMENESBindingSource.DataMember = "PA_REPORTE_ALUMNOS_CANT_EXAMENES";
            PA_REPORTE_ALUMNOS_CANT_EXAMENESBindingSource.DataSource = dSAlumnosCantExamenes;
            // 
            // dSAlumnosCantExamenes
            // 
            dSAlumnosCantExamenes.DataSetName = "DSAlumnosCantExamenes";
            dSAlumnosCantExamenes.Namespace = "http://tempuri.org/DSAlumnosCantExamenes.xsd";
            dSAlumnosCantExamenes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvAlumnos
            // 
            rpvAlumnos.DocumentMapWidth = 30;
            reportDataSource1.Name = "DataSetReporteAlumnosCantExamenes";
            reportDataSource1.Value = PA_REPORTE_ALUMNOS_CANT_EXAMENESBindingSource;
            rpvAlumnos.LocalReport.DataSources.Add(reportDataSource1);
            rpvAlumnos.LocalReport.ReportEmbeddedResource = "HelperReportes.Reportes.ReportAlumnosCantExamenes.rdlc";
            rpvAlumnos.Location = new System.Drawing.Point(14, 59);
            rpvAlumnos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rpvAlumnos.Name = "rpvAlumnos";
            rpvAlumnos.ServerReport.BearerToken = null;
            rpvAlumnos.Size = new System.Drawing.Size(814, 357);
            rpvAlumnos.TabIndex = 6;
            // 
            // pAREPORTEALUMNOSCANTEXAMENESBindingSource
            // 
            pAREPORTEALUMNOSCANTEXAMENESBindingSource.DataMember = "PA_REPORTE_ALUMNOS_CANT_EXAMENES";
            pAREPORTEALUMNOSCANTEXAMENESBindingSource.DataSource = dSAlumnosCantExamenes;
            // 
            // pA_REPORTE_ALUMNOS_CANT_EXAMENESTableAdapter
            // 
            pA_REPORTE_ALUMNOS_CANT_EXAMENESTableAdapter.ClearBeforeFill = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(104, 10);
            txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(164, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNombre.Location = new System.Drawing.Point(27, 10);
            lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(60, 17);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblSituacionLaboral
            // 
            lblSituacionLaboral.AutoSize = true;
            lblSituacionLaboral.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSituacionLaboral.Location = new System.Drawing.Point(279, 10);
            lblSituacionLaboral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSituacionLaboral.Name = "lblSituacionLaboral";
            lblSituacionLaboral.Size = new System.Drawing.Size(111, 17);
            lblSituacionLaboral.TabIndex = 2;
            lblSituacionLaboral.Text = "Situacion Laboral:";
            // 
            // cboSituacionLaboral
            // 
            cboSituacionLaboral.FormattingEnabled = true;
            cboSituacionLaboral.Location = new System.Drawing.Point(415, 9);
            cboSituacionLaboral.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboSituacionLaboral.Name = "cboSituacionLaboral";
            cboSituacionLaboral.Size = new System.Drawing.Size(166, 23);
            cboSituacionLaboral.TabIndex = 3;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.Location = new System.Drawing.Point(589, 5);
            btnGenerarReporte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new System.Drawing.Size(120, 29);
            btnGenerarReporte.TabIndex = 4;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = true;
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new System.Drawing.Point(716, 5);
            btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(120, 29);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmReporteAlumnosCantExamenes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(842, 430);
            Controls.Add(btnSalir);
            Controls.Add(btnGenerarReporte);
            Controls.Add(cboSituacionLaboral);
            Controls.Add(lblSituacionLaboral);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(rpvAlumnos);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FrmReporteAlumnosCantExamenes";
            Text = "Reporte Alumnos Cantidad de Examenes";
            Load += FrmReporteAlumnosCantExamenes_Load;
            ((System.ComponentModel.ISupportInitialize)PA_REPORTE_ALUMNOS_CANT_EXAMENESBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dSAlumnosCantExamenes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pAREPORTEALUMNOSCANTEXAMENESBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvAlumnos;
        private System.Windows.Forms.BindingSource PA_REPORTE_ALUMNOS_CANT_EXAMENESBindingSource;
        private DataSets.DSAlumnosCantExamenes dSAlumnosCantExamenes;
        private System.Windows.Forms.BindingSource pAREPORTEALUMNOSCANTEXAMENESBindingSource;
        private DataSets.DSAlumnosCantExamenesTableAdapters.PA_REPORTE_ALUMNOS_CANT_EXAMENESTableAdapter pA_REPORTE_ALUMNOS_CANT_EXAMENESTableAdapter;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblSituacionLaboral;
        private System.Windows.Forms.ComboBox cboSituacionLaboral;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Button btnSalir;
    }
}