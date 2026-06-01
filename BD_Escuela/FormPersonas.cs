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
            // Tu consulta de unión
                string sql = @"
            SELECT nombre || ' ' || apellido AS Nombre, 'Profesor' AS Tipo FROM profesores
            UNION
            SELECT nombre || ' ' || apellido AS Nombre, 'Alumno' AS Tipo FROM alumnos
            ORDER BY Nombre ASC";

            // Llamamos a la clase de conexión para obtener el DataTable
            DataTable dt = Conexion.Consultar(sql);

            // Asignamos al DataGridView
            dgvPersonas.DataSource = dt;

            // Opcional: Mejorar el aspecto visual de las columnas
            if (dgvPersonas.Columns["Nombre"] != null)
            {
                dgvPersonas.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
