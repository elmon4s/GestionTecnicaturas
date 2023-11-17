namespace HelperReportes.Presentacion
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteMateriaComision));
            PA_REPORTE_MATERIA_COMISIONBindingSource = new System.Windows.Forms.BindingSource(components);
            dSMateriaComision = new DataSets.DSMateriaComision();
            lblAñoDesde = new System.Windows.Forms.Label();
            txtAñoDesde = new System.Windows.Forms.TextBox();
            txtAñoHasta = new System.Windows.Forms.TextBox();
            lblAñoHasta = new System.Windows.Forms.Label();
            lblCarrera = new System.Windows.Forms.Label();
            cboCarrera = new System.Windows.Forms.ComboBox();
            btnGenerarReporte = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            pAREPORTEMATERIACOMISIONBindingSource = new System.Windows.Forms.BindingSource(components);
            pA_REPORTE_MATERIA_COMISIONTableAdapter = new DataSets.DSMateriaComisionTableAdapters.PA_REPORTE_MATERIA_COMISIONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)PA_REPORTE_MATERIA_COMISIONBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dSMateriaComision).BeginInit();
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
            // lblAñoDesde
            // 
            lblAñoDesde.AutoSize = true;
            lblAñoDesde.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblAñoDesde.Location = new System.Drawing.Point(38, 14);
            lblAñoDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAñoDesde.Name = "lblAñoDesde";
            lblAñoDesde.Size = new System.Drawing.Size(75, 17);
            lblAñoDesde.TabIndex = 0;
            lblAñoDesde.Text = "Año Desde:";
            // 
            // txtAñoDesde
            // 
            txtAñoDesde.Location = new System.Drawing.Point(133, 14);
            txtAñoDesde.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtAñoDesde.Name = "txtAñoDesde";
            txtAñoDesde.Size = new System.Drawing.Size(116, 23);
            txtAñoDesde.TabIndex = 1;
            // 
            // txtAñoHasta
            // 
            txtAñoHasta.Location = new System.Drawing.Point(370, 14);
            txtAñoHasta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtAñoHasta.Name = "txtAñoHasta";
            txtAñoHasta.Size = new System.Drawing.Size(116, 23);
            txtAñoHasta.TabIndex = 3;
            // 
            // lblAñoHasta
            // 
            lblAñoHasta.AutoSize = true;
            lblAñoHasta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblAñoHasta.Location = new System.Drawing.Point(275, 14);
            lblAñoHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAñoHasta.Name = "lblAñoHasta";
            lblAñoHasta.Size = new System.Drawing.Size(71, 17);
            lblAñoHasta.TabIndex = 2;
            lblAñoHasta.Text = "Año Hasta:";
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCarrera.Location = new System.Drawing.Point(38, 62);
            lblCarrera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new System.Drawing.Size(55, 17);
            lblCarrera.TabIndex = 4;
            lblCarrera.Text = "Carrera:";
            // 
            // cboCarrera
            // 
            cboCarrera.FormattingEnabled = true;
            cboCarrera.Location = new System.Drawing.Point(133, 62);
            cboCarrera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboCarrera.Name = "cboCarrera";
            cboCarrera.Size = new System.Drawing.Size(353, 23);
            cboCarrera.TabIndex = 5;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.Location = new System.Drawing.Point(522, 12);
            btnGenerarReporte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new System.Drawing.Size(158, 27);
            btnGenerarReporte.TabIndex = 6;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = true;
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new System.Drawing.Point(704, 10);
            btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(158, 27);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetReporteMateriaComision";
            reportDataSource1.Value = PA_REPORTE_MATERIA_COMISIONBindingSource;
            reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            reportViewer1.LocalReport.ReportEmbeddedResource = "HelperReportes.Reportes.ReportMateriaComision.rdlc";
            reportViewer1.Location = new System.Drawing.Point(14, 105);
            reportViewer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new System.Drawing.Size(847, 400);
            reportViewer1.TabIndex = 8;
            // 
            // pAREPORTEMATERIACOMISIONBindingSource
            // 
            pAREPORTEMATERIACOMISIONBindingSource.DataMember = "PA_REPORTE_MATERIA_COMISION";
            pAREPORTEMATERIACOMISIONBindingSource.DataSource = dSMateriaComision;
            // 
            // pA_REPORTE_MATERIA_COMISIONTableAdapter
            // 
            pA_REPORTE_MATERIA_COMISIONTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteMateriaComision
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(875, 519);
            Controls.Add(reportViewer1);
            Controls.Add(btnSalir);
            Controls.Add(btnGenerarReporte);
            Controls.Add(cboCarrera);
            Controls.Add(lblCarrera);
            Controls.Add(txtAñoHasta);
            Controls.Add(lblAñoHasta);
            Controls.Add(txtAñoDesde);
            Controls.Add(lblAñoDesde);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FrmReporteMateriaComision";
            Text = "Reporte Materias, Comision y Docente";
            Load += FrmReporteMateriaComision_Load;
            ((System.ComponentModel.ISupportInitialize)PA_REPORTE_MATERIA_COMISIONBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dSMateriaComision).EndInit();
            ((System.ComponentModel.ISupportInitialize)pAREPORTEMATERIACOMISIONBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblAñoDesde;
        private System.Windows.Forms.TextBox txtAñoDesde;
        private System.Windows.Forms.TextBox txtAñoHasta;
        private System.Windows.Forms.Label lblAñoHasta;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.ComboBox cboCarrera;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Button btnSalir;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PA_REPORTE_MATERIA_COMISIONBindingSource;
        private DataSets.DSMateriaComision dSMateriaComision;
        private System.Windows.Forms.BindingSource pAREPORTEMATERIACOMISIONBindingSource;
        private DataSets.DSMateriaComisionTableAdapters.PA_REPORTE_MATERIA_COMISIONTableAdapter pA_REPORTE_MATERIA_COMISIONTableAdapter;
    }
}