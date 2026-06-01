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
            dgvKardex.DataSource = dt; 
            
            
        }

        private void dgvKardex_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
