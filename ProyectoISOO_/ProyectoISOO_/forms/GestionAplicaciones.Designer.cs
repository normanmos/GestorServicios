namespace ProyectoISOO_.forms
{
    partial class GestionAplicaciones
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
            this.lblkill = new System.Windows.Forms.Label();
            this.chkstartkill = new System.Windows.Forms.CheckBox();
            this.txtstart = new System.Windows.Forms.TextBox();
            this.cmbplataforma = new System.Windows.Forms.ComboBox();
            this.lblstart = new System.Windows.Forms.Label();
            this.lblplataforma = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtkill = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblkill);
            this.groupBox1.Controls.Add(this.chkstartkill);
            this.groupBox1.Controls.Add(this.txtstart);
            this.groupBox1.Controls.Add(this.cmbplataforma);
            this.groupBox1.Controls.Add(this.lblstart);
            this.groupBox1.Controls.Add(this.lblplataforma);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.lblnombre);
            this.groupBox1.Controls.Add(this.txtkill);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 126);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Aplicacion";
            // 
            // lblkill
            // 
            this.lblkill.AutoSize = true;
            this.lblkill.Location = new System.Drawing.Point(17, 52);
            this.lblkill.Name = "lblkill";
            this.lblkill.Size = new System.Drawing.Size(23, 13);
            this.lblkill.TabIndex = 22;
            this.lblkill.Text = "Kill:";
            this.lblkill.Visible = false;
            // 
            // chkstartkill
            // 
            this.chkstartkill.AutoSize = true;
            this.chkstartkill.Location = new System.Drawing.Point(28, 103);
            this.chkstartkill.Name = "chkstartkill";
            this.chkstartkill.Size = new System.Drawing.Size(256, 17);
            this.chkstartkill.TabIndex = 12;
            this.chkstartkill.Text = "Click para revisar START y KILL de la aplicación";
            this.chkstartkill.UseVisualStyleBackColor = true;
            this.chkstartkill.CheckedChanged += new System.EventHandler(this.Chkstartkill_CheckedChanged);
            // 
            // txtstart
            // 
            this.txtstart.Location = new System.Drawing.Point(104, 23);
            this.txtstart.Name = "txtstart";
            this.txtstart.Size = new System.Drawing.Size(184, 20);
            this.txtstart.TabIndex = 14;
            this.txtstart.Visible = false;
            // 
            // cmbplataforma
            // 
            this.cmbplataforma.FormattingEnabled = true;
            this.cmbplataforma.Location = new System.Drawing.Point(104, 48);
            this.cmbplataforma.Name = "cmbplataforma";
            this.cmbplataforma.Size = new System.Drawing.Size(184, 21);
            this.cmbplataforma.TabIndex = 11;
            // 
            // lblstart
            // 
            this.lblstart.AutoSize = true;
            this.lblstart.Location = new System.Drawing.Point(17, 26);
            this.lblstart.Name = "lblstart";
            this.lblstart.Size = new System.Drawing.Size(32, 13);
            this.lblstart.TabIndex = 13;
            this.lblstart.Text = "Start:";
            this.lblstart.Visible = false;
            // 
            // lblplataforma
            // 
            this.lblplataforma.AutoSize = true;
            this.lblplataforma.Location = new System.Drawing.Point(17, 51);
            this.lblplataforma.Name = "lblplataforma";
            this.lblplataforma.Size = new System.Drawing.Size(60, 13);
            this.lblplataforma.TabIndex = 10;
            this.lblplataforma.Text = "Plataforma:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 12;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(104, 23);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(184, 20);
            this.txtnombre.TabIndex = 6;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(17, 26);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(47, 13);
            this.lblnombre.TabIndex = 4;
            this.lblnombre.Text = "Nombre:";
            // 
            // btnguardar
            // 
            this.btnguardar.BackgroundImage = global::ProyectoISOO_.Properties.Resources.guardar;
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.Location = new System.Drawing.Point(291, 144);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(33, 33);
            this.btnguardar.TabIndex = 20;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.Btnguardar_Click);
            // 
            // txtkill
            // 
            this.txtkill.Location = new System.Drawing.Point(104, 49);
            this.txtkill.Name = "txtkill";
            this.txtkill.Size = new System.Drawing.Size(184, 20);
            this.txtkill.TabIndex = 23;
            this.txtkill.Visible = false;
            // 
            // GestionAplicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 186);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.groupBox1);
            this.Name = "GestionAplicaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionAplicaciones";
            this.Load += new System.EventHandler(this.GestionAplicaciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.ComboBox cmbplataforma;
        private System.Windows.Forms.Label lblplataforma;
        private System.Windows.Forms.CheckBox chkstartkill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtstart;
        private System.Windows.Forms.Label lblstart;
        private System.Windows.Forms.Label lblkill;
        private System.Windows.Forms.TextBox txtkill;
    }
}