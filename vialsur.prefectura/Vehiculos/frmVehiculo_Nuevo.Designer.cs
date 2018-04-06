namespace vialsur.prefectura.Vehiculos
{
    partial class frmVehiculo_Nuevo
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.uc_Pais1 = new vialsur.prefectura.uc.uc_Pais();
            this.uc_VehiculoModelo1 = new vialsur.prefectura.uc.uc_VehiculoModelo();
            this.uc_VehiculoMarca1 = new vialsur.prefectura.uc.uc_VehiculoMarca();
            this.uc_VehiculoColor1 = new vialsur.prefectura.uc.uc_VehiculoColor();
            this.uc_NumericUpDown1 = new vialsur.prefectura.uc.uc_NumericUpDown();
            this.uc_NumericUpDown2 = new vialsur.prefectura.uc.uc_NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.decimalTextBox1 = new Vivaldi.UserControls.DecimalTextBox();
            this.alfaTextBox1 = new Vivaldi.AlfaTextBox();
            this.alfaTextBox2 = new Vivaldi.AlfaTextBox();
            this.alfaTextBox3 = new Vivaldi.AlfaTextBox();
            this.alfaTextBox4 = new Vivaldi.AlfaTextBox();
            this.alfaTextBox5 = new Vivaldi.AlfaTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uc_NumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uc_NumericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(94, 6);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(83, 52);
            this.btn_Guardar.TabIndex = 6;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "MARCA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "MODELO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "COLOR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "AÑO FABRICACIÓN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "AÑO DE COMPRA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "CILINDRAJE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "CODIGO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(435, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "CODIGO ANTERIOR:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "COSTO:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "ESTADO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "PAIS FABRICACIÓN:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(435, 341);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "PLACA PROVISIONAL:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 341);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "PLACA:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 282);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 17);
            this.label14.TabIndex = 21;
            this.label14.Text = "SERIE CHASIS:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 254);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 17);
            this.label15.TabIndex = 22;
            this.label15.Text = "SERIE MOTOR:";
            // 
            // uc_Pais1
            // 
            this.uc_Pais1.Ancho = 121;
            this.uc_Pais1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uc_Pais1.DropDownWidth = 121;
            this.uc_Pais1.FormattingEnabled = true;
            this.uc_Pais1.Location = new System.Drawing.Point(169, 192);
            this.uc_Pais1.Name = "uc_Pais1";
            this.uc_Pais1.Size = new System.Drawing.Size(121, 24);
            this.uc_Pais1.TabIndex = 26;
            // 
            // uc_VehiculoModelo1
            // 
            this.uc_VehiculoModelo1.Ancho = 121;
            this.uc_VehiculoModelo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uc_VehiculoModelo1.DropDownWidth = 121;
            this.uc_VehiculoModelo1.FormattingEnabled = true;
            this.uc_VehiculoModelo1.Location = new System.Drawing.Point(94, 165);
            this.uc_VehiculoModelo1.Name = "uc_VehiculoModelo1";
            this.uc_VehiculoModelo1.Size = new System.Drawing.Size(121, 24);
            this.uc_VehiculoModelo1.TabIndex = 25;
            // 
            // uc_VehiculoMarca1
            // 
            this.uc_VehiculoMarca1.Ancho = 121;
            this.uc_VehiculoMarca1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uc_VehiculoMarca1.DropDownWidth = 121;
            this.uc_VehiculoMarca1.FormattingEnabled = true;
            this.uc_VehiculoMarca1.Location = new System.Drawing.Point(94, 133);
            this.uc_VehiculoMarca1.Name = "uc_VehiculoMarca1";
            this.uc_VehiculoMarca1.Size = new System.Drawing.Size(121, 24);
            this.uc_VehiculoMarca1.TabIndex = 24;
            this.uc_VehiculoMarca1.SelectedIndexChanged += new System.EventHandler(this.uc_VehiculoMarca1_SelectedIndexChanged);
            // 
            // uc_VehiculoColor1
            // 
            this.uc_VehiculoColor1.Ancho = 121;
            this.uc_VehiculoColor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uc_VehiculoColor1.DropDownWidth = 121;
            this.uc_VehiculoColor1.FormattingEnabled = true;
            this.uc_VehiculoColor1.Location = new System.Drawing.Point(90, 220);
            this.uc_VehiculoColor1.Name = "uc_VehiculoColor1";
            this.uc_VehiculoColor1.Size = new System.Drawing.Size(121, 24);
            this.uc_VehiculoColor1.TabIndex = 23;
            // 
            // uc_NumericUpDown1
            // 
            this.uc_NumericUpDown1.Location = new System.Drawing.Point(169, 311);
            this.uc_NumericUpDown1.Maximum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.uc_NumericUpDown1.Minimum = new decimal(new int[] {
            1930,
            0,
            0,
            0});
            this.uc_NumericUpDown1.Name = "uc_NumericUpDown1";
            this.uc_NumericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.uc_NumericUpDown1.TabIndex = 27;
            this.uc_NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uc_NumericUpDown1.Value = new decimal(new int[] {
            2008,
            0,
            0,
            0});
            // 
            // uc_NumericUpDown2
            // 
            this.uc_NumericUpDown2.Location = new System.Drawing.Point(569, 311);
            this.uc_NumericUpDown2.Maximum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.uc_NumericUpDown2.Minimum = new decimal(new int[] {
            1930,
            0,
            0,
            0});
            this.uc_NumericUpDown2.Name = "uc_NumericUpDown2";
            this.uc_NumericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.uc_NumericUpDown2.TabIndex = 28;
            this.uc_NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uc_NumericUpDown2.Value = new decimal(new int[] {
            2008,
            0,
            0,
            0});
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(94, 397);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 21);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Text = "Activo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // decimalTextBox1
            // 
            this.decimalTextBox1.Location = new System.Drawing.Point(95, 368);
            this.decimalTextBox1.Name = "decimalTextBox1";
            this.decimalTextBox1.Size = new System.Drawing.Size(100, 22);
            this.decimalTextBox1.TabIndex = 29;
            // 
            // alfaTextBox1
            // 
            this.alfaTextBox1.Location = new System.Drawing.Point(509, 69);
            this.alfaTextBox1.Name = "alfaTextBox1";
            this.alfaTextBox1.Size = new System.Drawing.Size(100, 22);
            this.alfaTextBox1.TabIndex = 31;
            // 
            // alfaTextBox2
            // 
            this.alfaTextBox2.Location = new System.Drawing.Point(508, 98);
            this.alfaTextBox2.Name = "alfaTextBox2";
            this.alfaTextBox2.Size = new System.Drawing.Size(100, 22);
            this.alfaTextBox2.TabIndex = 32;
            // 
            // alfaTextBox3
            // 
            this.alfaTextBox3.Location = new System.Drawing.Point(148, 254);
            this.alfaTextBox3.Name = "alfaTextBox3";
            this.alfaTextBox3.Size = new System.Drawing.Size(100, 22);
            this.alfaTextBox3.TabIndex = 33;
            // 
            // alfaTextBox4
            // 
            this.alfaTextBox4.Location = new System.Drawing.Point(148, 277);
            this.alfaTextBox4.Name = "alfaTextBox4";
            this.alfaTextBox4.Size = new System.Drawing.Size(100, 22);
            this.alfaTextBox4.TabIndex = 34;
            // 
            // alfaTextBox5
            // 
            this.alfaTextBox5.Location = new System.Drawing.Point(90, 341);
            this.alfaTextBox5.Name = "alfaTextBox5";
            this.alfaTextBox5.Size = new System.Drawing.Size(100, 22);
            this.alfaTextBox5.TabIndex = 35;
            // 
            // frmVehiculo_Nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 437);
            this.Controls.Add(this.alfaTextBox5);
            this.Controls.Add(this.alfaTextBox4);
            this.Controls.Add(this.alfaTextBox3);
            this.Controls.Add(this.alfaTextBox2);
            this.Controls.Add(this.alfaTextBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.decimalTextBox1);
            this.Controls.Add(this.uc_NumericUpDown2);
            this.Controls.Add(this.uc_NumericUpDown1);
            this.Controls.Add(this.uc_Pais1);
            this.Controls.Add(this.uc_VehiculoModelo1);
            this.Controls.Add(this.uc_VehiculoMarca1);
            this.Controls.Add(this.uc_VehiculoColor1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Guardar);
            this.Name = "frmVehiculo_Nuevo";
            this.Text = "frmVehiculo_Nuevo";
            this.Load += new System.EventHandler(this.frmVehiculo_Nuevo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uc_NumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uc_NumericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private uc.uc_VehiculoColor uc_VehiculoColor1;
        private uc.uc_VehiculoMarca uc_VehiculoMarca1;
        private uc.uc_VehiculoModelo uc_VehiculoModelo1;
        private uc.uc_Pais uc_Pais1;
        private uc.uc_NumericUpDown uc_NumericUpDown1;
        private uc.uc_NumericUpDown uc_NumericUpDown2;
        private Vivaldi.UserControls.DecimalTextBox decimalTextBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private Vivaldi.AlfaTextBox alfaTextBox1;
        private Vivaldi.AlfaTextBox alfaTextBox2;
        private Vivaldi.AlfaTextBox alfaTextBox3;
        private Vivaldi.AlfaTextBox alfaTextBox4;
        private Vivaldi.AlfaTextBox alfaTextBox5;
    }
}