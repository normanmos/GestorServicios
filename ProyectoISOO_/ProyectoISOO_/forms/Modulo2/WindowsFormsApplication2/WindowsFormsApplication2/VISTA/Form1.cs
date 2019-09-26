using System;
using WindowsFormsApplication2.Mysql;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboservicio.DataSource = ventana.ObtenerServicios();
            comboservicio.DisplayMember = "descripcion";
            comboservicio.ValueMember = "id";

            combodepartamento.DataSource = ventana.ObtenerDepartamento();
            combodepartamento.DisplayMember= "descripcion";
            combodepartamento.ValueMember = "id";

            combozona.DataSource = ventana.ObtenerZonas();
            combozona.DisplayMember = "descripcion";
            combozona.ValueMember = "id";

            combogrupo.DataSource = ventana.ObtenerGrupos();
            combogrupo.DisplayMember = "descripcion";
            combogrupo.ValueMember = "id";

            combotrabajo.DataSource = ventana.ObtenerTrabajos();
            combotrabajo.DisplayMember = "razon";
            combotrabajo.ValueMember = "id";

            comboestado.DataSource = ventana.ObtenerEstados();
            comboestado.DisplayMember = "descripcion";
            comboestado.ValueMember = "id";

            comboresponsable.DataSource = ventana.ObtenerUsuarios();
            comboresponsable.DisplayMember = "nombre";
            comboresponsable.ValueMember = "id";
             

            comboejecutor.DataSource = ventana.ObtenerUsuarios();
            comboejecutor.DisplayMember = "nombre";
            comboejecutor.ValueMember = "id";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime inicio = dateTimePicker1.Value;
            DateTime final = dateTimePicker2.Value;

            label5.Text = inicio.ToString("yyyy-MM-dd HH:mm:00");
            label6.Text = final.ToString("yyyy-MM-dd HH:mm:00");   
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conexion.obtenerconexion();
            MessageBox.Show("Conexion Se realizo con exito");
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TXTUSER_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string f1 = label5.Text;
            string f2 = label6.Text;

            if (f1== "Inicio no seleccionado" && f2== "Fin No seleccionado")
            {
                MessageBox.Show("Debe Seleccionar una Fecha");
                
            }

            else if (f1 == f2)
            {
                MessageBox.Show("La fecha y Hora Seleccionadas no pueden ser Iguales, intente de nuevo");
            }
            else
            {
                comboservicio.Enabled = true;
                combodepartamento.Enabled = true;
                combozona.Enabled = true;
                combogrupo.Enabled = true;
                comboestado.Enabled = true;
                textdetalle.Enabled = true;
                buttoningresar.Enabled = true;
                combotrabajo.Enabled = true;
            }  
        }

        private void textidejecutor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboejecutor_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttoningresar_Click(object sender, EventArgs e)
        {

            usuario_agenda u = new usuario_agenda();
          
            u.idusuario_creador = Convert.ToInt32(txtusuarioagenda.Text);
            
             u.idusuario_ejecutor = Convert.ToInt32(comboejecutor.SelectedValue);
            
            u.idusuario_responsable = Convert.ToInt32(comboresponsable.SelectedValue);
            
            u.fecha_inicio = label5.Text;
            u.fecha_fin = label6.Text;
            int respuesta = ventana.Agregar(u);

            if (respuesta > 0)
            {
                agendar a = new agendar();
                a.id_trabajo = Convert.ToInt32(combotrabajo.SelectedValue);
                a.detalle = textdetalle.Text;
                a.id_servicio = Convert.ToInt32(comboservicio.SelectedValue);
                a.id_departamento = Convert.ToInt32(combodepartamento.SelectedValue);
                a.id_zona = Convert.ToInt32(combozona.SelectedValue);
                a.id_grupo = Convert.ToInt32(combogrupo.SelectedValue);
                a.id_estado = Convert.ToInt32(comboestado.SelectedValue);
                int resultado = ventana.AgregarAgenda(a);
                if (resultado > 0)
                {
                    MessageBox.Show("Ingresado con exito");
                   
                }
                else
                {
                    MessageBox.Show("Error al Agendar Ventana");
                }
                
           }

           else
            {
                MessageBox.Show("Error Al Elegir Usuarios Involucrados");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            seleccionmodulos s = new seleccionmodulos();
            s.Show();
            this.Hide();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            textdetalle.Text = " ";
            comboservicio.Enabled = false;
            combodepartamento.Enabled = false;
            combozona.Enabled = false;
            combogrupo.Enabled = false;
            comboestado.Enabled = false;
            textdetalle.Enabled = false;
            buttoningresar.Enabled = false;
            combotrabajo.Enabled = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void monthCalendar1_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            seleccionmodulos s = new seleccionmodulos();
            s.Show();
        
        }
    }
}
