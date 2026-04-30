using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace prySilvaMenendez_SP1_07._04._26
{
    public partial class frmEspecialidades : Form
    {
        private List<Especialidad> especialidades = new List<Especialidad>();
        public frmEspecialidades()
        {
            InitializeComponent();
        }

        private void frmEspecialidades_Load(object sender, EventArgs e)
        {
            CargarEspecialidades();
        }

        private void CargarEspecialidades()
        {
            dgvEspecialidades.DataSource = null;
            dgvEspecialidades.DataSource = especialidades;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            int numero = int.Parse(txtNumero.Text);
            string nombre = txtNombre.Text.Trim();

            if (ExisteEspecialidad(numero))
            {
                MessageBox.Show("El número de especialidad ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            especialidades.Add(new Especialidad { Numero = numero, Nombre = nombre });
            MessageBox.Show("Especialidad registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
            CargarEspecialidades();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                MessageBox.Show("Ingrese el número de especialidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Focus();
                return false;
            }

            if (!int.TryParse(txtNumero.Text, out int numero) || numero <= 0)
            {
                MessageBox.Show("El número debe ser un entero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre de la especialidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return false;
            }

            return true;
        }

        private bool ExisteEspecialidad(int numero)
        {
            return especialidades.Exists(e => e.Numero == numero);
        }

        private void LimpiarCampos()
        {
            txtNumero.Clear();
            txtNombre.Clear();
            txtNumero.Focus();
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class Especialidad
    {
        public int Numero { get; set; }
        public string Nombre { get; set; }
    }
}