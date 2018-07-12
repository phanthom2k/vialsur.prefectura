namespace vialsur.prefectura.Personal
{
    partial class frmMiPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMiPerfil));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.ltxt_Apellidos = new Vivaldi.UserControls.LettersTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ltxt_Nombres = new Vivaldi.UserControls.LettersTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ntxt_Cedula = new Vivaldi.UserControls.NumericTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtp_FechaDesactivacion = new System.Windows.Forms.DateTimePicker();
            this.dtp_FechaActivacion = new System.Windows.Forms.DateTimePicker();
            this.uc_TIPOUSUARIO1 = new vialsur.prefectura.uc.uc_TIPOUSUARIO();
            this.uc_CARGO1 = new vialsur.prefectura.uc.uc_CARGO();
            this.chk_Activo = new System.Windows.Forms.CheckBox();
            this.atxt_Observaciones = new Vivaldi.AlfaTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(615, 342);
            this.tabControl1.TabIndex = 49;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dtp_FechaNacimiento);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ltxt_Apellidos);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.ltxt_Nombres);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.ntxt_Cedula);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(607, 313);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos Persona";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "CEDULA:";
            // 
            // dtp_FechaNacimiento
            // 
            this.dtp_FechaNacimiento.CalendarMonthBackground = System.Drawing.Color.SkyBlue;
            this.dtp_FechaNacimiento.CalendarTrailingForeColor = System.Drawing.Color.Red;
            this.dtp_FechaNacimiento.Enabled = false;
            this.dtp_FechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaNacimiento.Location = new System.Drawing.Point(191, 89);
            this.dtp_FechaNacimiento.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dtp_FechaNacimiento.Name = "dtp_FechaNacimiento";
            this.dtp_FechaNacimiento.Size = new System.Drawing.Size(228, 22);
            this.dtp_FechaNacimiento.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "NOMBRES:";
            // 
            // ltxt_Apellidos
            // 
            this.ltxt_Apellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ltxt_Apellidos.Enabled = false;
            this.ltxt_Apellidos.Location = new System.Drawing.Point(104, 63);
            this.ltxt_Apellidos.MaxLength = 150;
            this.ltxt_Apellidos.Name = "ltxt_Apellidos";
            this.ltxt_Apellidos.Size = new System.Drawing.Size(315, 22);
            this.ltxt_Apellidos.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "APELLIDOS:";
            // 
            // ltxt_Nombres
            // 
            this.ltxt_Nombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ltxt_Nombres.Enabled = false;
            this.ltxt_Nombres.Location = new System.Drawing.Point(104, 37);
            this.ltxt_Nombres.MaxLength = 150;
            this.ltxt_Nombres.Name = "ltxt_Nombres";
            this.ltxt_Nombres.Size = new System.Drawing.Size(315, 22);
            this.ltxt_Nombres.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "FECHA DE NACIMIENTO:";
            // 
            // ntxt_Cedula
            // 
            this.ntxt_Cedula.AllowSpace = false;
            this.ntxt_Cedula.Enabled = false;
            this.ntxt_Cedula.Location = new System.Drawing.Point(104, 11);
            this.ntxt_Cedula.MaxLength = 10;
            this.ntxt_Cedula.Name = "ntxt_Cedula";
            this.ntxt_Cedula.Size = new System.Drawing.Size(180, 22);
            this.ntxt_Cedula.TabIndex = 44;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.dtp_FechaDesactivacion);
            this.tabPage2.Controls.Add(this.dtp_FechaActivacion);
            this.tabPage2.Controls.Add(this.uc_TIPOUSUARIO1);
            this.tabPage2.Controls.Add(this.uc_CARGO1);
            this.tabPage2.Controls.Add(this.chk_Activo);
            this.tabPage2.Controls.Add(this.atxt_Observaciones);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(607, 313);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos Generales";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 180);
            this.textBox2.MaxLength = 10;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(263, 22);
            this.textBox2.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "CLAVE";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 152);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 22);
            this.textBox1.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "CLAVE";
            // 
            // dtp_FechaDesactivacion
            // 
            this.dtp_FechaDesactivacion.Enabled = false;
            this.dtp_FechaDesactivacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaDesactivacion.Location = new System.Drawing.Point(192, 90);
            this.dtp_FechaDesactivacion.Name = "dtp_FechaDesactivacion";
            this.dtp_FechaDesactivacion.Size = new System.Drawing.Size(200, 22);
            this.dtp_FechaDesactivacion.TabIndex = 18;
            // 
            // dtp_FechaActivacion
            // 
            this.dtp_FechaActivacion.Enabled = false;
            this.dtp_FechaActivacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaActivacion.Location = new System.Drawing.Point(192, 62);
            this.dtp_FechaActivacion.Name = "dtp_FechaActivacion";
            this.dtp_FechaActivacion.Size = new System.Drawing.Size(200, 22);
            this.dtp_FechaActivacion.TabIndex = 17;
            // 
            // uc_TIPOUSUARIO1
            // 
            this.uc_TIPOUSUARIO1.Ancho = 121;
            this.uc_TIPOUSUARIO1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uc_TIPOUSUARIO1.DropDownWidth = 121;
            this.uc_TIPOUSUARIO1.Enabled = false;
            this.uc_TIPOUSUARIO1.FormattingEnabled = true;
            this.uc_TIPOUSUARIO1.Location = new System.Drawing.Point(129, 119);
            this.uc_TIPOUSUARIO1.Name = "uc_TIPOUSUARIO1";
            this.uc_TIPOUSUARIO1.Size = new System.Drawing.Size(263, 24);
            this.uc_TIPOUSUARIO1.TabIndex = 16;
            // 
            // uc_CARGO1
            // 
            this.uc_CARGO1.Ancho = 121;
            this.uc_CARGO1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uc_CARGO1.DropDownWidth = 121;
            this.uc_CARGO1.Enabled = false;
            this.uc_CARGO1.FormattingEnabled = true;
            this.uc_CARGO1.Location = new System.Drawing.Point(129, 7);
            this.uc_CARGO1.Name = "uc_CARGO1";
            this.uc_CARGO1.Size = new System.Drawing.Size(263, 24);
            this.uc_CARGO1.TabIndex = 15;
            // 
            // chk_Activo
            // 
            this.chk_Activo.AutoSize = true;
            this.chk_Activo.Checked = true;
            this.chk_Activo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Activo.Enabled = false;
            this.chk_Activo.Location = new System.Drawing.Point(129, 37);
            this.chk_Activo.Name = "chk_Activo";
            this.chk_Activo.Size = new System.Drawing.Size(98, 21);
            this.chk_Activo.TabIndex = 14;
            this.chk_Activo.Text = "checkBox2";
            this.chk_Activo.UseVisualStyleBackColor = true;
            // 
            // atxt_Observaciones
            // 
            this.atxt_Observaciones.Enabled = false;
            this.atxt_Observaciones.Location = new System.Drawing.Point(129, 215);
            this.atxt_Observaciones.MaxLength = 550;
            this.atxt_Observaciones.Multiline = true;
            this.atxt_Observaciones.Name = "atxt_Observaciones";
            this.atxt_Observaciones.Size = new System.Drawing.Size(461, 80);
            this.atxt_Observaciones.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "OBSERVACION";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "ACTIVO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "TIPO USUARIO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "FECHA DESACTIVACION:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "FECHA ACTIVACION:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "CARGO:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(636, 52);
            this.toolStrip1.TabIndex = 50;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(42, 49);
            this.toolStripButton1.Text = "&Salir";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(66, 49);
            this.toolStripButton2.Text = "&Guardar";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // frmMiPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 415);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMiPerfil";
            this.Text = "frmMiPerfil";
            this.Load += new System.EventHandler(this.frmMiPerfil_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_FechaNacimiento;
        private System.Windows.Forms.Label label2;
        private Vivaldi.UserControls.LettersTextBox ltxt_Apellidos;
        private System.Windows.Forms.Label label3;
        private Vivaldi.UserControls.LettersTextBox ltxt_Nombres;
        private System.Windows.Forms.Label label4;
        private Vivaldi.UserControls.NumericTextBox ntxt_Cedula;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtp_FechaDesactivacion;
        private System.Windows.Forms.DateTimePicker dtp_FechaActivacion;
        private uc.uc_TIPOUSUARIO uc_TIPOUSUARIO1;
        private uc.uc_CARGO uc_CARGO1;
        private System.Windows.Forms.CheckBox chk_Activo;
        private Vivaldi.AlfaTextBox atxt_Observaciones;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
    }
}