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
    public partial class FormCursos : Form
    {
        private int idProfesor => Convert.ToInt32(cmbProfesor.ValueMember);
        private int idMateria => Convert.ToInt32(cmbMateria.ValueMember);
        public FormCursos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string ejecutar = $"INSERT INTO cursos(id_profesor, id_materia) VALUES({idProfesor}, {idMateria})";
                Conexion.Ejecutar(ejecutar, out int filasAfectadas, out string mensaje);
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCursos();
            }
            catch
            {
                MessageBox.Show("Error al agregar el curso. Verifique los datos ingresados.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string idCursoSeleccionado = dgvCursos.CurrentRow.Cells["ID_CURSO"].Value.ToString();

                string ejecutar = $"DELETE FROM cursos WHERE id_curso = '{idCursoSeleccionado}'";
                Conexion.Ejecutar(ejecutar, out int filasAfectadas, out string mensaje);
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCursos();
            }
            catch
            {
                MessageBox.Show("Error al eliminar el curso. Verifique los datos ingresados.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string idCursoSeleccionado = dgvCursos.CurrentRow.Cells["ID_CURSO"].Value.ToString();

                string ejecutar = $"UPDATE cursos SET id_profesor = {idProfesor}, id_materia = {idMateria} WHERE id_curso = '{idCursoSeleccionado}'";
                Conexion.Ejecutar(ejecutar, out int filasAfectadas, out string mensaje);
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCursos();
            }
            catch
            {
                MessageBox.Show("Error al modificar el curso. Verifique los datos ingresados.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarCursos()
        {
            string consulta = "SELECT * FROM cursos ORDER BY id_curso";
            DataTable dt = Conexion.Consultar(consulta);
            dgvCursos.DataSource = dt;
        }



        // Carga los profesores en el ComboBox
        private void CargarProfesores()
        {
            string consulta = "SELECT id_profesor, nombre || ' ' || apellido AS nombre_completo FROM profesores ORDER BY nombre";
            DataTable dt = Conexion.Consultar(consulta);

            cmbProfesor.DataSource = dt;
            cmbProfesor.DisplayMember = "NOMBRE_COMPLETO"; // lo que VE el usuario
            cmbProfesor.ValueMember = "ID_PROFESOR";       // lo que se GUARDA en BD
        }

        // Carga las materias en el ComboBox
        private void CargarMaterias()
        {
            string consulta = "SELECT id_materia, nombre_materia FROM materias ORDER BY nombre_materia";
            DataTable dt = Conexion.Consultar(consulta);

            cmbMateria.DataSource = dt;
            cmbMateria.DisplayMember = "NOMBRE_MATERIA"; // lo que VE el usuario
            cmbMateria.ValueMember = "ID_MATERIA";       // lo que se GUARDA en BD
        }

        private void cmbProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormCursos_Load(object sender, EventArgs e)
        {
            CargarProfesores();
            CargarMaterias();
            CargarCursos();
        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCursos.CurrentRow != null)
            {
                cmbProfesor.SelectedValue = Convert.ToInt32(dgvCursos.CurrentRow.Cells["ID_PROFESOR"].Value);
                cmbMateria.SelectedValue = Convert.ToInt32(dgvCursos.CurrentRow.Cells["ID_MATERIA"].Value);
            }
        }
    }
}
