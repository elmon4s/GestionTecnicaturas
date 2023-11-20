namespace Front.Presentacion.Docentes
{
    partial class FrmConsultaDocentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaDocentes));
            dgvDocentes = new DataGridView();
            cIdDocente = new DataGridViewTextBoxColumn();
            cNomDocente = new DataGridViewTextBoxColumn();
            cTitulo = new DataGridViewTextBoxColumn();
            cEmail = new DataGridViewTextBoxColumn();
            cTelefono = new DataGridViewTextBoxColumn();
            cGestionar = new DataGridViewButtonColumn();
            label1 = new Label();
            txtNom = new TextBox();
            cboBarrio = new ComboBox();
            cboTitulo = new ComboBox();
            btnConsultar = new Button();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDocentes).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDocentes
            // 
            dgvDocentes.AllowUserToAddRows = false;
            dgvDocentes.AllowUserToDeleteRows = false;
            dgvDocentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDocentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocentes.Columns.AddRange(new DataGridViewColumn[] { cIdDocente, cNomDocente, cTitulo, cEmail, cTelefono, cGestionar });
            dgvDocentes.Location = new Point(12, 118);
            dgvDocentes.Name = "dgvDocentes";
            dgvDocentes.ReadOnly = true;
            dgvDocentes.RowTemplate.Height = 25;
            dgvDocentes.Size = new Size(715, 198);
            dgvDocentes.TabIndex = 1;
            dgvDocentes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cIdDocente
            // 
            cIdDocente.HeaderText = "ID Docente";
            cIdDocente.Name = "cIdDocente";
            cIdDocente.ReadOnly = true;
            cIdDocente.Visible = false;
            // 
            // cNomDocente
            // 
            cNomDocente.HeaderText = "Docente";
            cNomDocente.Name = "cNomDocente";
            cNomDocente.ReadOnly = true;
            // 
            // cTitulo
            // 
            cTitulo.HeaderText = "Titulo";
            cTitulo.Name = "cTitulo";
            cTitulo.ReadOnly = true;
            // 
            // cEmail
            // 
            cEmail.FillWeight = 110F;
            cEmail.HeaderText = "Email";
            cEmail.Name = "cEmail";
            cEmail.ReadOnly = true;
            // 
            // cTelefono
            // 
            cTelefono.HeaderText = "Telefono";
            cTelefono.Name = "cTelefono";
            cTelefono.ReadOnly = true;
            // 
            // cGestionar
            // 
            cGestionar.FillWeight = 60F;
            cGestionar.HeaderText = "Acciones";
            cGestionar.Name = "cGestionar";
            cGestionar.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(50, 19);
            label1.TabIndex = 0;
            label1.Text = "Titulo :";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(394, 62);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(176, 25);
            txtNom.TabIndex = 5;
            // 
            // cboBarrio
            // 
            cboBarrio.FormattingEnabled = true;
            cboBarrio.Location = new Point(68, 62);
            cboBarrio.Name = "cboBarrio";
            cboBarrio.Size = new Size(248, 25);
            cboBarrio.TabIndex = 3;
            // 
            // cboTitulo
            // 
            cboTitulo.FormattingEnabled = true;
            cboTitulo.Location = new Point(68, 30);
            cboTitulo.Name = "cboTitulo";
            cboTitulo.Size = new Size(150, 25);
            cboTitulo.TabIndex = 1;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(595, 62);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(104, 26);
            btnConsultar.TabIndex = 6;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(322, 65);
            label2.Name = "label2";
            label2.Size = new Size(66, 19);
            label2.TabIndex = 4;
            label2.Text = "Nombre :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 65);
            label3.Name = "label3";
            label3.Size = new Size(52, 19);
            label3.TabIndex = 2;
            label3.Text = "Barrio :";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNom);
            groupBox1.Controls.Add(cboTitulo);
            groupBox1.Controls.Add(cboBarrio);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(715, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Criterios de Busqueda:";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(623, 322);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(104, 26);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmConsultaDocentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(738, 354);
            Controls.Add(btnSalir);
            Controls.Add(groupBox1);
            Controls.Add(dgvDocentes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmConsultaDocentes";
            Text = "Consultar Docentes";
            Load += FrmConsultaDocentes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDocentes).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDocentes;
        private Label label1;
        private TextBox txtNom;
        private ComboBox cboBarrio;
        private ComboBox cboTitulo;
        private Button btnConsultar;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Button btnSalir;
        private DataGridViewTextBoxColumn cIdDocente;
        private DataGridViewTextBoxColumn cNomDocente;
        private DataGridViewTextBoxColumn cTitulo;
        private DataGridViewTextBoxColumn cEmail;
        private DataGridViewTextBoxColumn cTelefono;
        private DataGridViewButtonColumn cGestionar;
    }
}