using ProyectoISOO_.clases.VISTA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ProyectoISOO_
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        public string usuario_id { get; set; }
        public string tipo_usuario { get; set; }
        public static bool ValidarApertura(string formulario)
        {
            bool abierto = false;
            if (Application.OpenForms[formulario] != null)
                abierto = true;
            return abierto;
        }


        void visiblidad (string tipo_usuario)
        {
            if (tipo_usuario == "1")
            {
                modulo1ToolStripMenuItem.Visible = false;
                modulo2ToolStripMenuItem.Visible = false;
                modulo3ToolStripMenuItem.Visible = false;
                usuariosToolStripMenuItem.Visible = false;
            }         
        }
        private void ServidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool estaAbierto = ValidarApertura("ConsultaServidores");
            if (estaAbierto == true)
            {
                MessageBox.Show("EL FORMULARIO YA SE ENCUENTRA ABIERTO");
                Application.OpenForms["ConsultaServidores"].Focus();
            }
            else
            {                
                forms.consultas_modulo_1.ConsultaServidores servidores = new forms.consultas_modulo_1.ConsultaServidores();
                servidores.Show();
            }
        }

        private void PlataformasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool estaAbierto = ValidarApertura("ConsultaPlataformas");
            if (estaAbierto == true)
            {
                MessageBox.Show("EL FORMULARIO YA SE ENCUENTRA ABIERTO");
                Application.OpenForms["ConsultaPlataformas"].Focus();
            }
            else
            {
                forms.consultas_modulo_1.ConsultaPlataformas platforma = new forms.consultas_modulo_1.ConsultaPlataformas();
                platforma.Show();
            }
            
        }

        private void AplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool estaAbierto = ValidarApertura("ConsultaAplicaciones");
            if (estaAbierto == true)
            {
                MessageBox.Show("EL FORMULARIO YA SE ENCUENTRA ABIERTO");
                Application.OpenForms["ConsultaAplicaciones"].Focus();
            }
            else
            {
                forms.consultas_modulo_1.ConsultaAplicaciones app = new forms.consultas_modulo_1.ConsultaAplicaciones();
                app.Show();
            }            
        }

        private void ServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool estaAbierto = ValidarApertura("ConsultaServicios");
            if (estaAbierto == true)
            {
                MessageBox.Show("EL FORMULARIO YA SE ENCUENTRA ABIERTO");
                Application.OpenForms["ConsultaServicios"].Focus();
            }
            else
            {
                forms.consultas_modulo_1.ConsultaServicios serv = new forms.consultas_modulo_1.ConsultaServicios();
                serv.Show();
            }
            
        }

        private void TiposDePlataformasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            bool estaAbierto = ValidarApertura("ConsultaTiposPlataformas");
            if (estaAbierto == true)
            {
                MessageBox.Show("EL FORMULARIO YA SE ENCUENTRA ABIERTO");
                Application.OpenForms["ConsultaTiposPlataformas"].Focus();
            }
            else
            {
                forms.consultas_modulo_1.ConsultaTiposPlataformas tiposPlataformas = new forms.consultas_modulo_1.ConsultaTiposPlataformas();
                tiposPlataformas.Show();
            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            visiblidad(tipo_usuario);
        }

        private void modulo1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*bool estaAbierto = ValidarApertura("ReporteServicio");
            if (estaAbierto is true)
            {*/
            if(ValidarApertura("ReporteServicio")==true)
            { 
                MessageBox.Show("EL FORMULARIO YA SE ENCUENTRA ABIERTO");
                Application.OpenForms["ReporteServicio"].Focus();
            }
            else
            {
                reportes.ReporteServicio reporte = new reportes.ReporteServicio();
                reporte.vista = 1;
                reporte.Show();
            }
        }

        private void agendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication2.Form1 f = new WindowsFormsApplication2.Form1();
            f.usuario = usuario_id;
            f.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication2.Form2 a = new WindowsFormsApplication2.Form2();
            a.usuario = usuario_id;
            a.ShowDialog();
        }

        private void modulo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionUsuarios g = new GestionUsuarios();
            //this.Hide();
            g.Show();
        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresoUsuario iu =  new IngresoUsuario();

            iu.Show();
            //this.Hide();
        }

        private void temaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.Modulo_3.ConsultarTema c = new forms.Modulo_3.ConsultarTema();
            c.Show();
        }

        private void escenarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.Modulo_3.ConsultarEscenario c = new forms.Modulo_3.ConsultarEscenario();
            c.Show();
        }

        private void solucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.Modulo_3.ConsultaSolucion c = new forms.Modulo_3.ConsultaSolucion();
            c.Show();
        }

        private void modulo2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            reportes.ReporteServicio reporte = new reportes.ReporteServicio();
            reporte.vista = 2;
            reporte.Show();
        }

        private void modulo3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            reportes.ReporteServicio reporte = new reportes.ReporteServicio();
            reporte.vista = 3;
            reporte.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
