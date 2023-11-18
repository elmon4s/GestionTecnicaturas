namespace Front.Presentacion.Examenes
{
    partial class FrmGestorExamen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestorExamen));
            cboMaterias = new ComboBox();
            lblFecha = new Label();
            lblMateria = new Label();
            dtpFecha = new DateTimePicker();
            cboDocentes = new ComboBox();
            btnAceptar = new Button();
            dgvDetalles = new DataGridView();
            lblAlumno = new Label();
            cboAlumnos = new ComboBox();
            lblNota = new Label();
            nudNota = new NumericUpDown();
            btnAgregar = new Button();
            btnConfirmar = new Button();
            pnlExamen = new Panel();
            lblDocente = new Label();
            btnEditar = new Button();
            btnSalir = new Button();
            ColID = new DataGridViewTextBoxColumn();
            ColApellido = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColNota = new DataGridViewTextBoxColumn();
            ColAcciones = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNota).BeginInit();
            pnlExamen.SuspendLayout();
            SuspendLayout();
            // 
            // cboMaterias
            // 
            cboMaterias.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboMaterias.FormattingEnabled = true;
            cboMaterias.Location = new Point(88, 53);
            cboMaterias.Name = "cboMaterias";
            cboMaterias.Size = new Size(161, 25);
            cboMaterias.TabIndex = 1;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(47, 21);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(44, 19);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha";
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblMateria.Location = new Point(35, 57);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(56, 19);
            lblMateria.TabIndex = 3;
            lblMateria.Text = "Materia";
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(91, 15);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(104, 25);
            dtpFecha.TabIndex = 5;
            // 
            // cboDocentes
            // 
            cboDocentes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboDocentes.FormattingEnabled = true;
            cboDocentes.Location = new Point(90, 17);
            cboDocentes.Name = "cboDocentes";
            cboDocentes.Size = new Size(161, 25);
            cboDocentes.TabIndex = 6;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAceptar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(357, 376);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(79, 29);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // dgvDetalles
            // 
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.AllowUserToDeleteRows = false;
            dgvDetalles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Columns.AddRange(new DataGridViewColumn[] { ColID, ColApellido, ColNombre, ColNota, ColAcciones });
            dgvDetalles.Location = new Point(36, 82);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.ReadOnly = true;
            dgvDetalles.Size = new Size(570, 196);
            dgvDetalles.TabIndex = 7;
            dgvDetalles.CellContentClick += dgvDetalles_CellContentClick;
            // 
            // lblAlumno
            // 
            lblAlumno.AutoSize = true;
            lblAlumno.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblAlumno.Location = new Point(27, 51);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new Size(57, 19);
            lblAlumno.TabIndex = 9;
            lblAlumno.Text = "Alumno";
            // 
            // cboAlumnos
            // 
            cboAlumnos.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboAlumnos.FormattingEnabled = true;
            cboAlumnos.Location = new Point(90, 51);
            cboAlumnos.Name = "cboAlumnos";
            cboAlumnos.Size = new Size(161, 25);
            cboAlumnos.TabIndex = 10;
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblNota.Location = new Point(282, 51);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(39, 19);
            lblNota.TabIndex = 12;
            lblNota.Text = "Nota";
            // 
            // nudNota
            // 
            nudNota.Location = new Point(317, 50);
            nudNota.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudNota.Name = "nudNota";
            nudNota.Size = new Size(78, 25);
            nudNota.TabIndex = 13;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(531, 50);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 29);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnConfirmar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmar.Location = new Point(255, 50);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(84, 29);
            btnConfirmar.TabIndex = 15;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // pnlExamen
            // 
            pnlExamen.BackColor = SystemColors.ActiveCaption;
            pnlExamen.Controls.Add(lblDocente);
            pnlExamen.Controls.Add(cboDocentes);
            pnlExamen.Controls.Add(btnAgregar);
            pnlExamen.Controls.Add(dgvDetalles);
            pnlExamen.Controls.Add(nudNota);
            pnlExamen.Controls.Add(cboAlumnos);
            pnlExamen.Controls.Add(lblNota);
            pnlExamen.Controls.Add(lblAlumno);
            pnlExamen.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            pnlExamen.Location = new Point(-2, 89);
            pnlExamen.Name = "pnlExamen";
            pnlExamen.Size = new Size(635, 281);
            pnlExamen.TabIndex = 16;
            // 
            // lblDocente
            // 
            lblDocente.AutoSize = true;
            lblDocente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDocente.Location = new Point(27, 20);
            lblDocente.Name = "lblDocente";
            lblDocente.Size = new Size(60, 19);
            lblDocente.TabIndex = 15;
            lblDocente.Text = "Docente";
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.Location = new Point(442, 376);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(79, 29);
            btnEditar.TabIndex = 17;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(525, 376);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(79, 29);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // ColID
            // 
            ColID.HeaderText = "ID";
            ColID.Name = "ColID";
            ColID.ReadOnly = true;
            ColID.Visible = false;
            // 
            // ColApellido
            // 
            ColApellido.HeaderText = "Apellido";
            ColApellido.Name = "ColApellido";
            ColApellido.ReadOnly = true;
            // 
            // ColNombre
            // 
            ColNombre.HeaderText = "Nombre";
            ColNombre.Name = "ColNombre";
            ColNombre.ReadOnly = true;
            // 
            // ColNota
            // 
            ColNota.HeaderText = "Nota";
            ColNota.Name = "ColNota";
            ColNota.ReadOnly = true;
            // 
            // ColAcciones
            // 
            ColAcciones.FillWeight = 50F;
            ColAcciones.HeaderText = "Quitar";
            ColAcciones.Name = "ColAcciones";
            ColAcciones.ReadOnly = true;
            ColAcciones.Text = "Quitar";
            ColAcciones.UseColumnTextForButtonValue = true;
            // 
            // FrmGestorExamen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(634, 417);
            Controls.Add(btnSalir);
            Controls.Add(btnEditar);
            Controls.Add(pnlExamen);
            Controls.Add(btnConfirmar);
            Controls.Add(lblFecha);
            Controls.Add(cboMaterias);
            Controls.Add(btnAceptar);
            Controls.Add(dtpFecha);
            Controls.Add(lblMateria);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmGestorExamen";
            Text = "Examen";
            Load += ExamenFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNota).EndInit();
            pnlExamen.ResumeLayout(false);
            pnlExamen.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboMaterias;
        private Label lblFecha;
        private Label lblMateria;
        private DateTimePicker dtpFecha;
        private ComboBox cboDocentes;
        private Button btnAceptar;
        private DataGridView dgvDetalles;
        private Label lblAlumno;
        private ComboBox cboAlumnos;
        private Label lblNota;
        private NumericUpDown nudNota;
        private Button btnAgregar;
        private Button btnConfirmar;
        private Panel pnlExamen;
        private Button btnEditar;
        private Label lblDocente;
        private Button btnSalir;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn ColApellido;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColNota;
        private DataGridViewButtonColumn ColAcciones;
    }
}