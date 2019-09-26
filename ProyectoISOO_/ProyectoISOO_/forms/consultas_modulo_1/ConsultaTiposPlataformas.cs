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
    public partial class ConsultaTiposPlataformas : Form
    {
        public ConsultaTiposPlataformas()
        {
            InitializeComponent();
        }
        void CargaInicial()
        {
            try
            {
                string procedure = "PROC_CONSULTAR_TIPO_PLATAFORMA";
                clases.Servidor.Consulta(dgtipoplataforma, procedure, "ninguno");
                dgtipoplataforma.Columns[0].HeaderText = "Código";
                dgtipoplataforma.Columns[1].HeaderText = "Descripcion";                
                dgtipoplataforma.AutoResizeColumns();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error);
            }
        }
        private void ConsultaTiposPlataformas_Load(object sender, EventArgs e)
        {
            CargaInicial();
        }

        private void Btncrear_Click(object sender, EventArgs e)
        {
            bool estaAbierto = MenuPrincipal.ValidarApertura("GestionTipoPlataforma");
            if (estaAbierto == true)
            {
                MessageBox.Show("EL FORMULARIO YA SE ENCUENTRA ABIERTO");
                Application.OpenForms["GestionTpoPlataforma"].Focus();
            }
            else
            {
                forms.GestionTpoPlataforma gestionTpoPlataforma = new forms.GestionTpoPlataforma();
                gestionTpoPlataforma.ShowDialog();
                CargaInicial();
            }
        }

        private void Btnmodificar_Click(object sender, EventArgs e)
        {
            bool estaAbierto = MenuPrincipal.ValidarApertura("GestionTpoPlataforma");
            if (estaAbierto == true)
            {
                MessageBox.Show("EL FORMULARIO YA SE ENCUENTRA ABIERTO");
                Application.OpenForms["GestionTpoPlataforma"].Focus();
            }
            else
            {
                forms.GestionTpoPlataforma gestionTpoPlataforma = new forms.GestionTpoPlataforma();
                gestionTpoPlataforma.pIdTipoPlataforma = Int32.Parse(dgtipoplataforma.Rows[dgtipoplataforma.CurrentRow.Index].Cells[0].Value.ToString());                
                gestionTpoPlataforma.pnombre = dgtipoplataforma.Rows[dgtipoplataforma.CurrentRow.Index].Cells[1].Value.ToString();
                gestionTpoPlataforma.op_guardar = 1;
                gestionTpoPlataforma.ShowDialog();
                CargaInicial();
            }
        }

        private void Btneliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Confirma que desea realizar la eliminacion?: " +
                dgtipoplataforma.Rows[dgtipoplataforma.CurrentRow.Index].Cells[1].Value.ToString() + ".", "ATENCION",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (clases.TipoPlataforma.Eliminar(Int32.Parse(dgtipoplataforma.Rows[dgtipoplataforma.CurrentRow.Index].Cells[0].Value.ToString())) > 0)
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
