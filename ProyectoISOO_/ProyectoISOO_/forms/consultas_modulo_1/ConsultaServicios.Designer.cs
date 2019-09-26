namespace ProyectoISOO_.forms.consultas_modulo_1
{
    partial class ConsultaServicios
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
            this.dgservicios = new System.Windows.Forms.DataGridView();
            this.btncrear = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgservicios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Servicios Disponibles";
            // 
            // dgservicios
            // 
            this.dgservicios.AllowUserToAddRows = false;
            this.dgservicios.AllowUserToDeleteRows = false;
            this.dgservicios.AllowUserToOrderColumns = true;
            this.dgservicios.AllowUserToResizeColumns = false;
            this.dgservicios.AllowUserToResizeRows = false;
            this.dgservicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgservicios.Location = new System.Drawing.Point(12, 52);
            this.dgservicios.MultiSelect = false;
            this.dgservicios.Name = "dgservicios";
            this.dgservicios.ReadOnly = true;
            this.dgservicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgservicios.Size = new System.Drawing.Size(498, 256);
            this.dgservicios.TabIndex = 4;
            // 
            // btncrear
            // 
            this.btncrear.BackgroundImage = global::ProyectoISOO_.Properties.Resources.añadir;
            this.btncrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncrear.FlatAppearance.BorderSize = 0;
            this.btncrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncrear.Location = new System.Drawing.Point(399, 316);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(33, 33);
            this.btncrear.TabIndex = 29;
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.Btncrear_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackgroundImage = global::ProyectoISOO_.Properties.Resources.editar;
            this.btnmodificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmodificar.FlatAppearance.BorderSize = 0;
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificar.Location = new System.Drawing.Point(438, 316);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(33, 33);
            this.btnmodificar.TabIndex = 28;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.Btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackgroundImage = global::ProyectoISOO_.Properties.Resources.eliminar;
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminar.FlatAppearance.BorderSize = 0;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Location = new System.Drawing.Point(477, 316);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(33, 33);
            this.btneliminar.TabIndex = 27;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.Btneliminar_Click);
            // 
            // ConsultaServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 358);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgservicios);
            this.Name = "ConsultaServicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de servicios actuales";
            this.Load += new System.EventHandler(this.ConsultaServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgservicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgservicios;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
    }
}