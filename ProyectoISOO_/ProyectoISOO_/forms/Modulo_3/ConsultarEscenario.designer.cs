namespace ProyectoISOO_.forms.Modulo_3
{
    partial class ConsultarEscenario
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
            this.dgapp = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btncrear = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgapp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgapp
            // 
            this.dgapp.AllowUserToAddRows = false;
            this.dgapp.AllowUserToDeleteRows = false;
            this.dgapp.AllowUserToResizeColumns = false;
            this.dgapp.AllowUserToResizeRows = false;
            this.dgapp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgapp.Location = new System.Drawing.Point(12, 49);
            this.dgapp.MultiSelect = false;
            this.dgapp.Name = "dgapp";
            this.dgapp.ReadOnly = true;
            this.dgapp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgapp.Size = new System.Drawing.Size(462, 256);
            this.dgapp.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 29);
            this.label1.TabIndex = 38;
            this.label1.Text = "Escenarios Disponibles";
            // 
            // btncrear
            // 
            this.btncrear.BackgroundImage = global::ProyectoISOO_.Properties.Resources.añadir;
            this.btncrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncrear.FlatAppearance.BorderSize = 0;
            this.btncrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncrear.Location = new System.Drawing.Point(357, 313);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(33, 33);
            this.btncrear.TabIndex = 41;
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackgroundImage = global::ProyectoISOO_.Properties.Resources.editar;
            this.btnmodificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmodificar.FlatAppearance.BorderSize = 0;
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificar.Location = new System.Drawing.Point(402, 313);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(33, 33);
            this.btnmodificar.TabIndex = 40;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackgroundImage = global::ProyectoISOO_.Properties.Resources.eliminar;
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminar.FlatAppearance.BorderSize = 0;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Location = new System.Drawing.Point(441, 313);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(33, 33);
            this.btneliminar.TabIndex = 39;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // ConsultarEscenario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 355);
            this.Controls.Add(this.dgapp);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.label1);
            this.Name = "ConsultarEscenario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ConsultarTema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgapp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgapp;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label label1;
    }
}