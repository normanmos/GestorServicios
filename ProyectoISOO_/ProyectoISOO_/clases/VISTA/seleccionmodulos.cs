using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class seleccionmodulos : Form
    {
        public seleccionmodulos()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.txtusuarioagenda.Text = labelusuario.Text;
            f.Show();
            this.Hide();
        }

        private void agendarVentanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.txtusuarioagenda.Text = labelusuario.Text;
            f.ShowDialog();
            this.Hide();
        }

        private void consultarModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void seleccionmodulos_Load(object sender, EventArgs e)
        {

        }
    }
}
