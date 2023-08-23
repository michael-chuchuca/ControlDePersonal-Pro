using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDePersonal_Pro
{
    internal class ConexionTabla
    {
        public MySqlConnection conexion()
        {
            string servidor = "localhost";
            string bd = "controlpersonalbd";
            string usuario = "root";
            string password = "root";

            string cadenaConexion = "Database=" + bd + "; Data Source=" +
                servidor + "; User Id= " + usuario + "; Password= " + password + "";

            try
            {
                MySqlConnection conexionBDT = new MySqlConnection(cadenaConexion);
                return conexionBDT;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }

        }
    }
}
