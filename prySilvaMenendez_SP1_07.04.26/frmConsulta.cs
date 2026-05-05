using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySilvaMenendez_SP1_07._04._26
{
    public partial class frmConsulta : Form
    {
        private List<claseEspecialidad> especialidades;
        private List<claseMedico> medicos;

        public frmConsulta(List<claseEspecialidad> especialidades, List<claseMedico> medicos)
        {
            InitializeComponent();
            this.especialidades = especialidades;
            this.medicos = medicos;
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            ActualizarComboEspecialidades();
        }

        private void ActualizarComboEspecialidades()
        {
            cbxEspecialidad.DataSource = null;
            cbxEspecialidad.DataSource = new List<claseEspecialidad>(especialidades);
            cbxEspecialidad.DisplayMember = "Nombre";
            cbxEspecialidad.ValueMember = "Numero";
        }

        private void cbxEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEspecialidad.SelectedItem == null)
                return;

            claseEspecialidad especialidadSeleccionada = (claseEspecialidad)cbxEspecialidad.SelectedItem;
            var medicosEspecialidad = medicos.Where(m => m.Especialidad == especialidadSeleccionada.Numero).ToList();
            dgvMedicos.DataSource = null;
            dgvMedicos.DataSource = medicosEspecialidad;
        }
    }
}
