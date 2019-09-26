namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textdetalle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttoningresar = new System.Windows.Forms.Button();
            this.labelUSER = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelDEP = new System.Windows.Forms.Label();
            this.labeLZONA = new System.Windows.Forms.Label();
            this.labelservicio = new System.Windows.Forms.Label();
            this.labelGrupo = new System.Windows.Forms.Label();
            this.labelESTADO = new System.Windows.Forms.Label();
            this.comboservicio = new System.Windows.Forms.ComboBox();
            this.combodepartamento = new System.Windows.Forms.ComboBox();
            this.combozona = new System.Windows.Forms.ComboBox();
            this.combogrupo = new System.Windows.Forms.ComboBox();
            this.comboestado = new System.Windows.Forms.ComboBox();
            this.txtusuarioagenda = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboresponsable = new System.Windows.Forms.ComboBox();
            this.comboejecutor = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.combotrabajo = new System.Windows.Forms.ComboBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "lblinicio";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AccessibleDescription = "lblfinal";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "btngenerarfecha";
            this.button1.Location = new System.Drawing.Point(9, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generar Fecha";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de Inicio Seleccionada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha de Fin Seleccionada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Inicio no seleccionado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fin No seleccionado";
            // 
            // textdetalle
            // 
            this.textdetalle.Enabled = false;
            this.textdetalle.Location = new System.Drawing.Point(244, 199);
            this.textdetalle.Multiline = true;
            this.textdetalle.Name = "textdetalle";
            this.textdetalle.Size = new System.Drawing.Size(217, 123);
            this.textdetalle.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "DETALLE";
            // 
            // buttoningresar
            // 
            this.buttoningresar.BackColor = System.Drawing.Color.White;
            this.buttoningresar.Enabled = false;
            this.buttoningresar.Image = ((System.Drawing.Image)(resources.GetObject("buttoningresar.Image")));
            this.buttoningresar.Location = new System.Drawing.Point(284, 341);
            this.buttoningresar.Name = "buttoningresar";
            this.buttoningresar.Size = new System.Drawing.Size(52, 45);
            this.buttoningresar.TabIndex = 12;
            this.buttoningresar.UseVisualStyleBackColor = false;
            this.buttoningresar.Click += new System.EventHandler(this.buttoningresar_Click);
            // 
            // labelUSER
            // 
            this.labelUSER.AutoSize = true;
            this.labelUSER.Location = new System.Drawing.Point(315, 18);
            this.labelUSER.Name = "labelUSER";
            this.labelUSER.Size = new System.Drawing.Size(112, 13);
            this.labelUSER.TabIndex = 14;
            this.labelUSER.Text = "USUARIO CREADOR";
            this.labelUSER.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 16;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // labelDEP
            // 
            this.labelDEP.AutoSize = true;
            this.labelDEP.Location = new System.Drawing.Point(15, 223);
            this.labelDEP.Name = "labelDEP";
            this.labelDEP.Size = new System.Drawing.Size(97, 13);
            this.labelDEP.TabIndex = 18;
            this.labelDEP.Text = "DEPARTAMENTO";
            this.labelDEP.Click += new System.EventHandler(this.label11_Click);
            // 
            // labeLZONA
            // 
            this.labeLZONA.AutoSize = true;
            this.labeLZONA.Location = new System.Drawing.Point(74, 250);
            this.labeLZONA.Name = "labeLZONA";
            this.labeLZONA.Size = new System.Drawing.Size(37, 13);
            this.labeLZONA.TabIndex = 19;
            this.labeLZONA.Text = "ZONA";
            // 
            // labelservicio
            // 
            this.labelservicio.AutoSize = true;
            this.labelservicio.Location = new System.Drawing.Point(54, 196);
            this.labelservicio.Name = "labelservicio";
            this.labelservicio.Size = new System.Drawing.Size(57, 13);
            this.labelservicio.TabIndex = 23;
            this.labelservicio.Text = "SERVICIO";
            // 
            // labelGrupo
            // 
            this.labelGrupo.AutoSize = true;
            this.labelGrupo.Location = new System.Drawing.Point(6, 277);
            this.labelGrupo.Name = "labelGrupo";
            this.labelGrupo.Size = new System.Drawing.Size(106, 13);
            this.labelGrupo.TabIndex = 24;
            this.labelGrupo.Text = "GRUPO AFECTADO";
            // 
            // labelESTADO
            // 
            this.labelESTADO.AutoSize = true;
            this.labelESTADO.Location = new System.Drawing.Point(60, 304);
            this.labelESTADO.Name = "labelESTADO";
            this.labelESTADO.Size = new System.Drawing.Size(51, 13);
            this.labelESTADO.TabIndex = 25;
            this.labelESTADO.Text = "ESTADO";
            // 
            // comboservicio
            // 
            this.comboservicio.Enabled = false;
            this.comboservicio.FormattingEnabled = true;
            this.comboservicio.Location = new System.Drawing.Point(117, 193);
            this.comboservicio.Name = "comboservicio";
            this.comboservicio.Size = new System.Drawing.Size(121, 21);
            this.comboservicio.TabIndex = 29;
            this.comboservicio.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // combodepartamento
            // 
            this.combodepartamento.Enabled = false;
            this.combodepartamento.FormattingEnabled = true;
            this.combodepartamento.Location = new System.Drawing.Point(117, 220);
            this.combodepartamento.Name = "combodepartamento";
            this.combodepartamento.Size = new System.Drawing.Size(121, 21);
            this.combodepartamento.TabIndex = 30;
            // 
            // combozona
            // 
            this.combozona.Enabled = false;
            this.combozona.FormattingEnabled = true;
            this.combozona.Location = new System.Drawing.Point(117, 247);
            this.combozona.Name = "combozona";
            this.combozona.Size = new System.Drawing.Size(121, 21);
            this.combozona.TabIndex = 31;
            // 
            // combogrupo
            // 
            this.combogrupo.Enabled = false;
            this.combogrupo.FormattingEnabled = true;
            this.combogrupo.Location = new System.Drawing.Point(117, 274);
            this.combogrupo.Name = "combogrupo";
            this.combogrupo.Size = new System.Drawing.Size(121, 21);
            this.combogrupo.TabIndex = 32;
            // 
            // comboestado
            // 
            this.comboestado.Enabled = false;
            this.comboestado.FormattingEnabled = true;
            this.comboestado.Location = new System.Drawing.Point(117, 301);
            this.comboestado.Name = "comboestado";
            this.comboestado.Size = new System.Drawing.Size(121, 21);
            this.comboestado.TabIndex = 33;
            // 
            // txtusuarioagenda
            // 
            this.txtusuarioagenda.Enabled = false;
            this.txtusuarioagenda.Location = new System.Drawing.Point(318, 34);
            this.txtusuarioagenda.Name = "txtusuarioagenda";
            this.txtusuarioagenda.Size = new System.Drawing.Size(121, 20);
            this.txtusuarioagenda.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(315, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "RESPONSABLE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(315, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "EJECUTOR";
            // 
            // comboresponsable
            // 
            this.comboresponsable.FormattingEnabled = true;
            this.comboresponsable.Location = new System.Drawing.Point(318, 113);
            this.comboresponsable.Name = "comboresponsable";
            this.comboresponsable.Size = new System.Drawing.Size(121, 21);
            this.comboresponsable.TabIndex = 37;
            // 
            // comboejecutor
            // 
            this.comboejecutor.FormattingEnabled = true;
            this.comboejecutor.Location = new System.Drawing.Point(318, 73);
            this.comboejecutor.Name = "comboejecutor";
            this.comboejecutor.Size = new System.Drawing.Size(121, 21);
            this.comboejecutor.TabIndex = 38;
            this.comboejecutor.SelectedIndexChanged += new System.EventHandler(this.comboejecutor_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(318, 140);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 39;
            this.button5.Text = "AGENDAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(55, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "TRABAJO";
            // 
            // combotrabajo
            // 
            this.combotrabajo.Enabled = false;
            this.combotrabajo.FormattingEnabled = true;
            this.combotrabajo.Location = new System.Drawing.Point(117, 166);
            this.combotrabajo.Name = "combotrabajo";
            this.combotrabajo.Size = new System.Drawing.Size(121, 21);
            this.combotrabajo.TabIndex = 43;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.White;
            this.btnlimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnlimpiar.Image")));
            this.btnlimpiar.Location = new System.Drawing.Point(409, 341);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(52, 45);
            this.btnlimpiar.TabIndex = 45;
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:00";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(160, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 20);
            this.dateTimePicker1.TabIndex = 46;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd HH:mm:00";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(160, 90);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(136, 20);
            this.dateTimePicker2.TabIndex = 47;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(351, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 45);
            this.button2.TabIndex = 48;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.combotrabajo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboejecutor);
            this.Controls.Add(this.comboresponsable);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtusuarioagenda);
            this.Controls.Add(this.comboestado);
            this.Controls.Add(this.combogrupo);
            this.Controls.Add(this.combozona);
            this.Controls.Add(this.combodepartamento);
            this.Controls.Add(this.comboservicio);
            this.Controls.Add(this.labelESTADO);
            this.Controls.Add(this.labelGrupo);
            this.Controls.Add(this.labelservicio);
            this.Controls.Add(this.labeLZONA);
            this.Controls.Add(this.labelDEP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelUSER);
            this.Controls.Add(this.buttoningresar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textdetalle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "AGENDAR MANTENIMIENTO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textdetalle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttoningresar;
        private System.Windows.Forms.Label labelUSER;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelDEP;
        private System.Windows.Forms.Label labeLZONA;
        private System.Windows.Forms.Label labelservicio;
        private System.Windows.Forms.Label labelGrupo;
        private System.Windows.Forms.Label labelESTADO;
        private System.Windows.Forms.ComboBox comboservicio;
        private System.Windows.Forms.ComboBox combodepartamento;
        private System.Windows.Forms.ComboBox combozona;
        private System.Windows.Forms.ComboBox combogrupo;
        private System.Windows.Forms.ComboBox comboestado;
        public System.Windows.Forms.TextBox txtusuarioagenda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboresponsable;
        private System.Windows.Forms.ComboBox comboejecutor;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox combotrabajo;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button2;
    }
}

