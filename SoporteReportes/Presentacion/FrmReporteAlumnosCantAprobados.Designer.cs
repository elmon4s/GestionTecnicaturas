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
            components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            PA_REPORTE_ALUMNOS_CANT_APROBADOSBindingSource = new System.Windows.Forms.BindingSource(components);
            dSAlumnosCantAprobados = new DataSets.DSAlumnosCantAprobados();
            rpvAlumnos = new Microsoft.Reporting.WinForms.ReportViewer();
            lblAño = new System.Windows.Forms.Label();
            txtAño = new System.Windows.Forms.TextBox();
            btnGenerar = new System.Windows.Forms.Button();
            cboSituacionLaboral = new System.Windows.Forms.ComboBox();
            lblSituacionLaboral = new System.Windows.Forms.Label();
            pAREPORTEALUMNOSCANTAPROBADOSBindingSource = new System.Windows.Forms.BindingSource(components);
            pA_REPORTE_ALUMNOS_CANT_APROBADOSTableAdapter = new DataSets.DSAlumnosCantAprobadosTableAdapters.PA_REPORTE_ALUMNOS_CANT_APROBADOSTableAdapter();
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
            rpvAlumnos.LocalReport.ReportEmbeddedResource = "SoporteReportes.Reportes.ReportAlumnosCantAprobados.rdlc";
            rpvAlumnos.Location = new System.Drawing.Point(14, 50);
            rpvAlumnos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rpvAlumnos.Name = "rpvAlumnos";
            rpvAlumnos.ServerReport.BearerToken = null;
            rpvAlumnos.Size = new System.Drawing.Size(847, 379);
            rpvAlumnos.TabIndex = 0;
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblAño.Location = new System.Drawing.Point(45, 15);
            lblAño.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAño.Name = "lblAño";
            lblAño.Size = new System.Drawing.Size(37, 19);
            lblAño.TabIndex = 1;
            lblAño.Text = "Año:";
            // 
            // txtAño
            // 
            txtAño.Location = new System.Drawing.Point(95, 14);
            txtAño.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtAño.Name = "txtAño";
            txtAño.Size = new System.Drawing.Size(153, 23);
            txtAño.TabIndex = 2;
            // 
            // btnGenerar
            // 
            btnGenerar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnGenerar.Location = new System.Drawing.Point(565, 12);
            btnGenerar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new System.Drawing.Size(146, 25);
            btnGenerar.TabIndex = 3;
            btnGenerar.Text = "Generar Reporte";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // cboSituacionLaboral
            // 
            cboSituacionLaboral.FormattingEnabled = true;
            cboSituacionLaboral.Location = new System.Drawing.Point(398, 13);
            cboSituacionLaboral.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboSituacionLaboral.Name = "cboSituacionLaboral";
            cboSituacionLaboral.Size = new System.Drawing.Size(159, 23);
            cboSituacionLaboral.TabIndex = 4;
            // 
            // lblSituacionLaboral
            // 
            lblSituacionLaboral.AutoSize = true;
            lblSituacionLaboral.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSituacionLaboral.Location = new System.Drawing.Point(256, 15);
            lblSituacionLaboral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSituacionLaboral.Name = "lblSituacionLaboral";
            lblSituacionLaboral.Size = new System.Drawing.Size(116, 19);
            lblSituacionLaboral.TabIndex = 5;
            lblSituacionLaboral.Text = "Situacion Laboral:";
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
            // btnSalir
            // 
            btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSalir.Location = new System.Drawing.Point(768, 11);
            btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(91, 25);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmReporteAlumnosCantAprobados
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(872, 437);
            Controls.Add(btnSalir);
            Controls.Add(lblSituacionLaboral);
            Controls.Add(cboSituacionLaboral);
            Controls.Add(btnGenerar);
            Controls.Add(txtAño);
            Controls.Add(lblAño);
            Controls.Add(rpvAlumnos);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FrmReporteAlumnosCantAprobados";
            Text = "Reporte Alumnos Cantidad de Materias Aprobadas";
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
        private System.Windows.Forms.BindingSource PA_REPORTE_ALUMNOS_CANT_APROBADOSBindingSource;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ComboBox cboSituacionLaboral;
        private System.Windows.Forms.Label lblSituacionLaboral;
        private System.Windows.Forms.Button btnSalir;
    }
}

