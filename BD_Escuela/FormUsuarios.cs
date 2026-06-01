using BD_Escuela.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace BD_Escuela
{
    public partial class FormUsuarios : Form
    {

        

        public FormUsuarios()
        {
            InitializeComponent();
        }

        private string ObtenerIP()
        {
            try
            {
                string nombreHost = Dns.GetHostName();
                IPHostEntry host = Dns.GetHostEntry(nombreHost);

                foreach (IPAddress ip in host.AddressList)
                {

                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return ip.ToString();
                    }
                }
                return "127.0.0.1";
            }
            catch
            {
                return "Desconocida";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Usuario y contraseña son obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string usuario = txtUsuario.Text.Trim();
                string contrasena = txtContraseña.Text.Trim();
                int rolSeleccionado = Convert.ToInt32(cmbRol.SelectedValue);
                string ipActual = ObtenerIP();

                // 1. Insertar incluyendo explícitamente usr_creado
                string sqlUsuario = $@"INSERT INTO usuarios(usr_nombre, usr_pwd, usr_creado) 
                               VALUES('{usuario}', '{contrasena}', SYSDATE)";

                Conexion.Ejecutar(sqlUsuario, out int filas, out string msg);

                if (filas > 0)
                {
                    // 2. Obtener el ID recién creado
                    string idU = "(SELECT MAX(usr_id) FROM usuarios)";

                    // 3. Crear sesión
                    string token = Guid.NewGuid().ToString();
                    string sqlSesion = $@"INSERT INTO sesiones(ses_token, usr_id, ses_inicio, ses_ip) 
                                 VALUES('{token}', {idU}, SYSDATE, '{ipActual}')";
                    Conexion.Ejecutar(sqlSesion, out _, out _);

                    // 4. Vincular sesión al usuario y al rol
                    string idS = "(SELECT MAX(ses_id) FROM sesiones)";

                    string sqlUpdUsr = $@"UPDATE usuarios SET ses_id = {idS} WHERE usr_id = {idU}";
                    Conexion.Ejecutar(sqlUpdUsr, out _, out _);

                    string sqlRol = $@"INSERT INTO usuarios_roles(usr_id, rol_id, ses_id, ur_asignacion) 
                               VALUES({idU}, {rolSeleccionado}, {idS}, SYSDATE)";
                    Conexion.Ejecutar(sqlRol, out _, out _);

                    MessageBox.Show("Usuario registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarUsuarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // 1. Verificación básica
            if (dgvUsuarios.CurrentRow == null) return;

            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Usuario y contraseña son obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["USR_ID"].Value);
                string nuevoNombre = txtUsuario.Text.Trim();
                string nuevaContrasena = txtContraseña.Text.Trim();

                // 2. Modificamos solo las columnas editables: nombre y contraseña.
                // usr_creado y ses_id permanecen intactos para mantener la integridad histórica.
                string ejecutar = $@"UPDATE usuarios 
                             SET usr_nombre = '{nuevoNombre}', 
                                 usr_pwd = '{nuevaContrasena}' 
                             WHERE usr_id = {idUsuario}";

                Conexion.Ejecutar(ejecutar, out int filas, out string msg);

                if (filas > 0)
                {
                    MessageBox.Show("Usuario modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarUsuarios();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null) return;

            try
            {
                int idUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["USR_ID"].Value);
                string nombreUsuario = dgvUsuarios.CurrentRow.Cells["USR_NOMBRE"].Value.ToString();

                // 1. Verificamos el rol del usuario antes de borrar
                string consultaRol = $@"SELECT r.rol_nombre 
                                FROM roles r 
                                JOIN usuarios_roles ur ON r.rol_id = ur.rol_id 
                                WHERE ur.usr_id = {idUsuario}";

                DataTable dt = Conexion.Consultar(consultaRol);

                if (dt.Rows.Count > 0)
                {
                    string rolUsuario = dt.Rows[0]["ROL_NOMBRE"].ToString();

                    // 2. Aplicamos la regla: SOLO borrar si es 'SECRETARIO'
                    if (rolUsuario != "SECRETARIO")
                    {
                        MessageBox.Show($"No tiene permisos para eliminar un usuario con rol: {rolUsuario}.",
                            "Acción Denegada", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }

                // 3. Confirmación de eliminación
                DialogResult confirm = MessageBox.Show($"¿Está seguro que desea eliminar al secretario {nombreUsuario}?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    // Nota: Debido a tus FKs (sesiones, usuarios_roles), primero borramos dependencias
                    string[] pasosEliminacion = {
                $"DELETE FROM usuarios_roles WHERE usr_id = {idUsuario}",
                $"DELETE FROM sesiones WHERE usr_id = {idUsuario}",
                $"DELETE FROM usuarios WHERE usr_id = {idUsuario}"
            };

                    foreach (string sql in pasosEliminacion)
                    {
                        Conexion.Ejecutar(sql, out _, out _);
                    }

                    MessageBox.Show("Secretario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarUsuarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // El WHERE va antes del ORDER BY
            string consulta = @"SELECT rol_id, rol_nombre 
                        FROM roles 
                        WHERE rol_nombre IN ('ADMINISTRADOR', 'SECRETARIO') 
                        ORDER BY rol_nombre";

            DataTable dt = Conexion.Consultar(consulta);

            cmbRol.DataSource = dt;
            cmbRol.DisplayMember = "ROL_NOMBRE";
            cmbRol.ValueMember = "ROL_ID";
        }

        public void CargarUsuarios()
        {
            string consulta = @"SELECT u.usr_id, u.usr_nombre, u.usr_pwd, r.rol_nombre, u.usr_creado
                        FROM usuarios u
                        JOIN usuarios_roles ur ON u.usr_id = ur.usr_id
                        JOIN roles r ON ur.rol_id = r.rol_id
                        ORDER BY u.usr_nombre";
            DataTable dt = Conexion.Consultar(consulta);
            dgvUsuarios.DataSource = dt;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                txtUsuario.Text = dgvUsuarios.CurrentRow.Cells["USR_NOMBRE"].Value.ToString();
                txtContraseña.Text = dgvUsuarios.CurrentRow.Cells["USR_PWD"].Value.ToString();
            }
        }
    }
}
