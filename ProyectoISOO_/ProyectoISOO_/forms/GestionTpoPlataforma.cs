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
    public partial class GestionTpoPlataforma : Form
    {
        public GestionTpoPlataforma()
        {
            InitializeComponent();
        }
        int opcion = 0;
        public int pIdTipoPlataforma { get; set; }
        public string pnombre { set { txtnombre.Text = value; } }        
        public int op_guardar { set { opcion = 1; } }
        void ClearScreen()
        {            
            txtnombre.Clear();
        }
        private void Btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                clases.TipoPlataforma objeto = new clases.TipoPlataforma();
                objeto.Descripcion = txtnombre.Text.ToUpper().Trim();                
                if (txtnombre.Text != "" && clases.TipoPlataforma.Insertar(objeto, opcion, pIdTipoPlataforma) > 0)
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
