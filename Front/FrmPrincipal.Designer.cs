﻿namespace Front
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            docentesToolStripMenuItem = new ToolStripMenuItem();
            nuevoDocenteToolStripMenuItem = new ToolStripMenuItem();
            consultarDocentesToolStripMenuItem = new ToolStripMenuItem();
            examenesToolStripMenuItem = new ToolStripMenuItem();
            nueToolStripMenuItem = new ToolStripMenuItem();
            consultarExamenesToolStripMenuItem = new ToolStripMenuItem();
            alumnosToolStripMenuItem = new ToolStripMenuItem();
            nuevoAlumnoToolStripMenuItem = new ToolStripMenuItem();
            consultarAlumnosToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoUTN;
            pictureBox1.Location = new Point(594, 332);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, docentesToolStripMenuItem, examenesToolStripMenuItem, alumnosToolStripMenuItem, reportesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(708, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(48, 20);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // docentesToolStripMenuItem
            // 
            docentesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoDocenteToolStripMenuItem, consultarDocentesToolStripMenuItem });
            docentesToolStripMenuItem.Name = "docentesToolStripMenuItem";
            docentesToolStripMenuItem.Size = new Size(68, 20);
            docentesToolStripMenuItem.Text = "Docentes";
            // 
            // nuevoDocenteToolStripMenuItem
            // 
            nuevoDocenteToolStripMenuItem.Name = "nuevoDocenteToolStripMenuItem";
            nuevoDocenteToolStripMenuItem.Size = new Size(177, 22);
            nuevoDocenteToolStripMenuItem.Text = "Nuevo Docente";
            // 
            // consultarDocentesToolStripMenuItem
            // 
            consultarDocentesToolStripMenuItem.Name = "consultarDocentesToolStripMenuItem";
            consultarDocentesToolStripMenuItem.Size = new Size(177, 22);
            consultarDocentesToolStripMenuItem.Text = "Consultar Docentes";
            // 
            // examenesToolStripMenuItem
            // 
            examenesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nueToolStripMenuItem, consultarExamenesToolStripMenuItem });
            examenesToolStripMenuItem.Name = "examenesToolStripMenuItem";
            examenesToolStripMenuItem.Size = new Size(72, 20);
            examenesToolStripMenuItem.Text = "Examenes";
            // 
            // nueToolStripMenuItem
            // 
            nueToolStripMenuItem.Name = "nueToolStripMenuItem";
            nueToolStripMenuItem.Size = new Size(181, 22);
            nueToolStripMenuItem.Text = "Nuevo Examen";
            // 
            // consultarExamenesToolStripMenuItem
            // 
            consultarExamenesToolStripMenuItem.Name = "consultarExamenesToolStripMenuItem";
            consultarExamenesToolStripMenuItem.Size = new Size(181, 22);
            consultarExamenesToolStripMenuItem.Text = "Consultar Examenes";
            // 
            // alumnosToolStripMenuItem
            // 
            alumnosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoAlumnoToolStripMenuItem, consultarAlumnosToolStripMenuItem });
            alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            alumnosToolStripMenuItem.Size = new Size(67, 20);
            alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // nuevoAlumnoToolStripMenuItem
            // 
            nuevoAlumnoToolStripMenuItem.Name = "nuevoAlumnoToolStripMenuItem";
            nuevoAlumnoToolStripMenuItem.Size = new Size(176, 22);
            nuevoAlumnoToolStripMenuItem.Text = "Nuevo Alumno";
            // 
            // consultarAlumnosToolStripMenuItem
            // 
            consultarAlumnosToolStripMenuItem.Name = "consultarAlumnosToolStripMenuItem";
            consultarAlumnosToolStripMenuItem.Size = new Size(176, 22);
            consultarAlumnosToolStripMenuItem.Text = "Consultar Alumnos";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(65, 20);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(708, 450);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem docentesToolStripMenuItem;
        private ToolStripMenuItem nuevoDocenteToolStripMenuItem;
        private ToolStripMenuItem consultarDocentesToolStripMenuItem;
        private ToolStripMenuItem examenesToolStripMenuItem;
        private ToolStripMenuItem alumnosToolStripMenuItem;
        private ToolStripMenuItem nueToolStripMenuItem;
        private ToolStripMenuItem consultarExamenesToolStripMenuItem;
        private ToolStripMenuItem nuevoAlumnoToolStripMenuItem;
        private ToolStripMenuItem consultarAlumnosToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
    }
}