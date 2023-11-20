namespace Front.Presentacion.Alumnos
{
    partial class FrmGestorAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestorAlumno));
            numId = new NumericUpDown();
            cboEstadoCivil = new ComboBox();
            cboSituacionLaboral = new ComboBox();
            dgvMaterias = new DataGridView();
            IdMateria = new DataGridViewTextBoxColumn();
            Materia = new DataGridViewTextBoxColumn();
            FechaInsc = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            FechaEstado = new DataGridViewTextBoxColumn();
            Comision = new DataGridViewTextBoxColumn();
            Docente = new DataGridViewTextBoxColumn();
            Accion = new DataGridViewButtonColumn();
            lblLegajo = new Label();
            lblSituacionLaboral = new Label();
            lblEstadoCivil = new Label();
            txtNombre = new TextBox();
            txtEmail = new TextBox();
            txtDireccion = new TextBox();
            txtApellido = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDireccion = new Label();
            lblAltura = new Label();
            lblTelefono = new Label();
            numAltura = new NumericUpDown();
            lblEmail = new Label();
            cboBarrio = new ComboBox();
            lblBarrio = new Label();
            lblMateriaComision = new Label();
            btnMateriaComision = new Button();
            cboEstado = new ComboBox();
            lblEstado = new Label();
            dtpFechaInsc = new DateTimePicker();
            dtpFechaEstado = new DateTimePicker();
            lblFechaInsc = new Label();
            lblFechaEstado = new Label();
            txtTel = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            btnAgregar = new Button();
            grpMateria = new GroupBox();
            lblMateriaComSel = new Label();
            ((System.ComponentModel.ISupportInitialize)numId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAltura).BeginInit();
            grpMateria.SuspendLayout();
            SuspendLayout();
            // 
            // numId
            // 
            numId.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            numId.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            numId.InterceptArrowKeys = false;
            numId.Location = new Point(233, 27);
            numId.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            numId.Name = "numId";
            numId.Size = new Size(128, 25);
            numId.TabIndex = 1;
            // 
            // cboEstadoCivil
            // 
            cboEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstadoCivil.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboEstadoCivil.FormattingEnabled = true;
            cboEstadoCivil.Location = new Point(233, 135);
            cboEstadoCivil.Name = "cboEstadoCivil";
            cboEstadoCivil.Size = new Size(200, 25);
            cboEstadoCivil.TabIndex = 7;
            // 
            // cboSituacionLaboral
            // 
            cboSituacionLaboral.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSituacionLaboral.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboSituacionLaboral.FormattingEnabled = true;
            cboSituacionLaboral.Location = new Point(233, 171);
            cboSituacionLaboral.Name = "cboSituacionLaboral";
            cboSituacionLaboral.Size = new Size(200, 25);
            cboSituacionLaboral.TabIndex = 9;
            // 
            // dgvMaterias
            // 
            dgvMaterias.AllowUserToAddRows = false;
            dgvMaterias.AllowUserToDeleteRows = false;
            dgvMaterias.AllowUserToResizeColumns = false;
            dgvMaterias.AllowUserToResizeRows = false;
            dgvMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterias.Columns.AddRange(new DataGridViewColumn[] { IdMateria, Materia, FechaInsc, Estado, FechaEstado, Comision, Docente, Accion });
            dgvMaterias.Location = new Point(36, 395);
            dgvMaterias.Name = "dgvMaterias";
            dgvMaterias.ReadOnly = true;
            dgvMaterias.RowTemplate.Height = 25;
            dgvMaterias.Size = new Size(1018, 233);
            dgvMaterias.TabIndex = 22;
            dgvMaterias.CellContentClick += dgvMaterias_CellContentClick;
            // 
            // IdMateria
            // 
            IdMateria.HeaderText = "IdMateria";
            IdMateria.Name = "IdMateria";
            IdMateria.ReadOnly = true;
            IdMateria.Visible = false;
            // 
            // Materia
            // 
            Materia.HeaderText = "Materia";
            Materia.Name = "Materia";
            Materia.ReadOnly = true;
            Materia.Width = 200;
            // 
            // FechaInsc
            // 
            FechaInsc.HeaderText = "Fecha Inscripción";
            FechaInsc.Name = "FechaInsc";
            FechaInsc.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // FechaEstado
            // 
            FechaEstado.HeaderText = "Fecha Estado";
            FechaEstado.Name = "FechaEstado";
            FechaEstado.ReadOnly = true;
            // 
            // Comision
            // 
            Comision.HeaderText = "Comisión";
            Comision.Name = "Comision";
            Comision.ReadOnly = true;
            // 
            // Docente
            // 
            Docente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Docente.HeaderText = "Docente";
            Docente.Name = "Docente";
            Docente.ReadOnly = true;
            // 
            // Accion
            // 
            Accion.HeaderText = "Acción";
            Accion.Name = "Accion";
            Accion.ReadOnly = true;
            Accion.Resizable = DataGridViewTriState.True;
            Accion.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblLegajo.Location = new Point(175, 29);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(52, 19);
            lblLegajo.TabIndex = 0;
            lblLegajo.Text = "Legajo:";
            // 
            // lblSituacionLaboral
            // 
            lblSituacionLaboral.AutoSize = true;
            lblSituacionLaboral.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSituacionLaboral.Location = new Point(111, 169);
            lblSituacionLaboral.Name = "lblSituacionLaboral";
            lblSituacionLaboral.Size = new Size(116, 19);
            lblSituacionLaboral.TabIndex = 8;
            lblSituacionLaboral.Text = "Situación Laboral:";
            // 
            // lblEstadoCivil
            // 
            lblEstadoCivil.AutoSize = true;
            lblEstadoCivil.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstadoCivil.Location = new Point(145, 133);
            lblEstadoCivil.Name = "lblEstadoCivil";
            lblEstadoCivil.Size = new Size(82, 19);
            lblEstadoCivil.TabIndex = 6;
            lblEstadoCivil.Text = "Estado Civil:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(233, 63);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(272, 25);
            txtNombre.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(716, 170);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(256, 25);
            txtEmail.TabIndex = 19;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccion.Location = new Point(716, 64);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(256, 25);
            txtDireccion.TabIndex = 13;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(233, 99);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(272, 25);
            txtApellido.TabIndex = 5;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(166, 64);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(62, 19);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(166, 99);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(61, 19);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDireccion.Location = new Point(642, 61);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(68, 19);
            lblDireccion.TabIndex = 12;
            lblDireccion.Text = "Dirección:";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblAltura.Location = new Point(661, 97);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(49, 19);
            lblAltura.TabIndex = 14;
            lblAltura.Text = "Altura:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefono.Location = new Point(646, 135);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(63, 19);
            lblTelefono.TabIndex = 16;
            lblTelefono.Text = "Telefono:";
            // 
            // numAltura
            // 
            numAltura.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            numAltura.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            numAltura.InterceptArrowKeys = false;
            numAltura.Location = new Point(716, 97);
            numAltura.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            numAltura.Name = "numAltura";
            numAltura.Size = new Size(116, 25);
            numAltura.TabIndex = 15;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(666, 174);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 19);
            lblEmail.TabIndex = 18;
            lblEmail.Text = "Email:";
            // 
            // cboBarrio
            // 
            cboBarrio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBarrio.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboBarrio.FormattingEnabled = true;
            cboBarrio.Location = new Point(716, 29);
            cboBarrio.Name = "cboBarrio";
            cboBarrio.Size = new Size(256, 25);
            cboBarrio.TabIndex = 11;
            // 
            // lblBarrio
            // 
            lblBarrio.AutoSize = true;
            lblBarrio.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblBarrio.Location = new Point(662, 29);
            lblBarrio.Name = "lblBarrio";
            lblBarrio.Size = new Size(48, 19);
            lblBarrio.TabIndex = 10;
            lblBarrio.Text = "Barrio:";
            // 
            // lblMateriaComision
            // 
            lblMateriaComision.AutoSize = true;
            lblMateriaComision.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblMateriaComision.Location = new Point(39, 25);
            lblMateriaComision.Name = "lblMateriaComision";
            lblMateriaComision.Size = new Size(131, 19);
            lblMateriaComision.TabIndex = 0;
            lblMateriaComision.Text = "Materia y Comisión:";
            // 
            // btnMateriaComision
            // 
            btnMateriaComision.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnMateriaComision.Location = new Point(478, 68);
            btnMateriaComision.Name = "btnMateriaComision";
            btnMateriaComision.Size = new Size(79, 35);
            btnMateriaComision.TabIndex = 8;
            btnMateriaComision.Text = "Establecer";
            btnMateriaComision.UseVisualStyleBackColor = true;
            btnMateriaComision.Click += btnMateriaComision_Click;
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(138, 94);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(176, 25);
            cboEstado.TabIndex = 5;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstado.Location = new Point(79, 94);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(53, 19);
            lblEstado.TabIndex = 4;
            lblEstado.Text = "Estado:";
            // 
            // dtpFechaInsc
            // 
            dtpFechaInsc.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaInsc.Location = new Point(138, 56);
            dtpFechaInsc.Name = "dtpFechaInsc";
            dtpFechaInsc.Size = new Size(255, 25);
            dtpFechaInsc.TabIndex = 3;
            // 
            // dtpFechaEstado
            // 
            dtpFechaEstado.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaEstado.Location = new Point(138, 132);
            dtpFechaEstado.Name = "dtpFechaEstado";
            dtpFechaEstado.Size = new Size(255, 25);
            dtpFechaEstado.TabIndex = 7;
            // 
            // lblFechaInsc
            // 
            lblFechaInsc.AutoSize = true;
            lblFechaInsc.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaInsc.Location = new Point(16, 56);
            lblFechaInsc.Name = "lblFechaInsc";
            lblFechaInsc.Size = new Size(116, 19);
            lblFechaInsc.TabIndex = 2;
            lblFechaInsc.Text = "Fecha Inscripción:";
            // 
            // lblFechaEstado
            // 
            lblFechaEstado.AutoSize = true;
            lblFechaEstado.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaEstado.Location = new Point(40, 132);
            lblFechaEstado.Name = "lblFechaEstado";
            lblFechaEstado.Size = new Size(92, 19);
            lblFechaEstado.TabIndex = 0;
            lblFechaEstado.Text = "Fecha Estado:";
            // 
            // txtTel
            // 
            txtTel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTel.Location = new Point(716, 133);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(256, 25);
            txtTel.TabIndex = 17;
            txtTel.TextChanged += txtTel_TextChanged_1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(975, 634);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(79, 35);
            btnAceptar.TabIndex = 24;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(36, 634);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(79, 35);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(478, 110);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(79, 35);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // grpMateria
            // 
            grpMateria.BackColor = Color.WhiteSmoke;
            grpMateria.Controls.Add(lblMateriaComSel);
            grpMateria.Controls.Add(btnAgregar);
            grpMateria.Controls.Add(lblFechaEstado);
            grpMateria.Controls.Add(lblFechaInsc);
            grpMateria.Controls.Add(dtpFechaEstado);
            grpMateria.Controls.Add(dtpFechaInsc);
            grpMateria.Controls.Add(lblEstado);
            grpMateria.Controls.Add(cboEstado);
            grpMateria.Controls.Add(btnMateriaComision);
            grpMateria.Controls.Add(lblMateriaComision);
            grpMateria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grpMateria.Location = new Point(272, 212);
            grpMateria.Name = "grpMateria";
            grpMateria.Size = new Size(583, 177);
            grpMateria.TabIndex = 21;
            grpMateria.TabStop = false;
            grpMateria.Text = "Materia";
            // 
            // lblMateriaComSel
            // 
            lblMateriaComSel.AutoSize = true;
            lblMateriaComSel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblMateriaComSel.Location = new Point(171, 25);
            lblMateriaComSel.Name = "lblMateriaComSel";
            lblMateriaComSel.Size = new Size(0, 19);
            lblMateriaComSel.TabIndex = 1;
            // 
            // FrmGestorAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1090, 679);
            ControlBox = false;
            Controls.Add(grpMateria);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtTel);
            Controls.Add(lblBarrio);
            Controls.Add(cboBarrio);
            Controls.Add(lblEmail);
            Controls.Add(numAltura);
            Controls.Add(lblTelefono);
            Controls.Add(lblAltura);
            Controls.Add(lblDireccion);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtDireccion);
            Controls.Add(txtEmail);
            Controls.Add(txtNombre);
            Controls.Add(lblEstadoCivil);
            Controls.Add(lblSituacionLaboral);
            Controls.Add(lblLegajo);
            Controls.Add(dgvMaterias);
            Controls.Add(cboSituacionLaboral);
            Controls.Add(cboEstadoCivil);
            Controls.Add(numId);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1106, 718);
            MinimumSize = new Size(1106, 718);
            Name = "FrmGestorAlumno";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Alumno";
            Load += FrmGestorAlumno_Load_1;
            ((System.ComponentModel.ISupportInitialize)numId).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAltura).EndInit();
            grpMateria.ResumeLayout(false);
            grpMateria.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numId;
        private ComboBox cboEstadoCivil;
        private ComboBox cboSituacionLaboral;
        private DataGridView dgvMaterias;
        private Label lblLegajo;
        private Label lblSituacionLaboral;
        private Label lblEstadoCivil;
        private TextBox txtNombre;
        private TextBox txtEmail;
        private TextBox txtDireccion;
        private TextBox txtApellido;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDireccion;
        private Label lblAltura;
        private Label lblTelefono;
        private NumericUpDown numAltura;
        private Label lblEmail;
        private ComboBox cboBarrio;
        private Label lblBarrio;
        private Label lblEstado;
        private Label lblFechaInsc;
        private Button btnMateriaComision;
        private ComboBox cboEstado;
        private Label label13;
        private DateTimePicker dtpFechaInsc;
        private DateTimePicker dtpFechaEstado;
        private Label lblMateriaComision;
        private Label lblFechaEstado;
        private TextBox txtTel;
        private Button btnAceptar;
        private Button btnCancelar;
        private Button btnAgregar;
        private GroupBox grpMateria;
        private Label lblMateriaComSel;
        private DataGridViewTextBoxColumn IdMateria;
        private DataGridViewTextBoxColumn Materia;
        private DataGridViewTextBoxColumn FechaInsc;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn FechaEstado;
        private DataGridViewTextBoxColumn Comision;
        private DataGridViewTextBoxColumn Docente;
        private DataGridViewButtonColumn Accion;
    }
}