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
        private int idInscripcion => Convert.ToInt32(cmbInscripcion.SelectedValue);
        private string fecha => Convert.ToDateTime(txtFecha.Text).ToString("yyyy-MM-dd");
        private string estado => cmbEstado.SelectedItem.ToString();
        public FormAsistencia()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // id_asistencia es automático, no se inserta
                // La fecha se formatea para Oracle: TO_DATE('2024-01-15', 'YYYY-MM-DD')
                string ejecutar = $"INSERT INTO asistencia(id_inscripcion, fecha, estado) " +
                                  $"VALUES({idInscripcion}, TO_DATE('{fecha}', 'YYYY-MM-DD'), '{estado}')";
                Conexion.Ejecutar(ejecutar, out int filasAfectadas, out string mensaje);
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarAsistencia();
            }
            catch
            {
                MessageBox.Show("Error al registrar asistencia. Verifique que la fecha sea válida (DD/MM/YYYY).",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            try
            {
                int idAsistencia = Convert.ToInt32(dgvAsistencia.CurrentRow.Cells["ID_ASISTENCIA"].Value);

                string ejecutar = $"UPDATE asistencia SET id_inscripcion = {idInscripcion}, " +
                                  $"fecha = TO_DATE('{fecha}', 'YYYY-MM-DD'), estado = '{estado}' " +
                                  $"WHERE id_asistencia = {idAsistencia}";
                Conexion.Ejecutar(ejecutar, out int filasAfectadas, out string mensaje);
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarAsistencia();
            }
            catch
            {
                MessageBox.Show("Error al modificar la asistencia. Verifique los datos ingresados.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idAsistencia = Convert.ToInt32(dgvAsistencia.CurrentRow.Cells["ID_ASISTENCIA"].Value);

                string ejecutar = $"DELETE FROM asistencia WHERE id_asistencia = {idAsistencia}";
                Conexion.Ejecutar(ejecutar, out int filasAfectadas, out string mensaje);
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarAsistencia();
            }
            catch
            {
                MessageBox.Show("Error al eliminar la asistencia. Verifique los datos ingresados.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarAsistencia()
        {
            string consulta = "SELECT * FROM asistencia ORDER BY id_asistencia";
            DataTable dt = Conexion.Consultar(consulta);
            dgvAsistencia.DataSource = dt;
        }

        private void FormAsistencia_Load(object sender, EventArgs e)
        {
            CargarInscripciones();
            CargarEstados();
            CargarAsistencia();
        }

        private void CargarInscripciones()
        {
            string consulta = @"SELECT i.id_inscripcion, a.nombre || ' ' || a.apellido || ' - ' || i.id_curso AS descripcion
                                FROM inscripciones i JOIN alumnos a ON i.id_alumno = a.id_alumno ORDER BY a.nombre";
            DataTable dt = Conexion.Consultar(consulta);

            cmbInscripcion.DataSource = dt;
            cmbInscripcion.DisplayMember = "DESCRIPCION";
            cmbInscripcion.ValueMember = "ID_INSCRIPCION";
        }

        private void CargarEstados()
        {
            cmbEstado.Items.Clear();
            cmbEstado.Items.Add("Presente");
            cmbEstado.Items.Add("Ausente");
            cmbEstado.Items.Add("Justificado");
            cmbEstado.SelectedIndex = 0; // selecciona Presente por defecto
        }
    }
}
