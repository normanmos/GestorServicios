using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class usuario_agenda
    {
        public int idusuario_agenda { get; set; }
        public string idusuario_creador { get; set; }
        public string idusuario_responsable { get; set; }
        public string idusuario_ejecutor { get; set; }
        public string fecha_inicio { get; set; }
        public string fecha_fin { get; set; }

        public usuario_agenda() { }
        public usuario_agenda(int pidusuario_agenda, string pidusuario_creador, string pidusuario_responsable, string pidusuario_ejecutor, string pfecha_incio, string pfecha_fin)
        {
            this.idusuario_agenda = pidusuario_agenda;
            this.idusuario_creador = pidusuario_creador;
            this.idusuario_responsable = pidusuario_responsable;
            this.idusuario_ejecutor = pidusuario_ejecutor;
            this.fecha_inicio = pfecha_incio;
            this.fecha_fin = pfecha_fin;
        }
    }
}
