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
            ingreso.CommandText = ("select idtipo_usuario from usuario where idusuario = '" + textusuario.Text + "'and contrasena ='"+ txtcontra.Text +"' ");
            MySqlDataReader leer = ingreso.ExecuteReader();
            if (leer.Read())
            {
                if(leer.GetString(0)=="1")
                {
                    //ADMIN
                    ProyectoISOO_.MenuPrincipal s = new ProyectoISOO_.MenuPrincipal();
                    s.usuario_id= textusuario.Text;
                    
                    s.tipo_usuario = "0";
                    this.Hide();
                    s.ShowDialog();  
                }else if (leer.GetString(0)=="2")
                {
                    //OPERADOR
                    ProyectoISOO_.MenuPrincipal s = new ProyectoISOO_.MenuPrincipal();
                    s.usuario_id = textusuario.Text;
                    s.tipo_usuario = "1";
                    this.Hide();
                    s.ShowDialog();
                }
                
            } else
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtcontra.UseSystemPasswordChar == false)
            txtcontra.UseSystemPasswordChar = true;
            else
                txtcontra.UseSystemPasswordChar = false;
        }
    }
}
