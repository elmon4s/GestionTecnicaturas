namespace SoporteReportes.Presentacion
{
    partial class FrmReporteDocentesPorcentajes
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
            this.rpvDocentes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSDocentesPorcentajes = new SoporteReportes.DataSets.DSDocentesPorcentajes();
            this.pAREPORTEDOCENTESPORCENTAJESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pA_REPORTE_DOCENTES_PORCENTAJESTableAdapter = new SoporteReportes.DataSets.DSDocentesPorcentajesTableAdapters.PA_REPORTE_DOCENTES_PORCENTAJESTableAdapter();
            this.PA_REPORTE_DOCENTES_PORCENTAJESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTituloDocente = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dSDocentesPorcentajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAREPORTEDOCENTESPORCENTAJESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_REPORTE_DOCENTES_PORCENTAJESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvDocentes
            // 
            reportDataSource1.Name = "DataSetReporteDocentesPorcentaje";
            reportDataSource1.Value = this.PA_REPORTE_DOCENTES_PORCENTAJESBindingSource;
            this.rpvDocentes.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvDocentes.LocalReport.ReportEmbeddedResource = "SoporteReportes.Reportes.ReportDocentesPorcentajes.rdlc";
            this.rpvDocentes.Location = new System.Drawing.Point(13, 57);
            this.rpvDocentes.Name = "rpvDocentes";
            this.rpvDocentes.ServerReport.BearerToken = null;
            this.rpvDocentes.Size = new System.Drawing.Size(739, 296);
            this.rpvDocentes.TabIndex = 0;
            // 
            // dSDocentesPorcentajes
            // 
            this.dSDocentesPorcentajes.DataSetName = "DSDocentesPorcentajes";
            this.dSDocentesPorcentajes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pAREPORTEDOCENTESPORCENTAJESBindingSource
            // 
            this.pAREPORTEDOCENTESPORCENTAJESBindingSource.DataMember = "PA_REPORTE_DOCENTES_PORCENTAJES";
            this.pAREPORTEDOCENTESPORCENTAJESBindingSource.DataSource = this.dSDocentesPorcentajes;
            // 
            // pA_REPORTE_DOCENTES_PORCENTAJESTableAdapter
            // 
            this.pA_REPORTE_DOCENTES_PORCENTAJESTableAdapter.ClearBeforeFill = true;
            // 
            // PA_REPORTE_DOCENTES_PORCENTAJESBindingSource
            // 
            this.PA_REPORTE_DOCENTES_PORCENTAJESBindingSource.DataMember = "PA_REPORTE_DOCENTES_PORCENTAJES";
            this.PA_REPORTE_DOCENTES_PORCENTAJESBindingSource.DataSource = this.dSDocentesPorcentajes;
            // 
            // lblTituloDocente
            // 
            this.lblTituloDocente.AutoSize = true;
            this.lblTituloDocente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDocente.Location = new System.Drawing.Point(168, 15);
            this.lblTituloDocente.Name = "lblTituloDocente";
            this.lblTituloDocente.Size = new System.Drawing.Size(114, 17);
            this.lblTituloDocente.TabIndex = 1;
            this.lblTituloDocente.Text = "Titulo de Docente:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(288, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(440, 15);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(125, 23);
            this.btnGenerarReporte.TabIndex = 3;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // FrmReporteDocentesPorcentajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 365);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblTituloDocente);
            this.Controls.Add(this.rpvDocentes);
            this.Name = "FrmReporteDocentesPorcentajes";
            this.Text = "FrmReporteDocentesPorcentajes";
            this.Load += new System.EventHandler(this.FrmReporteDocentesPorcentajes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSDocentesPorcentajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAREPORTEDOCENTESPORCENTAJESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_REPORTE_DOCENTES_PORCENTAJESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvDocentes;
        private System.Windows.Forms.BindingSource PA_REPORTE_DOCENTES_PORCENTAJESBindingSource;
        private DataSets.DSDocentesPorcentajes dSDocentesPorcentajes;
        private System.Windows.Forms.BindingSource pAREPORTEDOCENTESPORCENTAJESBindingSource;
        private DataSets.DSDocentesPorcentajesTableAdapters.PA_REPORTE_DOCENTES_PORCENTAJESTableAdapter pA_REPORTE_DOCENTES_PORCENTAJESTableAdapter;
        private System.Windows.Forms.Label lblTituloDocente;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnGenerarReporte;
    }
}