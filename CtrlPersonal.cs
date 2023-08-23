using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDePersonal_Pro
{
    internal class CtrlPersonal : ConexionTabla
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT IdPersonal, NombrePersonal, ApellidoPersonal, CargoPersonal, CorreoPersonal, Contaseña FROM personal ORDER BY NombrePersonal ASC";
            }
            else
            {
                sql = "SELECT IdPersonal, NombrePersonal, ApellidoPersonal, CargoPersonal, CorreoPersonal, Contaseña FROM personal WHERE IdPersonal LIKE '%" +
                    dato + "%' OR NombrePersonal LIKE '%" + dato + "%' OR ApellidoPersonal LIKE '%" + dato + "%' OR CargoPersonal LIKE '%" +
                    dato + "%' OR CorreoPersonal LIKE '%" + dato + "%' ORDER BY NombrePersonal ASC";
            }

            try
            {
                MySqlConnection conexionBDT = base.conexion();
                conexionBDT.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBDT);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Personal _personal = new Personal();
                    _personal.IdPersonal1 = int.Parse(reader.GetString(0));
                    _personal.NombrePersonal1 = reader[1].ToString();
                    _personal.ApellidoPersonal1 = reader[2].ToString();
                    _personal.CorgoPersonal1 = reader[3].ToString();
                    _personal.CorreoPersonal1 = reader[4].ToString();
                    _personal.Contaseña1 = reader[5].ToString();
                    lista.Add(_personal);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }
    }
}
