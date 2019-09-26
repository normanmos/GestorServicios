namespace WindowsFormsApplication2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtdetalle = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.comboestados = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(41, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 52);
            this.button3.TabIndex = 14;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(205, 301);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 52);
            this.button5.TabIndex = 16;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(496, 150);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtdetalle
            // 
            this.txtdetalle.Location = new System.Drawing.Point(41, 235);
            this.txtdetalle.Multiline = true;
            this.txtdetalle.Name = "txtdetalle";
            this.txtdetalle.Size = new System.Drawing.Size(399, 60);
            this.txtdetalle.TabIndex = 21;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(41, 182);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 18;
            // 
            // comboestados
            // 
            this.comboestados.FormattingEnabled = true;
            this.comboestados.Location = new System.Drawing.Point(41, 208);
            this.comboestados.Name = "comboestados";
            this.comboestados.Size = new System.Drawing.Size(121, 21);
            this.comboestados.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(122, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 52);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboestados);
            this.Controls.Add(this.txtdetalle);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Name = "Form2";
            this.Text = "CONSULTS-MODIFICAR MANTENIMIENTO";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtdetalle;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.ComboBox comboestados;
        private System.Windows.Forms.Button button1;
    }
}