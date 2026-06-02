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
    public partial class FormKardex : Form
    {

        public FormKardex(DataTable dt)
        {
            InitializeComponent();

            string sqlRefrescar = "BEGIN DBMS_MVIEW.REFRESH('v_kardex', 'C'); END;";
            Conexion.Ejecutar(sqlRefrescar, out _, out _);

            dgvKardex.DataSource = Conexion.Consultar("SELECT * FROM v_kardex");
            dgvKardex.DataSource = dt;


        }

        private void dgvKardex_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormKardex_Load(object sender, EventArgs e)
        {

        }
    }
}
