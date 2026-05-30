using BD_Escuela.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BD_Escuela
{
    public partial class FormProfesores : Form
    {
        private string nombre => txtNombre.Text;
        private string apellido => txtApellido.Text;
        private string email => txtEmail.Text;
        public FormProfesores()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string ejecutar = $"INSERT INTO profesores(nombre, apellido, año_ingreso, email) VALUES('{nombre}', '{apellido}', '{email}')";
                Conexion.Ejecutar(ejecutar, out int filasAfectadas, out string mensaje);
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProfesores();
            }
            catch
            {
                MessageBox.Show("Error al agregar el profesor. Rellene y verifique todos los datos ingresados.",
                     "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int idProfesor = Convert.ToInt32(dgvProfesores.CurrentRow.Cells["ID_PROFESOR"].Value);

                string ejecutar = $"UPDATE profesores SET nombre = '{nombre}', apellido = '{apellido}', email = '{email}' WHERE id_profesor = {idProfesor}";
                Conexion.Ejecutar(ejecutar, out int filasAfectadas, out string mensaje);
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProfesores();
            }
            catch
            {
                MessageBox.Show("Error al eliminar el profesor. Rellene y verifique todos los datos ingresados.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string ejecutar = $"DELETE FROM profesores WHERE nombre = '{nombre}' AND apellido = '{apellido}' AND email = '{email}'";
                Conexion.Ejecutar(ejecutar, out int filasAfectadas, out string mensaje);
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProfesores();
            }
            catch
            {
                MessageBox.Show("Error al eliminar el profesor. Rellene y verifique todos los datos ingresados.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarProfesores()
        {
            string consulta = "SELECT * FROM profesores ORDER BY id_profesor";
            DataTable dt = Conexion.Consultar(consulta);
            dgvProfesores.DataSource = dt;
        }

        private void frmProfesores_Load(object sender, EventArgs e)
        {
            CargarProfesores();
        }
    }
}
