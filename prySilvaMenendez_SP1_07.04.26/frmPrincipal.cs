using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace prySilvaMenendez_SP1_07._04._26
{
    public partial class frmPrincipal : Form
    {
        private List<claseEspecialidad> especialidades = new List<claseEspecialidad>();
        private List<claseMedico> medicos = new List<claseMedico>();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            frmEspecialidades frm = new frmEspecialidades(especialidades);
            frm.ShowDialog();
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            if (especialidades.Count == 0)
            {
                MessageBox.Show("No hay Especialidades Cargadas. Agregue una Primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmMedicos frm = new frmMedicos(especialidades, medicos);
            frm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (especialidades.Count == 0)
            {
                MessageBox.Show("No hay Especialidades Cargadas. Agregue una Primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmConsulta frm = new frmConsulta(especialidades,medicos);
            frm.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
