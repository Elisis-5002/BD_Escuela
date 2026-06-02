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
        private int idProfesor
        {
            get
            {
                return cmbProfesor.SelectedValue != null ? Convert.ToInt32(cmbProfesor.SelectedValue) : 0;
            }
        }

        private int idMateria
        {
            get
            {
                return cmbMateria.SelectedValue != null ? Convert.ToInt32(cmbMateria.SelectedValue) : 0;
            }
        }
        public FormCursos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validaciones previas
                string idManual = txtID.Text.Trim();
                if (string.IsNullOrWhiteSpace(idManual))
                {
                    MessageBox.Show("Por favor, ingrese un ID válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Construcción de la consulta con campos de auditoría
                // Usamos SYSDATE para la fecha actual de Oracle y Sesion.NombreUsuario para quién lo crea
                string ejecutar = $@"INSERT INTO cursos(id_curso, id_profesor, id_materia, creado_por, fecha_creacion) 
                             VALUES('{idManual}', {idProfesor}, {idMateria}, '{Sesion.Usuario}', SYSDATE)";

                Conexion.Ejecutar(ejecutar, out int filasAfectadas, out string mensaje);

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Curso guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarCursos();
                }
                else
                {
                    MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el curso: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // Aseguramos que haya una fila seleccionada
                if (dgvCursos.CurrentRow == null) return;

                string idCursoSeleccionado = dgvCursos.CurrentRow.Cells["ID_CURSO"].Value.ToString();

                // Construimos el UPDATE incluyendo los campos de auditoría
                // Nota: Asegúrate de que los nombres de las columnas en tu BD sean exactamente estos
                string ejecutar = $@"UPDATE cursos 
                             SET id_profesor = {idProfesor}, 
                                 id_materia = {idMateria}, 
                                 modificado_por = '{Sesion.Usuario}', 
                                 fecha_modificacion = SYSDATE 
                             WHERE id_curso = '{idCursoSeleccionado}'";

                Conexion.Ejecutar(ejecutar, out int filasAfectadas, out string mensaje);

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Curso modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarCursos();
                }
                else
                {
                    MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el curso: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCursoMasUno()
        {
            string consulta = @"
        SELECT id_curso, COUNT(*) AS alumnos_en_el_curso 
        FROM inscripciones 
        GROUP BY id_curso 
        HAVING COUNT(*) > 1";

            DataTable dt = Conexion.Consultar(consulta);

            // Si tienes un DataGridView específico para reportes, úsalo aquí. 
            // Si quieres usar el mismo dgvCursos, ten en cuenta que cambiarán sus columnas.
            dgvMasUn.DataSource = dt;
        }

        public void CargarCursos()
        {
            string consulta;
            if (Sesion.Rol == "ADMINISTRADOR" || Sesion.Rol == "SECRETARIO")
            {
                consulta = "SELECT * FROM cursos ORDER BY id_curso";
            }
            else
            {
                consulta = "SELECT id_curso, id_profesor, id_materia FROM cursos ORDER BY id_curso";
            }
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
            btnGuardar.Enabled = Sesion.PuedeInsertar;
            btnModificar.Enabled = Sesion.PuedeModificar;
            btnEliminar.Enabled = Sesion.PuedeEliminar;
            CargarProfesores();
            CargarMaterias();
            CargarCursos();
            CargarCursoMasUno();
        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCursos.CurrentRow != null)
            {
                cmbProfesor.SelectedValue = Convert.ToInt32(dgvCursos.CurrentRow.Cells["ID_PROFESOR"].Value);
                cmbMateria.SelectedValue = Convert.ToInt32(dgvCursos.CurrentRow.Cells["ID_MATERIA"].Value);
            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
