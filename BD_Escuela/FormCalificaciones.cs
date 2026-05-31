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
    public partial class FormCalificaciones : Form
    {
        private int idInscripcion => Convert.ToInt32(cmbInscripcion.SelectedValue);
        private decimal nota => Convert.ToDecimal(txtNota.Text);
        public FormCalificaciones()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
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
            string consulta = "SELECT * FROM calificaciones ORDER BY id_calificacion";
            DataTable dt = Conexion.Consultar(consulta);
            dgvCalificaciones.DataSource = dt;
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

            CargarInscripciones();
            CargarCalificaciones();
        }

        private void dgvCalificaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
