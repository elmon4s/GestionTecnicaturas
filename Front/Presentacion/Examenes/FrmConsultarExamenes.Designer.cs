namespace Front.Presentacion.Examenes
{
    partial class FrmConsultarExamenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarExamenes));
            btnConsultar = new Button();
            dtpFechaHasta = new DateTimePicker();
            dtpFechaDesde = new DateTimePicker();
            btnSalir = new Button();
            dgvExamenes = new DataGridView();
            lblFechaDesde = new Label();
            lblFechaHasta = new Label();
            cboMaterias = new ComboBox();
            lblMateria = new Label();
            cboDocentes = new ComboBox();
            lblDocentes = new Label();
            grpCriterios = new GroupBox();
            ckbActivar = new CheckBox();
            pnlFechas = new Panel();
            btnEditar = new Button();
            btnEliminar = new Button();
            ColIdExamen = new DataGridViewTextBoxColumn();
            ColFecha = new DataGridViewTextBoxColumn();
            ColDocente = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvExamenes).BeginInit();
            grpCriterios.SuspendLayout();
            pnlFechas.SuspendLayout();
            SuspendLayout();
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConsultar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultar.Location = new Point(500, 83);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(79, 29);
            btnConsultar.TabIndex = 25;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // dtpFechaHasta
            // 
            dtpFechaHasta.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaHasta.Format = DateTimePickerFormat.Short;
            dtpFechaHasta.Location = new Point(226, 3);
            dtpFechaHasta.Name = "dtpFechaHasta";
            dtpFechaHasta.Size = new Size(111, 25);
            dtpFechaHasta.TabIndex = 20;
            // 
            // dtpFechaDesde
            // 
            dtpFechaDesde.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaDesde.Format = DateTimePickerFormat.Short;
            dtpFechaDesde.Location = new Point(60, 3);
            dtpFechaDesde.Name = "dtpFechaDesde";
            dtpFechaDesde.Size = new Size(111, 25);
            dtpFechaDesde.TabIndex = 19;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(597, 411);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(79, 29);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvExamenes
            // 
            dgvExamenes.AllowUserToAddRows = false;
            dgvExamenes.AllowUserToDeleteRows = false;
            dgvExamenes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvExamenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExamenes.BorderStyle = BorderStyle.Fixed3D;
            dgvExamenes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvExamenes.Columns.AddRange(new DataGridViewColumn[] { ColIdExamen, ColFecha, ColDocente });
            dgvExamenes.Location = new Point(44, 161);
            dgvExamenes.MaximumSize = new Size(880, 320);
            dgvExamenes.MultiSelect = false;
            dgvExamenes.Name = "dgvExamenes";
            dgvExamenes.ReadOnly = true;
            dgvExamenes.RowTemplate.Height = 25;
            dgvExamenes.Size = new Size(632, 244);
            dgvExamenes.TabIndex = 17;
            // 
            // lblFechaDesde
            // 
            lblFechaDesde.AutoSize = true;
            lblFechaDesde.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaDesde.Location = new Point(4, 6);
            lblFechaDesde.Name = "lblFechaDesde";
            lblFechaDesde.Size = new Size(50, 19);
            lblFechaDesde.TabIndex = 21;
            lblFechaDesde.Text = "Desde:";
            // 
            // lblFechaHasta
            // 
            lblFechaHasta.AutoSize = true;
            lblFechaHasta.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaHasta.Location = new Point(177, 6);
            lblFechaHasta.Name = "lblFechaHasta";
            lblFechaHasta.Size = new Size(47, 19);
            lblFechaHasta.TabIndex = 22;
            lblFechaHasta.Text = "Hasta:";
            // 
            // cboMaterias
            // 
            cboMaterias.BackColor = SystemColors.Window;
            cboMaterias.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboMaterias.FormattingEnabled = true;
            cboMaterias.Location = new Point(68, 31);
            cboMaterias.Name = "cboMaterias";
            cboMaterias.Size = new Size(161, 25);
            cboMaterias.TabIndex = 26;
            cboMaterias.SelectionChangeCommitted += cboMaterias_SelectionChangeCommitted;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblMateria.Location = new Point(15, 35);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(56, 19);
            lblMateria.TabIndex = 27;
            lblMateria.Text = "Materia";
            // 
            // cboDocentes
            // 
            cboDocentes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboDocentes.FormattingEnabled = true;
            cboDocentes.Location = new Point(68, 80);
            cboDocentes.Name = "cboDocentes";
            cboDocentes.Size = new Size(161, 25);
            cboDocentes.TabIndex = 28;
            // 
            // lblDocentes
            // 
            lblDocentes.AutoSize = true;
            lblDocentes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDocentes.Location = new Point(11, 83);
            lblDocentes.Name = "lblDocentes";
            lblDocentes.Size = new Size(60, 19);
            lblDocentes.TabIndex = 29;
            lblDocentes.Text = "Docente";
            // 
            // grpCriterios
            // 
            grpCriterios.Controls.Add(ckbActivar);
            grpCriterios.Controls.Add(pnlFechas);
            grpCriterios.Controls.Add(cboMaterias);
            grpCriterios.Controls.Add(cboDocentes);
            grpCriterios.Controls.Add(lblDocentes);
            grpCriterios.Controls.Add(lblMateria);
            grpCriterios.Controls.Add(btnConsultar);
            grpCriterios.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            grpCriterios.Location = new Point(63, 29);
            grpCriterios.Name = "grpCriterios";
            grpCriterios.Size = new Size(595, 126);
            grpCriterios.TabIndex = 31;
            grpCriterios.TabStop = false;
            grpCriterios.Text = "Criterios de Búsqueda";
            // 
            // ckbActivar
            // 
            ckbActivar.AutoSize = true;
            ckbActivar.Location = new Point(249, 59);
            ckbActivar.Name = "ckbActivar";
            ckbActivar.Size = new Size(115, 23);
            ckbActivar.TabIndex = 31;
            ckbActivar.Text = "Activar Fechas";
            ckbActivar.UseVisualStyleBackColor = true;
            ckbActivar.CheckedChanged += ckbActivar_CheckedChanged;
            // 
            // pnlFechas
            // 
            pnlFechas.Controls.Add(lblFechaDesde);
            pnlFechas.Controls.Add(dtpFechaDesde);
            pnlFechas.Controls.Add(dtpFechaHasta);
            pnlFechas.Controls.Add(lblFechaHasta);
            pnlFechas.Location = new Point(245, 31);
            pnlFechas.Name = "pnlFechas";
            pnlFechas.Size = new Size(344, 28);
            pnlFechas.TabIndex = 30;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.Location = new Point(44, 411);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(79, 29);
            btnEditar.TabIndex = 24;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(129, 411);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(79, 29);
            btnEliminar.TabIndex = 23;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // ColIdExamen
            // 
            ColIdExamen.FillWeight = 25F;
            ColIdExamen.HeaderText = "ColId";
            ColIdExamen.Name = "ColIdExamen";
            ColIdExamen.ReadOnly = true;
            ColIdExamen.Visible = false;
            // 
            // ColFecha
            // 
            ColFecha.HeaderText = "Fecha del Examen";
            ColFecha.Name = "ColFecha";
            ColFecha.ReadOnly = true;
            // 
            // ColDocente
            // 
            ColDocente.HeaderText = "Docente";
            ColDocente.Name = "ColDocente";
            ColDocente.ReadOnly = true;
            // 
            // FrmConsultarExamenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 462);
            Controls.Add(grpCriterios);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnSalir);
            Controls.Add(dgvExamenes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(984, 533);
            MinimumSize = new Size(690, 410);
            Name = "FrmConsultarExamenes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Examenes";
            Load += FrmConsultarExamenes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvExamenes).EndInit();
            grpCriterios.ResumeLayout(false);
            grpCriterios.PerformLayout();
            pnlFechas.ResumeLayout(false);
            pnlFechas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnConsultar;
        private DateTimePicker dtpFechaHasta;
        private DateTimePicker dtpFechaDesde;
        private Button btnSalir;
        private DataGridView dgvExamenes;
        private Label lblFechaDesde;
        private Label lblFechaHasta;
        private ComboBox cboMaterias;
        private Label lblMateria;
        private ComboBox cboDocentes;
        private Label lblDocentes;
        private GroupBox grpCriterios;
        private GroupBox groupBox1;
        private Panel pnlFechas;
        private CheckBox ckbActivar;
        private Button btnEditar;
        private Button btnEliminar;
        private DataGridViewTextBoxColumn ColIdExamen;
        private DataGridViewTextBoxColumn ColFecha;
        private DataGridViewTextBoxColumn ColDocente;
    }
}