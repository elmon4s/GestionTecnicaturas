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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpvAlumnos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSAlumnosCantExamenes = new SoporteReportes.DataSets.DSAlumnosCantExamenes();
            this.pAREPORTEALUMNOSCANTEXAMENESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pA_REPORTE_ALUMNOS_CANT_EXAMENESTableAdapter = new SoporteReportes.DataSets.DSAlumnosCantExamenesTableAdapters.PA_REPORTE_ALUMNOS_CANT_EXAMENESTableAdapter();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboSituacionLaboral = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblSituacionLaboral = new System.Windows.Forms.Label();
            this.PA_REPORTE_ALUMNOS_CANT_EXAMENESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dSAlumnosCantExamenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAREPORTEALUMNOSCANTEXAMENESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_REPORTE_ALUMNOS_CANT_EXAMENESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvAlumnos
            // 
            reportDataSource1.Name = "DataSetReportAlumnosCantExamenes";
            reportDataSource1.Value = this.PA_REPORTE_ALUMNOS_CANT_EXAMENESBindingSource;
            this.rpvAlumnos.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvAlumnos.LocalReport.ReportEmbeddedResource = "SoporteReportes.Reportes.ReportAlumnosCantExamenes.rdlc";
            this.rpvAlumnos.Location = new System.Drawing.Point(12, 54);
            this.rpvAlumnos.Name = "rpvAlumnos";
            this.rpvAlumnos.ServerReport.BearerToken = null;
            this.rpvAlumnos.Size = new System.Drawing.Size(716, 368);
            this.rpvAlumnos.TabIndex = 0;
            // 
            // dSAlumnosCantExamenes
            // 
            this.dSAlumnosCantExamenes.DataSetName = "DSAlumnosCantExamenes";
            this.dSAlumnosCantExamenes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pAREPORTEALUMNOSCANTEXAMENESBindingSource
            // 
            this.pAREPORTEALUMNOSCANTEXAMENESBindingSource.DataMember = "PA_REPORTE_ALUMNOS_CANT_EXAMENES";
            this.pAREPORTEALUMNOSCANTEXAMENESBindingSource.DataSource = this.dSAlumnosCantExamenes;
            // 
            // pA_REPORTE_ALUMNOS_CANT_EXAMENESTableAdapter
            // 
            this.pA_REPORTE_ALUMNOS_CANT_EXAMENESTableAdapter.ClearBeforeFill = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(55, 15);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 17);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(116, 13);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(139, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // cboSituacionLaboral
            // 
            this.cboSituacionLaboral.FormattingEnabled = true;
            this.cboSituacionLaboral.Location = new System.Drawing.Point(378, 13);
            this.cboSituacionLaboral.Name = "cboSituacionLaboral";
            this.cboSituacionLaboral.Size = new System.Drawing.Size(121, 21);
            this.cboSituacionLaboral.TabIndex = 3;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(518, 12);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(116, 23);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblSituacionLaboral
            // 
            this.lblSituacionLaboral.AutoSize = true;
            this.lblSituacionLaboral.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacionLaboral.Location = new System.Drawing.Point(261, 15);
            this.lblSituacionLaboral.Name = "lblSituacionLaboral";
            this.lblSituacionLaboral.Size = new System.Drawing.Size(111, 17);
            this.lblSituacionLaboral.TabIndex = 5;
            this.lblSituacionLaboral.Text = "Situacion Laboral:";
            // 
            // PA_REPORTE_ALUMNOS_CANT_EXAMENESBindingSource
            // 
            this.PA_REPORTE_ALUMNOS_CANT_EXAMENESBindingSource.DataMember = "PA_REPORTE_ALUMNOS_CANT_EXAMENES";
            this.PA_REPORTE_ALUMNOS_CANT_EXAMENESBindingSource.DataSource = this.dSAlumnosCantExamenes;
            // 
            // FrmReporteAlumnosCantExamenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 436);
            this.Controls.Add(this.lblSituacionLaboral);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.cboSituacionLaboral);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.rpvAlumnos);
            this.Name = "FrmReporteAlumnosCantExamenes";
            this.Text = "FrmReporteAlumnoCantExamenes";
            this.Load += new System.EventHandler(this.FrmReporteAlumnosCantExamenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSAlumnosCantExamenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAREPORTEALUMNOSCANTEXAMENESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_REPORTE_ALUMNOS_CANT_EXAMENESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}