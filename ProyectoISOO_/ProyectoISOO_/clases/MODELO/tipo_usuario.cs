using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoISOO_.clases.MODELO
{
    class tipo_usuario
    {
        public int id { get; set; }
        public string descripcion { get; set; }

        public tipo_usuario() { }
        public tipo_usuario(int pid, string pdescripcion )
        {
            this.id = pid;
            this.descripcion = pdescripcion;
        }

    }
}
