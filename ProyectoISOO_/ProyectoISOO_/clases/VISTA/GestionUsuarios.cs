using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoISOO_.clases;
using WindowsFormsApplication2;
using ProyectoISOO_.clases.MODELO;

namespace ProyectoISOO_
{
    public partial class GestionUsuarios : Form
    {
        ventana v = new ventana();
        public GestionUsuarios()
        {
            InitializeComponent();
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void botonbuscar_Click(object sender, EventArgs e)
        {
            
          
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            v.llenarGridUsuario(dataGridView2);

            comodepartamento.DataSource = ventana.ObtenerDepartamento();
            comodepartamento.DisplayMember = "descripcion";
            comodepartamento.ValueMember = "id";

            comotipo.DataSource = ventana.Obtenertipos();
            comotipo.DisplayMember = "descripcion";
            comotipo.ValueMember = "id";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.CurrentRow.Selected = true;
            txtid.Text = dataGridView2.Rows[e.RowIndex].Cells["idusuario"].FormattedValue.ToString();
            txtcontra.Text = dataGridView2.Rows[e.RowIndex].Cells["contrasena"].FormattedValue.ToString();
            txtnombre.Text = dataGridView2.Rows[e.RowIndex].Cells["nombre"].FormattedValue.ToString();
            txtapellido.Text = dataGridView2.Rows[e.RowIndex].Cells["apellido"].FormattedValue.ToString();
            txttipo.Text = dataGridView2.Rows[e.RowIndex].Cells["descripcion"].FormattedValue.ToString();
            txtdep.Text = dataGridView2.Rows[e.RowIndex].Cells["descripcion1"].FormattedValue.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            usuario u = new usuario();

            u.id = txtid.Text;
            u.contrasena = txtcontra.Text;
            u.id_tipo = Convert.ToInt32(comotipo.SelectedValue);
            u.id_dpto = Convert.ToInt32(comodepartamento.SelectedValue); 

            int respuesta = ventana.ActulizarUsuario(u);
            if (respuesta > 0)
            {
                MessageBox.Show("Actualizado con Exito!!");
                v.llenarGridUsuario(dataGridView2);

            }
            else
            {
                MessageBox.Show("Ha ocurrido un error!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            txtcontra.Enabled = true;
            comodepartamento.Visible = true;
            comotipo.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
           tipo_usuario a = new tipo_usuario();
            a.id = Convert.ToInt32(txtid.Text);

            int respuesta = ventana.EliminarUsuario(a);
            if (respuesta > 0)
            {
                MessageBox.Show("Eliminado con Exito!!");
                v.llenarGridUsuario(dataGridView2);

            }
            else
            {
                MessageBox.Show("Ha ocurrido un error!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MenuPrincipal m = new MenuPrincipal();
            this.Hide();
            m.Show();
        }
    }
}
