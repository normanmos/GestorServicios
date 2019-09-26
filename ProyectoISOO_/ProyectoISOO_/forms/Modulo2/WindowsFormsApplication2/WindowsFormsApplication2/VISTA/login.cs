using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.Mysql;
using MySql.Data.MySqlClient;


namespace WindowsFormsApplication2
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void buttoningreso_Click(object sender, EventArgs e)
        {
            MySqlCommand ingreso = new MySqlCommand();
            MySqlConnection conecta = new MySqlConnection();
            ingreso.Connection = conexion.obtenerconexion();
            ingreso.CommandText = ("select nombre from usuario where idusuario = '" + textusuario.Text + "'and contrasena ='"+ txtcontra.Text +"' ");
            MySqlDataReader leer = ingreso.ExecuteReader();
            if (leer.Read())
            {
                seleccionmodulos s = new seleccionmodulos();
                s.labelusuario.Text = textusuario.Text;
                this.Hide();
                s.ShowDialog();  
            }

            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos");        
            }        
        }

        private void buttonsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtcontra_TextChanged(object sender, EventArgs e)
        {

        }

        private void textusuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
