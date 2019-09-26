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
    public partial class ConsultaServicios : Form
    {
        public ConsultaServicios()
        {
            InitializeComponent();
        }

        private void Btncrear_Click(object sender, EventArgs e)
        {
            bool estaAbierto = MenuPrincipal.ValidarApertura("GestionServicios");
            if (estaAbierto == true)
            {
                MessageBox.Show("EL FORMULARIO YA SE ENCUENTRA ABIERTO");
                Application.OpenForms["GestionServicios"].Focus();
            }
            else
            {
                forms.GestionServicios  gestionServicios= new forms.GestionServicios();
                gestionServicios.ShowDialog();
                CargaInicial();
            }
        }
        void CargaInicial()
        {
            try
            {
                string procedure = "PROC_CONSULTAR_SERVICIO";
                clases.Servicio.Consulta(dgservicios, procedure, "ninguno");
                dgservicios.Columns[0].HeaderText = "Código";
                dgservicios.Columns[1].HeaderText = "Descripcion";
                dgservicios.Columns[2].HeaderText = "Aplicacion";
                dgservicios.Columns[3].HeaderText = "Plataforma";
                dgservicios.Columns[4].HeaderText = "Servidor";
                dgservicios.AutoResizeColumns();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error);
            }
        }

        private void ConsultaServicios_Load(object sender, EventArgs e)
        {
            CargaInicial();
        }

        private void Btnmodificar_Click(object sender, EventArgs e)
        {
            bool estaAbierto = MenuPrincipal.ValidarApertura("GestionServicios");
            if (estaAbierto == true)
            {
                MessageBox.Show("EL FORMULARIO YA SE ENCUENTRA ABIERTO");
                Application.OpenForms["GestionServicios"].Focus();
            }
            else
            {
                forms.GestionServicios gestion = new forms.GestionServicios();
                gestion.pideservicio = Int32.Parse(dgservicios.Rows[dgservicios.CurrentRow.Index].Cells[0].Value.ToString());
                gestion.pNombre = dgservicios.Rows[dgservicios.CurrentRow.Index].Cells[1].Value.ToString();
                gestion.pidapp = dgservicios.Rows[dgservicios.CurrentRow.Index].Cells[2].Value.ToString();
                gestion.pidplataforma = dgservicios.Rows[dgservicios.CurrentRow.Index].Cells[3].Value.ToString();
                gestion.pservidor = dgservicios.Rows[dgservicios.CurrentRow.Index].Cells[4].Value.ToString();
                gestion.op_guardar = 1;
                gestion.ShowDialog();
                CargaInicial();
            }
        }

        private void Btneliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Confirma que desea realizar la eliminacion?: " +
               dgservicios.Rows[dgservicios.CurrentRow.Index].Cells[1].Value.ToString() + ".", "ATENCION",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (clases.Servicio.Eliminar(Int32.Parse(dgservicios.Rows[dgservicios.CurrentRow.Index].Cells[0].Value.ToString())) > 0)
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
