namespace ProyectoISOO_.reportes
{
    partial class ReporteServicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.servicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetServicio = new ProyectoISOO_.reportes.DataSetServicio();
            this.modulo3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulo3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // servicioBindingSource
            // 
            this.servicioBindingSource.DataMember = "servicio";
            this.servicioBindingSource.DataSource = this.DataSetServicio;
            // 
            // DataSetServicio
            // 
            this.DataSetServicio.DataSetName = "DataSetServicio";
            this.DataSetServicio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modulo3BindingSource
            // 
            this.modulo3BindingSource.DataMember = "modulo3";
            this.modulo3BindingSource.DataSource = this.DataSetServicio;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetServicio";
            reportDataSource1.Value = this.servicioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoISOO_.reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1227, 433);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Visible = false;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "ProyectoISOO_.reportes.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(1227, 433);
            this.reportViewer2.TabIndex = 1;
            this.reportViewer2.Visible = false;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "modulo3";
            reportDataSource2.Value = this.modulo3BindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "ProyectoISOO_.reportes.Report3.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 0);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(1227, 433);
            this.reportViewer3.TabIndex = 2;
            this.reportViewer3.Visible = false;
            // 
            // ReporteServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 433);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteServicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReporteServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulo3BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource servicioBindingSource;
        private DataSetServicio DataSetServicio;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource modulo3BindingSource;
    }
}