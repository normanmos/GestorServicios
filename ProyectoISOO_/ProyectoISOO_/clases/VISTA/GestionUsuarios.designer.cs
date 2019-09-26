namespace ProyectoISOO_
{
    partial class GestionUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionUsuarios));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdep = new System.Windows.Forms.TextBox();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comotipo = new System.Windows.Forms.ComboBox();
            this.comodepartamento = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(22, 12);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(555, 139);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(94, 167);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 3;
            // 
            // txtnombre
            // 
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(259, 170);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 4;
            // 
            // txtdep
            // 
            this.txtdep.Enabled = false;
            this.txtdep.Location = new System.Drawing.Point(455, 197);
            this.txtdep.Name = "txtdep";
            this.txtdep.Size = new System.Drawing.Size(100, 20);
            this.txtdep.TabIndex = 5;
            // 
            // txtcontra
            // 
            this.txtcontra.Enabled = false;
            this.txtcontra.Location = new System.Drawing.Point(94, 193);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(100, 20);
            this.txtcontra.TabIndex = 6;
            // 
            // txttipo
            // 
            this.txttipo.Enabled = false;
            this.txttipo.Location = new System.Drawing.Point(455, 171);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(100, 20);
            this.txttipo.TabIndex = 7;
            // 
            // txtapellido
            // 
            this.txtapellido.Enabled = false;
            this.txtapellido.Location = new System.Drawing.Point(259, 196);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(100, 20);
            this.txtapellido.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(260, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 52);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(317, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 52);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tipo de Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Departamento";
            // 
            // comotipo
            // 
            this.comotipo.FormattingEnabled = true;
            this.comotipo.Location = new System.Drawing.Point(455, 171);
            this.comotipo.Name = "comotipo";
            this.comotipo.Size = new System.Drawing.Size(121, 21);
            this.comotipo.TabIndex = 18;
            this.comotipo.Visible = false;
            // 
            // comodepartamento
            // 
            this.comodepartamento.FormattingEnabled = true;
            this.comodepartamento.Location = new System.Drawing.Point(455, 196);
            this.comodepartamento.Name = "comodepartamento";
            this.comodepartamento.Size = new System.Drawing.Size(121, 21);
            this.comodepartamento.TabIndex = 19;
            this.comodepartamento.Visible = false;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(375, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 52);
            this.button4.TabIndex = 20;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // GestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 294);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comodepartamento);
            this.Controls.Add(this.comotipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txttipo);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.txtdep);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.dataGridView2);
            this.Name = "GestionUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionUsuarios";
            this.Load += new System.EventHandler(this.GestionUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdep;
        private System.Windows.Forms.TextBox txtcontra;
        private System.Windows.Forms.TextBox txttipo;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comotipo;
        private System.Windows.Forms.ComboBox comodepartamento;
        private System.Windows.Forms.Button button4;
    }
}