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
            dgvDetalles = new DataGridView();
            IdMateriaComision = new DataGridViewTextBoxColumn();
            Docente = new DataGridViewTextBoxColumn();
            Materia = new DataGridViewTextBoxColumn();
            Comision = new DataGridViewTextBoxColumn();
            Acciones = new DataGridViewButtonColumn();
            lblDocente = new Label();
            lblComision = new Label();
            lblMateria = new Label();
            txtDocente = new TextBox();
            txtComision = new TextBox();
            txtMateria = new TextBox();
            btnCancelar = new Button();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            SuspendLayout();
            // 
            // dgvDetalles
            // 
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.AllowUserToDeleteRows = false;
            dgvDetalles.AllowUserToResizeColumns = false;
            dgvDetalles.AllowUserToResizeRows = false;
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDetalles.Columns.AddRange(new DataGridViewColumn[] { IdMateriaComision, Docente, Materia, Comision, Acciones });
            dgvDetalles.Location = new Point(12, 148);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvDetalles.RowTemplate.Height = 25;
            dgvDetalles.Size = new Size(695, 231);
            dgvDetalles.TabIndex = 0;
            dgvDetalles.CellContentClick += dgvDetalles_CellContentClick;
            // 
            // IdMateriaComision
            // 
            IdMateriaComision.HeaderText = "IdMateriaComision";
            IdMateriaComision.Name = "IdMateriaComision";
            IdMateriaComision.ReadOnly = true;
            IdMateriaComision.Visible = false;
            // 
            // Docente
            // 
            Docente.FillWeight = 122.699409F;
            Docente.HeaderText = "Docente";
            Docente.Name = "Docente";
            Docente.ReadOnly = true;
            Docente.Width = 200;
            // 
            // Materia
            // 
            Materia.FillWeight = 106.988327F;
            Materia.HeaderText = "Materia";
            Materia.Name = "Materia";
            Materia.ReadOnly = true;
            Materia.Width = 174;
            // 
            // Comision
            // 
            Comision.FillWeight = 55.505043F;
            Comision.HeaderText = "Comisión";
            Comision.Name = "Comision";
            Comision.ReadOnly = true;
            Comision.Width = 91;
            // 
            // Acciones
            // 
            Acciones.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Acciones.FillWeight = 114.807304F;
            Acciones.HeaderText = "Acciones";
            Acciones.Name = "Acciones";
            Acciones.ReadOnly = true;
            Acciones.Resizable = DataGridViewTriState.True;
            Acciones.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // lblDocente
            // 
            lblDocente.AutoSize = true;
            lblDocente.Location = new Point(12, 39);
            lblDocente.Name = "lblDocente";
            lblDocente.Size = new Size(54, 15);
            lblDocente.TabIndex = 1;
            lblDocente.Text = "Docente:";
            // 
            // lblComision
            // 
            lblComision.AutoSize = true;
            lblComision.Location = new Point(12, 91);
            lblComision.Name = "lblComision";
            lblComision.Size = new Size(61, 15);
            lblComision.TabIndex = 2;
            lblComision.Text = "Comision:";
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new Point(12, 69);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(50, 15);
            lblMateria.TabIndex = 3;
            lblMateria.Text = "Materia:";
            // 
            // txtDocente
            // 
            txtDocente.Location = new Point(101, 32);
            txtDocente.MaximumSize = new Size(523, 23);
            txtDocente.MinimumSize = new Size(523, 23);
            txtDocente.Name = "txtDocente";
            txtDocente.Size = new Size(523, 23);
            txtDocente.TabIndex = 4;
            // 
            // txtComision
            // 
            txtComision.Location = new Point(101, 90);
            txtComision.Name = "txtComision";
            txtComision.Size = new Size(523, 23);
            txtComision.TabIndex = 5;
            // 
            // txtMateria
            // 
            txtMateria.Location = new Point(101, 61);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(523, 23);
            txtMateria.TabIndex = 6;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 397);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(632, 87);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // FrmConsultarDetalleMateriaComision
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 434);
            ControlBox = false;
            Controls.Add(btnBuscar);
            Controls.Add(btnCancelar);
            Controls.Add(txtMateria);
            Controls.Add(txtComision);
            Controls.Add(txtDocente);
            Controls.Add(lblMateria);
            Controls.Add(lblComision);
            Controls.Add(lblDocente);
            Controls.Add(dgvDetalles);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(748, 473);
            MinimumSize = new Size(748, 473);
            Name = "FrmConsultarDetalleMateriaComision";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Materia Comision";
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}