using BD_Escuela.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace BD_Escuela
{
    public partial class FormLogin : Form
    {
        public FormLogin()
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

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContraseña.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor ingrese usuario y contraseña.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                
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

                
                Sesion.UsrId = Convert.ToInt32(dt.Rows[0]["USR_ID"]);
                Sesion.Usuario = dt.Rows[0]["USR_NOMBRE"].ToString();
                Sesion.Rol = dt.Rows[0]["ROL_NOMBRE"].ToString();
                Sesion.Permisos = dt.Rows[0]["PERM_PERMISOS"].ToString().Trim();

                try
                {
                   
                    string token = Guid.NewGuid().ToString();

                    
                    string ip = ObtenerIP();

                    
                    string sqlSesion = $@"INSERT INTO sesiones (ses_token, ses_inicio, ses_ultima_actividad, ses_ip, usr_id) 
                          VALUES ('{token}', SYSDATE, SYSDATE, '{ip}', {Sesion.UsrId})";

                    bool exitoSesion = Conexion.Ejecutar(sqlSesion, out int filas, out string msg);

                    if (!exitoSesion)
                    {
                        MessageBox.Show("Error al registrar la sesión: " + msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Sesion.Token = token;
                    frmMenu menu = new frmMenu();
                    menu.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error crítico al iniciar sesión: " + ex.Message);
                }


                
            }
            catch
            {
                MessageBox.Show("Error al conectar con la base de datos.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
     }

        private void btnVer_CheckedChanged(object sender, EventArgs e)
        {
            if (!btnVer.Checked)
                txtContraseña.PasswordChar = '●';
            else
                txtContraseña.PasswordChar = '\0';
        }
    }
}
