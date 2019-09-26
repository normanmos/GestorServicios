using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoISOO_.clases
{
    public class Modulo_3
    {
        public string param1 { get; set; }
        public string param2 { get; set; }
        public string param3 { get; set; }
        public string param4 { get; set; }
        public Modulo_3()
        {

        }

        public Modulo_3(string p1, string p2, string p3, string p4)
        {
            this.param1 = p1;
            this.param2 = p2;
            this.param3 = p3;
            this.param4 = p4;
        }
        //operaciones
        public static void Consulta(DataGridView grid, string procedure, string filtro)
        {
            if (filtro == "ninguno")
            {
                clases.Conexion conexion = new clases.Conexion();
                try
                {

                    conexion.AbrirConexion();
                    MySqlCommand cmd = new MySqlCommand(procedure, conexion.conexion);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    grid.DataSource = dt;
                    conexion.CerrarConexion();
                }
                catch (Exception ex)
                {
                    conexion.CerrarConexion();
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public static int Insertar(clases.Modulo_3 objeto, int opcion, int id,string procedimiento)
        {
            clases.Conexion conexion = new clases.Conexion();
            int retorno;
            MySqlCommand cmd;
            try
            {

                if (opcion == 0)
                {
                    conexion.AbrirConexion();
                    cmd = new MySqlCommand(procedimiento+"(@P1,@P2,@P3,@P4)", conexion.conexion);
                    cmd.Parameters.AddWithValue("@P1", objeto.param1);
                    cmd.Parameters.AddWithValue("@P2", objeto.param2);
                    cmd.Parameters.AddWithValue("@P3",objeto.param3);
                    cmd.Parameters.AddWithValue("@P4",objeto.param4);
                }
                else
                {
                    conexion.AbrirConexion();
                    cmd = new MySqlCommand(procedimiento + "(@P1,@P2,@P3,@ID)", conexion.conexion);
                    cmd.Parameters.AddWithValue("@P1", objeto.param1);
                    cmd.Parameters.AddWithValue("@P2", objeto.param2);
                    cmd.Parameters.AddWithValue("@P3", objeto.param3);
                    cmd.Parameters.AddWithValue("@ID", id);
                }
                retorno = cmd.ExecuteNonQuery();
                conexion.CerrarConexion();
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.CerrarConexion();
                return 0;
            }
        }

        public static int Eliminar(int id,string parametro)
        {
            int retorno;
            clases.Conexion conexion = new clases.Conexion();
            try
            {
                conexion.AbrirConexion();
                MySqlCommand cmd = new MySqlCommand(parametro+"(@ID)", conexion.conexion);
                cmd.Parameters.AddWithValue("@ID", id);
                retorno = cmd.ExecuteNonQuery();
                conexion.CerrarConexion();
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.CerrarConexion();
                return 0;
            }
        }
        public static void LlenarCombo(ComboBox combo,string procedimiento)
        {
            clases.Conexion conexion = new clases.Conexion();
            try
            {
                conexion.AbrirConexion();
                MySqlCommand cmd = new MySqlCommand(procedimiento, conexion.conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                combo.ValueMember = "ID";
                combo.DisplayMember = "NOMBRE";
                combo.DataSource = dt;
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.CerrarConexion();
            }
        }
    }
}