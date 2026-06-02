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
    public partial class FormAsistencia : Form
    {
        private string fecha => dtpFecha.Value.ToString("yyyy-MM-dd");
        public FormAsistencia()
        {
            InitializeComponent();
        }
        private void CargarCursos()
        {
            if (Sesion.Rol == "ALUMNO") return;

            string sql;

            if (Sesion.Rol == "ADMINISTRADOR" || Sesion.Rol == "SECRETARIO")
            {
                // Admin ve todos los cursos
                sql = @"SELECT c.id_curso, c.id_curso || ' - ' || m.nombre_materia AS nombre_curso
                FROM cursos c
                JOIN materias m ON c.id_materia = m.id_materia
                ORDER BY c.id_curso";
            }
            else 
            {
                // Maestro solo ve sus cursos
                sql = $@"SELECT c.id_curso, c.id_curso || ' - ' || m.nombre_materia AS nombre_curso
                 FROM cursos c
                 JOIN materias m ON c.id_materia = m.id_materia
                 WHERE c.id_profesor = (SELECT p.id_profesor FROM profesores p WHERE p.usr_id = {Sesion.UsrId})
                 ORDER BY c.id_curso";
            }
            

            DataTable dt = Conexion.Consultar(sql);
            cmbCurso.DataSource = dt;
            cmbCurso.DisplayMember = "NOMBRE_CURSO";
            cmbCurso.ValueMember = "ID_CURSO";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string fechaSeleccionada = dtpFecha.Value.ToString("yyyy-MM-dd");


                string sqlInsert = $@"
                INSERT INTO asistencia (id_inscripcion, fecha, estado)
                SELECT i.id_inscripcion, TO_DATE('{fechaSeleccionada}', 'YYYY-MM-DD'), 'Falta'
                FROM inscripciones i
                JOIN cursos c ON i.id_curso = c.id_curso
                JOIN profesores p ON c.id_profesor = p.id_profesor
                WHERE p.usr_id = {Sesion.UsrId}
                AND NOT EXISTS (
                    SELECT 1 FROM asistencia a 
                    WHERE a.id_inscripcion = i.id_inscripcion 
                    AND TRUNC(a.fecha) = TO_DATE('{fechaSeleccionada}', 'YYYY-MM-DD')
            )";

                bool exito = Conexion.Ejecutar(sqlInsert, out int filasAfectadas, out string mensaje);

                if (exito)
                {
                    MessageBox.Show($"Se han generado {filasAfectadas} registros de asistencia como 'Falta'.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarAsistencia();
                }
                else
                {
                    MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error crítico al generar la lista: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Sesion.Permisos != "0000001D" && Sesion.Permisos != "0000001F")
            {
                MessageBox.Show("No tiene permisos para eliminar registros de asistencia.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (MessageBox.Show("¿Está seguro de que desea eliminar TODA la lista de asistencia de este día para este curso?",
                "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            try
            {
                string fechaSeleccionada = dtpFecha.Value.ToString("yyyy-MM-dd");

                string sqlDelete = $@"
                DELETE FROM asistencia 
                WHERE TRUNC(fecha) = TO_DATE('{fechaSeleccionada}', 'YYYY-MM-DD')
                AND id_inscripcion IN (
                    SELECT i.id_inscripcion 
                    FROM inscripciones i
                    JOIN cursos c ON i.id_curso = c.id_curso
                    JOIN profesores p ON c.id_profesor = p.id_profesor
                    WHERE p.usr_id = {Sesion.UsrId}
                )";

                bool exito = Conexion.Ejecutar(sqlDelete, out int filasAfectadas, out string mensaje);

                if (exito)
                {
                    MessageBox.Show($"Se han eliminado {filasAfectadas} registros correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarAsistencia();
                }
                else
                {
                    MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarAsistencia()
        {
            string fechaSeleccionada = dtpFecha.Value.ToString("yyyy-MM-dd");
            string consulta = "";

            // 1. Lógica para roles que dependen del ComboBox (Admin, Sec, Maestro)
            if (Sesion.Rol == "ADMINISTRADOR" || Sesion.Rol == "SECRETARIO" || Sesion.Rol == "MAESTRO")
            {
                // Validación específica para roles que requieren el curso
                if (cmbCurso.SelectedValue == null) return;

                string idCursoSeleccionado = cmbCurso.SelectedValue.ToString();

                if (Sesion.Rol == "MAESTRO" && checkFaltas.Checked)
                {
                    consulta = $@"SELECT DISTINCT a.nombre || ' ' || a.apellido AS Alumno
                          FROM alumnos a
                          INNER JOIN inscripciones i ON a.id_alumno = i.id_alumno
                          WHERE i.id_curso = '{idCursoSeleccionado}'
                          AND NOT EXISTS(SELECT 1 FROM asistencia asi 
                                         WHERE asi.id_inscripcion = i.id_inscripcion 
                                         AND asi.estado = 'Falta'
                                         AND TRUNC(asi.fecha) = TO_DATE('{fechaSeleccionada}', 'YYYY-MM-DD'))";
                }
                else
                {
                    consulta = $@"SELECT asi.id_asistencia, a.nombre || ' ' || a.apellido AS Alumno, 
                                 asi.estado AS Estado, asi.fecha AS Fecha
                          FROM asistencia asi
                          INNER JOIN inscripciones i ON asi.id_inscripcion = i.id_inscripcion
                          INNER JOIN alumnos a ON i.id_alumno = a.id_alumno
                          WHERE i.id_curso = '{idCursoSeleccionado}'
                          AND TRUNC(asi.fecha) = TO_DATE('{fechaSeleccionada}', 'YYYY-MM-DD')
                          ORDER BY a.apellido, a.nombre";
                }
            }
            // 2. Lógica específica para ALUMNO (No depende del ComboBox)
            else
            {
                consulta = $@"SELECT asi.id_asistencia, m.nombre_materia AS Materia, 
                             asi.estado AS Estado, asi.fecha AS Fecha
                      FROM asistencia asi
                      INNER JOIN inscripciones i ON asi.id_inscripcion = i.id_inscripcion
                      INNER JOIN cursos c ON i.id_curso = c.id_curso
                      INNER JOIN materias m ON c.id_materia = m.id_materia
                      INNER JOIN alumnos a ON i.id_alumno = a.id_alumno
                      WHERE a.usr_id = {Sesion.UsrId} 
                      AND TRUNC(asi.fecha) = TO_DATE('{fechaSeleccionada}', 'YYYY-MM-DD')
                      ORDER BY asi.fecha DESC";
            }

            // 3. Ejecución y visualización
            DataTable dt = Conexion.Consultar(consulta);
            dgvAsistencia.DataSource = dt;

            if (dgvAsistencia.Columns["ID_ASISTENCIA"] != null)
                dgvAsistencia.Columns["ID_ASISTENCIA"].Visible = false;
        }

        private void FormAsistencia_Load_1(object sender, EventArgs e)
        {
            if (Sesion.Permisos == "0000001D" || Sesion.Permisos == "0000001F")
            {
                btnGuardar.Enabled = true;
                btnEliminar.Enabled = true;
                checkFaltas.Enabled = true;
                CargarCursos();
            }
            else
            {
                btnGuardar.Enabled = false;
                btnEliminar.Enabled = false;
                checkFaltas.Enabled = false;
                cmbCurso.Enabled = false;
            }
            CargarAsistencia();

        }





        private void dgvAsistencia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (checkFaltas.Checked)
                return;

            if (e.RowIndex < 0 || dgvAsistencia.CurrentRow == null) return;


            var cellValue = dgvAsistencia.CurrentRow.Cells["ID_ASISTENCIA"].Value;
            if (cellValue == null || cellValue == DBNull.Value) return;



            if (Sesion.Permisos == "0000001D")
            {
                string estadoActual = dgvAsistencia.CurrentRow.Cells["ESTADO"].Value.ToString();
                string nuevoEstado = "";


                switch (estadoActual)
                {
                    case "Asistio": nuevoEstado = "Falta"; break;
                    case "Falta": nuevoEstado = "Justificada"; break;
                    case "Justificada": nuevoEstado = "Asistio"; break;
                    default: nuevoEstado = "Asistio"; break;
                }


                int idAsistencia = Convert.ToInt32(dgvAsistencia.CurrentRow.Cells["ID_ASISTENCIA"].Value);
                string sqlUpdate = $"UPDATE asistencia SET estado = '{nuevoEstado}' WHERE id_asistencia = {idAsistencia}";

                bool exito = Conexion.Ejecutar(sqlUpdate, out int filas, out string msg);

                if (exito)
                {

                    CargarAsistencia();
                }
                else
                {
                    MessageBox.Show($"Error al actualizar estado: {msg}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            CargarAsistencia();
        }


        private void checkFaltas_CheckedChanged(object sender, EventArgs e)
        {
            CargarAsistencia();
        }

        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarAsistencia();
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
