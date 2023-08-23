using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDePersonal_Pro
{
    public partial class IngresoPersonal : Form
    {
        private static IngresoPersonal instVentana = null;

        public IngresoPersonal()
        {
            InitializeComponent();
            cargarTabla(null);
        }

        /*public static IngresoPersonal UnaVentana()
        {
            if (instVentana == null )
            {
                instVentana= new IngresoPersonal();
                return instVentana;
            }
            return instVentana;
        }*/

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            { 
                string nombres = txtNombres.Text;
                string apellidos = txtApellidos.Text;
                string cargo = combxCargo.Text;
                string correo = txtCorreo.Text;
                string contrasena = txtContasena.Text;

                if (nombres != "" && apellidos != "" && cargo != "" && correo != "" )
                {

                    String sql = "INSERT INTO personal (NombrePersonal, ApellidoPersonal, CargoPersonal, CorreoPersonal, Contaseña) VALUES ('" + nombres + "','" + apellidos + "','" + cargo + "','" + correo + "','" + contrasena + "')";

                    MySqlConnection conexionBD = Conexion.conexion();
                    conexionBD.Open();

                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Registro guardado");
                        limpiar();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al guardar: " + ex.Message);
                    }
                    finally
                    {
                        conexionBD.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos");
                }
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Datos incorrectos: " + fex.Message);
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            string id = txtId.Text;
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            string cargo = combxCargo.Text;
            string correo = txtCorreo.Text;
            string contrasena = txtContasena.Text;

            string sql = "UPDATE personal SET NombrePersonal='" + nombres + "', ApellidoPersonal= '" + apellidos + "', CargoPersonal= '" + cargo + "', CorreoPersonal='" + correo + "', Contaseña='" + contrasena + "' WHERE IdPersonal='" + id + "'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro modificado");
                limpiar();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);

            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;


            string sql = "DELETE FROM personal WHERE IdPersonal='" + id + "'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado");
                limpiar();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);

            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            MySqlDataReader reader = null;

            string sql = "SELECT IdPersonal, NombrePersonal, ApellidoPersonal, CargoPersonal, CorreoPersonal, Contaseña FROM personal WHERE IdPersonal LIKE '" + id + "' LIMIT 1";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtId.Text = reader.GetString(0);
                        txtNombres.Text = reader.GetString(1);
                        txtApellidos.Text = reader.GetString(2);
                        combxCargo.Text = reader.GetString(3);
                        txtCorreo.Text = reader.GetString(4);
                        txtContasena.Text = reader.GetString(5);
                    }

                }
                else
                {
                    MessageBox.Show("No se encontraron registros");

                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(" Error al buscar " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        } 

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            txtId.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            combxCargo.Text = "";
            txtCorreo.Text = "";
            txtContasena.Text = "";
        }

        private void IngresoPersonal_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cargarTabla(string dato)
        {
            List<Personal> lista = new List<Personal>();
            CtrlPersonal _ctrlProductos = new CtrlPersonal();
            dgvPersonal.DataSource = _ctrlProductos.consulta(dato);
        }


    }
}
