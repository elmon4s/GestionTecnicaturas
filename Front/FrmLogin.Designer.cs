namespace Front
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            LblIniciarSesion = new Label();
            lblUsuario = new Label();
            lblContraseña = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            chkMostrarContraseña = new CheckBox();
            btnIngresar = new Button();
            btnCancelar = new Button();
            btnRegistro = new Button();
            SuspendLayout();
            // 
            // LblIniciarSesion
            // 
            LblIniciarSesion.AutoSize = true;
            LblIniciarSesion.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LblIniciarSesion.Location = new Point(246, 9);
            LblIniciarSesion.Name = "LblIniciarSesion";
            LblIniciarSesion.Size = new Size(115, 25);
            LblIniciarSesion.TabIndex = 0;
            LblIniciarSesion.Text = "Iniciar Sesion";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(150, 57);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 19);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario:";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblContraseña.Location = new Point(125, 95);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(82, 19);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(210, 55);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(223, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(210, 94);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(223, 23);
            txtContraseña.TabIndex = 4;
            // 
            // chkMostrarContraseña
            // 
            chkMostrarContraseña.AutoSize = true;
            chkMostrarContraseña.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            chkMostrarContraseña.Location = new Point(210, 139);
            chkMostrarContraseña.Name = "chkMostrarContraseña";
            chkMostrarContraseña.Size = new Size(151, 23);
            chkMostrarContraseña.TabIndex = 5;
            chkMostrarContraseña.Text = "Mostrar Contraseña";
            chkMostrarContraseña.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.Location = new Point(150, 180);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(105, 28);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(328, 180);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 28);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRegistro
            // 
            btnRegistro.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistro.Location = new Point(461, 236);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(105, 28);
            btnRegistro.TabIndex = 8;
            btnRegistro.Text = "Registro";
            btnRegistro.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 276);
            Controls.Add(btnRegistro);
            Controls.Add(btnCancelar);
            Controls.Add(btnIngresar);
            Controls.Add(chkMostrarContraseña);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(LblIniciarSesion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblIniciarSesion;
        private Label lblUsuario;
        private Label lblContraseña;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private CheckBox chkMostrarContraseña;
        private Button btnIngresar;
        private Button btnCancelar;
        private Button btnRegistro;
    }
}