using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySilvaMenendez_SP1_07._04._26
{
    public static class claseConexion
    {
        private static string rutaDB = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "clinica.accdb");
        private static string cadenaConexion => $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={rutaDB};";

        public static OleDbConnection ObtenerConexion()
        {
            return new OleDbConnection(cadenaConexion);
        }
    }
}
