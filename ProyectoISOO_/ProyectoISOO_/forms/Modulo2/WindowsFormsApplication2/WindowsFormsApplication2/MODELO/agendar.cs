using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class agendar
    {
        public int id_agenda { get; set; }
        public int id_trabajo { get; set; }
        public string detalle { get; set; }
        public int id_servicio { get; set; }
        public int id_usuario { get; set; }
        public int id_departamento { get; set; }
        public int id_zona { get; set; }
        public int id_grupo { get; set; }
        public int id_estado { get; set; }

        public agendar() { }
        public agendar(int pid_agenda, int pid_trabajo, string pdetalle, int pid_servicio, int pid_usuario, int pid_departamento, int pid_zona, int pid_grupo, int pid_estado)
        {
            this.id_agenda = pid_agenda;
            this.id_trabajo = pid_trabajo;
            this.detalle = pdetalle;
            this.id_servicio = pid_servicio;
            this.id_usuario = pid_usuario;
            this.id_departamento = pid_departamento;
            this.id_zona = pid_zona;
            this.id_grupo = pid_grupo;
            this.id_estado = pid_estado;
        }
    }
}
