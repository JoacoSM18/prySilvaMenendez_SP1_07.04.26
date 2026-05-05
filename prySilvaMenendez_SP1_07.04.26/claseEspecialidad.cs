using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySilvaMenendez_SP1_07._04._26
{
    public class claseEspecialidad
    {
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public claseEspecialidad() { }
        public claseEspecialidad(int numero, string nombre)
        {
            Numero = numero;
            Nombre = nombre;
        }
        public void RegistrarEspecialidadenBD()
        {
            try
            {
                using (OleDbConnection con = claseConexion.ObtenerConexion())
                {
                    con.Open();
                    string query = "INSERT INTO especialidades (codigoEspecialidad, nombreEspecialidad) VALUES (@codigo, @nombre)";
                    OleDbCommand cmd = new OleDbCommand(query, con);
                    cmd.Parameters.AddWithValue("@codigo", Numero);
                    cmd.Parameters.AddWithValue("@nombre", Nombre);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar especialidad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
