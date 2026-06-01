using BD_Escuela.Clases;
using BD_Escuela.Forms;

namespace BD_Escuela
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            // Mostrar el usuario activo en la barra de título
            this.Text = $"Menú Principal - {Sesion.Usuario} ({Sesion.Rol})";

            AplicarPermisos();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCalificaciones formCalificaciones = new FormCalificaciones();
            formCalificaciones.Show();
        }

        private void AplicarPermisos()
        {
            switch (Sesion.Rol)
            {
                case "ADMINISTRADOR":
                    // Ve todo, no se oculta nada
                    break;

                case "MAESTRO":
                    // Solo ve calificaciones y asistencia
                    profesoresToolStripMenuItem.Visible = false;
                    alumnosToolStripMenuItem.Visible = false;
                    materiasToolStripMenuItem.Visible = false;
                    cursosToolStripMenuItem.Visible = false;
                    inscripcionesToolStripMenuItem.Visible = false;
                    usuariosToolStripMenuItem.Visible = false;
                    break;

                case "ALUMNO":
                    // Solo ve sus calificaciones y asistencia
                    profesoresToolStripMenuItem.Visible = true;
                    alumnosToolStripMenuItem.Visible = false;
                    materiasToolStripMenuItem.Visible = false;
                    cursosToolStripMenuItem.Visible = false;
                    inscripcionesToolStripMenuItem.Visible = true;
                    calificacionesToolStripMenuItem.Visible = true;
                    usuariosToolStripMenuItem.Visible = false;
                    break;

                case "SECRETARIO":
                    // Ve todo pero sin modificar — eso se controla en cada form
                    profesoresToolStripMenuItem.Visible = false;
                    materiasToolStripMenuItem.Visible = false;
                    cursosToolStripMenuItem.Visible = false;
                    usuariosToolStripMenuItem.Visible = false;
                    break;
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Sesion.Token))
            {
                // Actualizamos la base de datos con la fecha de fin de sesión
                string sql = $"UPDATE sesiones SET ses_fin = SYSDATE WHERE ses_token = '{Sesion.Token}'";

                // Usamos Ejecutar para actualizar la BD
                Conexion.Ejecutar(sql, out int filas, out string mensaje);
            }

            // Limpiamos la sesión en memoria para que no queden datos basura
            Sesion.Token = null;
            Sesion.UsrId = 0;
            Sesion.Limpiar();

            // Abrimos el login y cerramos el formulario actual
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuarios formUsuarios = new FormUsuarios();
            formUsuarios.Show();
        }
    }
}
