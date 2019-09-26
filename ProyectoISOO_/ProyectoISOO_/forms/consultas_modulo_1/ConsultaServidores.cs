using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoISOO_.forms.consultas_modulo_1
{
    public partial class ConsultaServidores : Form
    {
        public ConsultaServidores()
        {
            InitializeComponent();
        }        
                 
        void CargaInicial()
        {
            try
            {
                string procedure = "PROC_CONSULTAR_SERVIDOR";
                clases.Servidor.Consulta(dgservidores, procedure, "ninguno");
                dgservidores.Columns[0].HeaderText = "Código";
                dgservidores.Columns[1].HeaderText = "Nombre";
                dgservidores.Columns[2].HeaderText = "Dirección IP";
                dgservidores.AutoResizeColumns();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error);
            }
        }
        private void ConsultaServidores_Load(object sender, EventArgs e)
        {
            CargaInicial();
        }        

        private void Btncrear_Click(object sender, EventArgs e)
        {
            bool estaAbierto = MenuPrincipal.ValidarApertura("GestionServidores");
            if (estaAbierto == true)
            {
                MessageBox.Show("EL FORMULARIO YA SE ENCUENTRA ABIERTO");
                Application.OpenForms["GestionServidores"].Focus();
            }
            else
            {
                forms.GestionServidores gestionServidores = new forms.GestionServidores();
                gestionServidores.ShowDialog();
                CargaInicial();
            }            
        }

        private void Btnrefrescar_Click(object sender, EventArgs e)
        {
            CargaInicial();
        }

        private void Btnmodificar_Click(object sender, EventArgs e)
        {
            bool estaAbierto = MenuPrincipal.ValidarApertura("GestionServidores");
            if (estaAbierto == true)
            {
                MessageBox.Show("EL FORMULARIO YA SE ENCUENTRA ABIERTO");
                Application.OpenForms["GestionServidores"].Focus();
            }
            else
            {                
                forms.GestionServidores gestionServidores = new forms.GestionServidores();
                gestionServidores.pidservidor= Int32.Parse(dgservidores.Rows[dgservidores.CurrentRow.Index].Cells[0].Value.ToString());
                gestionServidores.pnombre= dgservidores.Rows[dgservidores.CurrentRow.Index].Cells[1].Value.ToString();
                gestionServidores.pip = dgservidores.Rows[dgservidores.CurrentRow.Index].Cells[2].Value.ToString();
                gestionServidores.op_guardar = 1;
                gestionServidores.ShowDialog();
                CargaInicial();
            }                        
        }

        private void Btneliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirma que desea eliminar el servidor: "+
                dgservidores.Rows[dgservidores.CurrentRow.Index].Cells[1].Value.ToString()+".","ATENCION",
                MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(result==DialogResult.Yes)
            {                
                if (clases.Servidor.Eliminar(Int32.Parse(dgservidores.Rows[dgservidores.CurrentRow.Index].Cells[0].Value.ToString()))> 0)
                {
                    MessageBox.Show("OPERACION CORRECTA", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargaInicial();
                }
                else
                {
                    MessageBox.Show("OPERACION INCORRECTA", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("OPERACION CANCELADA", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
