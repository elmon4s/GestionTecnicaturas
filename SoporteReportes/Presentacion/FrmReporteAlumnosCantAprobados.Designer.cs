namespace SoporteReportes
{
    partial class FrmReporteAlumnosCantAprobados
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpvAlumnos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblAño = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblSituacionLaboral = new System.Windows.Forms.Label();
            this.PA_REPORTE_ALUMNOS_CANT_APROBADOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAlumnosCantAprobados = new SoporteReportes.DataSets.DSAlumnosCantAprobados();
            this.pAREPORTEALUMNOSCANTAPROBADOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pA_REPORTE_ALUMNOS_CANT_APROBADOSTableAdapter = new SoporteReportes.DataSets.DSAlumnosCantAprobadosTableAdapters.PA_REPORTE_ALUMNOS_CANT_APROBADOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PA_REPORTE_ALUMNOS_CANT_APROBADOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAlumnosCantAprobados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAREPORTEALUMNOSCANTAPROBADOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvAlumnos
            // 
            reportDataSource1.Name = "DataSetReportAlumnosCantAprobados";
            reportDataSource1.Value = this.PA_REPORTE_ALUMNOS_CANT_APROBADOSBindingSource;
            this.rpvAlumnos.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvAlumnos.LocalReport.ReportEmbeddedResource = "SoporteReportes.Reportes.ReportAlumnosCantAprobados.rdlc";
            this.rpvAlumnos.Location = new System.Drawing.Point(12, 43);
            this.rpvAlumnos.Name = "rpvAlumnos";
            this.rpvAlumnos.ServerReport.BearerToken = null;
            this.rpvAlumnos.Size = new System.Drawing.Size(726, 329);
            this.rpvAlumnos.TabIndex = 0;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAño.Location = new System.Drawing.Point(84, 13);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(37, 19);
            this.lblAño.TabIndex = 1;
            this.lblAño.Text = "Año:";
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(127, 12);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(132, 20);
            this.txtAño.TabIndex = 2;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGenerar.Location = new System.Drawing.Point(530, 10);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(125, 22);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(387, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // lblSituacionLaboral
            // 
            this.lblSituacionLaboral.AutoSize = true;
            this.lblSituacionLaboral.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSituacionLaboral.Location = new System.Drawing.Point(265, 13);
            this.lblSituacionLaboral.Name = "lblSituacionLaboral";
            this.lblSituacionLaboral.Size = new System.Drawing.Size(116, 19);
            this.lblSituacionLaboral.TabIndex = 5;
            this.lblSituacionLaboral.Text = "Situacion Laboral:";
            // 
            // PA_REPORTE_ALUMNOS_CANT_APROBADOSBindingSource
            // 
            this.PA_REPORTE_ALUMNOS_CANT_APROBADOSBindingSource.DataMember = "PA_REPORTE_ALUMNOS_CANT_APROBADOS";
            this.PA_REPORTE_ALUMNOS_CANT_APROBADOSBindingSource.DataSource = this.dSAlumnosCantAprobados;
            // 
            // dSAlumnosCantAprobados
            // 
            this.dSAlumnosCantAprobados.DataSetName = "DSAlumnosCantAprobados";
            this.dSAlumnosCantAprobados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pAREPORTEALUMNOSCANTAPROBADOSBindingSource
            // 
            this.pAREPORTEALUMNOSCANTAPROBADOSBindingSource.DataMember = "PA_REPORTE_ALUMNOS_CANT_APROBADOS";
            this.pAREPORTEALUMNOSCANTAPROBADOSBindingSource.DataSource = this.dSAlumnosCantAprobados;
            // 
            // pA_REPORTE_ALUMNOS_CANT_APROBADOSTableAdapter
            // 
            this.pA_REPORTE_ALUMNOS_CANT_APROBADOSTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteAlumnosCantAprobados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 379);
            this.Controls.Add(this.lblSituacionLaboral);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.rpvAlumnos);
            this.Name = "FrmReporteAlumnosCantAprobados";
            this.Text = "Reporte Alumnos Cantidad de Materias Aprobadas";
            this.Load += new System.EventHandler(this.FrmReporteAlumnosCantAprobados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PA_REPORTE_ALUMNOS_CANT_APROBADOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAlumnosCantAprobados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAREPORTEALUMNOSCANTAPROBADOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvAlumnos;
        private System.Windows.Forms.BindingSource pAREPORTEALUMNOSCANTAPROBADOSBindingSource;
        private DataSets.DSAlumnosCantAprobados dSAlumnosCantAprobados;
        private DataSets.DSAlumnosCantAprobadosTableAdapters.PA_REPORTE_ALUMNOS_CANT_APROBADOSTableAdapter pA_REPORTE_ALUMNOS_CANT_APROBADOSTableAdapter;
        private System.Windows.Forms.BindingSource PA_REPORTE_ALUMNOS_CANT_APROBADOSBindingSource;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblSituacionLaboral;
    }
}

