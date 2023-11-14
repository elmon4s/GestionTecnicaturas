namespace Front.Presentacion.Alumnos
{
    partial class FrmConsultaAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaAlumnos));
            dgvAlumnos = new DataGridView();
            IdAlumno = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            SituacionLaboral = new DataGridViewTextBoxColumn();
            EstadoCivil = new DataGridViewTextBoxColumn();
            Acciones = new DataGridViewButtonColumn();
            Acciones2 = new DataGridViewButtonColumn();
            cboSituacionLaboral = new ComboBox();
            cboEstadoCivil = new ComboBox();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblSituacionLab = new Label();
            lblEstadoCivil = new Label();
            btnBuscar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AllowUserToAddRows = false;
            dgvAlumnos.AllowUserToDeleteRows = false;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Columns.AddRange(new DataGridViewColumn[] { IdAlumno, Nombre, Apellido, SituacionLaboral, EstadoCivil, Acciones, Acciones2 });
            dgvAlumnos.Location = new Point(24, 157);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.ReadOnly = true;
            dgvAlumnos.RowTemplate.Height = 25;
            dgvAlumnos.Size = new Size(859, 240);
            dgvAlumnos.TabIndex = 0;
            dgvAlumnos.CellContentClick += dgvAlumnos_CellContentClick;
            // 
            // IdAlumno
            // 
            IdAlumno.HeaderText = "IdAlumno";
            IdAlumno.Name = "IdAlumno";
            IdAlumno.ReadOnly = true;
            IdAlumno.Visible = false;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 150;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            Apellido.Width = 150;
            // 
            // SituacionLaboral
            // 
            SituacionLaboral.HeaderText = "Situacion Laboral";
            SituacionLaboral.Name = "SituacionLaboral";
            SituacionLaboral.ReadOnly = true;
            SituacionLaboral.Width = 150;
            // 
            // EstadoCivil
            // 
            EstadoCivil.HeaderText = "Estado civil";
            EstadoCivil.Name = "EstadoCivil";
            EstadoCivil.ReadOnly = true;
            EstadoCivil.Width = 150;
            // 
            // Acciones
            // 
            Acciones.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Acciones.HeaderText = "Acciones";
            Acciones.Name = "Acciones";
            Acciones.ReadOnly = true;
            Acciones.Resizable = DataGridViewTriState.True;
            Acciones.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Acciones2
            // 
            Acciones2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Acciones2.HeaderText = "";
            Acciones2.Name = "Acciones2";
            Acciones2.ReadOnly = true;
            Acciones2.Resizable = DataGridViewTriState.True;
            Acciones2.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // cboSituacionLaboral
            // 
            cboSituacionLaboral.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSituacionLaboral.FormattingEnabled = true;
            cboSituacionLaboral.Location = new Point(151, 62);
            cboSituacionLaboral.Name = "cboSituacionLaboral";
            cboSituacionLaboral.Size = new Size(174, 23);
            cboSituacionLaboral.TabIndex = 1;
            // 
            // cboEstadoCivil
            // 
            cboEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstadoCivil.FormattingEnabled = true;
            cboEstadoCivil.Location = new Point(151, 91);
            cboEstadoCivil.Name = "cboEstadoCivil";
            cboEstadoCivil.Size = new Size(174, 23);
            cboEstadoCivil.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(151, 33);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(612, 23);
            txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(24, 36);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre:";
            // 
            // lblSituacionLab
            // 
            lblSituacionLab.AutoSize = true;
            lblSituacionLab.Location = new Point(24, 65);
            lblSituacionLab.Name = "lblSituacionLab";
            lblSituacionLab.Size = new Size(98, 15);
            lblSituacionLab.TabIndex = 6;
            lblSituacionLab.Text = "Situación laboral:";
            // 
            // lblEstadoCivil
            // 
            lblEstadoCivil.AutoSize = true;
            lblEstadoCivil.Location = new Point(24, 94);
            lblEstadoCivil.Name = "lblEstadoCivil";
            lblEstadoCivil.Size = new Size(69, 15);
            lblEstadoCivil.TabIndex = 7;
            lblEstadoCivil.Text = "Estado civil:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(787, 36);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(96, 78);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(24, 415);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmConsultaAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 450);
            ControlBox = false;
            Controls.Add(btnCancelar);
            Controls.Add(btnBuscar);
            Controls.Add(lblEstadoCivil);
            Controls.Add(lblSituacionLab);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(cboEstadoCivil);
            Controls.Add(cboSituacionLaboral);
            Controls.Add(dgvAlumnos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(929, 489);
            MinimumSize = new Size(929, 489);
            Name = "FrmConsultaAlumnos";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Consultar Alumnos";
            Load += FrmConsultaAlumnos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAlumnos;
        private ComboBox cboSituacionLaboral;
        private ComboBox cboEstadoCivil;
        private TextBox txtNombre;
        private Button button1;
        private Label lblNombre;
        private Label lblSituacionLab;
        private Label lblEstadoCivil;
        private Button btnBuscar;
        private Button btnCancelar;
        private DataGridViewTextBoxColumn IdAlumno;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn SituacionLaboral;
        private DataGridViewTextBoxColumn EstadoCivil;
        private DataGridViewButtonColumn Acciones;
        private DataGridViewButtonColumn Acciones2;
    }
}