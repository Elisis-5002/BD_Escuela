using BD_Escuela.Clases;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BD_Escuela.Forms
{
    public partial class frmAlumnos : Form
    {
        private string nombre => txtNombre.Text;
        private string apellido => txtApellido.Text;
        private string email => txtEmail.Text;
        private int añoIngreso => (int)numAño.Value;
        public frmAlumnos()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ejecutar = $"INSERT INTO alumnos(nombre, apellido, año_ingreso, email) VALUES('{nombre}', '{apellido}', {añoIngreso}, '{email}')";
                Conexion.Ejecutar(ejecutar, out int filasAfectadas, out string mensaje);
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarAlumnos();
            }
            catch
            {
                MessageBox.Show("Error al agregar el alumno. Rellene y verifique todos los datos ingresados.",
                     "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                string ejecutar = $"DELETE FROM alumnos WHERE nombre = '{nombre}' AND apellido = '{apellido}' AND año_ingreso = {añoIngreso} AND email = '{email}'";
                Conexion.Ejecutar(ejecutar, out int filasAfectadas, out string mensaje);
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarAlumnos();
            }
            catch
            {
                MessageBox.Show("Error al eliminar el alumno. Rellene y verifique todos los datos ingresados.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int idAlumno = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells["ID_ALUMNO"].Value);

                string ejecutar = $"UPDATE alumnos SET nombre = '{nombre}', apellido = '{apellido}', año_ingreso = {añoIngreso}, email = '{email}' WHERE id_alumno = {idAlumno}";
                Conexion.Ejecutar(ejecutar, out int filasAfectadas, out string mensaje);
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarAlumnos();
            }
            catch
            {
                MessageBox.Show("Error al eliminar el alumno. Rellene y verifique todos los datos ingresados.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void CargarAlumnos()
        {
            string consulta = "SELECT * FROM alumnos ORDER BY id_alumno";
            DataTable dt = Conexion.Consultar(consulta);
            dgvAlumnos.DataSource = dt;
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            CargarAlumnos();
        }
    }
}
