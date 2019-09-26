namespace ProyectoISOO_.forms.consultas_modulo_1
{
    partial class ConsultaTiposPlataformas
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgtipoplataforma = new System.Windows.Forms.DataGridView();
            this.btncrear = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgtipoplataforma)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tipos de plataformas disponibles";
            // 
            // dgtipoplataforma
            // 
            this.dgtipoplataforma.AllowUserToAddRows = false;
            this.dgtipoplataforma.AllowUserToDeleteRows = false;
            this.dgtipoplataforma.AllowUserToResizeColumns = false;
            this.dgtipoplataforma.AllowUserToResizeRows = false;
            this.dgtipoplataforma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtipoplataforma.Location = new System.Drawing.Point(12, 53);
            this.dgtipoplataforma.MultiSelect = false;
            this.dgtipoplataforma.Name = "dgtipoplataforma";
            this.dgtipoplataforma.ReadOnly = true;
            this.dgtipoplataforma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgtipoplataforma.Size = new System.Drawing.Size(470, 242);
            this.dgtipoplataforma.TabIndex = 34;
            // 
            // btncrear
            // 
            this.btncrear.BackgroundImage = global::ProyectoISOO_.Properties.Resources.añadir;
            this.btncrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncrear.FlatAppearance.BorderSize = 0;
            this.btncrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncrear.Location = new System.Drawing.Point(365, 307);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(33, 33);
            this.btncrear.TabIndex = 33;
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.Btncrear_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackgroundImage = global::ProyectoISOO_.Properties.Resources.editar;
            this.btnmodificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmodificar.FlatAppearance.BorderSize = 0;
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificar.Location = new System.Drawing.Point(410, 307);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(33, 33);
            this.btnmodificar.TabIndex = 31;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.Btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackgroundImage = global::ProyectoISOO_.Properties.Resources.eliminar;
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminar.FlatAppearance.BorderSize = 0;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Location = new System.Drawing.Point(449, 307);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(33, 33);
            this.btneliminar.TabIndex = 30;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.Btneliminar_Click);
            // 
            // ConsultaTiposPlataformas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 352);
            this.Controls.Add(this.dgtipoplataforma);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.label1);
            this.Name = "ConsultaTiposPlataformas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ConsultaTiposPlataformas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtipoplataforma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgtipoplataforma;
    }
}