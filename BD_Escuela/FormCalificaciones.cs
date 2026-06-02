using BD_Escuela.Clases;
using System.Data;

namespace BD_Escuela
{
    public partial class FormCalificaciones : Form
    {
        private int idInscripcion => Convert.ToInt32(cmbInscripcion.SelectedValue);
        private decimal nota => Convert.ToDecimal(txtNota.Text);
        private int idAlumno;
        public FormCalificaciones()
        {
            InitializeComponent();
            btnGuardar.Enabled = Sesion.PuedeInsertar;
            if (Sesion.Rol == "ALUMNO")
            {
                idAlumno = Convert.ToInt32(Conexion.Consultar("select id_alumno from alumnos a JOIN usuarios u on u.usr_id = a.usr_id where u.usr_id = " + Sesion.UsrId).Rows[0][0]);
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int id_inscripcion = Convert.ToInt32(cmbInscripcion.SelectedValue);
                string ejecutar = $"INSERT INTO calificaciones(id_inscripcion, nota) VALUES({idInscripcion}, {nota})";
                Conexion.Ejecutar(ejecutar, out int filasAfectadas, out string mensaje);
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCalificaciones();
            }
            catch
            {
                MessageBox.Show("Error al agregar la calificación. Verifique los datos ingresados.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idCalificacion = Convert.ToInt32(dgvCalificaciones.CurrentRow.Cells["ID_CALIFICACION"].Value);

                string ejecutar = $"DELETE FROM calificaciones WHERE id_calificacion = {idCalificacion}";
                Conexion.Ejecutar(ejecutar, out int filasAfectadas, out string mensaje);
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCalificaciones();
            }
            catch
            {
                MessageBox.Show("Error al eliminar la calificación. Verifique los datos ingresados.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int idCalificacion = Convert.ToInt32(dgvCalificaciones.CurrentRow.Cells["ID_CALIFICACION"].Value);

                string ejecutar = $"UPDATE calificaciones SET id_inscripcion = {idInscripcion}, nota = {nota} WHERE id_calificacion = {idCalificacion}";
                Conexion.Ejecutar(ejecutar, out int filasAfectadas, out string mensaje);
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCalificaciones();
            }
            catch
            {
                MessageBox.Show("Error al modificar la calificación. Verifique los datos ingresados.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarCalificaciones()
        {
            string consulta;
            if (Sesion.Rol == "ADMINISTRADOR" || Sesion.Rol == "SECRETARIO")
            {
                consulta = "SELECT cal.id_calificacion, a.id_alumno, a.nombre || ' ' || a.apellido AS alumno," +
                            " i.id_inscripcion, i.id_curso, cal.nota, cal.estatus , cal.creado_por, cal.fecha_creacion, cal.modificado_por, cal.fecha_modificacion, cal.ses_id " +
                        " FROM calificaciones cal" +
                        " INNER JOIN inscripciones i" +
                            " ON cal.id_inscripcion = i.id_inscripcion" +
                        " INNER JOIN alumnos a" +
                            " ON i.id_alumno = a.id_alumno" +
                        " WHERE i.id_curso = '" + cmbCurso.SelectedValue + "'";

            }
            else if (Sesion.Rol == "PROFESOR")
            {
                consulta = "SELECT cal.id_calificacion, a.id_alumno, a.nombre || ' ' || a.apellido AS alumno," +
                            " i.id_inscripcion, i.id_curso, cal.nota, cal.estatus " +
                        " FROM calificaciones cal" +
                        " INNER JOIN inscripciones i" +
                            " ON cal.id_inscripcion = i.id_inscripcion" +
                        " INNER JOIN alumnos a" +
                            " ON i.id_alumno = a.id_alumno" +
                        " WHERE i.id_curso = '" + cmbCurso.SelectedValue + "'" +
                        " ORDER BY alumno";
            }
            else
            {
                consulta = @"SELECT
                            a.nombre || ' ' || a.apellido AS alumno,
                            i.id_curso,
                            c.parcial,
                            c.nota,
                            c.estatus
                        FROM calificaciones c
                        INNER JOIN inscripciones i
                            ON c.id_inscripcion = i.id_inscripcion
                        INNER JOIN alumnos a
                            ON i.id_alumno = a.id_alumno
                        WHERE i.id_alumno = " + idAlumno + @"
                        AND i.id_curso = '" + cmbCurso.SelectedValue + @"'
                        ORDER BY c.parcial;";
            }
            DataTable dt = Conexion.Consultar(consulta);
            dgvCalificaciones.DataSource = dt;

        }

        public void cargarCursos()
        {
            string consulta;
            if (Sesion.Rol == "ADMINISTRADOR" || Sesion.Rol == "SECRETARIO")
            {
                btnGuardar.Visible = false;
                btnEliminar.Visible = false;
                btnModificar.Visible = false;
                txtNota.Visible = false;
                lblNota.Visible = false;
                consulta = "SELECT c.id_curso, c.id_curso || ' - ' || m.nombre_materia AS CURSO " +
                    "FROM cursos c " +
                    "INNER JOIN profesores p " +
                    "ON c.id_profesor = p.id_profesor " +
                    "INNER JOIN materias m " +
                    "ON c.id_materia = m.id_materia";
            }
            else if (Sesion.Rol == "PROFESOR")
            {
                int idProfesor = Convert.ToInt32(Conexion.Consultar("select id_profesor from profesores p JOIN usuarios u on u.usr_id = p.usr_id where u.usr_id = " + Sesion.UsrId).Rows[0][0]);
                consulta = "SELECT c.id_curso, c.id_curso || ' - ' || m.nombre_materia AS CURSO " +
                    "FROM cursos c " +
                    "INNER JOIN profesores p    " +
                    "ON c.id_profesor = p.id_profesor " +
                    "INNER JOIN materias m    " +
                    "ON c.id_materia = m.id_materia" +
                    " WHERE p.id_profesor = " + idProfesor;
            }
            else
            {
                consulta = "SELECT c.id_curso, c.id_curso || ' - ' || m.nombre_materia AS CURSO " +
                    "FROM inscripciones i " +
                    "INNER JOIN cursos c " +
                    "ON i.id_curso = c.id_curso " +
                    "INNER JOIN materias m " +
                    "ON c.id_materia = m.id_materia " +
                    "WHERE i.id_alumno = " + idAlumno +
                    " ORDER BY c.id_curso;";
                lblInscripcion.Visible = false;
                lblNota.Visible = false;
                cmbInscripcion.Visible = false;
                txtNota.Visible = false;

            }
            DataTable dt = Conexion.Consultar(consulta);

            cmbCurso.DataSource = dt;
            cmbCurso.DisplayMember = "CURSO";
            cmbCurso.ValueMember = "ID_CURSO";
            cmbCurso.SelectedIndex = -1;
        }

        private void CargarAlumnos()
        {
            // Muestra: nombre del alumno + id del curso
            string consulta = @"SELECT i.id_inscripcion,a.id_alumno, a.nombre || ' ' || a.apellido AS alumno, c.id_curso 
                    FROM inscripciones i
                    INNER JOIN alumnos a
                        ON i.id_alumno = a.id_alumno
                    INNER JOIN cursos c
                        ON i.id_curso = c.id_curso
                    WHERE i.id_curso = '" + cmbCurso.SelectedValue + "'";
            DataTable dt = Conexion.Consultar(consulta);

            cmbInscripcion.DataSource = dt;
            cmbInscripcion.DisplayMember = "alumno";
            cmbInscripcion.ValueMember = "ID_INSCRIPCION";
            if (cmbInscripcion.SelectedItem != null)
            {
                DataRowView fila = (DataRowView)cmbInscripcion.SelectedItem;
                idAlumno = Convert.ToInt32(fila["ID_ALUMNO"]);
            }
        }

        private void CargarInscripciones()
        {
            // Muestra: nombre del alumno + id del curso
            string consulta = @"SELECT i.id_inscripcion, a.nombre || ' ' || a.apellido || ' - ' || i.id_curso AS descripcion
                                FROM inscripciones i JOIN alumnos a ON i.id_alumno = a.id_alumno ORDER BY a.nombre";
            DataTable dt = Conexion.Consultar(consulta);

            cmbInscripcion.DataSource = dt;
            cmbInscripcion.DisplayMember = "DESCRIPCION";
            cmbInscripcion.ValueMember = "ID_INSCRIPCION";
        }

        private void FormCalificaciones_Load(object sender, EventArgs e)
        {
            // Aplicar permisos a los botones
            btnGuardar.Enabled = Sesion.PuedeInsertar;
            btnModificar.Enabled = Sesion.PuedeModificar;
            btnEliminar.Enabled = Sesion.PuedeEliminar;


            cargarCursos();
            CargarCalificaciones();
        }

        private void dgvCalificaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbInscripcion_SelectedIndexChanged(object sender, EventArgs e)
        {

            /*
                        if (cmbInscripcion.SelectedItem != null)
                        {
                            DataRowView fila = (DataRowView)cmbInscripcion.SelectedItem;
                            idAlumno = Convert.ToInt32(fila["ID_ALUMNO"]);
                        }*/

        }

        private void btnCerrar_Click(object sender, EventArgs e)
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
    }
}
