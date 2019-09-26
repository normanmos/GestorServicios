namespace WindowsFormsApplication2
{
    partial class seleccionmodulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(seleccionmodulos));
            this.labelusuario = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modulo1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulo2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarVentanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarModificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulo3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelusuario
            // 
            this.labelusuario.AutoSize = true;
            this.labelusuario.Location = new System.Drawing.Point(3, 184);
            this.labelusuario.Name = "labelusuario";
            this.labelusuario.Size = new System.Drawing.Size(41, 13);
            this.labelusuario.TabIndex = 3;
            this.labelusuario.Text = "usuario";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modulo1ToolStripMenuItem,
            this.modulo2ToolStripMenuItem,
            this.modulo3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(253, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modulo1ToolStripMenuItem
            // 
            this.modulo1ToolStripMenuItem.Name = "modulo1ToolStripMenuItem";
            this.modulo1ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.modulo1ToolStripMenuItem.Text = "Modulo1";
            // 
            // modulo2ToolStripMenuItem
            // 
            this.modulo2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendarVentanaToolStripMenuItem,
            this.consultarModificarToolStripMenuItem});
            this.modulo2ToolStripMenuItem.Name = "modulo2ToolStripMenuItem";
            this.modulo2ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.modulo2ToolStripMenuItem.Text = "Modulo2";
            // 
            // agendarVentanaToolStripMenuItem
            // 
            this.agendarVentanaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agendarVentanaToolStripMenuItem.Image")));
            this.agendarVentanaToolStripMenuItem.Name = "agendarVentanaToolStripMenuItem";
            this.agendarVentanaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.agendarVentanaToolStripMenuItem.Text = "Agendar Ventana";
            this.agendarVentanaToolStripMenuItem.Click += new System.EventHandler(this.agendarVentanaToolStripMenuItem_Click);
            // 
            // consultarModificarToolStripMenuItem
            // 
            this.consultarModificarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultarModificarToolStripMenuItem.Image")));
            this.consultarModificarToolStripMenuItem.Name = "consultarModificarToolStripMenuItem";
            this.consultarModificarToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.consultarModificarToolStripMenuItem.Text = "Consultar-Modificar";
            this.consultarModificarToolStripMenuItem.Click += new System.EventHandler(this.consultarModificarToolStripMenuItem_Click);
            // 
            // modulo3ToolStripMenuItem
            // 
            this.modulo3ToolStripMenuItem.Name = "modulo3ToolStripMenuItem";
            this.modulo3ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.modulo3ToolStripMenuItem.Text = "Modulo3";
            // 
            // seleccionmodulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 206);
            this.Controls.Add(this.labelusuario);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "seleccionmodulos";
            this.Text = "seleccionmodulos";
            this.Load += new System.EventHandler(this.seleccionmodulos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label labelusuario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modulo1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modulo2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendarVentanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarModificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modulo3ToolStripMenuItem;
    }
}