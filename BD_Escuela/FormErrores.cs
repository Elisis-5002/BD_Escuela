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
    public partial class FormErrores : Form
    {
        public FormErrores()
        {
            InitializeComponent();
            CargarLogs();
        }
        public void CargarLogs()
        {
            try
            {
                // Consultamos todos los registros ordenados del más reciente al más antiguo
                string consulta = "SELECT id_error, descripcion_error, fecha_registro FROM log_errores ORDER BY fecha_registro DESC";

                DataTable dt = Conexion.Consultar(consulta);

                // Asignamos el resultado al DataGridView
                dgvErrores.DataSource = dt;

                // Opcional: Ajustar formato de columnas para que se vea mejor
                if (dgvErrores.Columns["DESCRIPCION_ERROR"] != null)
                {
                    dgvErrores.Columns["DESCRIPCION_ERROR"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudieron cargar los errores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
