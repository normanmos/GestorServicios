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
    public class Aplicaciones
    {
        public int IdApp { get; set; }
        public string Descripcion { get; set; }
        public int IdPlataforma { get; set; }
        public string Start { get; set; }
        public string Stop { get; set; }
        public Aplicaciones()
        {

        }

        public Aplicaciones(int pIdApp, string pDescripcion, int pIdPlataforma, string pStart,string pStop)
        {
            this.IdApp = pIdApp;
            this.Descripcion = pDescripcion;
            this.IdPlataforma = pIdPlataforma;
            this.Start = pStart;
            this.Stop = pStop;
        }
        //operaciones
        public static void LlenarCombo(ComboBox combo)
        {
            clases.Conexion conexion = new clases.Conexion();
            try
            {
                conexion.AbrirConexion();
                MySqlCommand cmd = new MySqlCommand("PROC_CONSULTAR_APP", conexion.conexion);
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
        public static int Insertar(clases.Aplicaciones objeto, int opcion, int id)
        {
            clases.Conexion conexion = new clases.Conexion();
            int retorno;
            MySqlCommand cmd;
            try
            {

                if (opcion == 0)
                {
                    conexion.AbrirConexion();
                    cmd = new MySqlCommand("PROC_INSERTAR_APP(@NOMBRE,@PLATAFORMA,@START,@STOP)", conexion.conexion);
                    cmd.Parameters.AddWithValue("@NOMBRE", objeto.Descripcion);
                    cmd.Parameters.AddWithValue("@PLATAFORMA", objeto.IdPlataforma);
                    cmd.Parameters.AddWithValue("@START", objeto.Start);
                    cmd.Parameters.AddWithValue("@STOP",objeto.Stop);
                }
                else
                {
                    conexion.AbrirConexion();
                    cmd = new MySqlCommand("PROC_MODIFICAR_APP(@NOMBRE,@PLATAFORMA,@START,@STOP,@ID)", conexion.conexion);
                    cmd.Parameters.AddWithValue("@NOMBRE", objeto.Descripcion);
                    cmd.Parameters.AddWithValue("@PLATAFORMA", objeto.IdPlataforma);
                    cmd.Parameters.AddWithValue("@START", objeto.Start);
                    cmd.Parameters.AddWithValue("@STOP", objeto.Stop);
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
        public static int Eliminar(int id)
        {
            int retorno;
            clases.Conexion conexion = new clases.Conexion();
            try
            {
                conexion.AbrirConexion();
                MySqlCommand cmd = new MySqlCommand("PROC_ELIMINAR_APP(@ID)", conexion.conexion);
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
    }
}
