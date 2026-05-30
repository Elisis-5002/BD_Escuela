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
        private int idAlumno => Convert.ToInt32(cmbAlumno.SelectedValue);
        private string idCurso => cmbCurso.SelectedValue.ToString();
        public FormInscripciones()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string ejecutar = $"INSERT INTO inscripciones(id_alumno, id_curso) VALUES({idAlumno}, '{idCurso}')";
                Conexion.Ejecutar(ejecutar, out int filasAfectadas, out string mensaje);
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarInscripciones();
            }
            catch
            {
                MessageBox.Show("Error al agregar la inscripción. Verifique los datos ingresados.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int idInscripcion = Convert.ToInt32(dgvInscripciones.CurrentRow.Cells["ID_INSCRIPCION"].Value);

                string ejecutar = $"UPDATE inscripciones SET id_alumno = {idAlumno}, id_curso = '{idCurso}' WHERE id_inscripcion = {idInscripcion}";
                Conexion.Ejecutar(ejecutar, out int filasAfectadas, out string mensaje);
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarInscripciones();
            }
            catch
            {
                MessageBox.Show("Error al modificar la inscripción. Verifique los datos ingresados.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string consulta = "SELECT * FROM inscripciones ORDER BY id_inscripcion";
            DataTable dt = Conexion.Consultar(consulta);
            dgvInscripciones.DataSource = dt;
        }
        private void FormInscripciones_Load(object sender, EventArgs e)
        {
            CargarAlumnos();
            CargarCursos();
            CargarInscripciones();
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
    }
}
