namespace Front
{
    partial class FrmGestorDocente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestorDocente));
            txtAlt = new TextBox();
            cboTitulo = new ComboBox();
            cboBarrio = new ComboBox();
            txtDirec = new TextBox();
            txtMail = new TextBox();
            txtApe = new TextBox();
            txtNom = new TextBox();
            txtId = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            btnLimpiar = new Button();
            btnCancelar = new Button();
            btnAceptar = new Button();
            txtTel = new TextBox();
            lblABM = new Label();
            btnEliminar = new Button();
            grbDatosPersonales = new GroupBox();
            grbComunicaciones = new GroupBox();
            grbUbicacion = new GroupBox();
            pnlDatosDocente = new Panel();
            grbDatosPersonales.SuspendLayout();
            grbComunicaciones.SuspendLayout();
            grbUbicacion.SuspendLayout();
            pnlDatosDocente.SuspendLayout();
            SuspendLayout();
            // 
            // txtAlt
            // 
            txtAlt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlt.Location = new Point(91, 78);
            txtAlt.Name = "txtAlt";
            txtAlt.Size = new Size(152, 25);
            txtAlt.TabIndex = 1;
            // 
            // cboTitulo
            // 
            cboTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboTitulo.FormattingEnabled = true;
            cboTitulo.Location = new Point(85, 160);
            cboTitulo.Name = "cboTitulo";
            cboTitulo.Size = new Size(152, 25);
            cboTitulo.TabIndex = 2;
            // 
            // cboBarrio
            // 
            cboBarrio.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboBarrio.FormattingEnabled = true;
            cboBarrio.Location = new Point(91, 116);
            cboBarrio.Name = "cboBarrio";
            cboBarrio.Size = new Size(152, 25);
            cboBarrio.TabIndex = 3;
            // 
            // txtDirec
            // 
            txtDirec.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDirec.Location = new Point(91, 40);
            txtDirec.Name = "txtDirec";
            txtDirec.Size = new Size(152, 25);
            txtDirec.TabIndex = 6;
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMail.Location = new Point(89, 75);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(152, 25);
            txtMail.TabIndex = 8;
            // 
            // txtApe
            // 
            txtApe.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtApe.Location = new Point(85, 117);
            txtApe.Name = "txtApe";
            txtApe.Size = new Size(152, 25);
            txtApe.TabIndex = 9;
            // 
            // txtNom
            // 
            txtNom.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNom.Location = new Point(85, 76);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(152, 25);
            txtNom.TabIndex = 10;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(85, 37);
            txtId.Name = "txtId";
            txtId.Size = new Size(152, 25);
            txtId.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(24, 40);
            label4.Name = "label4";
            label4.Size = new Size(59, 19);
            label4.TabIndex = 12;
            label4.Text = "Nro Tel :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(28, 78);
            label5.Name = "label5";
            label5.Size = new Size(55, 19);
            label5.TabIndex = 13;
            label5.Text = "E-Mail :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(13, 43);
            label6.Name = "label6";
            label6.Size = new Size(72, 19);
            label6.TabIndex = 14;
            label6.Text = "Direccion :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(32, 79);
            label7.Name = "label7";
            label7.Size = new Size(53, 19);
            label7.TabIndex = 15;
            label7.Text = "Altura :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(33, 119);
            label8.Name = "label8";
            label8.Size = new Size(52, 19);
            label8.TabIndex = 16;
            label8.Text = "Barrio :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(49, 40);
            label9.Name = "label9";
            label9.Size = new Size(30, 19);
            label9.TabIndex = 17;
            label9.Text = "ID :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(13, 76);
            label10.Name = "label10";
            label10.Size = new Size(66, 19);
            label10.TabIndex = 18;
            label10.Text = "Nombre :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(14, 120);
            label11.Name = "label11";
            label11.Size = new Size(65, 19);
            label11.TabIndex = 19;
            label11.Text = "Apellido :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(29, 163);
            label12.Name = "label12";
            label12.Size = new Size(50, 19);
            label12.TabIndex = 20;
            label12.Text = "Título :";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(608, 294);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(79, 29);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(36, 294);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(79, 29);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(693, 294);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(79, 29);
            btnAceptar.TabIndex = 24;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click_1;
            // 
            // txtTel
            // 
            txtTel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTel.Location = new Point(89, 37);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(152, 25);
            txtTel.TabIndex = 25;
            // 
            // lblABM
            // 
            lblABM.AutoSize = true;
            lblABM.BackColor = Color.AliceBlue;
            lblABM.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblABM.Location = new Point(328, 9);
            lblABM.Name = "lblABM";
            lblABM.Size = new Size(164, 28);
            lblABM.TabIndex = 26;
            lblABM.Text = "Creando Docente";
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(778, 294);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(79, 29);
            btnEliminar.TabIndex = 27;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // grbDatosPersonales
            // 
            grbDatosPersonales.BackColor = SystemColors.ActiveCaption;
            grbDatosPersonales.Controls.Add(label9);
            grbDatosPersonales.Controls.Add(cboTitulo);
            grbDatosPersonales.Controls.Add(txtId);
            grbDatosPersonales.Controls.Add(label12);
            grbDatosPersonales.Controls.Add(label11);
            grbDatosPersonales.Controls.Add(txtApe);
            grbDatosPersonales.Controls.Add(label10);
            grbDatosPersonales.Controls.Add(txtNom);
            grbDatosPersonales.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grbDatosPersonales.Location = new Point(37, 13);
            grbDatosPersonales.Name = "grbDatosPersonales";
            grbDatosPersonales.Size = new Size(264, 204);
            grbDatosPersonales.TabIndex = 28;
            grbDatosPersonales.TabStop = false;
            grbDatosPersonales.Text = "Datos Personales";
            // 
            // grbComunicaciones
            // 
            grbComunicaciones.BackColor = SystemColors.ActiveCaption;
            grbComunicaciones.Controls.Add(txtMail);
            grbComunicaciones.Controls.Add(txtTel);
            grbComunicaciones.Controls.Add(label4);
            grbComunicaciones.Controls.Add(label5);
            grbComunicaciones.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grbComunicaciones.Location = new Point(315, 13);
            grbComunicaciones.Name = "grbComunicaciones";
            grbComunicaciones.Size = new Size(264, 204);
            grbComunicaciones.TabIndex = 29;
            grbComunicaciones.TabStop = false;
            grbComunicaciones.Text = "Comunicación";
            // 
            // grbUbicacion
            // 
            grbUbicacion.BackColor = SystemColors.ActiveCaption;
            grbUbicacion.Controls.Add(txtDirec);
            grbUbicacion.Controls.Add(txtAlt);
            grbUbicacion.Controls.Add(cboBarrio);
            grbUbicacion.Controls.Add(label6);
            grbUbicacion.Controls.Add(label7);
            grbUbicacion.Controls.Add(label8);
            grbUbicacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grbUbicacion.Location = new Point(594, 13);
            grbUbicacion.Name = "grbUbicacion";
            grbUbicacion.Size = new Size(264, 204);
            grbUbicacion.TabIndex = 30;
            grbUbicacion.TabStop = false;
            grbUbicacion.Text = "Ubicación";
            // 
            // pnlDatosDocente
            // 
            pnlDatosDocente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlDatosDocente.BackColor = SystemColors.ActiveCaption;
            pnlDatosDocente.Controls.Add(grbDatosPersonales);
            pnlDatosDocente.Controls.Add(grbUbicacion);
            pnlDatosDocente.Controls.Add(grbComunicaciones);
            pnlDatosDocente.Location = new Point(-1, 49);
            pnlDatosDocente.Name = "pnlDatosDocente";
            pnlDatosDocente.Size = new Size(892, 239);
            pnlDatosDocente.TabIndex = 31;
            // 
            // FrmGestorDocente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(890, 333);
            Controls.Add(pnlDatosDocente);
            Controls.Add(btnEliminar);
            Controls.Add(lblABM);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(btnLimpiar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(906, 372);
            MinimumSize = new Size(906, 372);
            Name = "FrmGestorDocente";
            Text = "Docente";
            Load += FrmNuevoDocente_Load_1;
            grbDatosPersonales.ResumeLayout(false);
            grbDatosPersonales.PerformLayout();
            grbComunicaciones.ResumeLayout(false);
            grbComunicaciones.PerformLayout();
            grbUbicacion.ResumeLayout(false);
            grbUbicacion.PerformLayout();
            pnlDatosDocente.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtAlt;
        private ComboBox cboTitulo;
        private ComboBox cboBarrio;
        private TextBox txtDirec;
        private TextBox txtMail;
        private TextBox txtApe;
        private TextBox txtNom;
        private TextBox txtId;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button btnLimpiar;
        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox txtTel;
        private Label lblABM;
        private Button btnEliminar;
        private GroupBox grbDatosPersonales;
        private GroupBox grbComunicaciones;
        private GroupBox grbUbicacion;
        private Panel pnlDatosDocente;
    }
}