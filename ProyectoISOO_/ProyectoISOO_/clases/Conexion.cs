using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoISOO_.clases
{
    public class Conexion
    {
        public MySqlConnection conexion;
        public string server;
        public string database;
        public string userid;
        public string password;
        public Conexion()
        {
            server = "localhost";
            database = "proyecto_isoo";
            userid = "root";
            password = "root";
            string SentenciaConexion;
            SentenciaConexion = "SERVER=" + server + ";" +
                                "DATABASE=" + database + ";" +
                                "UID=" + userid + ";" +
                                "PASSWORD=" + password + ";";
            conexion = new MySqlConnection(SentenciaConexion);
        }

        public bool AbrirConexion()
        {
            try
            {
                conexion.Open();
                return true;
            }
            catch (MySqlException error)
            {
                Console.WriteLine("Error en apertura [" + error.Number + "]: " + error.Message);
                return false;
            }
        }

        public bool CerrarConexion()
        {
            try
            {
                conexion.Close();
                return true;
            }
            catch (MySqlException error)
            {
                Console.WriteLine("Error al cerrar [" + error.Number + "]: " + error.Message);
                return false;
            }
        }

    }
}
