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
    public partial class FormInscripciones : Form
    {
        // Para el ID del Alumno (numérico)
        private int idAlumno
        {
            get
            {
                return cmbAlumno.SelectedValue != null ? Convert.ToInt32(cmbAlumno.SelectedValue) : 0;
            }
        }

        // Para el ID del Curso (VARCHAR2)
        private string idCurso
        {
            get
            {
                return cmbCurso.SelectedValue != null ? cmbCurso.SelectedValue.ToString() : string.Empty;
            }
        }
        public FormInscripciones()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Construcción de la consulta con campos de auditoría
                // Nota: Asegúrate de que idAlumno sea un valor numérico y idCurso sea el string del ID
                string ejecutar = $@"INSERT INTO inscripciones(id_alumno, id_curso, creado_por, fecha_creacion) 
                             VALUES({idAlumno}, '{idCurso}', '{Sesion.Usuario}', SYSDATE)";

                Conexion.Ejecutar(ejecutar, out int filasAfectadas, out string mensaje);

                // 2. Verificación de resultado
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Inscripción guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarInscripciones();
                }
                else
                {
                    MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la inscripción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validamos que haya una fila seleccionada
                if (dgvInscripciones.CurrentRow == null) return;

                int idInscripcion = Convert.ToInt32(dgvInscripciones.CurrentRow.Cells["ID_INSCRIPCION"].Value);

                // 2. Construcción del UPDATE incluyendo los campos de auditoría
                // Nota: Asegúrate de que los nombres de columna en tu BD sean exactamente estos
                string ejecutar = $@"UPDATE inscripciones 
                             SET id_alumno = {idAlumno}, 
                                 id_curso = '{idCurso}', 
                                 modificado_por = '{Sesion.Usuario}', 
                                 fecha_modificacion = SYSDATE 
                             WHERE id_inscripcion = {idInscripcion}";

                Conexion.Ejecutar(ejecutar, out int filasAfectadas, out string mensaje);

                // 3. Verificación de resultado
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Inscripción modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarInscripciones();
                }
                else
                {
                    MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar la inscripción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idInscripcion = Convert.ToInt32(dgvInscripciones.CurrentRow.Cells["ID_INSCRIPCION"].Value);

                string ejecutar = $"DELETE FROM inscripciones WHERE id_inscripcion = {idInscripcion}";
                Conexion.Ejecutar(ejecutar, out int filasAfectadas, out string mensaje);
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarInscripciones();
            }
            catch
            {
                MessageBox.Show("Error al eliminar la inscripción. Verifique los datos ingresados.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarInscripciones()
        {
            string consulta;
            if (Sesion.Rol == "ADMINISTRADOR" || Sesion.Rol == "SECRETARIO")
            {
                consulta = "SELECT * FROM inscripciones ORDER BY id_inscripcion";
            }
            else
            {
                consulta = "SELECT id_inscripcion, id_alumno, id_curso FROM inscripciones ORDER BY id_inscripcion";
            }
            DataTable dt = Conexion.Consultar(consulta);
            dgvInscripciones.DataSource = dt;
        }

        private void CargarAlumnos()
        {
            string consulta = "SELECT id_alumno, nombre || ' ' || apellido AS nombre_completo FROM alumnos ORDER BY nombre";
            DataTable dt = Conexion.Consultar(consulta);

            cmbAlumno.DataSource = dt;
            cmbAlumno.DisplayMember = "NOMBRE_COMPLETO";
            cmbAlumno.ValueMember = "ID_ALUMNO";
        }

        private void CargarCursos()
        {
            // Mostramos algo legible: id_curso + nombre de materia
            string consulta = @"SELECT c.id_curso, m.nombre_materia || ' - ' || c.id_curso AS descripcion
                                FROM cursos c JOIN materias m ON c.id_materia = m.id_materia ORDER BY m.nombre_materia";
            DataTable dt = Conexion.Consultar(consulta);

            cmbCurso.DataSource = dt;
            cmbCurso.DisplayMember = "DESCRIPCION";
            cmbCurso.ValueMember = "ID_CURSO";
        }

        private void FormInscripciones_Load_1(object sender, EventArgs e)
        {
            btnGuardar.Enabled = Sesion.PuedeInsertar;
            btnModificar.Enabled = Sesion.PuedeModificar;
            btnEliminar.Enabled = Sesion.PuedeEliminar;
            CargarAlumnos();
            CargarCursos();
            CargarInscripciones();
        }

        //Corregir esto //////
        private void dgvInscripciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvInscripciones.CurrentRow != null)
            {
                int idAlumno = Convert.ToInt32(dgvInscripciones.CurrentRow.Cells["ID_ALUMNO"].Value);
                cmbAlumno.SelectedValue = idAlumno;
                string idCurso = dgvInscripciones.CurrentRow.Cells["ID_CURSO"].Value.ToString();
                cmbCurso.SelectedValue = idCurso;
            }
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
