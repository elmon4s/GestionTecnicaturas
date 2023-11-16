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
            components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            PA_REPORTE_DOCENTES_PORCENTAJESBindingSource = new System.Windows.Forms.BindingSource(components);
            dSDocentesPorcentajes = new DataSets.DSDocentesPorcentajes();
            rpvDocentes = new Microsoft.Reporting.WinForms.ReportViewer();
            pAREPORTEDOCENTESPORCENTAJESBindingSource = new System.Windows.Forms.BindingSource(components);
            pA_REPORTE_DOCENTES_PORCENTAJESTableAdapter = new DataSets.DSDocentesPorcentajesTableAdapters.PA_REPORTE_DOCENTES_PORCENTAJESTableAdapter();
            lblTituloDocente = new System.Windows.Forms.Label();
            cboTitulos = new System.Windows.Forms.ComboBox();
            btnGenerarReporte = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)PA_REPORTE_DOCENTES_PORCENTAJESBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dSDocentesPorcentajes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pAREPORTEDOCENTESPORCENTAJESBindingSource).BeginInit();
            SuspendLayout();
            // 
            // PA_REPORTE_DOCENTES_PORCENTAJESBindingSource
            // 
            PA_REPORTE_DOCENTES_PORCENTAJESBindingSource.DataMember = "PA_REPORTE_DOCENTES_PORCENTAJES";
            PA_REPORTE_DOCENTES_PORCENTAJESBindingSource.DataSource = dSDocentesPorcentajes;
            // 
            // dSDocentesPorcentajes
            // 
            dSDocentesPorcentajes.DataSetName = "DSDocentesPorcentajes";
            dSDocentesPorcentajes.Namespace = "http://tempuri.org/DSDocentesPorcentajes.xsd";
            dSDocentesPorcentajes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvDocentes
            // 
            reportDataSource2.Name = "DataSetReporteDocentesPorcentaje";
            reportDataSource2.Value = PA_REPORTE_DOCENTES_PORCENTAJESBindingSource;
            rpvDocentes.LocalReport.DataSources.Add(reportDataSource2);
            rpvDocentes.LocalReport.ReportEmbeddedResource = "SoporteReportes.Reportes.ReportDocentesPorcentajes.rdlc";
            rpvDocentes.Location = new System.Drawing.Point(15, 66);
            rpvDocentes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rpvDocentes.Name = "rpvDocentes";
            rpvDocentes.ServerReport.BearerToken = null;
            rpvDocentes.Size = new System.Drawing.Size(862, 341);
            rpvDocentes.TabIndex = 0;
            // 
            // pAREPORTEDOCENTESPORCENTAJESBindingSource
            // 
            pAREPORTEDOCENTESPORCENTAJESBindingSource.DataMember = "PA_REPORTE_DOCENTES_PORCENTAJES";
            pAREPORTEDOCENTESPORCENTAJESBindingSource.DataSource = dSDocentesPorcentajes;
            // 
            // pA_REPORTE_DOCENTES_PORCENTAJESTableAdapter
            // 
            pA_REPORTE_DOCENTES_PORCENTAJESTableAdapter.ClearBeforeFill = true;
            // 
            // lblTituloDocente
            // 
            lblTituloDocente.AutoSize = true;
            lblTituloDocente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTituloDocente.Location = new System.Drawing.Point(16, 22);
            lblTituloDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTituloDocente.Name = "lblTituloDocente";
            lblTituloDocente.Size = new System.Drawing.Size(114, 17);
            lblTituloDocente.TabIndex = 1;
            lblTituloDocente.Text = "Titulo de Docente:";
            // 
            // cboTitulos
            // 
            cboTitulos.FormattingEnabled = true;
            cboTitulos.Location = new System.Drawing.Point(156, 22);
            cboTitulos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboTitulos.Name = "cboTitulos";
            cboTitulos.Size = new System.Drawing.Size(170, 23);
            cboTitulos.TabIndex = 2;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.Location = new System.Drawing.Point(333, 22);
            btnGenerarReporte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new System.Drawing.Size(146, 27);
            btnGenerarReporte.TabIndex = 3;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = true;
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new System.Drawing.Point(782, 22);
            btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(96, 27);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmReporteDocentesPorcentajes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(891, 421);
            Controls.Add(btnSalir);
            Controls.Add(btnGenerarReporte);
            Controls.Add(cboTitulos);
            Controls.Add(lblTituloDocente);
            Controls.Add(rpvDocentes);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FrmReporteDocentesPorcentajes";
            Text = "FrmReporteDocentesPorcentajes";
            Load += FrmReporteDocentesPorcentajes_Load;
            ((System.ComponentModel.ISupportInitialize)PA_REPORTE_DOCENTES_PORCENTAJESBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dSDocentesPorcentajes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pAREPORTEDOCENTESPORCENTAJESBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvDocentes;
        private System.Windows.Forms.BindingSource PA_REPORTE_DOCENTES_PORCENTAJESBindingSource;
        private DataSets.DSDocentesPorcentajes dSDocentesPorcentajes;
        private System.Windows.Forms.BindingSource pAREPORTEDOCENTESPORCENTAJESBindingSource;
        private DataSets.DSDocentesPorcentajesTableAdapters.PA_REPORTE_DOCENTES_PORCENTAJESTableAdapter pA_REPORTE_DOCENTES_PORCENTAJESTableAdapter;
        private System.Windows.Forms.Label lblTituloDocente;
        private System.Windows.Forms.ComboBox cboTitulos;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Button btnSalir;
    }
}