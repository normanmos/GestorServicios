using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoISOO_.forms.consultas_modulo_1
{
    public partial class ConsultaAplicaciones : Form
    {
        public ConsultaAplicaciones()
        {
            InitializeComponent();
        }
        void CargaInicial()
        {
            try
            {
                string procedure = "PROC_CONSULTAR_APP";
                clases.Aplicaciones.Consulta(dgapp, procedure, "ninguno");
                dgapp.Columns[0].HeaderText = "Código";
                dgapp.Columns[1].HeaderText = "Nombre";
                dgapp.Columns[2].HeaderText = "Plataforma";
                dgapp.Columns[3].HeaderText = "Start";
                dgapp.Columns[4].HeaderText = "Stop";
                dgapp.AutoResizeColumns();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error);
            }
        }
        private void Btncrear_Click(object sender, EventArgs e)
        {
            bool estaAbierto = MenuPrincipal.ValidarApertura("GestionAplicaciones");
            if (estaAbierto == true)
            {
                MessageBox.Show("EL FORMULARIO YA SE ENCUENTRA ABIERTO");
                Application.OpenForms["GestionAplicaciones"].Focus();
            }
            else
            {
                forms.GestionAplicaciones aplicaciones = new forms.GestionAplicaciones();
                aplicaciones.ShowDialog();
                CargaInicial();
            }
            
        }

        private void ConsultaAplicaciones_Load(object sender, EventArgs e)
        {
            CargaInicial();
        }

        private void Btnmodificar_Click(object sender, EventArgs e)
        {
            bool estaAbierto = MenuPrincipal.ValidarApertura("GestionAplicaciones");
            if (estaAbierto == true)
            {
                MessageBox.Show("EL FORMULARIO YA SE ENCUENTRA ABIERTO");
                Application.OpenForms["GestionAplicaciones"].Focus();
            }
            else
            {
                forms.GestionAplicaciones gestion = new forms.GestionAplicaciones();
                gestion.pidapp = Int32.Parse(dgapp.Rows[dgapp.CurrentRow.Index].Cells[0].Value.ToString());
                gestion.pNombre = dgapp.Rows[dgapp.CurrentRow.Index].Cells[1].Value.ToString();
                gestion.pidplataforma = dgapp.Rows[dgapp.CurrentRow.Index].Cells[2].Value.ToString();
                gestion.start = dgapp.Rows[dgapp.CurrentRow.Index].Cells[3].Value.ToString();
                gestion.stop = dgapp.Rows[dgapp.CurrentRow.Index].Cells[4].Value.ToString();
                gestion.op_guardar = 1;
                gestion.ShowDialog();
                CargaInicial();
            }
        }

        private void Btneliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Confirma que desea realizar la eliminacion?: " +
               dgapp.Rows[dgapp.CurrentRow.Index].Cells[1].Value.ToString() + ".", "ATENCION",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (clases.Aplicaciones.Eliminar(Int32.Parse(dgapp.Rows[dgapp.CurrentRow.Index].Cells[0].Value.ToString())) > 0)
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
