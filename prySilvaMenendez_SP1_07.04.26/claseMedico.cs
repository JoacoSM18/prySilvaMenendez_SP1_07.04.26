using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySilvaMenendez_SP1_07._04._26
{
    public class claseMedico
    {
        public int Matricula { get; set; }
        public string Nombre { get; set; } 
        public string Apellido { get; set; }
        public int Especialidad { get; set; }

        public claseMedico(int matricula, string nombre, string apellido, int especialidad)
        {
            Matricula = matricula;
            Nombre = nombre;
            Apellido = apellido;
            Especialidad = especialidad;
        }

        public void RegistrarMedicoenBD()
        {
            try
            {
                using (OleDbConnection con = claseConexion.ObtenerConexion())
                {
                    con.Open();
                    string query = "INSERT INTO medicos (matricula, nombre, apellido, especialidad) VALUES (@matricula, @nombre, @apellido, @especialidad)";
                    OleDbCommand cmd = new OleDbCommand(query, con);
                    cmd.Parameters.AddWithValue("@matricula", Matricula);
                    cmd.Parameters.AddWithValue("@nombre", Nombre);
                    cmd.Parameters.AddWithValue("@apellido", Apellido);
                    cmd.Parameters.AddWithValue("@especialidad", Especialidad);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar médico: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
