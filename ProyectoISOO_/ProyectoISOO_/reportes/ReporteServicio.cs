using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoISOO_.reportes
{
    public partial class ReporteServicio : Form
    {
        public ReporteServicio()
        {
            InitializeComponent();
        }
        public int vista { get; set; }
        public void ReporteServicios()
        {
            reportViewer1.Visible = true;
            clases.Conexion conexion = new clases.Conexion();
                try
                {

                    conexion.AbrirConexion();
                    MySqlCommand cmd = new MySqlCommand("PROC_REPORTE_MODULO1", conexion.conexion);                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataSetServicio dt = new DataSetServicio();                
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    this.DataSetServicio.Clear();
                    da.SelectCommand = cmd;
                    da.Fill(this.DataSetServicio.Tables["servicio"]);
                    this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void ReporteSolucion()
        {
            clases.Conexion conexion = new clases.Conexion();
            try
            {
                reportViewer3.Visible = true;
                conexion.AbrirConexion();
                MySqlCommand cmd = new MySqlCommand("PROC_REPORTE_MODULO3", conexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                DataSetServicio dt = new DataSetServicio();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                this.DataSetServicio.Clear();
                da.SelectCommand = cmd;
                da.Fill(this.DataSetServicio.Tables["modulo3"]);
                this.reportViewer3.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void Reporte2()
        {
            clases.Conexion conexion = new clases.Conexion();
            try
            {
                reportViewer2.Visible = true;
                conexion.AbrirConexion();
                MySqlCommand cmd = new MySqlCommand("PROC_REPORTE_MODULO2", conexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                DataSetServicio dt = new DataSetServicio();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                this.DataSetServicio.Clear();
                da.SelectCommand = cmd;
                da.Fill(this.DataSetServicio.Tables["modulo2"]);
                this.reportViewer2.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ReporteServicio_Load(object sender, EventArgs e)
        {      
            switch(vista)
            {
                case 1:
                    ReporteServicios();
                    break;
                case 2:
                    Reporte2();
                    break;
                case 3:
                    ReporteSolucion();
                    break;
            }      
            
        }
    }
}
