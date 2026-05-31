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
    public partial class FormUsuarios : Form
    {

        private string usuario => txtUsuario.Text.Trim();
        private string contrasena => txtContraseña.Text.Trim();
        private int idRol => Convert.ToInt32(cmbRol.SelectedValue);

        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Usuario y contraseña son obligatorios.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Determinar qué procedimiento usar según el rol seleccionado
                string rolSeleccionado = cmbRol.Text;

                if (rolSeleccionado == "MAESTRO")
                {
                    // Usar el procedimiento almacenado dar_alta_profesor
                    string[] partes = usuario.Split('.');
                    if (partes.Length < 2)
                    {
                        MessageBox.Show("Para maestros el usuario debe tener formato nombre.apellido",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    string nombre = partes[0];
                    string apellido = partes[1];
                    string emailTemp = $"{usuario}@escuela.com";

                    string ejecutar = $"BEGIN dar_alta_profesor('{nombre}', '{apellido}', '{emailTemp}', '{contrasena}', :id); END;";
                    Conexion.Ejecutar(ejecutar, out int filas, out string msg);
                    MessageBox.Show(msg, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rolSeleccionado == "ALUMNO")
                {
                    // Usar el procedimiento almacenado dar_alta_alumno
                    string[] partes = usuario.Split('.');
                    if (partes.Length < 2)
                    {
                        MessageBox.Show("Para alumnos el usuario debe tener formato nombre.apellido",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    string nombre = partes[0];
                    string apellido = partes[1];
                    string emailTemp = $"{usuario}@escuela.com";

                    string ejecutar = $"BEGIN dar_alta_alumno('{nombre}', '{apellido}', '{emailTemp}', '{contrasena}', :id); END;";
                    Conexion.Ejecutar(ejecutar, out int filas, out string msg);
                    MessageBox.Show(msg, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Para Admin y Secretario insertar directo
                    string ejecutar = $"INSERT INTO usuarios(usr_nombre, usr_pwd) VALUES('{usuario}', '{contrasena}')";
                    Conexion.Ejecutar(ejecutar, out int filas, out string msg);
                    MessageBox.Show(msg, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CargarUsuarios();
            }
            catch
            {
                MessageBox.Show("Error al guardar el usuario. Verifique los datos.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int idUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["USR_ID"].Value);

                string ejecutar = $"UPDATE usuarios SET usr_nombre = '{usuario}', usr_pwd = '{contrasena}' WHERE usr_id = {idUsuario}";
                Conexion.Ejecutar(ejecutar, out int filas, out string msg);
                MessageBox.Show(msg, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarUsuarios();
            }
            catch
            {
                MessageBox.Show("Error al modificar el usuario. Verifique los datos.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["USR_ID"].Value);

                DialogResult confirm = MessageBox.Show(
                    "¿Está seguro que desea eliminar este usuario?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    string ejecutar = $"DELETE FROM usuarios WHERE usr_id = {idUsuario}";
                    Conexion.Ejecutar(ejecutar, out int filas, out string msg);
                    MessageBox.Show(msg, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarUsuarios();
                }
            }
            catch
            {
                MessageBox.Show("Error al eliminar el usuario. Verifique los datos.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            // Este form solo lo puede ver el Admin
            btnGuardar.Enabled = Sesion.PuedeInsertar;
            btnModificar.Enabled = Sesion.PuedeModificar;
            btnEliminar.Enabled = Sesion.PuedeEliminar;

            CargarRoles();
            CargarUsuarios();
        }

        private void CargarRoles()
        {
            string consulta = "SELECT rol_id, rol_nombre FROM roles ORDER BY rol_nombre";
            DataTable dt = Conexion.Consultar(consulta);

            cmbRol.DataSource = dt;
            cmbRol.DisplayMember = "ROL_NOMBRE"; // ve: "ADMINISTRADOR"
            cmbRol.ValueMember = "ROL_ID";       // guarda: 1
        }

        public void CargarUsuarios()
        {
            // Mostramos usuario junto con su rol asignado
            string consulta = @"SELECT u.usr_id, u.usr_nombre, r.rol_nombre, u.usr_creado
                                FROM usuarios u
                                JOIN usuarios_roles ur ON u.usr_id = ur.usr_id
                                JOIN roles r ON ur.rol_id = r.rol_id
                                ORDER BY u.usr_nombre";
            DataTable dt = Conexion.Consultar(consulta);
            dgvUsuarios.DataSource = dt;
        }
    }
}
