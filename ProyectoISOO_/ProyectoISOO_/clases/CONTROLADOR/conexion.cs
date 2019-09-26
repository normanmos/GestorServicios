using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2.Mysql
{
    class conexion
    {
        public static MySqlConnection obtenerconexion()
        {
            MySqlConnection conexion = new MySqlConnection("server=localhost;database=proyecto_isoo;uid=root;pwd=root;");
            conexion.Open();
            return conexion;
        }
    }
}
