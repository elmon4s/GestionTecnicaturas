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
            dataGridView1 = new DataGridView();
            lblLegajo = new Label();
            lblSituacionLaboral = new Label();
            lblEstadoCivil = new Label();
            txtNombre = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            txtApellido = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDireccion = new Label();
            lblAltura = new Label();
            lblTelefono = new Label();
            numAltura = new NumericUpDown();
            numTelefono = new NumericUpDown();
            lblEmail = new Label();
            comboBox3 = new ComboBox();
            lblBarrio = new Label();
            label11 = new Label();
            label12 = new Label();
            button1 = new Button();
            comboBox4 = new ComboBox();
            label13 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label14 = new Label();
            label15 = new Label();
            ((System.ComponentModel.ISupportInitialize)numId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAltura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTelefono).BeginInit();
            SuspendLayout();
            // 
            // numId
            // 
            numId.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            numId.InterceptArrowKeys = false;
            numId.Location = new Point(141, 45);
            numId.Name = "numId";
            numId.Size = new Size(120, 23);
            numId.TabIndex = 0;
            // 
            // cboEstadoCivil
            // 
            cboEstadoCivil.FormattingEnabled = true;
            cboEstadoCivil.Location = new Point(141, 132);
            cboEstadoCivil.Name = "cboEstadoCivil";
            cboEstadoCivil.Size = new Size(200, 23);
            cboEstadoCivil.TabIndex = 1;
            // 
            // cboSituacionLaboral
            // 
            cboSituacionLaboral.FormattingEnabled = true;
            cboSituacionLaboral.Location = new Point(141, 161);
            cboSituacionLaboral.Name = "cboSituacionLaboral";
            cboSituacionLaboral.Size = new Size(200, 23);
            cboSituacionLaboral.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(59, 433);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 3;
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Location = new Point(34, 47);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(45, 15);
            lblLegajo.TabIndex = 4;
            lblLegajo.Text = "Legajo:";
            // 
            // lblSituacionLaboral
            // 
            lblSituacionLaboral.AutoSize = true;
            lblSituacionLaboral.Location = new Point(34, 164);
            lblSituacionLaboral.Name = "lblSituacionLaboral";
            lblSituacionLaboral.Size = new Size(101, 15);
            lblSituacionLaboral.TabIndex = 5;
            lblSituacionLaboral.Text = "Situación Laboral:";
            // 
            // lblEstadoCivil
            // 
            lblEstadoCivil.AutoSize = true;
            lblEstadoCivil.Location = new Point(34, 135);
            lblEstadoCivil.Name = "lblEstadoCivil";
            lblEstadoCivil.Size = new Size(71, 15);
            lblEstadoCivil.TabIndex = 6;
            lblEstadoCivil.Text = "Estado Civil:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(141, 74);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(272, 23);
            txtNombre.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(518, 161);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(256, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(518, 74);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(256, 23);
            textBox4.TabIndex = 10;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(141, 103);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(272, 23);
            txtApellido.TabIndex = 11;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(34, 77);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 12;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(34, 106);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 13;
            lblApellido.Text = "Apellido:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(452, 77);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(60, 15);
            lblDireccion.TabIndex = 14;
            lblDireccion.Text = "Dirección:";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(452, 106);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(42, 15);
            lblAltura.TabIndex = 15;
            lblAltura.Text = "Altura:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(452, 135);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(55, 15);
            lblTelefono.TabIndex = 16;
            lblTelefono.Text = "Telefono:";
            // 
            // numAltura
            // 
            numAltura.Location = new Point(518, 104);
            numAltura.Name = "numAltura";
            numAltura.Size = new Size(80, 23);
            numAltura.TabIndex = 17;
            // 
            // numTelefono
            // 
            numTelefono.Location = new Point(518, 133);
            numTelefono.Name = "numTelefono";
            numTelefono.Size = new Size(256, 23);
            numTelefono.TabIndex = 18;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(452, 164);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 19;
            lblEmail.Text = "Email:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(518, 44);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(256, 23);
            comboBox3.TabIndex = 20;
            // 
            // lblBarrio
            // 
            lblBarrio.AutoSize = true;
            lblBarrio.Location = new Point(452, 47);
            lblBarrio.Name = "lblBarrio";
            lblBarrio.Size = new Size(41, 15);
            lblBarrio.TabIndex = 21;
            lblBarrio.Text = "Barrio:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 281);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 22;
            label11.Text = "Materias";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(22, 310);
            label12.Name = "label12";
            label12.Size = new Size(140, 15);
            label12.TabIndex = 24;
            label12.Text = "Detalle Materia Comision";
            // 
            // button1
            // 
            button1.Location = new Point(168, 306);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 25;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(154, 335);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(23, 338);
            label13.Name = "label13";
            label13.Size = new Size(42, 15);
            label13.TabIndex = 27;
            label13.Text = "Estado";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(154, 364);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 28;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(154, 393);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 29;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(23, 370);
            label14.Name = "label14";
            label14.Size = new Size(62, 15);
            label14.TabIndex = 30;
            label14.Text = "Fecha Insc";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(23, 399);
            label15.Name = "label15";
            label15.Size = new Size(76, 15);
            label15.TabIndex = 31;
            label15.Text = "Fecha Estado";
            // 
            // FrmGestorAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 605);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label13);
            Controls.Add(comboBox4);
            Controls.Add(button1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(lblBarrio);
            Controls.Add(comboBox3);
            Controls.Add(lblEmail);
            Controls.Add(numTelefono);
            Controls.Add(numAltura);
            Controls.Add(lblTelefono);
            Controls.Add(lblAltura);
            Controls.Add(lblDireccion);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtApellido);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(txtNombre);
            Controls.Add(lblEstadoCivil);
            Controls.Add(lblSituacionLaboral);
            Controls.Add(lblLegajo);
            Controls.Add(dataGridView1);
            Controls.Add(cboSituacionLaboral);
            Controls.Add(cboEstadoCivil);
            Controls.Add(numId);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmGestorAlumno";
            Text = "Alumno";
            ((System.ComponentModel.ISupportInitialize)numId).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAltura).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTelefono).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numId;
        private ComboBox cboEstadoCivil;
        private ComboBox cboSituacionLaboral;
        private DataGridView dataGridView1;
        private Label lblLegajo;
        private Label lblSituacionLaboral;
        private Label lblEstadoCivil;
        private TextBox txtNombre;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox txtApellido;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDireccion;
        private Label lblAltura;
        private Label lblTelefono;
        private NumericUpDown numAltura;
        private NumericUpDown numTelefono;
        private Label lblEmail;
        private ComboBox comboBox3;
        private Label lblBarrio;
        private Label label11;
        private Label label12;
        private Button button1;
        private ComboBox comboBox4;
        private Label label13;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label14;
        private Label label15;
    }
}