namespace BD_Escuela
{
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            ventanasToolStripMenuItem = new ToolStripMenuItem();
            profesoresToolStripMenuItem = new ToolStripMenuItem();
            alumnosToolStripMenuItem = new ToolStripMenuItem();
            asistenciaToolStripMenuItem = new ToolStripMenuItem();
            inscripcionesToolStripMenuItem = new ToolStripMenuItem();
            materiasToolStripMenuItem = new ToolStripMenuItem();
            cursosToolStripMenuItem = new ToolStripMenuItem();
            calificacionesToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, ventanasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(533, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(104, 31);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(224, 32);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // ventanasToolStripMenuItem
            // 
            ventanasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { profesoresToolStripMenuItem, alumnosToolStripMenuItem, asistenciaToolStripMenuItem, inscripcionesToolStripMenuItem, materiasToolStripMenuItem, cursosToolStripMenuItem, calificacionesToolStripMenuItem, usuariosToolStripMenuItem });
            ventanasToolStripMenuItem.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ventanasToolStripMenuItem.Name = "ventanasToolStripMenuItem";
            ventanasToolStripMenuItem.Size = new Size(112, 31);
            ventanasToolStripMenuItem.Text = "Ventanas";
            // 
            // profesoresToolStripMenuItem
            // 
            profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            profesoresToolStripMenuItem.Size = new Size(234, 32);
            profesoresToolStripMenuItem.Text = "Profesores";
            profesoresToolStripMenuItem.Click += profesoresToolStripMenuItem_Click;
            // 
            // alumnosToolStripMenuItem
            // 
            alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            alumnosToolStripMenuItem.Size = new Size(234, 32);
            alumnosToolStripMenuItem.Text = "Alumnos";
            alumnosToolStripMenuItem.Click += alumnosToolStripMenuItem_Click;
            // 
            // asistenciaToolStripMenuItem
            // 
            asistenciaToolStripMenuItem.Name = "asistenciaToolStripMenuItem";
            asistenciaToolStripMenuItem.Size = new Size(234, 32);
            asistenciaToolStripMenuItem.Text = "Asistencia";
            asistenciaToolStripMenuItem.Click += asistenciaToolStripMenuItem_Click;
            // 
            // inscripcionesToolStripMenuItem
            // 
            inscripcionesToolStripMenuItem.Name = "inscripcionesToolStripMenuItem";
            inscripcionesToolStripMenuItem.Size = new Size(234, 32);
            inscripcionesToolStripMenuItem.Text = "Inscripciones";
            inscripcionesToolStripMenuItem.Click += inscripcionesToolStripMenuItem_Click;
            // 
            // materiasToolStripMenuItem
            // 
            materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            materiasToolStripMenuItem.Size = new Size(234, 32);
            materiasToolStripMenuItem.Text = "Materias";
            materiasToolStripMenuItem.Click += materiasToolStripMenuItem_Click;
            // 
            // cursosToolStripMenuItem
            // 
            cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            cursosToolStripMenuItem.Size = new Size(234, 32);
            cursosToolStripMenuItem.Text = "Cursos";
            cursosToolStripMenuItem.Click += cursosToolStripMenuItem_Click;
            // 
            // calificacionesToolStripMenuItem
            // 
            calificacionesToolStripMenuItem.Name = "calificacionesToolStripMenuItem";
            calificacionesToolStripMenuItem.Size = new Size(234, 32);
            calificacionesToolStripMenuItem.Text = "Calificaciones";
            calificacionesToolStripMenuItem.Click += calificacionesToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(155, 133);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(280, 34);
            label1.TabIndex = 1;
            label1.Text = "Base de Datos Escolar";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(234, 32);
            usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 300);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmMenu";
            Text = "Menu";
            Load += frmMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmAlumnos formAlumnos = new Forms.frmAlumnos();
            formAlumnos.Show();
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProfesores formProfesores = new FormProfesores();
            formProfesores.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCursos formCursos = new FormCursos();
            formCursos.Show();
        }

        private void asistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAsistencia formAsistencia = new FormAsistencia();
            formAsistencia.Show();
        }

        private void inscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInscripciones formInscripciones = new FormInscripciones();
            formInscripciones.Show();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMaterias formMaterias = new FormMaterias();
            formMaterias.Show();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem ventanasToolStripMenuItem;
        private ToolStripMenuItem profesoresToolStripMenuItem;
        private ToolStripMenuItem alumnosToolStripMenuItem;
        private ToolStripMenuItem cursosToolStripMenuItem;
        private ToolStripMenuItem asistenciaToolStripMenuItem;
        private Label label1;
        private ToolStripMenuItem inscripcionesToolStripMenuItem;
        private ToolStripMenuItem materiasToolStripMenuItem;
        private ToolStripMenuItem calificacionesToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
    }
}
