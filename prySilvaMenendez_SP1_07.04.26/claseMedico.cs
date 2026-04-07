using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySilvaMenendez_SP1_07._04._26
{
    internal class claseMedico
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

        }
    }
}
