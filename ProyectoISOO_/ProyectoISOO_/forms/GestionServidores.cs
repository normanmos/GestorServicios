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
    public partial class GestionServidores : Form
    {
        public GestionServidores()
        {
            InitializeComponent();
        }
        //variables globalaes        
        int opcion= 0;
        public int pidservidor { get; set; }
        public string pnombre { set { txtnombre.Text = value; } }
        public string pip { set {txtip.Text=value; } }
        public int op_guardar { set { opcion = 1; } }
        //funciones
        void ClearScreen()
        {
            txtip.Clear();
            txtnombre.Clear();
        }
        
        private void Btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                clases.Servidor objeto = new clases.Servidor();
                objeto.Nombre = txtnombre.Text.ToUpper().Trim();
                objeto.DireccionIP = txtip.Text.ToUpper().Trim();    
                    if (txtnombre.Text != "" && txtip.Text != "" && clases.Servidor.Insertar(objeto, opcion,pidservidor) > 0)
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

        private void GestionServidores_Load(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
