using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Expect.Open.Types.Condition.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ControlDePersonal_Pro
{
    public partial class FormIngresoPersonal : Form
    {
        public FormIngresoPersonal()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form2 frmIngreso = new  Form2();
            frmIngreso.Show();
        }
       
            private void btnRegistro_Click(object sender, EventArgs e)
        {
            string nombres = txbUsuario.Text;
            string contrasena = txbContaseña.Text;
            MySqlDataReader reader = null;
            string id = null;
            string nombre = null;
            string apellido = null;
            string cargo = null;
            string correo = null;
            string contasena = null;



            string sql = "SELECT IdPersona, NombrePersonal, ApellidoPersonal, CargoPersonal, CorreoPersonal, Contaseña FROM personal WHERE NombrePersonal LIKE '" + nombres + "' AND contaseña LIKE '" + contrasena + "'";
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
                        id = reader.GetString(0);
                        nombre = reader.GetString(1);
                        apellido = reader.GetString(2);
                        cargo = reader.GetString(3);
                        correo = reader.GetString(4);
                        contasena = reader.GetString(5);
                    }

                    String hora = null;
                    hora = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss");
                    conexionBD.Close();
                    //-------------------------------------------
                    MySqlConnection conexionBD2 = Conexion.conexion();
                    conexionBD2.Open();

                    

                    string sql2 = "insert into registros(NombreUsuario, HorarioEntrada, IdPersona) values ('" + nombre + "','" + hora + "', "+ id + ")";
                    
                    MySqlCommand comando2 = new MySqlCommand(sql2, conexionBD2);
                    comando2.ExecuteNonQuery();

                    lblVerificacion.Text = "Bienvenido " + nombre + " , su hora de logueo es: " + hora + "\n" + " Su entrada fue registrada exitosamente";
                    conexionBD2.Close();
                }
                else
                {
                    MessageBox.Show("No se encontro el usuario");

                }

                if (cargo == "Administrador")
                {
                    btnAdministador.Enabled = true;
                    MessageBox.Show("Bienvenido Usuario Administrador");
                    lblVerificacion.Text = string.Empty;
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

            txbUsuario.Text = null;
            txbContaseña.Text = null;
            //lblVerificacion.Text = null;
        }

        private void FormIngresoPersonal_Load(object sender, EventArgs e)
        {

        }

        private void btn_reg_salida_Click(object sender, EventArgs e)
        {
            
                string nombres = txbUsuario.Text;
                string contrasena = txbContaseña.Text;
                MySqlDataReader reader = null;
                string id = null;
                string nombre = null;
                string apellido = null;
                string cargo = null;
                string correo = null;
                string contasena = null;



                string sql = "SELECT IdPersona, NombrePersonal, ApellidoPersonal, CargoPersonal, CorreoPersonal, Contaseña FROM personal WHERE NombrePersonal LIKE '" + nombres + "' AND contaseña LIKE '" + contrasena + "'";
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
                            id = reader.GetString(0);
                            nombre = reader.GetString(1);
                            apellido = reader.GetString(2);
                            cargo = reader.GetString(3);
                            correo = reader.GetString(4);
                            contasena = reader.GetString(5);
                        }

                        String hora = null;
                        hora = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss");
                        conexionBD.Close();
                        //-------------------------------------------
                        MySqlConnection conexionBD2 = Conexion.conexion();
                        conexionBD2.Open();


                        string sql2 = "insert into registros(NombreUsuario, HorarioSalida, IdPersona) values ('" + nombre + "','" + hora + "', " + id + ")";

                        MySqlCommand comando2 = new MySqlCommand(sql2, conexionBD2);
                        comando2.ExecuteNonQuery();

                        lblVerificacion.Text = "Bienvenido " + nombre + " , su hora de logueo es: " + hora + "\n" + " Su salida fue registrada exitosamente";
                        conexionBD2.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se encontro el usuario");

                    }

                    //if (cargo == "Administrador")
                    //{
                        //btnAdministador.Enabled = true;
                        //MessageBox.Show("Bienvenido Usuario Administrador");
                        //lblVerificacion.Text = string.Empty;
                   // }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(" Error al buscar " + ex.Message);
                }
                finally
                {
                    conexionBD.Close();

                }

                txbUsuario.Text = null;
                txbContaseña.Text = null;
                
                //lblVerificacion.Text = null;
            
        }



        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txbUsuario.Text = null;
            txbContaseña.Text = null;
            lblVerificacion.Text = null;
            btnAdministador.Enabled = false;
            txbUsuario.Focus();
        }
    }

}
