namespace SoporteReportes.Presentacion
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
            PA_REPORTE_ALUMNOS_CANT_EXAMENESBindingSource = new System.Windows.Forms.BindingSource(components);
            dSAlumnosCantExamenes = new DataSets.DSAlumnosCantExamenes();
            rpvAlumnos = new Microsoft.Reporting.WinForms.ReportViewer();
            pAREPORTEALUMNOSCANTEXAMENESBindingSource = new System.Windows.Forms.BindingSource(components);
            pA_REPORTE_ALUMNOS_CANT_EXAMENESTableAdapter = new DataSets.DSAlumnosCantExamenesTableAdapters.PA_REPORTE_ALUMNOS_CANT_EXAMENESTableAdapter();
            lblNombre = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            cboSituacionLaboral = new System.Windows.Forms.ComboBox();
            btnGenerar = new System.Windows.Forms.Button();
            lblSituacionLaboral = new System.Windows.Forms.Label();
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
            reportDataSource1.Name = "DataSetReportAlumnosCantExamenes";
            reportDataSource1.Value = PA_REPORTE_ALUMNOS_CANT_EXAMENESBindingSource;
            rpvAlumnos.LocalReport.DataSources.Add(reportDataSource1);
            rpvAlumnos.LocalReport.ReportEmbeddedResource = "SoporteReportes.Reportes.ReportAlumnosCantExamenes.rdlc";
            rpvAlumnos.Location = new System.Drawing.Point(14, 62);
            rpvAlumnos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rpvAlumnos.Name = "rpvAlumnos";
            rpvAlumnos.ServerReport.BearerToken = null;
            rpvAlumnos.Size = new System.Drawing.Size(835, 424);
            rpvAlumnos.TabIndex = 0;
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
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNombre.Location = new System.Drawing.Point(22, 15);
            lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(57, 17);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(93, 13);
            txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(162, 23);
            txtNombre.TabIndex = 2;
            // 
            // cboSituacionLaboral
            // 
            cboSituacionLaboral.FormattingEnabled = true;
            cboSituacionLaboral.Location = new System.Drawing.Point(399, 13);
            cboSituacionLaboral.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboSituacionLaboral.Name = "cboSituacionLaboral";
            cboSituacionLaboral.Size = new System.Drawing.Size(140, 23);
            cboSituacionLaboral.TabIndex = 3;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new System.Drawing.Point(562, 12);
            btnGenerar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new System.Drawing.Size(135, 27);
            btnGenerar.TabIndex = 4;
            btnGenerar.Text = "Generar Reporte";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // lblSituacionLaboral
            // 
            lblSituacionLaboral.AutoSize = true;
            lblSituacionLaboral.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSituacionLaboral.Location = new System.Drawing.Point(262, 15);
            lblSituacionLaboral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSituacionLaboral.Name = "lblSituacionLaboral";
            lblSituacionLaboral.Size = new System.Drawing.Size(111, 17);
            lblSituacionLaboral.TabIndex = 5;
            lblSituacionLaboral.Text = "Situacion Laboral:";
            // 
            // btnSalir
            // 
            btnSalir.Location = new System.Drawing.Point(754, 10);
            btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(96, 27);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmReporteAlumnosCantExamenes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(863, 503);
            Controls.Add(btnSalir);
            Controls.Add(lblSituacionLaboral);
            Controls.Add(btnGenerar);
            Controls.Add(cboSituacionLaboral);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(rpvAlumnos);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FrmReporteAlumnosCantExamenes";
            Text = "FrmReporteAlumnoCantExamenes";
            Load += FrmReporteAlumnosCantExamenes_Load;
            ((System.ComponentModel.ISupportInitialize)PA_REPORTE_ALUMNOS_CANT_EXAMENESBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dSAlumnosCantExamenes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pAREPORTEALUMNOSCANTEXAMENESBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvAlumnos;
        private System.Windows.Forms.BindingSource pAREPORTEALUMNOSCANTEXAMENESBindingSource;
        private DataSets.DSAlumnosCantExamenes dSAlumnosCantExamenes;
        private DataSets.DSAlumnosCantExamenesTableAdapters.PA_REPORTE_ALUMNOS_CANT_EXAMENESTableAdapter pA_REPORTE_ALUMNOS_CANT_EXAMENESTableAdapter;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboSituacionLaboral;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblSituacionLaboral;
        private System.Windows.Forms.BindingSource PA_REPORTE_ALUMNOS_CANT_EXAMENESBindingSource;
        private System.Windows.Forms.Button btnSalir;
    }
}