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
using Microsoft.SqlServer.Server;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ControlDePersonal_Pro;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ControlDePersonal_Pro
{
    public partial class Frm_Reportes : Form
    {
        public Frm_Reportes()
        {
            InitializeComponent();
        }

        private void Frm_Reportes_Load(object sender, EventArgs e)
        {
            Llenar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgv1.Rows.Clear();
            dgv1.Refresh();
            MySqlDataReader reader = null;
            string idregistro = null;
            string idpersona = null;
            string nombreusuario = null;
            string horaentrada = null;
            string horasalida = null;

            string sql4 = "SELECT IdRegistro,IdPersona,NombreUsuario, IF(ISNULL(HorarioEntrada)=1, 'N/A', HorarioEntrada) AS 'HorarioEntrada', IF(ISNULL(HorarioSalida)=1, 'N/A', HorarioSalida) AS 'HorarioSalida' FROM REGISTROS WHERE NombreUsuario ='" + txb_Nombre.Text + "' ";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql4, conexionBD);
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int n = dgv1.Rows.Add();
                        dgv1.Rows[n].Cells[0].Value = reader.GetString(0);
                        dgv1.Rows[n].Cells[1].Value = reader.GetString(1);
                        dgv1.Rows[n].Cells[2].Value = reader.GetString(2);
                        dgv1.Rows[n].Cells[3].Value = reader.GetString(3);
                        dgv1.Rows[n].Cells[4].Value = reader.GetString(4);
                    }

                }
                else
                {
                    MessageBox.Show("No se encontro el usuario");
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
            dgv1.Rows.Clear();
            dgv1.Refresh();
            txb_Nombre.Text = string.Empty;
            Llenar();

        }
        private void Llenar()
        {
            MySqlDataReader reader = null;
            string idregistro = null;
            string idpersona = null;
            string nombreusuario = null;
            string horaentrada = null;
            string horasalida = null;
            string sql = "SELECT IdRegistro,IdPersona,NombreUsuario, IF(ISNULL(HorarioEntrada)=1, 'N/A', HorarioEntrada) AS 'HorarioEntrada', IF(ISNULL(HorarioSalida)=1, 'N/A', HorarioSalida) AS 'HorarioSalida' FROM REGISTROS";
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
                        int n = dgv1.Rows.Add();
                        dgv1.Rows[n].Cells[0].Value = reader.GetString(0);
                        dgv1.Rows[n].Cells[1].Value = reader.GetString(1);
                        dgv1.Rows[n].Cells[2].Value = reader.GetString(2);
                        dgv1.Rows[n].Cells[3].Value = reader.GetString(3);
                        dgv1.Rows[n].Cells[4].Value = reader.GetString(4);
                    }

                }
                else
                {
                    MessageBox.Show("No se encontro el usuario");
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
    }
 }   


