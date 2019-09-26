namespace ProyectoISOO_.forms
{
    partial class GestionServicios
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbaplicacion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbplataforma = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbservidor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbaplicacion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbplataforma);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbservidor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 140);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Servicio";
            // 
            // cmbaplicacion
            // 
            this.cmbaplicacion.FormattingEnabled = true;
            this.cmbaplicacion.Location = new System.Drawing.Point(104, 103);
            this.cmbaplicacion.Name = "cmbaplicacion";
            this.cmbaplicacion.Size = new System.Drawing.Size(184, 21);
            this.cmbaplicacion.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Aplicacion:";
            // 
            // cmbplataforma
            // 
            this.cmbplataforma.FormattingEnabled = true;
            this.cmbplataforma.Location = new System.Drawing.Point(104, 76);
            this.cmbplataforma.Name = "cmbplataforma";
            this.cmbplataforma.Size = new System.Drawing.Size(184, 21);
            this.cmbplataforma.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Plataforma:";
            // 
            // cmbservidor
            // 
            this.cmbservidor.FormattingEnabled = true;
            this.cmbservidor.Location = new System.Drawing.Point(104, 49);
            this.cmbservidor.Name = "cmbservidor";
            this.cmbservidor.Size = new System.Drawing.Size(184, 21);
            this.cmbservidor.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Servidor:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(104, 23);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(184, 20);
            this.txtnombre.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            // 
            // btnguardar
            // 
            this.btnguardar.BackgroundImage = global::ProyectoISOO_.Properties.Resources.guardar;
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Location = new System.Drawing.Point(289, 159);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(33, 33);
            this.btnguardar.TabIndex = 21;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.Btnguardar_Click);
            // 
            // GestionServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 200);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.groupBox1);
            this.Name = "GestionServicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Servicios";
            this.Load += new System.EventHandler(this.GestionServicios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbaplicacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbplataforma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbservidor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnguardar;
    }
}