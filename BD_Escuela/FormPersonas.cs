using BD_Escuela.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BD_Escuela
{
    public partial class FormPersonas : Form
    {
        public FormPersonas()
        {
            InitializeComponent();
            string sql = @"
            SELECT nombre || ' ' || apellido AS Nombre, 'Profesor' AS Tipo FROM profesores
            UNION
            SELECT nombre || ' ' || apellido AS Nombre, 'Alumno' AS Tipo FROM alumnos
            ORDER BY Nombre ASC";

            DataTable dt = Conexion.Consultar(sql);

            dgvPersonas.DataSource = dt;

            if (dgvPersonas.Columns["Nombre"] != null)
            {
                dgvPersonas.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormPersonas_Load(object sender, EventArgs e)
        {

        }
    }
}
