namespace ProyectoISOO_.forms.consultas_modulo_1
{
    partial class ConsultaServidores
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
            this.dgservidores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnrefrescar = new System.Windows.Forms.Button();
            this.btncrear = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgservidores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgservidores
            // 
            this.dgservidores.AllowUserToAddRows = false;
            this.dgservidores.AllowUserToDeleteRows = false;
            this.dgservidores.AllowUserToResizeColumns = false;
            this.dgservidores.AllowUserToResizeRows = false;
            this.dgservidores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgservidores.Location = new System.Drawing.Point(12, 58);
            this.dgservidores.MultiSelect = false;
            this.dgservidores.Name = "dgservidores";
            this.dgservidores.ReadOnly = true;
            this.dgservidores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgservidores.Size = new System.Drawing.Size(372, 256);
            this.dgservidores.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Servidores disponibles";
            // 
            // btnrefrescar
            // 
            this.btnrefrescar.BackgroundImage = global::ProyectoISOO_.Properties.Resources.refrescar_3;
            this.btnrefrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnrefrescar.FlatAppearance.BorderSize = 0;
            this.btnrefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefrescar.Location = new System.Drawing.Point(234, 320);
            this.btnrefrescar.Name = "btnrefrescar";
            this.btnrefrescar.Size = new System.Drawing.Size(33, 33);
            this.btnrefrescar.TabIndex = 27;
            this.btnrefrescar.UseVisualStyleBackColor = true;
            this.btnrefrescar.Click += new System.EventHandler(this.Btnrefrescar_Click);
            // 
            // btncrear
            // 
            this.btncrear.BackgroundImage = global::ProyectoISOO_.Properties.Resources.añadir;
            this.btncrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncrear.FlatAppearance.BorderSize = 0;
            this.btncrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncrear.Location = new System.Drawing.Point(273, 320);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(33, 33);
            this.btncrear.TabIndex = 26;
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.Btncrear_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackgroundImage = global::ProyectoISOO_.Properties.Resources.editar;
            this.btnmodificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmodificar.FlatAppearance.BorderSize = 0;
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificar.Location = new System.Drawing.Point(312, 320);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(33, 33);
            this.btnmodificar.TabIndex = 24;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.Btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackgroundImage = global::ProyectoISOO_.Properties.Resources.eliminar;
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminar.FlatAppearance.BorderSize = 0;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Location = new System.Drawing.Point(351, 320);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(33, 33);
            this.btneliminar.TabIndex = 23;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.Btneliminar_Click);
            // 
            // ConsultaServidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 363);
            this.Controls.Add(this.btnrefrescar);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgservidores);
            this.Name = "ConsultaServidores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ConsultaServidores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgservidores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgservidores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnrefrescar;
    }
}