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
            dtpFechaHasta = new DateTimePicker();
            dtpFechaDesde = new DateTimePicker();
            btnSalir = new Button();
            dgvExamenes = new DataGridView();
            ColIdExamen = new DataGridViewTextBoxColumn();
            ColFecha = new DataGridViewTextBoxColumn();
            ColDocente = new DataGridViewTextBoxColumn();
            ColMateria = new DataGridViewTextBoxColumn();
            ColAcciones = new DataGridViewButtonColumn();
            lblFechaDesde = new Label();
            lblFechaHasta = new Label();
            cboMaterias = new ComboBox();
            lblMateria = new Label();
            cboDocentes = new ComboBox();
            lblDocentes = new Label();
            grpCriterios = new GroupBox();
            btnLimpiar = new Button();
            ckbActivarFechas = new CheckBox();
            pnlFechas = new Panel();
            btnConsultar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvExamenes).BeginInit();
            grpCriterios.SuspendLayout();
            pnlFechas.SuspendLayout();
            SuspendLayout();
            // 
            // dtpFechaHasta
            // 
            dtpFechaHasta.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaHasta.Format = DateTimePickerFormat.Short;
            dtpFechaHasta.Location = new Point(226, 3);
            dtpFechaHasta.Name = "dtpFechaHasta";
            dtpFechaHasta.Size = new Size(111, 25);
            dtpFechaHasta.TabIndex = 3;
            // 
            // dtpFechaDesde
            // 
            dtpFechaDesde.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaDesde.Format = DateTimePickerFormat.Short;
            dtpFechaDesde.Location = new Point(60, 3);
            dtpFechaDesde.Name = "dtpFechaDesde";
            dtpFechaDesde.Size = new Size(111, 25);
            dtpFechaDesde.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(640, 442);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(79, 29);
            btnSalir.TabIndex = 3;
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
            dgvExamenes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvExamenes.Columns.AddRange(new DataGridViewColumn[] { ColIdExamen, ColFecha, ColDocente, ColMateria, ColAcciones });
            dgvExamenes.Location = new Point(44, 187);
            dgvExamenes.MaximumSize = new Size(880, 320);
            dgvExamenes.MultiSelect = false;
            dgvExamenes.Name = "dgvExamenes";
            dgvExamenes.ReadOnly = true;
            dgvExamenes.RowTemplate.Height = 25;
            dgvExamenes.Size = new Size(675, 249);
            dgvExamenes.TabIndex = 1;
            dgvExamenes.CellContentClick += dgvExamenes_CellContentClick;
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
            // ColMateria
            // 
            ColMateria.HeaderText = "Materia";
            ColMateria.Name = "ColMateria";
            ColMateria.ReadOnly = true;
            // 
            // ColAcciones
            // 
            ColAcciones.FillWeight = 60F;
            ColAcciones.HeaderText = "Acciones";
            ColAcciones.Name = "ColAcciones";
            ColAcciones.ReadOnly = true;
            ColAcciones.Text = "Ver Examen";
            ColAcciones.UseColumnTextForButtonValue = true;
            // 
            // lblFechaDesde
            // 
            lblFechaDesde.AutoSize = true;
            lblFechaDesde.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaDesde.Location = new Point(4, 6);
            lblFechaDesde.Name = "lblFechaDesde";
            lblFechaDesde.Size = new Size(50, 19);
            lblFechaDesde.TabIndex = 0;
            lblFechaDesde.Text = "Desde:";
            // 
            // lblFechaHasta
            // 
            lblFechaHasta.AutoSize = true;
            lblFechaHasta.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaHasta.Location = new Point(177, 6);
            lblFechaHasta.Name = "lblFechaHasta";
            lblFechaHasta.Size = new Size(47, 19);
            lblFechaHasta.TabIndex = 2;
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
            cboMaterias.TabIndex = 1;
            cboMaterias.SelectionChangeCommitted += cboMaterias_SelectionChangeCommitted;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblMateria.Location = new Point(15, 35);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(56, 19);
            lblMateria.TabIndex = 0;
            lblMateria.Text = "Materia";
            // 
            // cboDocentes
            // 
            cboDocentes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboDocentes.FormattingEnabled = true;
            cboDocentes.Location = new Point(68, 72);
            cboDocentes.Name = "cboDocentes";
            cboDocentes.Size = new Size(161, 25);
            cboDocentes.TabIndex = 3;
            // 
            // lblDocentes
            // 
            lblDocentes.AutoSize = true;
            lblDocentes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDocentes.Location = new Point(11, 75);
            lblDocentes.Name = "lblDocentes";
            lblDocentes.Size = new Size(60, 19);
            lblDocentes.TabIndex = 2;
            lblDocentes.Text = "Docente";
            // 
            // grpCriterios
            // 
            grpCriterios.BackColor = Color.WhiteSmoke;
            grpCriterios.Controls.Add(btnLimpiar);
            grpCriterios.Controls.Add(ckbActivarFechas);
            grpCriterios.Controls.Add(pnlFechas);
            grpCriterios.Controls.Add(cboMaterias);
            grpCriterios.Controls.Add(cboDocentes);
            grpCriterios.Controls.Add(lblDocentes);
            grpCriterios.Controls.Add(lblMateria);
            grpCriterios.Controls.Add(btnConsultar);
            grpCriterios.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            grpCriterios.Location = new Point(62, 29);
            grpCriterios.Name = "grpCriterios";
            grpCriterios.Size = new Size(644, 152);
            grpCriterios.TabIndex = 0;
            grpCriterios.TabStop = false;
            grpCriterios.Text = "Criterios de Búsqueda:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpiar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(163, 103);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(66, 26);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // ckbActivarFechas
            // 
            ckbActivarFechas.AutoSize = true;
            ckbActivarFechas.Location = new Point(282, 58);
            ckbActivarFechas.Name = "ckbActivarFechas";
            ckbActivarFechas.Size = new Size(115, 23);
            ckbActivarFechas.TabIndex = 5;
            ckbActivarFechas.Text = "Activar Fechas";
            ckbActivarFechas.UseVisualStyleBackColor = true;
            ckbActivarFechas.CheckedChanged += ckbActivar_CheckedChanged;
            // 
            // pnlFechas
            // 
            pnlFechas.Controls.Add(lblFechaDesde);
            pnlFechas.Controls.Add(dtpFechaDesde);
            pnlFechas.Controls.Add(dtpFechaHasta);
            pnlFechas.Controls.Add(lblFechaHasta);
            pnlFechas.Location = new Point(278, 30);
            pnlFechas.Name = "pnlFechas";
            pnlFechas.Size = new Size(344, 28);
            pnlFechas.TabIndex = 4;
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConsultar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultar.Location = new Point(537, 91);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(79, 29);
            btnConsultar.TabIndex = 7;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(555, 442);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(79, 29);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FrmConsultarExamenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(768, 493);
            Controls.Add(grpCriterios);
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
        private CheckBox ckbActivarFechas;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnConsultar;
        private DataGridViewTextBoxColumn ColIdExamen;
        private DataGridViewTextBoxColumn ColFecha;
        private DataGridViewTextBoxColumn ColDocente;
        private DataGridViewTextBoxColumn ColMateria;
        private DataGridViewButtonColumn ColAcciones;
    }
}