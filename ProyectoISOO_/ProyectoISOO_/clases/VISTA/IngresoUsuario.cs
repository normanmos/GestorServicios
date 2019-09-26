using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2;

namespace ProyectoISOO_.clases.VISTA
{
    public partial class IngresoUsuario : Form
    {
        ventana v = new ventana();
        public IngresoUsuario()
        {
            InitializeComponent();
        }

        private void combotipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IngresoUsuario_Load(object sender, EventArgs e)
        {
            combotipo.DataSource = ventana.Obtenertipos();
            combotipo.DisplayMember = "descripcion";
            combotipo.ValueMember = "id";

            combodep.DataSource = ventana.ObtenerDepartamento();
            combodep.DisplayMember = "descripcion";
            combodep.ValueMember = "id";
        }

        private void botoncrear_Click(object sender, EventArgs e)
        {
            usuario u = new usuario();
            u.id = txtid.Text;
            u.contrasena = txtcontra.Text;
            u.nombre = txtnombre.Text;
            u.apellido = txtapellido.Text;
            u.id_tipo = Convert.ToInt32(combotipo.SelectedValue);
            u.id_dpto = Convert.ToInt32(combodep.SelectedValue);
            
            int resultado = ventana.AgregarUsuario(u);
            if (resultado > 0)
            {
                MessageBox.Show("Ingresado con exito");

            }
            else
            {
                MessageBox.Show("Error al Crear Usuario");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MenuPrincipal m = new MenuPrincipal();
            this.Hide();
           // m.Show();
        }
    }
}
