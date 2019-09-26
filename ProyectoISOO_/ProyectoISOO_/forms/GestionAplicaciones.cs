using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoISOO_.forms
{
    public partial class GestionAplicaciones : Form
    {
        public GestionAplicaciones()
        {
            InitializeComponent();
        }
        int opcion = 0;
        public int pidapp { get; set; }
        public string pNombre { set { txtnombre.Text = value; } }
        public string pidplataforma { set { cmbplataforma.ValueMember = value.ToString(); } }
        public string start { set { txtstart.Text = value; } }
        public string stop { set { txtkill.Text = value; } }
        public int op_guardar { set { opcion = 1; } }
        void ClearScreen()
        {
            txtnombre.Clear();
            txtkill.Clear();
            txtstart.Clear();
        }
        void mostrar_start_kill(int num)
        {
            switch (num)
            {
                case 1:
                    lblstart.Visible = true;
                    lblkill.Visible = true;
                    txtkill.Visible = true;
                    txtstart.Visible = true;
                break;
                case 0:
                    lblstart.Visible = false;
                    lblkill.Visible = false;
                    txtkill.Visible = false;
                    txtstart.Visible = false;
                break;
            }
        }
        private void Chkstartkill_CheckedChanged(object sender, EventArgs e)
        {
            if(chkstartkill.Checked)
            {
                mostrar_start_kill(1);
                //lblservidor.Visible = false;
                //cmbservidor.Visible = false;
                lblnombre.Visible = false;
                txtnombre.Visible = false;
                lblplataforma.Visible = false;
                cmbplataforma.Visible = false;
                groupBox1.Text = "Ingrese procedimientos";

            }
            else
            {
                mostrar_start_kill(0);
                //lblservidor.Visible = true;
                //cmbservidor.Visible = true;
                lblnombre.Visible = true;
                txtnombre.Visible = true;
                lblplataforma.Visible = true;
                cmbplataforma.Visible = true;
                groupBox1.Text = "Datos aplicacion";
            }
        }

        private void Btnbuscar_Click(object sender, EventArgs e)
        {
            forms.consultas_modulo_1.ConsultaAplicaciones app = new forms.consultas_modulo_1.ConsultaAplicaciones();
            app.Show();
        }

        private void GestionAplicaciones_Load(object sender, EventArgs e)
        {
            //clases.Servidor.LlenarCombo(cmbservidor);
            clases.Plataforma.LlenarCombo(cmbplataforma);
        }

        private void Btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                clases.Aplicaciones objeto = new clases.Aplicaciones();
                objeto.Descripcion = txtnombre.Text.ToUpper().Trim();
                objeto.IdPlataforma= Convert.ToInt32(cmbplataforma.SelectedValue);
                objeto.Start = txtstart.Text.ToUpper().Trim();
                objeto.Stop = txtkill.Text.ToUpper().Trim();

                if (txtnombre.Text != "" && clases.Aplicaciones.Insertar(objeto, opcion, pidapp) > 0)
                {
                    MessageBox.Show("Operacion Correcta", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearScreen();
                }
                else
                {
                    MessageBox.Show("Operacion Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error);
            }
        }
    }
}
