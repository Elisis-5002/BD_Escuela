using Guna.UI2.WinForms.Suite;

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
            CustomizableEdges customizableEdges1 = new CustomizableEdges();
            CustomizableEdges customizableEdges2 = new CustomizableEdges();
            CustomizableEdges customizableEdges3 = new CustomizableEdges();
            CustomizableEdges customizableEdges4 = new CustomizableEdges();
            CustomizableEdges customizableEdges5 = new CustomizableEdges();
            CustomizableEdges customizableEdges6 = new CustomizableEdges();
            CustomizableEdges customizableEdges7 = new CustomizableEdges();
            CustomizableEdges customizableEdges8 = new CustomizableEdges();
            CustomizableEdges customizableEdges9 = new CustomizableEdges();
            CustomizableEdges customizableEdges10 = new CustomizableEdges();
            CustomizableEdges customizableEdges11 = new CustomizableEdges();
            CustomizableEdges customizableEdges12 = new CustomizableEdges();
            CustomizableEdges customizableEdges13 = new CustomizableEdges();
            CustomizableEdges customizableEdges14 = new CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesiónToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            ventanasToolStripMenuItem = new ToolStripMenuItem();
            profesoresToolStripMenuItem = new ToolStripMenuItem();
            alumnosToolStripMenuItem = new ToolStripMenuItem();
            asistenciaToolStripMenuItem = new ToolStripMenuItem();
            inscripcionesToolStripMenuItem = new ToolStripMenuItem();
            materiasToolStripMenuItem = new ToolStripMenuItem();
            cursosToolStripMenuItem = new ToolStripMenuItem();
            calificacionesToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            personasToolStripMenuItem = new ToolStripMenuItem();
            erroresDeInsercionToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnMaximizar = new Guna.UI2.WinForms.Guna2Button();
            btnMinimizar = new Guna.UI2.WinForms.Guna2Button();
            btnCerrar = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            label2 = new Label();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pnlBurbuja1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Dock = DockStyle.Left;
            guna2Panel1.FillColor = Color.FromArgb(255, 192, 192);
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(220, 100);
            guna2Panel1.TabIndex = 0;
            // 
            // guna2ContextMenuStrip1
            // 
            guna2ContextMenuStrip1.ImageScalingSize = new Size(24, 24);
            guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            guna2ContextMenuStrip1.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            guna2ContextMenuStrip1.RenderStyle.BorderColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SeparatorColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            guna2ContextMenuStrip1.Size = new Size(61, 4);
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cerrarSesiónToolStripMenuItem, salirToolStripMenuItem });
            archivoToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            archivoToolStripMenuItem.ForeColor = Color.White;
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(118, 36);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            cerrarSesiónToolStripMenuItem.BackColor = SystemColors.GradientActiveCaption;
            cerrarSesiónToolStripMenuItem.ForeColor = Color.Black;
            cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            cerrarSesiónToolStripMenuItem.Size = new Size(270, 40);
            cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            cerrarSesiónToolStripMenuItem.Click += cerrarSesiónToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.BackColor = Color.FromArgb(24, 95, 165);
            salirToolStripMenuItem.ForeColor = Color.Black;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(270, 40);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // ventanasToolStripMenuItem
            // 
            ventanasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { profesoresToolStripMenuItem, alumnosToolStripMenuItem, asistenciaToolStripMenuItem, inscripcionesToolStripMenuItem, materiasToolStripMenuItem, cursosToolStripMenuItem, calificacionesToolStripMenuItem, usuariosToolStripMenuItem, personasToolStripMenuItem, erroresDeInsercionToolStripMenuItem });
            ventanasToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ventanasToolStripMenuItem.ForeColor = Color.White;
            ventanasToolStripMenuItem.Name = "ventanasToolStripMenuItem";
            ventanasToolStripMenuItem.Size = new Size(133, 36);
            ventanasToolStripMenuItem.Text = "Ventanas";
            // 
            // profesoresToolStripMenuItem
            // 
            profesoresToolStripMenuItem.ForeColor = Color.Black;
            profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            profesoresToolStripMenuItem.Size = new Size(347, 40);
            profesoresToolStripMenuItem.Text = "Profesores";
            profesoresToolStripMenuItem.Click += profesoresToolStripMenuItem_Click;
            // 
            // alumnosToolStripMenuItem
            // 
            alumnosToolStripMenuItem.ForeColor = Color.Black;
            alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            alumnosToolStripMenuItem.Size = new Size(347, 40);
            alumnosToolStripMenuItem.Text = "Alumnos";
            alumnosToolStripMenuItem.Click += alumnosToolStripMenuItem_Click;
            // 
            // asistenciaToolStripMenuItem
            // 
            asistenciaToolStripMenuItem.ForeColor = Color.Black;
            asistenciaToolStripMenuItem.Name = "asistenciaToolStripMenuItem";
            asistenciaToolStripMenuItem.Size = new Size(347, 40);
            asistenciaToolStripMenuItem.Text = "Asistencia";
            asistenciaToolStripMenuItem.Click += asistenciaToolStripMenuItem_Click;
            // 
            // inscripcionesToolStripMenuItem
            // 
            inscripcionesToolStripMenuItem.Name = "inscripcionesToolStripMenuItem";
            inscripcionesToolStripMenuItem.Size = new Size(347, 40);
            inscripcionesToolStripMenuItem.Text = "Inscripciones";
            inscripcionesToolStripMenuItem.Click += inscripcionesToolStripMenuItem_Click;
            // 
            // materiasToolStripMenuItem
            // 
            materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            materiasToolStripMenuItem.Size = new Size(347, 40);
            materiasToolStripMenuItem.Text = "Materias";
            materiasToolStripMenuItem.Click += materiasToolStripMenuItem_Click;
            // 
            // cursosToolStripMenuItem
            // 
            cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            cursosToolStripMenuItem.Size = new Size(347, 40);
            cursosToolStripMenuItem.Text = "Cursos";
            cursosToolStripMenuItem.Click += cursosToolStripMenuItem_Click;
            // 
            // calificacionesToolStripMenuItem
            // 
            calificacionesToolStripMenuItem.Name = "calificacionesToolStripMenuItem";
            calificacionesToolStripMenuItem.Size = new Size(347, 40);
            calificacionesToolStripMenuItem.Text = "Calificaciones";
            calificacionesToolStripMenuItem.Click += calificacionesToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(347, 40);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // personasToolStripMenuItem
            // 
            personasToolStripMenuItem.Name = "personasToolStripMenuItem";
            personasToolStripMenuItem.Size = new Size(347, 40);
            personasToolStripMenuItem.Text = "Personas";
            personasToolStripMenuItem.Click += personasToolStripMenuItem_Click;
            // 
            // erroresDeInsercionToolStripMenuItem
            // 
            erroresDeInsercionToolStripMenuItem.Name = "erroresDeInsercionToolStripMenuItem";
            erroresDeInsercionToolStripMenuItem.Size = new Size(347, 40);
            erroresDeInsercionToolStripMenuItem.Text = "Errores de insercion";
            erroresDeInsercionToolStripMenuItem.Click += erroresDeInsercionToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(24, 95, 165);
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            menuStrip1.ForeColor = Color.Black;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, ventanasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(259, 40);
            menuStrip1.TabIndex = 4;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.FromArgb(181, 212, 244);
            guna2HtmlLabel2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.ForeColor = Color.FromArgb(24, 95, 165);
            guna2HtmlLabel2.Location = new Point(136, 165);
            guna2HtmlLabel2.Margin = new Padding(4);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(490, 67);
            guna2HtmlLabel2.TabIndex = 3;
            guna2HtmlLabel2.Text = "Base de Datos Escolar";
            // 
            // btnMaximizar
            // 
            btnMaximizar.BackColor = Color.FromArgb(24, 95, 165);
            btnMaximizar.BorderRadius = 17;
            btnMaximizar.CustomizableEdges = customizableEdges3;
            btnMaximizar.DisabledState.BorderColor = Color.DarkGray;
            btnMaximizar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMaximizar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMaximizar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMaximizar.FillColor = Color.FromArgb(55, 138, 221);
            btnMaximizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaximizar.ForeColor = Color.White;
            btnMaximizar.Location = new Point(699, 0);
            btnMaximizar.Margin = new Padding(4);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnMaximizar.Size = new Size(40, 40);
            btnMaximizar.TabIndex = 7;
            btnMaximizar.Text = "□";
            btnMaximizar.Click += btnMaximizar_Click_1;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.FromArgb(24, 95, 165);
            btnMinimizar.BorderRadius = 17;
            btnMinimizar.CustomizableEdges = customizableEdges5;
            btnMinimizar.DisabledState.BorderColor = Color.DarkGray;
            btnMinimizar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMinimizar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMinimizar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMinimizar.FillColor = Color.FromArgb(55, 138, 221);
            btnMinimizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimizar.ForeColor = Color.White;
            btnMinimizar.Location = new Point(653, 0);
            btnMinimizar.Margin = new Padding(4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnMinimizar.Size = new Size(48, 40);
            btnMinimizar.TabIndex = 6;
            btnMinimizar.Text = "─";
            btnMinimizar.Click += btnMinimizar_Click_1;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(24, 95, 165);
            btnCerrar.BorderRadius = 17;
            btnCerrar.CustomizableEdges = customizableEdges7;
            btnCerrar.DisabledState.BorderColor = Color.DarkGray;
            btnCerrar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCerrar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCerrar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCerrar.FillColor = Color.FromArgb(226, 75, 74);
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(738, 0);
            btnCerrar.Margin = new Padding(4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnCerrar.Size = new Size(49, 40);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "✕";
            btnCerrar.Click += btnCerrar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(24, 95, 165);
            label1.Location = new Point(301, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 8;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(24, 95, 165);
            label2.Location = new Point(210, -2);
            label2.Name = "label2";
            label2.Size = new Size(577, 42);
            label2.TabIndex = 9;
            label2.Click += label2_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.FromArgb(181, 212, 244);
            guna2HtmlLabel1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(24, 95, 165);
            guna2HtmlLabel1.Location = new Point(271, 255);
            guna2HtmlLabel1.Margin = new Padding(4);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(214, 56);
            guna2HtmlLabel1.TabIndex = 10;
            guna2HtmlLabel1.Text = "Bienvenido";
            guna2HtmlLabel1.Click += guna2HtmlLabel1_Click;
            // 
            // pnlBurbuja1
            // 
            pnlBurbuja1.BorderRadius = 110;
            pnlBurbuja1.CustomizableEdges = customizableEdges9;
            pnlBurbuja1.FillColor = Color.FromArgb(214, 232, 247);
            pnlBurbuja1.Location = new Point(0, 355);
            pnlBurbuja1.Margin = new Padding(5, 3, 5, 3);
            pnlBurbuja1.Name = "pnlBurbuja1";
            pnlBurbuja1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            pnlBurbuja1.Size = new Size(302, 275);
            pnlBurbuja1.TabIndex = 11;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BorderRadius = 110;
            guna2Panel2.CustomizableEdges = customizableEdges11;
            guna2Panel2.FillColor = Color.FromArgb(214, 232, 247);
            guna2Panel2.Location = new Point(722, 36);
            guna2Panel2.Margin = new Padding(5, 3, 5, 3);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2Panel2.Size = new Size(253, 250);
            guna2Panel2.TabIndex = 12;
            // 
            // guna2Panel3
            // 
            guna2Panel3.BorderRadius = 110;
            guna2Panel3.CustomizableEdges = customizableEdges13;
            guna2Panel3.FillColor = Color.FromArgb(214, 232, 247);
            guna2Panel3.Location = new Point(687, 369);
            guna2Panel3.Margin = new Padding(5, 3, 5, 3);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2Panel3.Size = new Size(253, 250);
            guna2Panel3.TabIndex = 13;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(181, 212, 244);
            ClientSize = new Size(786, 458);
            Controls.Add(guna2Panel3);
            Controls.Add(guna2Panel2);
            Controls.Add(pnlBurbuja1);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(label1);
            Controls.Add(btnMaximizar);
            Controls.Add(btnMinimizar);
            Controls.Add(btnCerrar);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(menuStrip1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel pnlBurbuja1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem ventanasToolStripMenuItem;
        private ToolStripMenuItem profesoresToolStripMenuItem;
        private ToolStripMenuItem alumnosToolStripMenuItem;
        private ToolStripMenuItem asistenciaToolStripMenuItem;
        private ToolStripMenuItem inscripcionesToolStripMenuItem;
        private ToolStripMenuItem materiasToolStripMenuItem;
        private ToolStripMenuItem cursosToolStripMenuItem;
        private ToolStripMenuItem calificacionesToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem personasToolStripMenuItem;
        private ToolStripMenuItem erroresDeInsercionToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button btnMaximizar;
        private Guna.UI2.WinForms.Guna2Button btnMinimizar;
        private Guna.UI2.WinForms.Guna2Button btnCerrar;
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
    }
}
