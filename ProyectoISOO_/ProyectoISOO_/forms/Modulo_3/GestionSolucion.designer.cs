namespace ProyectoISOO_.forms.Modulo_3
{
    partial class GestionSolucion
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
            this.btnguardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.BackgroundImage = global::ProyectoISOO_.Properties.Resources.guardar;
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.Location = new System.Drawing.Point(291, 202);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(33, 33);
            this.btnguardar.TabIndex = 10;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 184);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 148);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(104, 23);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(184, 119);
            this.txtnombre.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Escenario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Solucion:";
            // 
            // GestionSolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 247);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.groupBox1);
            this.Name = "GestionSolucion";
            this.Load += new System.EventHandler(this.GestionTemas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}