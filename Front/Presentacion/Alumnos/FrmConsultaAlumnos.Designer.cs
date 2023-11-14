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
            grpCriteriosBusqueda = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            grpCriteriosBusqueda.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AllowUserToAddRows = false;
            dgvAlumnos.AllowUserToDeleteRows = false;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Columns.AddRange(new DataGridViewColumn[] { IdAlumno, Nombre, Apellido, SituacionLaboral, EstadoCivil, Acciones, Acciones2 });
            dgvAlumnos.Location = new Point(24, 188);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.ReadOnly = true;
            dgvAlumnos.RowTemplate.Height = 25;
            dgvAlumnos.Size = new Size(859, 297);
            dgvAlumnos.TabIndex = 0;
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
            cboSituacionLaboral.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboSituacionLaboral.FormattingEnabled = true;
            cboSituacionLaboral.Location = new Point(141, 78);
            cboSituacionLaboral.Name = "cboSituacionLaboral";
            cboSituacionLaboral.Size = new Size(174, 25);
            cboSituacionLaboral.TabIndex = 1;
            // 
            // cboEstadoCivil
            // 
            cboEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstadoCivil.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboEstadoCivil.FormattingEnabled = true;
            cboEstadoCivil.Location = new Point(141, 113);
            cboEstadoCivil.Name = "cboEstadoCivil";
            cboEstadoCivil.Size = new Size(174, 25);
            cboEstadoCivil.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(141, 43);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(551, 25);
            txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(73, 47);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(62, 19);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre:";
            // 
            // lblSituacionLab
            // 
            lblSituacionLab.AutoSize = true;
            lblSituacionLab.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSituacionLab.Location = new Point(23, 81);
            lblSituacionLab.Name = "lblSituacionLab";
            lblSituacionLab.Size = new Size(112, 19);
            lblSituacionLab.TabIndex = 6;
            lblSituacionLab.Text = "Situación laboral:";
            // 
            // lblEstadoCivil
            // 
            lblEstadoCivil.AutoSize = true;
            lblEstadoCivil.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstadoCivil.Location = new Point(56, 116);
            lblEstadoCivil.Name = "lblEstadoCivil";
            lblEstadoCivil.Size = new Size(79, 19);
            lblEstadoCivil.TabIndex = 7;
            lblEstadoCivil.Text = "Estado civil:";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.Location = new Point(740, 133);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(79, 31);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(24, 491);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(79, 31);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // grpCriteriosBusqueda
            // 
            grpCriteriosBusqueda.BackColor = Color.WhiteSmoke;
            grpCriteriosBusqueda.Controls.Add(lblNombre);
            grpCriteriosBusqueda.Controls.Add(cboSituacionLaboral);
            grpCriteriosBusqueda.Controls.Add(btnBuscar);
            grpCriteriosBusqueda.Controls.Add(cboEstadoCivil);
            grpCriteriosBusqueda.Controls.Add(lblEstadoCivil);
            grpCriteriosBusqueda.Controls.Add(txtNombre);
            grpCriteriosBusqueda.Controls.Add(lblSituacionLab);
            grpCriteriosBusqueda.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            grpCriteriosBusqueda.Location = new Point(43, 12);
            grpCriteriosBusqueda.Name = "grpCriteriosBusqueda";
            grpCriteriosBusqueda.Size = new Size(825, 170);
            grpCriteriosBusqueda.TabIndex = 10;
            grpCriteriosBusqueda.TabStop = false;
            grpCriteriosBusqueda.Text = "Criterios de Busqueda";
            // 
            // FrmConsultaAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(913, 540);
            ControlBox = false;
            Controls.Add(grpCriteriosBusqueda);
            Controls.Add(btnCancelar);
            Controls.Add(dgvAlumnos);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(929, 579);
            MinimumSize = new Size(929, 579);
            Name = "FrmConsultaAlumnos";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Consultar Alumnos";
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            grpCriteriosBusqueda.ResumeLayout(false);
            grpCriteriosBusqueda.PerformLayout();
            ResumeLayout(false);
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
        private GroupBox grpCriteriosBusqueda;
    }
}