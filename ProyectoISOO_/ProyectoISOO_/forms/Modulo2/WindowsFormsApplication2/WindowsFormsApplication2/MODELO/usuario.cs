using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class usuario
    {
        public int id { get; set; }
        public string contrasena { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int id_tipo { get; set; }
        public int id_dpto { get; set; }

        public usuario() { }
        public usuario (int pid, string pcontrasena, string pnombre, string papellido, int pid_tipo, int pid_dpto)
        {
            this.id = pid;
            this.contrasena = pcontrasena;
            this.nombre = pnombre;
            this.apellido = papellido;
            this.id_tipo = pid_tipo;
            this.id_dpto = pid_dpto;
        }
        
    }
}
