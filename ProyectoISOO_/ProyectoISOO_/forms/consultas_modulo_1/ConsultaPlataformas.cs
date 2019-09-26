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
    public partial class ConsultaPlataformas : Form
    {
        public ConsultaPlataformas()
        {
            InitializeComponent();
        }
        void CargaInicial()
        {
            try
            {
                string procedure = "PROC_CONSULTAR_PLATAFORMA";
                clases.Servidor.Consulta(dgplataforma, procedure, "ninguno");
                dgplataforma.Columns[0].HeaderText = "Código";
                dgplataforma.Columns[1].HeaderText = "Descripcion";
                dgplataforma.Columns[2].HeaderText = "Servidor";
                dgplataforma.Columns[3].HeaderText = "Tipo Plataforma";
                dgplataforma.AutoResizeColumns();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error);
            }
        }
        private void ConsultaPlataformas_Load(object sender, EventArgs e)
        {
            CargaInicial();
        }

        private void Btncrear_Click(object sender, EventArgs e)
        {
            bool estaAbierto = MenuPrincipal.ValidarApertura("GestionPlataformas");
            if (estaAbierto == true)
            {
                MessageBox.Show("EL FORMULARIO YA SE ENCUENTRA ABIERTO");
                Application.OpenForms["GestionPlataformas"].Focus();
            }
            else
            {
                forms.GestionPlataformas gestionPlataformas = new forms.GestionPlataformas();
                gestionPlataformas.ShowDialog();
                CargaInicial();
            }
        }

        private void Btnmodificar_Click(object sender, EventArgs e)
        {
            bool estaAbierto = MenuPrincipal.ValidarApertura("GestionPlataformas");
            if (estaAbierto == true)
            {
                MessageBox.Show("EL FORMULARIO YA SE ENCUENTRA ABIERTO");
                Application.OpenForms["GestionPlataformas"].Focus();
            }
            else
            {
                forms.GestionPlataformas gestionPlataformas = new forms.GestionPlataformas();
                gestionPlataformas.pIdPlataforma = Int32.Parse(dgplataforma.Rows[dgplataforma.CurrentRow.Index].Cells[0].Value.ToString());
                gestionPlataformas.pNombre = dgplataforma.Rows[dgplataforma.CurrentRow.Index].Cells[1].Value.ToString();
                gestionPlataformas.pServidor= dgplataforma.Rows[dgplataforma.CurrentRow.Index].Cells[2].Value.ToString();
                gestionPlataformas.pTipo = dgplataforma.Rows[dgplataforma.CurrentRow.Index].Cells[3].Value.ToString();
                gestionPlataformas.op_guardar = 1;
                gestionPlataformas.ShowDialog();
                CargaInicial();
            }
        }

        private void Btneliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Confirma que desea realizar la eliminacion?: " +
                dgplataforma.Rows[dgplataforma.CurrentRow.Index].Cells[1].Value.ToString() + ".", "ATENCION",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (clases.Plataforma.Eliminar(Int32.Parse(dgplataforma.Rows[dgplataforma.CurrentRow.Index].Cells[0].Value.ToString())) > 0)
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
