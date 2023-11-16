namespace Front
{
    partial class FrmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistro));
            label1 = new Label();
            lblUsuario = new Label();
            lblContraseña = new Label();
            label4 = new Label();
            chkMostrarContraseña = new CheckBox();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            txtRepetirContraseña = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(250, 9);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 0;
            label1.Text = "Registro";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(133, 59);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 19);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario:";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblContraseña.Location = new Point(110, 102);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(82, 19);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(63, 148);
            label4.Name = "label4";
            label4.Size = new Size(129, 19);
            label4.TabIndex = 3;
            label4.Text = "Repetir Contraseña:";
            // 
            // chkMostrarContraseña
            // 
            chkMostrarContraseña.AutoSize = true;
            chkMostrarContraseña.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            chkMostrarContraseña.Location = new Point(198, 186);
            chkMostrarContraseña.Name = "chkMostrarContraseña";
            chkMostrarContraseña.Size = new Size(151, 23);
            chkMostrarContraseña.TabIndex = 4;
            chkMostrarContraseña.Text = "Mostrar Contraseña";
            chkMostrarContraseña.UseVisualStyleBackColor = true;
            chkMostrarContraseña.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmar.Location = new Point(126, 225);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(119, 28);
            btnConfirmar.TabIndex = 5;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(317, 225);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(119, 28);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(198, 57);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(210, 23);
            txtUsuario.TabIndex = 7;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(198, 100);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(210, 23);
            txtContraseña.TabIndex = 8;
            // 
            // txtRepetirContraseña
            // 
            txtRepetirContraseña.Location = new Point(198, 146);
            txtRepetirContraseña.Name = "txtRepetirContraseña";
            txtRepetirContraseña.Size = new Size(210, 23);
            txtRepetirContraseña.TabIndex = 9;
            // 
            // FrmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 285);
            Controls.Add(txtRepetirContraseña);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(chkMostrarContraseña);
            Controls.Add(label4);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmRegistro";
            Text = "Registro";
            Load += FrmRegistro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblUsuario;
        private Label lblContraseña;
        private Label label4;
        private CheckBox chkMostrarContraseña;
        private Button btnConfirmar;
        private Button btnCancelar;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private TextBox txtRepetirContraseña;
    }
}