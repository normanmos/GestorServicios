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
    public class TipoPlataforma
    {
        public int IdTipoPlataforma { get; set; }
        public string Descripcion { get; set; }        
        public TipoPlataforma()
        {

        }

        public TipoPlataforma(int pIdTipoPlataforma, string pDescripcion)
        {
            this.IdTipoPlataforma = pIdTipoPlataforma;
            this.Descripcion = pDescripcion;            
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
                MySqlCommand cmd = new MySqlCommand("PROC_CONSULTAR_TIPO_PLATAFORMA", conexion.conexion);
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
        public static int Insertar(clases.TipoPlataforma objeto, int opcion, int id)
        {
            clases.Conexion conexion = new clases.Conexion();
            int retorno;
            MySqlCommand cmd;
            try
            {

                if (opcion == 0)
                {
                    conexion.AbrirConexion();
                    cmd = new MySqlCommand("PROC_INSERTAR_TIPO_PLATAFORMA(@NOMBRE)", conexion.conexion);
                    cmd.Parameters.AddWithValue("@NOMBRE", objeto.Descripcion);                    
                }
                else
                {                    
                    conexion.AbrirConexion();
                    cmd = new MySqlCommand("PROC_MODIFICAR_TIPO_PLATAFORMA(@NOMBRE,@ID)", conexion.conexion);
                    cmd.Parameters.AddWithValue("@NOMBRE", objeto.Descripcion);
                    cmd.Parameters.AddWithValue("@ID",id);                    
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
                MySqlCommand cmd = new MySqlCommand("PROC_ELIMINAR_TIPO_PLATAFORMA(@ID)", conexion.conexion);
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
