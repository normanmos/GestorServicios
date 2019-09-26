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
    public class Plataforma
    {
        public int IdPlataforma { get; set; }
        public string Descripcion { get; set; }
        public int IdServidor { get; set; }
        public int IdTipoPlataforma { get; set; }
        public Plataforma()
        {

        }

        public Plataforma(int pIdPlataforma, string pDescripcion, int pIdServidor,int pIdTipoPlataforma)
        {
            this.IdTipoPlataforma = pIdTipoPlataforma;
            this.Descripcion = pDescripcion;
            this.IdServidor = pIdServidor;
            this.IdTipoPlataforma = pIdTipoPlataforma;
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
        public static void LlenarCombo(ComboBox combo)
        {
            clases.Conexion conexion = new clases.Conexion();
            try
            {
                conexion.AbrirConexion();
                MySqlCommand cmd = new MySqlCommand("PROC_CONSULTAR_PLATAFORMA", conexion.conexion);
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
        public static int Insertar(clases.Plataforma objeto, int opcion, int id)
        {
            clases.Conexion conexion = new clases.Conexion();
            int retorno;
            MySqlCommand cmd;
            try
            {

                if (opcion == 0)
                {
                    conexion.AbrirConexion();
                    cmd = new MySqlCommand("PROC_INSERTAR_PLATAFORMA(@NOMBRE,@SERVIDOR,@TIPO)", conexion.conexion);
                    cmd.Parameters.AddWithValue("@NOMBRE", objeto.Descripcion);
                    cmd.Parameters.AddWithValue("@SERVIDOR",objeto.IdServidor);
                    cmd.Parameters.AddWithValue("@TIPO",objeto.IdTipoPlataforma);
                }
                else
                {
                    conexion.AbrirConexion();
                    cmd = new MySqlCommand("PROC_MODIFICAR_PLATAFORMA(@NOMBRE,@SERVIDOR,@TIPO,@ID)", conexion.conexion);
                    cmd.Parameters.AddWithValue("@NOMBRE", objeto.Descripcion);
                    cmd.Parameters.AddWithValue("@SERVIDOR", objeto.IdServidor);
                    cmd.Parameters.AddWithValue("@TIPO", objeto.IdTipoPlataforma);
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
                MySqlCommand cmd = new MySqlCommand("PROC_ELIMINAR_PLATAFORMA(@ID)", conexion.conexion);
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
