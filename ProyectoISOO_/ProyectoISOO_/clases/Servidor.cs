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
    public class Servidor
    {
        public int IdServidor { get; set; }
        public string Nombre { get; set; }
        public string DireccionIP { get; set; }
        public Servidor()
        {

        }
        public Servidor(int pIdServidor, string pNombre, string pDireccionIP)
        {
            this.IdServidor = pIdServidor;
            this.Nombre = pNombre;
            this.DireccionIP = pDireccionIP;
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
        public static int Insertar(clases.Servidor objeto, int opcion,int id)
        {
            clases.Conexion conexion = new clases.Conexion();
            int retorno;
            try
            {

                if (opcion == 0)
                {                    
                    conexion.AbrirConexion();
                    MySqlCommand cmd = new MySqlCommand("PROC_INSERTAR_SERVIDOR(@NOMBRE,@IP)", conexion.conexion);
                    cmd.Parameters.AddWithValue("@NOMBRE", objeto.Nombre);
                    cmd.Parameters.AddWithValue("@IP", objeto.DireccionIP);
                    retorno = cmd.ExecuteNonQuery();
                    conexion.CerrarConexion();
                    return retorno;
                }
                else
                {                                    
                    conexion.AbrirConexion();
                    MySqlCommand cmd2 = new MySqlCommand("PROC_MODIFICAR_SERVIDOR(@NOMBRE,@IP,@ID)", conexion.conexion);
                    cmd2.Parameters.AddWithValue("@NOMBRE", objeto.Nombre);
                    cmd2.Parameters.AddWithValue("@IP", objeto.DireccionIP);
                    cmd2.Parameters.AddWithValue("@ID",id);
                    retorno = cmd2.ExecuteNonQuery();
                    conexion.CerrarConexion();
                    return retorno;                                                
                }
                
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
                MySqlCommand cmd = new MySqlCommand("PROC_ELIMINAR_SERVIDOR(@ID)", conexion.conexion);                
                cmd.Parameters.AddWithValue("@ID",id);
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
        public static void LlenarCombo(ComboBox combo)
        {            
            clases.Conexion conexion = new clases.Conexion();
            try
            {
                conexion.AbrirConexion();
                MySqlCommand cmd = new MySqlCommand("PROC_CONSULTAR_SERVIDOR", conexion.conexion);
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
