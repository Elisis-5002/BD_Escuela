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


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string contrasenaPorDefecto = "pwd_123";

            // Invocamos el Stored Procedure de Alumnos
            bool exito = Clases.Conexion.RegistrarAlumnoSP(
                txtNombre.Text,
                txtApellido.Text,
                txtEmail.Text,
                contrasenaPorDefecto,
                out int idUsuario,
                out string mensaje
            );

            if (exito)
            {
                MessageBox.Show($"{mensaje}\nID Usuario Asignado: {idUsuario}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarAlumnos(); // Tu método para refrescar el DataGridView
            }
            else
            {
                MessageBox.Show(mensaje, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string ejecutar = $"DELETE FROM alumnos WHERE nombre = '{nombre}' AND apellido = '{apellido}' AND año_ingreso = {añoIngreso} AND email = '{email}'";
                Conexion.Ejecutar(ejecutar, out int filasAfectadas, out string mensaje);
                if (filasAfectadas == 0)
                {
                    MessageBox.Show("Ingrese alumno a eliminar", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
            string consulta;
            if (Sesion.Rol == "ADMINISTRADOR" || Sesion.Rol == "SECRETARIO")
            {
                consulta = "SELECT * FROM alumnos ORDER BY UPPER(nombre),UPPER(apellido)";
            }
            else
            {
                consulta = "SELECT id_alumno, nombre, apellido,año_ingreso, email FROM alumnos ORDER BY UPPER(nombre),UPPER(apellido)";
            }
            DataTable dt = Conexion.Consultar(consulta);
            dgvAlumnos.DataSource = dt;
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            btnGuardar.Enabled = Sesion.PuedeInsertar;
            btnModificar.Enabled = Sesion.PuedeModificar;
            btnEliminar.Enabled = Sesion.PuedeEliminar;
            CargarAlumnos();
        }

        private void dgvAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAlumnos.CurrentRow != null)
            {
                txtNombre.Text = dgvAlumnos.CurrentRow.Cells["NOMBRE"].Value.ToString();
                txtApellido.Text = dgvAlumnos.CurrentRow.Cells["APELLIDO"].Value.ToString();
                txtEmail.Text = dgvAlumnos.CurrentRow.Cells["EMAIL"].Value.ToString();
                numAño.Value = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells["AÑO_INGRESO"].Value);
            }
        }

        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAlumnos.CurrentRow != null)
            {
                txtNombre.Text = dgvAlumnos.CurrentRow.Cells["NOMBRE"].Value.ToString();
                txtApellido.Text = dgvAlumnos.CurrentRow.Cells["APELLIDO"].Value.ToString();
                txtEmail.Text = dgvAlumnos.CurrentRow.Cells["EMAIL"].Value.ToString();
                numAño.Value = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells["AÑO_INGRESO"].Value);
            }

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
