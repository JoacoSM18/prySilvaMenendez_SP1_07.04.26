using System;
using System.Windows.Forms;

namespace prySilvaMenendez_SP1_07._04._26
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            frmEspecialidades frm = new frmEspecialidades();
            frm.ShowDialog();
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            frmMedicos frm = new frmMedicos();
            frm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
