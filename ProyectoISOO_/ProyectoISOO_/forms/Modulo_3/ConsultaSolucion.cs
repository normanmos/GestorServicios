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
    public partial class ConsultaSolucion : Form
    {
        public ConsultaSolucion()
        {
            InitializeComponent();
        }
        void CargaInicial()
        {
            try
            {
                string procedure = "PROC_CONSULTAR_SOLUCION";
                clases.Modulo_3.Consulta(dgapp, procedure, "ninguno");
                dgapp.Columns[0].HeaderText = "Código";
                dgapp.Columns[1].HeaderText = "Solucion";
                dgapp.Columns[2].HeaderText = "Escenario";
                dgapp.AutoResizeColumns();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error);
            }
        }
        private void ConsultarTema_Load(object sender, EventArgs e)
        {
            CargaInicial();
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            forms.Modulo_3.GestionSolucion tema = new forms.Modulo_3.GestionSolucion();
            tema.opcion = 0;
            tema.ShowDialog();
            CargaInicial();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            forms.Modulo_3.GestionSolucion tema = new forms.Modulo_3.GestionSolucion();
            tema.opcion = 1;
            tema.id= Int32.Parse(dgapp.Rows[dgapp.CurrentRow.Index].Cells[0].Value.ToString());
            tema.nombre = dgapp.Rows[dgapp.CurrentRow.Index].Cells[1].Value.ToString();
            tema.ShowDialog();
            CargaInicial();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Confirma que desea realizar la eliminacion?: " +
               dgapp.Rows[dgapp.CurrentRow.Index].Cells[1].Value.ToString() + ".", "ATENCION",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (clases.Modulo_3.Eliminar(Int32.Parse(dgapp.Rows[dgapp.CurrentRow.Index].Cells[0].Value.ToString()),"PROC_ELIMINAR_SOLUCION") > 0)
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
