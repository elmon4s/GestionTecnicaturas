namespace Front.Presentacion.Alumnos
{
    partial class FrmConsultarDetalleMateriaComision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarDetalleMateriaComision));
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.IdMateriaComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Docente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblDocente = new System.Windows.Forms.Label();
            this.lblComision = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.txtDocente = new System.Windows.Forms.TextBox();
            this.txtComision = new System.Windows.Forms.TextBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grbCriteriosBusqueda = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.grbCriteriosBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.AllowUserToResizeColumns = false;
            this.dgvDetalles.AllowUserToResizeRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMateriaComision,
            this.Docente,
            this.Materia,
            this.Comision,
            this.Acciones});
            this.dgvDetalles.Location = new System.Drawing.Point(33, 178);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDetalles.RowTemplate.Height = 25;
            this.dgvDetalles.Size = new System.Drawing.Size(669, 295);
            this.dgvDetalles.TabIndex = 0;
            // 
            // IdMateriaComision
            // 
            this.IdMateriaComision.HeaderText = "IdMateriaComision";
            this.IdMateriaComision.Name = "IdMateriaComision";
            this.IdMateriaComision.ReadOnly = true;
            this.IdMateriaComision.Visible = false;
            // 
            // Docente
            // 
            this.Docente.FillWeight = 122.6994F;
            this.Docente.HeaderText = "Docente";
            this.Docente.Name = "Docente";
            this.Docente.ReadOnly = true;
            this.Docente.Width = 200;
            // 
            // Materia
            // 
            this.Materia.FillWeight = 106.9883F;
            this.Materia.HeaderText = "Materia";
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            this.Materia.Width = 174;
            // 
            // Comision
            // 
            this.Comision.FillWeight = 55.50504F;
            this.Comision.HeaderText = "Comisión";
            this.Comision.Name = "Comision";
            this.Comision.ReadOnly = true;
            this.Comision.Width = 91;
            // 
            // Acciones
            // 
            this.Acciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Acciones.FillWeight = 114.8073F;
            this.Acciones.HeaderText = "Acciones";
            this.Acciones.Name = "Acciones";
            this.Acciones.ReadOnly = true;
            this.Acciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Acciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lblDocente
            // 
            this.lblDocente.AutoSize = true;
            this.lblDocente.Location = new System.Drawing.Point(27, 42);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(63, 19);
            this.lblDocente.TabIndex = 1;
            this.lblDocente.Text = "Docente:";
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Location = new System.Drawing.Point(21, 115);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(69, 19);
            this.lblComision.TabIndex = 2;
            this.lblComision.Text = "Comision:";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(31, 79);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(59, 19);
            this.lblMateria.TabIndex = 3;
            this.lblMateria.Text = "Materia:";
            // 
            // txtDocente
            // 
            this.txtDocente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDocente.Location = new System.Drawing.Point(96, 42);
            this.txtDocente.MaximumSize = new System.Drawing.Size(523, 23);
            this.txtDocente.Name = "txtDocente";
            this.txtDocente.Size = new System.Drawing.Size(347, 23);
            this.txtDocente.TabIndex = 4;
            // 
            // txtComision
            // 
            this.txtComision.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtComision.Location = new System.Drawing.Point(96, 112);
            this.txtComision.Name = "txtComision";
            this.txtComision.Size = new System.Drawing.Size(347, 26);
            this.txtComision.TabIndex = 5;
            // 
            // txtMateria
            // 
            this.txtMateria.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMateria.Location = new System.Drawing.Point(96, 75);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(347, 26);
            this.txtMateria.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(33, 479);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 35);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(552, 109);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(79, 35);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // grbCriteriosBusqueda
            // 
            this.grbCriteriosBusqueda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grbCriteriosBusqueda.Controls.Add(this.txtDocente);
            this.grbCriteriosBusqueda.Controls.Add(this.btnBuscar);
            this.grbCriteriosBusqueda.Controls.Add(this.lblDocente);
            this.grbCriteriosBusqueda.Controls.Add(this.lblComision);
            this.grbCriteriosBusqueda.Controls.Add(this.txtMateria);
            this.grbCriteriosBusqueda.Controls.Add(this.lblMateria);
            this.grbCriteriosBusqueda.Controls.Add(this.txtComision);
            this.grbCriteriosBusqueda.Location = new System.Drawing.Point(51, 14);
            this.grbCriteriosBusqueda.Name = "grbCriteriosBusqueda";
            this.grbCriteriosBusqueda.Size = new System.Drawing.Size(637, 158);
            this.grbCriteriosBusqueda.TabIndex = 9;
            this.grbCriteriosBusqueda.TabStop = false;
            this.grbCriteriosBusqueda.Text = "Criterios de Busqueda";
            // 
            // FrmConsultarDetalleMateriaComision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(732, 521);
            this.ControlBox = false;
            this.Controls.Add(this.grbCriteriosBusqueda);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvDetalles);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(748, 560);
            this.MinimumSize = new System.Drawing.Size(748, 560);
            this.Name = "FrmConsultarDetalleMateriaComision";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Materia Comision";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.grbCriteriosBusqueda.ResumeLayout(false);
            this.grbCriteriosBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvDetalles;
        private Label lblDocente;
        private Label lblComision;
        private Label lblMateria;
        private TextBox txtDocente;
        private TextBox txtComision;
        private TextBox txtMateria;
        private Button btnCancelar;
        private Button btnBuscar;
        private DataGridViewTextBoxColumn IdMateriaComision;
        private DataGridViewTextBoxColumn Docente;
        private DataGridViewTextBoxColumn Materia;
        private DataGridViewTextBoxColumn Comision;
        private DataGridViewButtonColumn Acciones;
        private GroupBox grbCriteriosBusqueda;
    }
}