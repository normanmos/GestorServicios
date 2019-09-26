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
    public partial class GestionPlataformas : Form
    {
        public GestionPlataformas()
        {
            InitializeComponent();
        }
        int opcion = 0;
        public int pIdPlataforma { get; set; }
        public string pNombre {  set { txtnombre.Text = value; } }   
        public string pServidor {  set { cmbservidor.ValueMember = value; } }
        public string pTipo {  set { cmbservidor.ValueMember = value; } }
        public int op_guardar {  set { opcion = 1; } }
        void ClearScreen()
        {            
            txtnombre.Clear();
        }     

        private void Btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                clases.Plataforma objeto = new clases.Plataforma();                
                objeto.Descripcion = txtnombre.Text.ToUpper().Trim(); 
                objeto.IdServidor = Convert.ToInt32(cmbservidor.SelectedValue);                
                objeto.IdTipoPlataforma = Convert.ToInt32(cmbtipoplataforma.SelectedValue);
                if (txtnombre.Text != "" && clases.Plataforma.Insertar(objeto, opcion, pIdPlataforma) > 0)
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

        private void GestionPlataformas_Load(object sender, EventArgs e)
        {            
            clases.Servidor.LlenarCombo(cmbservidor);
            clases.TipoPlataforma.LlenarCombo(cmbtipoplataforma);
        }        
    }
}
