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
    public class Servicio
    {
        public int IdServicio { get; set; }
        public string Descripcion { get; set; }
        public string IdApp { get; set; }
        public string IdPlataforma { get; set; }
        public string IdServidor { get; set; }
        public Servicio()
        {

        }

        public Servicio(int pIdServicio, string pDescripcion, string pIdApp, string pIdPlataforma,string pIdServidor)
        {
            this.IdServicio = pIdServicio;
            this.Descripcion = pDescripcion;
            this.IdApp = pIdApp;
            this.IdPlataforma = pIdPlataforma;
            this.IdServidor = pIdServidor;
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
        public static int Insertar(clases.Servicio objeto, int opcion, int id)
        {
            clases.Conexion conexion = new clases.Conexion();
            int retorno;
            MySqlCommand cmd;
            try
            {

                if (opcion == 0)
                {
                    conexion.AbrirConexion();
                    cmd = new MySqlCommand("PROC_INSERTAR_SERVICIO(@NOMBRE,@APP,@PLATAFORMA,@SERVIDOR)", conexion.conexion);
                    cmd.Parameters.AddWithValue("@NOMBRE", objeto.Descripcion);
                    cmd.Parameters.AddWithValue("@APP",objeto.IdApp);
                    cmd.Parameters.AddWithValue("@PLATAFORMA", objeto.IdPlataforma);
                    cmd.Parameters.AddWithValue("@SERVIDOR",objeto.IdServidor);

                }
                else
                {
                    conexion.AbrirConexion();
                    cmd = new MySqlCommand("PROC_MODIFICAR_SERVICIO(@NOMBRE,@APP,@PLATAFORMA,@SERVIDOR,@ID)", conexion.conexion);
                    cmd.Parameters.AddWithValue("@NOMBRE", objeto.Descripcion);                    
                    cmd.Parameters.AddWithValue("@APP", objeto.IdApp);
                    cmd.Parameters.AddWithValue("@PLATAFORMA", objeto.IdPlataforma);
                    cmd.Parameters.AddWithValue("@SERVIDOR", objeto.IdServidor);
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
                MySqlCommand cmd = new MySqlCommand("PROC_ELIMINAR_SERVICIO(@ID)", conexion.conexion);
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