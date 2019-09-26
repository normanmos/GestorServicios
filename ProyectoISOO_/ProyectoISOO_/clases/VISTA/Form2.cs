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
    public partial class Form2 : Form
    {
        ventana v = new ventana();
        public Form2()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public string usuario { get; set; }
        void load()
        {
            v.llenarGrid(dataGridView1);
            comboestados.DataSource = ventana.ObtenerEstados();
            comboestados.DisplayMember = "descripcion";
            comboestados.ValueMember = "id";
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          /*if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
              dataGridView1.CurrentRow.Selected = true;
                txtid.Text = dataGridView1.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                txtdetalle.Text= dataGridView1.Rows[e.RowIndex].Cells["DETALLE"].FormattedValue.ToString();


            }*/
            dataGridView1.CurrentRow.Selected = true;
            txtid.Text = dataGridView1.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
            txtdetalle.Text = dataGridView1.Rows[e.RowIndex].Cells["DETALLE"].FormattedValue.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            agendar a = new agendar();

            a.detalle = txtdetalle.Text;
            a.id_grupo = Convert.ToInt32(comboestados.SelectedValue);
            a.id_agenda = Convert.ToInt32(txtid.Text);

            int respuesta = ventana.ActulizarAgenda(a);
            if (respuesta > 0)
            {
                MessageBox.Show("Actualizado con Exito!!");
                load();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error!");
            }
        


        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            seleccionmodulos s = new seleccionmodulos();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            agendar a = new agendar();
            a.id_agenda = Convert.ToInt32(txtid.Text);

            int respuesta = ventana.EliminarAgenda(a);
            if (respuesta > 0)
            {
                MessageBox.Show("Eliminado con Exito!!");
                load();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error!");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
