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
            this.dgvDocentes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.cboBarrio = new System.Windows.Forms.ComboBox();
            this.cboTitulo = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cIdDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNomDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cApeDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAltura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGestionar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDocentes
            // 
            this.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIdDocente,
            this.cNomDocente,
            this.cApeDocente,
            this.cTitulo,
            this.cDireccion,
            this.cAltura,
            this.cBario,
            this.cEmail,
            this.cTelefono,
            this.cGestionar});
            this.dgvDocentes.Location = new System.Drawing.Point(75, 153);
            this.dgvDocentes.Name = "dgvDocentes";
            this.dgvDocentes.RowTemplate.Height = 25;
            this.dgvDocentes.Size = new System.Drawing.Size(1045, 198);
            this.dgvDocentes.TabIndex = 0;
            this.dgvDocentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titulo :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(597, 91);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(112, 23);
            this.txtNom.TabIndex = 2;
            // 
            // cboBarrio
            // 
            this.cboBarrio.FormattingEnabled = true;
            this.cboBarrio.Location = new System.Drawing.Point(445, 91);
            this.cboBarrio.Name = "cboBarrio";
            this.cboBarrio.Size = new System.Drawing.Size(121, 23);
            this.cboBarrio.TabIndex = 3;
            // 
            // cboTitulo
            // 
            this.cboTitulo.FormattingEnabled = true;
            this.cboTitulo.Location = new System.Drawing.Point(293, 91);
            this.cboTitulo.Name = "cboTitulo";
            this.cboTitulo.Size = new System.Drawing.Size(121, 23);
            this.cboTitulo.TabIndex = 4;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(741, 74);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(104, 40);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(624, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Barrio :";
            // 
            // cIdDocente
            // 
            this.cIdDocente.HeaderText = "ID Docente";
            this.cIdDocente.Name = "cIdDocente";
            // 
            // cNomDocente
            // 
            this.cNomDocente.HeaderText = "Nombre";
            this.cNomDocente.Name = "cNomDocente";
            // 
            // cApeDocente
            // 
            this.cApeDocente.HeaderText = "Apellido";
            this.cApeDocente.Name = "cApeDocente";
            // 
            // cTitulo
            // 
            this.cTitulo.HeaderText = "Titulo";
            this.cTitulo.Name = "cTitulo";
            // 
            // cDireccion
            // 
            this.cDireccion.HeaderText = "Direccion";
            this.cDireccion.Name = "cDireccion";
            // 
            // cAltura
            // 
            this.cAltura.HeaderText = "Altura";
            this.cAltura.Name = "cAltura";
            // 
            // cBario
            // 
            this.cBario.HeaderText = "Barrio";
            this.cBario.Name = "cBario";
            // 
            // cEmail
            // 
            this.cEmail.HeaderText = "Email";
            this.cEmail.Name = "cEmail";
            // 
            // cTelefono
            // 
            this.cTelefono.HeaderText = "Telefono";
            this.cTelefono.Name = "cTelefono";
            // 
            // cGestionar
            // 
            this.cGestionar.HeaderText = "Gestionar";
            this.cGestionar.Name = "cGestionar";
            // 
            // FrmConsultaDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.cboTitulo);
            this.Controls.Add(this.cboBarrio);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDocentes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultaDocentes";
            this.Text = "Consultar Docentes";
            this.Load += new System.EventHandler(this.FrmConsultaDocentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DataGridViewTextBoxColumn cIdDocente;
        private DataGridViewTextBoxColumn cNomDocente;
        private DataGridViewTextBoxColumn cApeDocente;
        private DataGridViewTextBoxColumn cTitulo;
        private DataGridViewTextBoxColumn cDireccion;
        private DataGridViewTextBoxColumn cAltura;
        private DataGridViewTextBoxColumn cBario;
        private DataGridViewTextBoxColumn cEmail;
        private DataGridViewTextBoxColumn cTelefono;
        private DataGridViewButtonColumn cGestionar;
    }
}