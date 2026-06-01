using BD_Escuela.Clases;
using Oracle.ManagedDataAccess.Client;
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
            //try
            //{
            //    string ejecutar = $"INSERT INTO profesores(nombre, apellido, email) VALUES('{nombre}', '{apellido}', '{email}')";
            //    Conexion.Ejecutar(ejecutar, out int filasAfectadas, out string mensaje);
            //    MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    CargarProfesores();
            //}
            //catch
            //{
            //    MessageBox.Show("Error al agregar el profesor. Rellene y verifique todos los datos ingresados.",
            //         "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            string contrasenaPorDefecto = "password123";


            bool exito = Clases.Conexion.RegistrarProfesorSP(
                nombre,
                apellido,
                email,
                contrasenaPorDefecto,
                out int idUsuario,
                out string mensaje
            );

            if (exito)
            {
                MessageBox.Show($"{mensaje}\nID Usuario Asignado: {idUsuario}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProfesores();
            }
            else
            {
                MessageBox.Show(mensaje, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (filasAfectadas == 0)
                {
                    MessageBox.Show("Asegurese de que el profesor no está impartiendo cursos actualmente", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
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
            string consulta;
            if (Sesion.Rol == "ADMINISTRADOR" || Sesion.Rol == "SECRETARIO")
            {
                consulta = "SELECT * FROM profesores ORDER BY id_profesor";
            }
            else
            {
                consulta = "SELECT id_profesor, nombre, apellido, email FROM profesores ORDER BY id_profesor";
            }
            DataTable dt = Conexion.Consultar(consulta);
            dgvProfesores.DataSource = dt;
        }

        private void FormProfesores_Load(object sender, EventArgs e)
        {
            btnGuardar.Enabled = Sesion.PuedeInsertar;
            btnModificar.Enabled = Sesion.PuedeModificar;
            btnEliminar.Enabled = Sesion.PuedeEliminar;
            CargarProfesores();
        }

        private void dgvProfesores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProfesores.CurrentRow != null)
            {
                txtNombre.Text = dgvProfesores.CurrentRow.Cells["NOMBRE"].Value.ToString();
                txtApellido.Text = dgvProfesores.CurrentRow.Cells["APELLIDO"].Value.ToString();
                txtEmail.Text = dgvProfesores.CurrentRow.Cells["EMAIL"].Value.ToString();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
