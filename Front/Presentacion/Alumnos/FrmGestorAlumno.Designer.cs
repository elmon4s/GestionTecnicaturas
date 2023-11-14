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
            numId.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            numId.InterceptArrowKeys = false;
            numId.Location = new Point(228, 37);
            numId.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            numId.Name = "numId";
            numId.Size = new Size(128, 23);
            numId.TabIndex = 0;
            // 
            // cboEstadoCivil
            // 
            cboEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstadoCivil.FormattingEnabled = true;
            cboEstadoCivil.Location = new Point(228, 124);
            cboEstadoCivil.Name = "cboEstadoCivil";
            cboEstadoCivil.Size = new Size(200, 23);
            cboEstadoCivil.TabIndex = 1;
            // 
            // cboSituacionLaboral
            // 
            cboSituacionLaboral.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSituacionLaboral.FormattingEnabled = true;
            cboSituacionLaboral.Location = new Point(228, 153);
            cboSituacionLaboral.Name = "cboSituacionLaboral";
            cboSituacionLaboral.Size = new Size(200, 23);
            cboSituacionLaboral.TabIndex = 2;
            // 
            // dgvMaterias
            // 
            dgvMaterias.AllowUserToAddRows = false;
            dgvMaterias.AllowUserToDeleteRows = false;
            dgvMaterias.AllowUserToResizeColumns = false;
            dgvMaterias.AllowUserToResizeRows = false;
            dgvMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterias.Columns.AddRange(new DataGridViewColumn[] { IdMateria, Materia, FechaInsc, Estado, FechaEstado, Comision, Docente, Accion });
            dgvMaterias.Location = new Point(23, 374);
            dgvMaterias.Name = "dgvMaterias";
            dgvMaterias.ReadOnly = true;
            dgvMaterias.RowTemplate.Height = 25;
            dgvMaterias.Size = new Size(1044, 247);
            dgvMaterias.TabIndex = 3;
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
            lblLegajo.Location = new Point(121, 39);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(45, 15);
            lblLegajo.TabIndex = 4;
            lblLegajo.Text = "Legajo:";
            // 
            // lblSituacionLaboral
            // 
            lblSituacionLaboral.AutoSize = true;
            lblSituacionLaboral.Location = new Point(121, 156);
            lblSituacionLaboral.Name = "lblSituacionLaboral";
            lblSituacionLaboral.Size = new Size(101, 15);
            lblSituacionLaboral.TabIndex = 5;
            lblSituacionLaboral.Text = "Situación Laboral:";
            // 
            // lblEstadoCivil
            // 
            lblEstadoCivil.AutoSize = true;
            lblEstadoCivil.Location = new Point(121, 127);
            lblEstadoCivil.Name = "lblEstadoCivil";
            lblEstadoCivil.Size = new Size(71, 15);
            lblEstadoCivil.TabIndex = 6;
            lblEstadoCivil.Text = "Estado Civil:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(228, 66);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(272, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(717, 153);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(256, 23);
            txtEmail.TabIndex = 9;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(717, 66);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(256, 23);
            txtDireccion.TabIndex = 10;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(228, 95);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(272, 23);
            txtApellido.TabIndex = 11;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(121, 69);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 12;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(121, 98);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 13;
            lblApellido.Text = "Apellido:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(651, 69);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(60, 15);
            lblDireccion.TabIndex = 14;
            lblDireccion.Text = "Dirección:";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(651, 98);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(42, 15);
            lblAltura.TabIndex = 15;
            lblAltura.Text = "Altura:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(651, 127);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(55, 15);
            lblTelefono.TabIndex = 16;
            lblTelefono.Text = "Telefono:";
            // 
            // numAltura
            // 
            numAltura.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            numAltura.InterceptArrowKeys = false;
            numAltura.Location = new Point(717, 96);
            numAltura.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            numAltura.Name = "numAltura";
            numAltura.Size = new Size(116, 23);
            numAltura.TabIndex = 17;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(651, 156);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 19;
            lblEmail.Text = "Email:";
            // 
            // cboBarrio
            // 
            cboBarrio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBarrio.FormattingEnabled = true;
            cboBarrio.Location = new Point(717, 36);
            cboBarrio.Name = "cboBarrio";
            cboBarrio.Size = new Size(256, 23);
            cboBarrio.TabIndex = 20;
            // 
            // lblBarrio
            // 
            lblBarrio.AutoSize = true;
            lblBarrio.Location = new Point(651, 39);
            lblBarrio.Name = "lblBarrio";
            lblBarrio.Size = new Size(41, 15);
            lblBarrio.TabIndex = 21;
            lblBarrio.Text = "Barrio:";
            // 
            // lblMateriaComision
            // 
            lblMateriaComision.AutoSize = true;
            lblMateriaComision.Location = new Point(20, 31);
            lblMateriaComision.Name = "lblMateriaComision";
            lblMateriaComision.Size = new Size(113, 15);
            lblMateriaComision.TabIndex = 24;
            lblMateriaComision.Text = "Materia y Comisión:";
            // 
            // btnMateriaComision
            // 
            btnMateriaComision.Location = new Point(461, 27);
            btnMateriaComision.Name = "btnMateriaComision";
            btnMateriaComision.Size = new Size(75, 23);
            btnMateriaComision.TabIndex = 25;
            btnMateriaComision.Text = "Establecer";
            btnMateriaComision.UseVisualStyleBackColor = true;
            btnMateriaComision.Click += btnMateriaComision_Click;
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(152, 85);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(176, 23);
            cboEstado.TabIndex = 26;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(21, 88);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 27;
            lblEstado.Text = "Estado:";
            // 
            // dtpFechaInsc
            // 
            dtpFechaInsc.Location = new Point(152, 56);
            dtpFechaInsc.Name = "dtpFechaInsc";
            dtpFechaInsc.Size = new Size(248, 23);
            dtpFechaInsc.TabIndex = 28;
            // 
            // dtpFechaEstado
            // 
            dtpFechaEstado.Location = new Point(152, 114);
            dtpFechaEstado.Name = "dtpFechaEstado";
            dtpFechaEstado.Size = new Size(248, 23);
            dtpFechaEstado.TabIndex = 29;
            // 
            // lblFechaInsc
            // 
            lblFechaInsc.AutoSize = true;
            lblFechaInsc.Location = new Point(21, 62);
            lblFechaInsc.Name = "lblFechaInsc";
            lblFechaInsc.Size = new Size(102, 15);
            lblFechaInsc.TabIndex = 30;
            lblFechaInsc.Text = "Fecha Inscripción:";
            // 
            // lblFechaEstado
            // 
            lblFechaEstado.AutoSize = true;
            lblFechaEstado.Location = new Point(21, 120);
            lblFechaEstado.Name = "lblFechaEstado";
            lblFechaEstado.Size = new Size(79, 15);
            lblFechaEstado.TabIndex = 31;
            lblFechaEstado.Text = "Fecha Estado:";
            // 
            // txtTel
            // 
            txtTel.Location = new Point(717, 124);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(256, 23);
            txtTel.TabIndex = 32;
            txtTel.TextChanged += txtTel_TextChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(992, 627);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 33;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(23, 633);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 34;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(459, 101);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 37);
            btnAgregar.TabIndex = 35;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // grpMateria
            // 
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
            grpMateria.Location = new Point(295, 211);
            grpMateria.Name = "grpMateria";
            grpMateria.Size = new Size(542, 157);
            grpMateria.TabIndex = 36;
            grpMateria.TabStop = false;
            grpMateria.Text = "Materia";
            // 
            // lblMateriaComSel
            // 
            lblMateriaComSel.AutoSize = true;
            lblMateriaComSel.Location = new Point(152, 31);
            lblMateriaComSel.Name = "lblMateriaComSel";
            lblMateriaComSel.Size = new Size(0, 15);
            lblMateriaComSel.TabIndex = 36;
            // 
            // FrmGestorAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 668);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1106, 707);
            MinimumSize = new Size(1106, 707);
            Name = "FrmGestorAlumno";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Alumno";
            Load += FrmGestorAlumno_Load;
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