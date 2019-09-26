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
    public partial class GestionServicios : Form
    {
        public GestionServicios()
        {
            InitializeComponent();
        }
        int opcion = 0;
        public int pideservicio { get; set; }
        public string pNombre { set { txtnombre.Text = value; } }
        public string pidapp { set { cmbaplicacion.ValueMember = value.ToString(); } }

        public string pidplataforma { set { cmbplataforma.ValueMember = value.ToString(); } }
        public string pservidor { set { cmbservidor.ValueMember = value.ToString(); } }

        public int op_guardar { set { opcion = 1; } }
        void ClearScreen()
        {
            txtnombre.Clear();            
        }
        private void Btnbuscar_Click(object sender, EventArgs e)
        {
            forms.consultas_modulo_1.ConsultaServicios serv = new forms.consultas_modulo_1.ConsultaServicios();
            serv.Show();
        }

        private void Btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                clases.Servicio objeto = new clases.Servicio();
                objeto.Descripcion = txtnombre.Text.ToUpper().Trim();
                objeto.IdApp = cmbaplicacion.SelectedValue.ToString();
                objeto.IdPlataforma = cmbplataforma.SelectedValue.ToString();
                objeto.IdServidor = cmbservidor.SelectedValue.ToString();
                if (txtnombre.Text != "" && clases.Servicio.Insertar(objeto, opcion, pideservicio) > 0)
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

        private void GestionServicios_Load(object sender, EventArgs e)
        {
            clases.Servidor.LlenarCombo(cmbservidor);
            clases.Plataforma.LlenarCombo(cmbplataforma);
            clases.Aplicaciones.LlenarCombo(cmbaplicacion);
        }
    }
}
