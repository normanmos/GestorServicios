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
            MySqlConnection conexion = new MySqlConnection("server=127.0.0.1;database=proyecto_isoo;uid=root;pwd=zeroandten316;");
            conexion.Open();
            return conexion;
        }
    }
}
