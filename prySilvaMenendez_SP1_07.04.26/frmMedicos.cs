using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace prySilvaMenendez_SP1_07._04._26
{
    public partial class frmMedicos : Form
    {
        private List<claseEspecialidad> especialidades;
        private List<claseMedico> medicos;

        public frmMedicos(List<claseEspecialidad> especialidades, List<claseMedico> medicos)
        {
            InitializeComponent();
            this.especialidades = especialidades;
            this.medicos = medicos;
        }

        private void frmMedicos_Load(object sender, EventArgs e)
        {
            ActualizarComboEspecialidades();
        }

        private void ActualizarComboEspecialidades()
        {
            cbxEspecialidadMedico.DataSource = null;
            cbxEspecialidadMedico.DataSource = new List<claseEspecialidad>(especialidades);
            cbxEspecialidadMedico.DisplayMember = "Nombre";
            cbxEspecialidadMedico.ValueMember = "Numero";
        }

        private void btnAgregarMedico_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposMedico())
                return;

            if (cbxEspecialidadMedico.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una Especialidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int matricula = int.Parse(txtMatricula.Text);
            string nombre = txtNombreMedico.Text.Trim();
            claseEspecialidad especialidadSeleccionada = (claseEspecialidad)cbxEspecialidadMedico.SelectedItem;

            if (ExisteMedico(matricula))
            {
                MessageBox.Show("La Matrícula de Médico ya Existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            medicos.Add(new claseMedico(matricula, nombre, "", especialidadSeleccionada.Numero));
            MessageBox.Show("Médico Registrado Correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCamposMedico();
        }

        private void btnLimpiarMedico_Click(object sender, EventArgs e)
        {
            LimpiarCamposMedico();
        }

        private bool ValidarCamposMedico()
        {
            if (string.IsNullOrWhiteSpace(txtMatricula.Text))
            {
                MessageBox.Show("Ingrese la Matrícula del Médico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatricula.Focus();
                return false;
            }

            if (!int.TryParse(txtMatricula.Text, out int matricula) || matricula <= 0)
            {
                MessageBox.Show("La Matrícula Debe ser un Entero Positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatricula.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombreMedico.Text))
            {
                MessageBox.Show("Ingrese el Nombre del Médico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreMedico.Focus();
                return false;
            }

            return true;
        }

        private bool ExisteMedico(int matricula)
        {
            return medicos.Exists(m => m.Matricula == matricula);
        }

        private void LimpiarCamposMedico()
        {
            txtMatricula.Clear();
            txtNombreMedico.Clear();
            txtMatricula.Focus();
        }

        private void groupBoxConsulta_Enter(object sender, EventArgs e)
        {

        }
    }
}