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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PA_REPORTE_MATERIA_COMISIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMateriaComision = new SoporteReportes.DataSets.DSMateriaComision();
            this.rpvMateriaComision = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSMateriaComisionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pAREPORTEMATERIACOMISIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pA_REPORTE_MATERIA_COMISIONTableAdapter = new SoporteReportes.DataSets.DSMateriaComisionTableAdapters.PA_REPORTE_MATERIA_COMISIONTableAdapter();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAñoDesde = new System.Windows.Forms.TextBox();
            this.txtAñoHasta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PA_REPORTE_MATERIA_COMISIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMateriaComision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMateriaComisionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAREPORTEMATERIACOMISIONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PA_REPORTE_MATERIA_COMISIONBindingSource
            // 
            this.PA_REPORTE_MATERIA_COMISIONBindingSource.DataMember = "PA_REPORTE_MATERIA_COMISION";
            this.PA_REPORTE_MATERIA_COMISIONBindingSource.DataSource = this.dSMateriaComision;
            // 
            // dSMateriaComision
            // 
            this.dSMateriaComision.DataSetName = "DSMateriaComision";
            this.dSMateriaComision.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvMateriaComision
            // 
            reportDataSource2.Name = "DataSetReporteMateriaComision";
            reportDataSource2.Value = this.PA_REPORTE_MATERIA_COMISIONBindingSource;
            this.rpvMateriaComision.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvMateriaComision.LocalReport.ReportEmbeddedResource = "SoporteReportes.Reportes.ReportMateriaComision.rdlc";
            this.rpvMateriaComision.Location = new System.Drawing.Point(12, 90);
            this.rpvMateriaComision.Name = "rpvMateriaComision";
            this.rpvMateriaComision.ServerReport.BearerToken = null;
            this.rpvMateriaComision.Size = new System.Drawing.Size(730, 280);
            this.rpvMateriaComision.TabIndex = 0;
            // 
            // dSMateriaComisionBindingSource
            // 
            this.dSMateriaComisionBindingSource.DataSource = this.dSMateriaComision;
            this.dSMateriaComisionBindingSource.Position = 0;
            // 
            // pAREPORTEMATERIACOMISIONBindingSource
            // 
            this.pAREPORTEMATERIACOMISIONBindingSource.DataMember = "PA_REPORTE_MATERIA_COMISION";
            this.pAREPORTEMATERIACOMISIONBindingSource.DataSource = this.dSMateriaComisionBindingSource;
            // 
            // pA_REPORTE_MATERIA_COMISIONTableAdapter
            // 
            this.pA_REPORTE_MATERIA_COMISIONTableAdapter.ClearBeforeFill = true;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesde.Location = new System.Drawing.Point(153, 29);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(75, 17);
            this.lblFechaDesde.TabIndex = 1;
            this.lblFechaDesde.Text = "Año Desde:";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHasta.Location = new System.Drawing.Point(379, 29);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(71, 17);
            this.lblFechaHasta.TabIndex = 3;
            this.lblFechaHasta.Text = "Año Hasta:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(219, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(153, 59);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(55, 17);
            this.lblCarrera.TabIndex = 6;
            this.lblCarrera.Text = "Carrera:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Generar Reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAñoDesde
            // 
            this.txtAñoDesde.Location = new System.Drawing.Point(244, 29);
            this.txtAñoDesde.Name = "txtAñoDesde";
            this.txtAñoDesde.Size = new System.Drawing.Size(115, 20);
            this.txtAñoDesde.TabIndex = 8;
            // 
            // txtAñoHasta
            // 
            this.txtAñoHasta.Location = new System.Drawing.Point(466, 29);
            this.txtAñoHasta.Name = "txtAñoHasta";
            this.txtAñoHasta.Size = new System.Drawing.Size(115, 20);
            this.txtAñoHasta.TabIndex = 9;
            // 
            // FrmReporteMateriaComision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 389);
            this.Controls.Add(this.txtAñoHasta);
            this.Controls.Add(this.txtAñoDesde);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.rpvMateriaComision);
            this.Name = "FrmReporteMateriaComision";
            this.Text = "FrmReporteMateriaComision";
            this.Load += new System.EventHandler(this.FrmReporteMateriaComision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PA_REPORTE_MATERIA_COMISIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMateriaComision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMateriaComisionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAREPORTEMATERIACOMISIONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAñoDesde;
        private System.Windows.Forms.TextBox txtAñoHasta;
    }
}