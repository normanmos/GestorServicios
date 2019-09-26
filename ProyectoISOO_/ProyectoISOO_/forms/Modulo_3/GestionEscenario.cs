using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoISOO_.forms.Modulo_3
{
    public partial class GestionEscenario : Form
    {
        public GestionEscenario()
        {
            InitializeComponent();
        }
        public int opcion { get; set;}
        public int id { get; set; }
        public string nombre { get; set; }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (opcion==0)
            {
                clases.Modulo_3 objeto = new clases.Modulo_3();
                objeto.param1 = txtnombre.Text.ToUpper().Trim();
                objeto.param2 = comboBox1.SelectedValue.ToString();
                clases.Modulo_3.Insertar(objeto, opcion, id, "PROC_INSERTAR_ESCENARIO");

            }else if (opcion ==1)
            {
                clases.Modulo_3 objeto = new clases.Modulo_3();
                objeto.param1 = txtnombre.Text.ToUpper().Trim();
                objeto.param2 = comboBox1.SelectedValue.ToString();
                clases.Modulo_3.Insertar(objeto, opcion, id, "PROC_MODIFICAR_ESCENARIO");
                txtnombre.Clear();
            }
            this.Close();
        }

        private void GestionTemas_Load(object sender, EventArgs e)
        {
            clases.Modulo_3.LlenarCombo(comboBox1,"PROC_CONSULTAR_TEMA");
            if (opcion == 1)
                txtnombre.Text = nombre;
        }
    }
}
