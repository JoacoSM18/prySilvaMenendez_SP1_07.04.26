using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySilvaMenendez_SP1_07._04._26
{
    internal class claseEspecialidades
    {
        internal class claseEspecialidad
        {
            public string Nombre { get; set; }
            public int Codigo { get; set; }

            public claseEspecialidad( string nombre, int codigo)
            {
                Nombre = nombre;
                Codigo = codigo;
            }
            public void RegistrarEspecialidadenBD()
            {

            }
        }
    }
}
