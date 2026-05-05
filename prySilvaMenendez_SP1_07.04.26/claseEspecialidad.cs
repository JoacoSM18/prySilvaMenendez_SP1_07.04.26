using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        }
    }
}
