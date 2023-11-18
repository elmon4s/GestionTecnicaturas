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
            lblDocente = new Label();
            lblComision = new Label();
            lblMateria = new Label();
            txtDocente = new TextBox();
            txtComision = new TextBox();
            txtMateria = new TextBox();
            btnCancelar = new Button();
            btnBuscar = new Button();
            grbCriteriosBusqueda = new GroupBox();
            IdMateriaComision = new DataGridViewTextBoxColumn();
            Docente = new DataGridViewTextBoxColumn();
            Materia = new DataGridViewTextBoxColumn();
            Comision = new DataGridViewTextBoxColumn();
            AnioLectivo = new DataGridViewTextBoxColumn();
            Acciones = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            grbCriteriosBusqueda.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDetalles
            // 
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.AllowUserToDeleteRows = false;
            dgvDetalles.AllowUserToResizeColumns = false;
            dgvDetalles.AllowUserToResizeRows = false;
            dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDetalles.Columns.AddRange(new DataGridViewColumn[] { IdMateriaComision, Docente, Materia, Comision, AnioLectivo, Acciones });
            dgvDetalles.Location = new Point(33, 178);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvDetalles.RowTemplate.Height = 25;
            dgvDetalles.Size = new Size(669, 295);
            dgvDetalles.TabIndex = 0;
            dgvDetalles.CellContentClick += dgvDetalles_CellContentClick;
            // 
            // lblDocente
            // 
            lblDocente.AutoSize = true;
            lblDocente.Location = new Point(27, 42);
            lblDocente.Name = "lblDocente";
            lblDocente.Size = new Size(63, 19);
            lblDocente.TabIndex = 1;
            lblDocente.Text = "Docente:";
            // 
            // lblComision
            // 
            lblComision.AutoSize = true;
            lblComision.Location = new Point(21, 115);
            lblComision.Name = "lblComision";
            lblComision.Size = new Size(69, 19);
            lblComision.TabIndex = 2;
            lblComision.Text = "Comision:";
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new Point(31, 79);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(59, 19);
            lblMateria.TabIndex = 3;
            lblMateria.Text = "Materia:";
            // 
            // txtDocente
            // 
            txtDocente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDocente.Location = new Point(96, 42);
            txtDocente.MaximumSize = new Size(523, 23);
            txtDocente.Name = "txtDocente";
            txtDocente.Size = new Size(347, 23);
            txtDocente.TabIndex = 4;
            // 
            // txtComision
            // 
            txtComision.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtComision.Location = new Point(96, 112);
            txtComision.Name = "txtComision";
            txtComision.Size = new Size(347, 25);
            txtComision.TabIndex = 5;
            // 
            // txtMateria
            // 
            txtMateria.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMateria.Location = new Point(96, 75);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(347, 25);
            txtMateria.TabIndex = 6;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(33, 479);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(79, 35);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.Location = new Point(552, 109);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(79, 35);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // grbCriteriosBusqueda
            // 
            grbCriteriosBusqueda.BackColor = Color.WhiteSmoke;
            grbCriteriosBusqueda.Controls.Add(txtDocente);
            grbCriteriosBusqueda.Controls.Add(btnBuscar);
            grbCriteriosBusqueda.Controls.Add(lblDocente);
            grbCriteriosBusqueda.Controls.Add(lblComision);
            grbCriteriosBusqueda.Controls.Add(txtMateria);
            grbCriteriosBusqueda.Controls.Add(lblMateria);
            grbCriteriosBusqueda.Controls.Add(txtComision);
            grbCriteriosBusqueda.Location = new Point(51, 14);
            grbCriteriosBusqueda.Name = "grbCriteriosBusqueda";
            grbCriteriosBusqueda.Size = new Size(637, 158);
            grbCriteriosBusqueda.TabIndex = 9;
            grbCriteriosBusqueda.TabStop = false;
            grbCriteriosBusqueda.Text = "Criterios de Busqueda";
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
            Docente.FillWeight = 122.6994F;
            Docente.HeaderText = "Docente";
            Docente.Name = "Docente";
            Docente.ReadOnly = true;
            // 
            // Materia
            // 
            Materia.FillWeight = 106.9883F;
            Materia.HeaderText = "Materia";
            Materia.Name = "Materia";
            Materia.ReadOnly = true;
            // 
            // Comision
            // 
            Comision.FillWeight = 70F;
            Comision.HeaderText = "Comisión";
            Comision.Name = "Comision";
            Comision.ReadOnly = true;
            // 
            // AnioLectivo
            // 
            AnioLectivo.FillWeight = 70F;
            AnioLectivo.HeaderText = "Año Lectivo";
            AnioLectivo.Name = "AnioLectivo";
            // 
            // Acciones
            // 
            Acciones.FillWeight = 110F;
            Acciones.HeaderText = "Acciones";
            Acciones.Name = "Acciones";
            Acciones.ReadOnly = true;
            Acciones.Resizable = DataGridViewTriState.True;
            Acciones.SortMode = DataGridViewColumnSortMode.Automatic;
            Acciones.Text = "Seleccionar";
            Acciones.UseColumnTextForButtonValue = true;
            // 
            // FrmConsultarDetalleMateriaComision
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(732, 521);
            ControlBox = false;
            Controls.Add(grbCriteriosBusqueda);
            Controls.Add(btnCancelar);
            Controls.Add(dgvDetalles);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(748, 560);
            MinimumSize = new Size(748, 560);
            Name = "FrmConsultarDetalleMateriaComision";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Materia Comision";
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            grbCriteriosBusqueda.ResumeLayout(false);
            grbCriteriosBusqueda.PerformLayout();
            ResumeLayout(false);
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
        private GroupBox grbCriteriosBusqueda;
        private DataGridViewTextBoxColumn IdMateriaComision;
        private DataGridViewTextBoxColumn Docente;
        private DataGridViewTextBoxColumn Materia;
        private DataGridViewTextBoxColumn Comision;
        private DataGridViewTextBoxColumn AnioLectivo;
        private DataGridViewButtonColumn Acciones;
    }
}