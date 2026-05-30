using BD_Escuela.Forms;

namespace BD_Escuela
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCalificaciones formCalificaciones = new FormCalificaciones();
            formCalificaciones.Show();
        }
    }
}
