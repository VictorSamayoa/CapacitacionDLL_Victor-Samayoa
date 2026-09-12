using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_MVC
{
    public class Conexion
    {
        public OdbcConnection conexion()
        {
            OdbcConnection conn = new OdbcConnection("Dsn=capacitacion-MVC");
            try
            {
                conn.Open();
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("No conectó: " + ex.Message);
            }
            return conn;
        }

        public void desconexion(OdbcConnection conn)
        {
            try
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("No se desconectó: " + ex.Message);
            }
        }
    }
}
