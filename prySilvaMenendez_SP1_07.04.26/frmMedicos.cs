using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace prySilvaMenendez_SP1_07._04._26
{
    public partial class frmMedicos : Form
    {
        private List<Medico> medicos = new List<Medico>();
        private List<Especialidad> especialidades = new List<Especialidad>();

        public frmMedicos()
        {
            InitializeComponent();
        }

        private void frmMedicos_Load(object sender, EventArgs e)
        {
            CargarEspecialidades();
            ActualizarComboEspecialidades();
        }

        private void CargarEspecialidades()
        {
            especialidades.Clear();
            especialidades.Add(new Especialidad { Numero = 1, Nombre = "Cardiología" });
            especialidades.Add(new Especialidad { Numero = 2, Nombre = "Neurología" });
            especialidades.Add(new Especialidad { Numero = 3, Nombre = "Pediatría" });
            especialidades.Add(new Especialidad { Numero = 4, Nombre = "Oftalmología" });
        }

        private void ActualizarComboEspecialidades()
        {
            cbxEspecialidad.DataSource = null;
            cbxEspecialidad.DataSource = new List<Especialidad>(especialidades);
            cbxEspecialidad.DisplayMember = "Nombre";
            cbxEspecialidad.ValueMember = "Numero";
            cbxEspecialidad.SelectedIndex = 0;

            cbxEspecialidadMedico.DataSource = null;
            cbxEspecialidadMedico.DataSource = new List<Especialidad>(especialidades);
            cbxEspecialidadMedico.DisplayMember = "Nombre";
            cbxEspecialidadMedico.ValueMember = "Numero";
            cbxEspecialidadMedico.SelectedIndex = 0;
        }

        private void btnAgregarMedico_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposMedico())
                return;

            int matricula = int.Parse(txtMatricula.Text);
            string nombre = txtNombreMedico.Text.Trim();

            if (cbxEspecialidadMedico.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una especialidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Especialidad especialidadSeleccionada = (Especialidad)cbxEspecialidadMedico.SelectedItem;
            int numeroEspecialidad = especialidadSeleccionada.Numero;

            if (ExisteMedico(matricula))
            {
                MessageBox.Show("La matrícula de médico ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            medicos.Add(new Medico { Matricula = matricula, Nombre = nombre, NumeroEspecialidad = numeroEspecialidad });
            MessageBox.Show("Médico registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCamposMedico();
        }

        private void btnLimpiarMedico_Click(object sender, EventArgs e)
        {
            LimpiarCamposMedico();
        }

        private void cbxEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEspecialidad.SelectedItem != null)
            {
                Especialidad especialidadSeleccionada = (Especialidad)cbxEspecialidad.SelectedItem;
                int numeroEspecialidad = especialidadSeleccionada.Numero;
                var medicosEspecialidad = medicos.Where(m => m.NumeroEspecialidad == numeroEspecialidad).ToList();
                dgvMedicos.DataSource = null;
                dgvMedicos.DataSource = medicosEspecialidad;
            }
        }

        private bool ValidarCamposMedico()
        {
            if (string.IsNullOrWhiteSpace(txtMatricula.Text))
            {
                MessageBox.Show("Ingrese la matrícula del médico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatricula.Focus();
                return false;
            }

            if (!int.TryParse(txtMatricula.Text, out int matricula) || matricula <= 0)
            {
                MessageBox.Show("La matrícula debe ser un entero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatricula.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombreMedico.Text))
            {
                MessageBox.Show("Ingrese el nombre del médico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }

    public class Medico
    {
        public int Matricula { get; set; }
        public string Nombre { get; set; }
        public int NumeroEspecialidad { get; set; }
    }
}