namespace SoporteReportes.Presentacion
{
    partial class FrmReporteMateriaComision
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            PA_REPORTE_MATERIA_COMISIONBindingSource = new System.Windows.Forms.BindingSource(components);
            dSMateriaComision = new DataSets.DSMateriaComision();
            rpvMateriaComision = new Microsoft.Reporting.WinForms.ReportViewer();
            dSMateriaComisionBindingSource = new System.Windows.Forms.BindingSource(components);
            pAREPORTEMATERIACOMISIONBindingSource = new System.Windows.Forms.BindingSource(components);
            pA_REPORTE_MATERIA_COMISIONTableAdapter = new DataSets.DSMateriaComisionTableAdapters.PA_REPORTE_MATERIA_COMISIONTableAdapter();
            lblFechaDesde = new System.Windows.Forms.Label();
            lblFechaHasta = new System.Windows.Forms.Label();
            cboCarrera = new System.Windows.Forms.ComboBox();
            lblCarrera = new System.Windows.Forms.Label();
            btnGenerarReporte = new System.Windows.Forms.Button();
            txtAñoDesde = new System.Windows.Forms.TextBox();
            txtAñoHasta = new System.Windows.Forms.TextBox();
            btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)PA_REPORTE_MATERIA_COMISIONBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dSMateriaComision).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dSMateriaComisionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pAREPORTEMATERIACOMISIONBindingSource).BeginInit();
            SuspendLayout();
            // 
            // PA_REPORTE_MATERIA_COMISIONBindingSource
            // 
            PA_REPORTE_MATERIA_COMISIONBindingSource.DataMember = "PA_REPORTE_MATERIA_COMISION";
            PA_REPORTE_MATERIA_COMISIONBindingSource.DataSource = dSMateriaComision;
            // 
            // dSMateriaComision
            // 
            dSMateriaComision.DataSetName = "DSMateriaComision";
            dSMateriaComision.Namespace = "http://tempuri.org/DSMateriaComision.xsd";
            dSMateriaComision.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvMateriaComision
            // 
            reportDataSource3.Name = "DataSetReporteMateriaComision";
            reportDataSource3.Value = PA_REPORTE_MATERIA_COMISIONBindingSource;
            rpvMateriaComision.LocalReport.DataSources.Add(reportDataSource3);
            rpvMateriaComision.LocalReport.ReportEmbeddedResource = "SoporteReportes.Reportes.ReportMateriaComision.rdlc";
            rpvMateriaComision.Location = new System.Drawing.Point(14, 104);
            rpvMateriaComision.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rpvMateriaComision.Name = "rpvMateriaComision";
            rpvMateriaComision.ServerReport.BearerToken = null;
            rpvMateriaComision.Size = new System.Drawing.Size(851, 323);
            rpvMateriaComision.TabIndex = 0;
            // 
            // dSMateriaComisionBindingSource
            // 
            dSMateriaComisionBindingSource.DataSource = dSMateriaComision;
            dSMateriaComisionBindingSource.Position = 0;
            // 
            // pAREPORTEMATERIACOMISIONBindingSource
            // 
            pAREPORTEMATERIACOMISIONBindingSource.DataMember = "PA_REPORTE_MATERIA_COMISION";
            pAREPORTEMATERIACOMISIONBindingSource.DataSource = dSMateriaComisionBindingSource;
            // 
            // pA_REPORTE_MATERIA_COMISIONTableAdapter
            // 
            pA_REPORTE_MATERIA_COMISIONTableAdapter.ClearBeforeFill = true;
            // 
            // lblFechaDesde
            // 
            lblFechaDesde.AutoSize = true;
            lblFechaDesde.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblFechaDesde.Location = new System.Drawing.Point(63, 22);
            lblFechaDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFechaDesde.Name = "lblFechaDesde";
            lblFechaDesde.Size = new System.Drawing.Size(75, 17);
            lblFechaDesde.TabIndex = 1;
            lblFechaDesde.Text = "Año Desde:";
            // 
            // lblFechaHasta
            // 
            lblFechaHasta.AutoSize = true;
            lblFechaHasta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblFechaHasta.Location = new System.Drawing.Point(327, 22);
            lblFechaHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFechaHasta.Name = "lblFechaHasta";
            lblFechaHasta.Size = new System.Drawing.Size(71, 17);
            lblFechaHasta.TabIndex = 3;
            lblFechaHasta.Text = "Año Hasta:";
            // 
            // cboCarrera
            // 
            cboCarrera.FormattingEnabled = true;
            cboCarrera.Location = new System.Drawing.Point(140, 55);
            cboCarrera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboCarrera.Name = "cboCarrera";
            cboCarrera.Size = new System.Drawing.Size(163, 23);
            cboCarrera.TabIndex = 5;
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCarrera.Location = new System.Drawing.Point(63, 57);
            lblCarrera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new System.Drawing.Size(55, 17);
            lblCarrera.TabIndex = 6;
            lblCarrera.Text = "Carrera:";
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.Location = new System.Drawing.Point(429, 55);
            btnGenerarReporte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new System.Drawing.Size(134, 27);
            btnGenerarReporte.TabIndex = 7;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = true;
            btnGenerarReporte.Click += button1_Click;
            // 
            // txtAñoDesde
            // 
            txtAñoDesde.Location = new System.Drawing.Point(170, 22);
            txtAñoDesde.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtAñoDesde.Name = "txtAñoDesde";
            txtAñoDesde.Size = new System.Drawing.Size(134, 23);
            txtAñoDesde.TabIndex = 8;
            // 
            // txtAñoHasta
            // 
            txtAñoHasta.Location = new System.Drawing.Point(429, 22);
            txtAñoHasta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtAñoHasta.Name = "txtAñoHasta";
            txtAñoHasta.Size = new System.Drawing.Size(134, 23);
            txtAñoHasta.TabIndex = 9;
            // 
            // btnSalir
            // 
            btnSalir.Location = new System.Drawing.Point(769, 22);
            btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(98, 27);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmReporteMateriaComision
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(880, 449);
            Controls.Add(btnSalir);
            Controls.Add(txtAñoHasta);
            Controls.Add(txtAñoDesde);
            Controls.Add(btnGenerarReporte);
            Controls.Add(lblCarrera);
            Controls.Add(cboCarrera);
            Controls.Add(lblFechaHasta);
            Controls.Add(lblFechaDesde);
            Controls.Add(rpvMateriaComision);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FrmReporteMateriaComision";
            Text = "FrmReporteMateriaComision";
            Load += FrmReporteMateriaComision_Load;
            ((System.ComponentModel.ISupportInitialize)PA_REPORTE_MATERIA_COMISIONBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dSMateriaComision).EndInit();
            ((System.ComponentModel.ISupportInitialize)dSMateriaComisionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pAREPORTEMATERIACOMISIONBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvMateriaComision;
        private System.Windows.Forms.BindingSource PA_REPORTE_MATERIA_COMISIONBindingSource;
        private DataSets.DSMateriaComision dSMateriaComision;
        private System.Windows.Forms.BindingSource dSMateriaComisionBindingSource;
        private System.Windows.Forms.BindingSource pAREPORTEMATERIACOMISIONBindingSource;
        private DataSets.DSMateriaComisionTableAdapters.PA_REPORTE_MATERIA_COMISIONTableAdapter pA_REPORTE_MATERIA_COMISIONTableAdapter;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.ComboBox cboCarrera;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.TextBox txtAñoDesde;
        private System.Windows.Forms.TextBox txtAñoHasta;
        private System.Windows.Forms.Button btnSalir;
    }
}