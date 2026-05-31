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
    public partial class FormMaterias : Form
    {
        private string nombre => txtNombre.Text;
        public FormMaterias()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string ejecutar = $"INSERT INTO materias(nombre_materia) VALUES('{nombre}')";
                Conexion.Ejecutar(ejecutar, out int filasAfectadas, out string mensaje);
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarMaterias();
            }
            catch
            {
                MessageBox.Show("Error al agregar el materia. Rellene y verifique todos los datos ingresados.",
                     "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string ejecutar = $"DELETE FROM materias WHERE nombre_materia = '{nombre}'";
                Conexion.Ejecutar(ejecutar, out int filasAfectadas, out string mensaje);
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarMaterias();
            }
            catch
            {
                MessageBox.Show("Error al eliminar el materia. Rellene y verifique todos los datos ingresados.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int idMateria = Convert.ToInt32(dgvMaterias.CurrentRow.Cells["ID_MATERIA"].Value);

                string ejecutar = $"UPDATE materias SET nombre_materia = '{nombre}' WHERE id_materia = {idMateria}";
                Conexion.Ejecutar(ejecutar, out int filasAfectadas, out string mensaje);
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarMaterias();
            }
            catch
            {
                MessageBox.Show("Error al eliminar el materia. Rellene y verifique todos los datos ingresados.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarMaterias()
        {
            string consulta = "SELECT * FROM materias ORDER BY id_materia";
            DataTable dt = Conexion.Consultar(consulta);
            dgvMaterias.DataSource = dt;
        }

        private void FormMaterias_Load(object sender, EventArgs e)
        {
            btnGuardar.Enabled = Sesion.PuedeInsertar;
            btnModificar.Enabled = Sesion.PuedeModificar;
            btnEliminar.Enabled = Sesion.PuedeEliminar;
            CargarMaterias();
        }

        private void dgvMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMaterias.CurrentRow != null)
            {
                txtNombre.Text = dgvMaterias.CurrentRow.Cells["NOMBRE_MATERIA"].Value.ToString();
            }
        }
    }
}
