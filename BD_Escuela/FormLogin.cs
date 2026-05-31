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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.KeyPreview = true;

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContraseña.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor ingrese usuario y contraseña.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Busca el usuario y obtiene su rol y permisos en una sola consulta
                string consulta = $@"SELECT u.usr_id, u.usr_nombre, r.rol_nombre, p.perm_permisos
                                     FROM usuarios u
                                     JOIN usuarios_roles ur ON u.usr_id = ur.usr_id
                                     JOIN roles r ON ur.rol_id = r.rol_id
                                     JOIN permisos p ON r.rol_id = p.rol_id
                                     WHERE u.usr_nombre = '{usuario}'
                                     AND u.usr_pwd = '{contrasena}'";

                DataTable dt = Conexion.Consultar(consulta);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Guardar datos de sesión
                Sesion.UsrId = Convert.ToInt32(dt.Rows[0]["USR_ID"]);
                Sesion.Usuario = dt.Rows[0]["USR_NOMBRE"].ToString();
                
                Sesion.Rol = dt.Rows[0]["ROL_NOMBRE"].ToString();
                Sesion.Permisos = dt.Rows[0]["PERM_PERMISOS"].ToString().Trim();

                // Abrir el menú principal y cerrar el login
                frmMenu menu = new frmMenu();
                menu.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Error al conectar con la base de datos.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIniciarSesion_Click(sender, e); 
            }
        }
    }
}
