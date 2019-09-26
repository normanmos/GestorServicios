namespace WindowsFormsApplication2
{
    partial class login
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
            this.labelUSUARIO = new System.Windows.Forms.Label();
            this.labelCONTRA = new System.Windows.Forms.Label();
            this.textusuario = new System.Windows.Forms.TextBox();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.buttoningreso = new System.Windows.Forms.Button();
            this.buttonsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUSUARIO
            // 
            this.labelUSUARIO.AutoSize = true;
            this.labelUSUARIO.Location = new System.Drawing.Point(43, 49);
            this.labelUSUARIO.Name = "labelUSUARIO";
            this.labelUSUARIO.Size = new System.Drawing.Size(56, 13);
            this.labelUSUARIO.TabIndex = 0;
            this.labelUSUARIO.Text = "USUARIO";
            // 
            // labelCONTRA
            // 
            this.labelCONTRA.AutoSize = true;
            this.labelCONTRA.Location = new System.Drawing.Point(18, 76);
            this.labelCONTRA.Name = "labelCONTRA";
            this.labelCONTRA.Size = new System.Drawing.Size(81, 13);
            this.labelCONTRA.TabIndex = 1;
            this.labelCONTRA.Text = "CONTRASEÑA";
            // 
            // textusuario
            // 
            this.textusuario.Location = new System.Drawing.Point(105, 46);
            this.textusuario.Name = "textusuario";
            this.textusuario.Size = new System.Drawing.Size(100, 20);
            this.textusuario.TabIndex = 2;
            this.textusuario.TextChanged += new System.EventHandler(this.textusuario_TextChanged);
            // 
            // txtcontra
            // 
            this.txtcontra.Location = new System.Drawing.Point(105, 73);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.PasswordChar = '*';
            this.txtcontra.Size = new System.Drawing.Size(100, 20);
            this.txtcontra.TabIndex = 3;
            this.txtcontra.TextChanged += new System.EventHandler(this.txtcontra_TextChanged);
            // 
            // buttoningreso
            // 
            this.buttoningreso.Location = new System.Drawing.Point(32, 129);
            this.buttoningreso.Name = "buttoningreso";
            this.buttoningreso.Size = new System.Drawing.Size(75, 23);
            this.buttoningreso.TabIndex = 4;
            this.buttoningreso.Text = "INGRESAR";
            this.buttoningreso.UseVisualStyleBackColor = true;
            this.buttoningreso.Click += new System.EventHandler(this.buttoningreso_Click);
            // 
            // buttonsalir
            // 
            this.buttonsalir.Location = new System.Drawing.Point(116, 129);
            this.buttonsalir.Name = "buttonsalir";
            this.buttonsalir.Size = new System.Drawing.Size(75, 23);
            this.buttonsalir.TabIndex = 5;
            this.buttonsalir.Text = "SALIR";
            this.buttonsalir.UseVisualStyleBackColor = true;
            this.buttonsalir.Click += new System.EventHandler(this.buttonsalir_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 195);
            this.Controls.Add(this.buttonsalir);
            this.Controls.Add(this.buttoningreso);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.textusuario);
            this.Controls.Add(this.labelCONTRA);
            this.Controls.Add(this.labelUSUARIO);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUSUARIO;
        private System.Windows.Forms.Label labelCONTRA;
        private System.Windows.Forms.TextBox textusuario;
        private System.Windows.Forms.TextBox txtcontra;
        private System.Windows.Forms.Button buttoningreso;
        private System.Windows.Forms.Button buttonsalir;
    }
}