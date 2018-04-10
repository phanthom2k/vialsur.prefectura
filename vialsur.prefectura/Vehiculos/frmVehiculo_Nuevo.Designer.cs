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
            this.chk_activo = new System.Windows.Forms.CheckBox();
            this.dtxt_costo = new Vivaldi.UserControls.DecimalTextBox();
            this.atxt_codigo = new Vivaldi.AlfaTextBox();
            this.atxt_codigoanterior = new Vivaldi.AlfaTextBox();
            this.atxt_seriemotor = new Vivaldi.AlfaTextBox();
            this.atxt_seriechasis = new Vivaldi.AlfaTextBox();
            this.atxt_placa = new Vivaldi.AlfaTextBox();
            this.ntxt_cilindraje = new Vivaldi.UserControls.NumericTextBox();
            this.atxt_placaprovisional = new Vivaldi.AlfaTextBox();
            this.error_Provider1 = new Vivaldi.UserControls.Error_Provider();
            this.nud_anocompra = new vialsur.prefectura.uc.uc_NumericUpDown();
            this.nud_anofabricacion = new vialsur.prefectura.uc.uc_NumericUpDown();
            this.cmb_pais = new vialsur.prefectura.uc.uc_Pais();
            this.cmb_modelo = new vialsur.prefectura.uc.uc_VehiculoModelo();
            this.cmb_Marca = new vialsur.prefectura.uc.uc_VehiculoMarca();
            this.cmb_color = new vialsur.prefectura.uc.uc_VehiculoColor();
            ((System.ComponentModel.ISupportInitialize)(this.error_Provider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_anocompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_anofabricacion)).BeginInit();
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
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "MARCA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "MODELO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "COLOR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "AÑO FABRICACIÓN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 296);
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
            this.label7.Location = new System.Drawing.Point(27, 104);
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
            this.label9.Location = new System.Drawing.Point(27, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "COSTO:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 377);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "ESTADO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "PAIS FABRICACIÓN:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(435, 324);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "PLACA PROVISIONAL:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 323);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "PLACA:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 272);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 17);
            this.label14.TabIndex = 21;
            this.label14.Text = "SERIE CHASIS:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 244);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 17);
            this.label15.TabIndex = 22;
            this.label15.Text = "SERIE MOTOR:";
            // 
            // chk_activo
            // 
            this.chk_activo.AutoSize = true;
            this.chk_activo.Checked = true;
            this.chk_activo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_activo.Location = new System.Drawing.Point(109, 376);
            this.chk_activo.Name = "chk_activo";
            this.chk_activo.Size = new System.Drawing.Size(68, 21);
            this.chk_activo.TabIndex = 30;
            this.chk_activo.Text = "Activo";
            this.chk_activo.UseVisualStyleBackColor = true;
            // 
            // dtxt_costo
            // 
            this.dtxt_costo.Location = new System.Drawing.Point(95, 346);
            this.dtxt_costo.Name = "dtxt_costo";
            this.dtxt_costo.Size = new System.Drawing.Size(116, 22);
            this.dtxt_costo.TabIndex = 29;
            this.dtxt_costo.Text = "22250";
            // 
            // atxt_codigo
            // 
            this.atxt_codigo.Location = new System.Drawing.Point(95, 101);
            this.atxt_codigo.Name = "atxt_codigo";
            this.atxt_codigo.Size = new System.Drawing.Size(195, 22);
            this.atxt_codigo.TabIndex = 31;
            this.atxt_codigo.Text = "codigo123";
            // 
            // atxt_codigoanterior
            // 
            this.atxt_codigoanterior.Location = new System.Drawing.Point(578, 101);
            this.atxt_codigoanterior.Name = "atxt_codigoanterior";
            this.atxt_codigoanterior.Size = new System.Drawing.Size(149, 22);
            this.atxt_codigoanterior.TabIndex = 32;
            this.atxt_codigoanterior.Text = "codigo anterior";
            // 
            // atxt_seriemotor
            // 
            this.atxt_seriemotor.Location = new System.Drawing.Point(141, 241);
            this.atxt_seriemotor.Name = "atxt_seriemotor";
            this.atxt_seriemotor.Size = new System.Drawing.Size(271, 22);
            this.atxt_seriemotor.TabIndex = 33;
            this.atxt_seriemotor.Text = "seria motor 123";
            // 
            // atxt_seriechasis
            // 
            this.atxt_seriechasis.Location = new System.Drawing.Point(141, 267);
            this.atxt_seriechasis.Name = "atxt_seriechasis";
            this.atxt_seriechasis.Size = new System.Drawing.Size(271, 22);
            this.atxt_seriechasis.TabIndex = 34;
            this.atxt_seriechasis.Text = "serie chasis 123";
            // 
            // atxt_placa
            // 
            this.atxt_placa.Location = new System.Drawing.Point(95, 318);
            this.atxt_placa.Name = "atxt_placa";
            this.atxt_placa.Size = new System.Drawing.Size(116, 22);
            this.atxt_placa.TabIndex = 35;
            this.atxt_placa.Text = "lbl1234";
            // 
            // ntxt_cilindraje
            // 
            this.ntxt_cilindraje.AllowSpace = false;
            this.ntxt_cilindraje.Location = new System.Drawing.Point(565, 220);
            this.ntxt_cilindraje.Name = "ntxt_cilindraje";
            this.ntxt_cilindraje.Size = new System.Drawing.Size(162, 22);
            this.ntxt_cilindraje.TabIndex = 36;
            this.ntxt_cilindraje.Text = "2000";
            // 
            // atxt_placaprovisional
            // 
            this.atxt_placaprovisional.Location = new System.Drawing.Point(589, 321);
            this.atxt_placaprovisional.Name = "atxt_placaprovisional";
            this.atxt_placaprovisional.Size = new System.Drawing.Size(138, 22);
            this.atxt_placaprovisional.TabIndex = 37;
            this.atxt_placaprovisional.Text = "lea4444";
            // 
            // error_Provider1
            // 
            this.error_Provider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.error_Provider1.ContainerControl = this;
            // 
            // nud_anocompra
            // 
            this.nud_anocompra.Location = new System.Drawing.Point(590, 294);
            this.nud_anocompra.Maximum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.nud_anocompra.Minimum = new decimal(new int[] {
            1930,
            0,
            0,
            0});
            this.nud_anocompra.Name = "nud_anocompra";
            this.nud_anocompra.Size = new System.Drawing.Size(137, 22);
            this.nud_anocompra.TabIndex = 28;
            this.nud_anocompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_anocompra.Value = new decimal(new int[] {
            2008,
            0,
            0,
            0});
            this.nud_anocompra.ValueChanged += new System.EventHandler(this.nud_anocompra_ValueChanged);
            // 
            // nud_anofabricacion
            // 
            this.nud_anofabricacion.Location = new System.Drawing.Point(169, 294);
            this.nud_anofabricacion.Maximum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.nud_anofabricacion.Minimum = new decimal(new int[] {
            1930,
            0,
            0,
            0});
            this.nud_anofabricacion.Name = "nud_anofabricacion";
            this.nud_anofabricacion.Size = new System.Drawing.Size(120, 22);
            this.nud_anofabricacion.TabIndex = 27;
            this.nud_anofabricacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_anofabricacion.Value = new decimal(new int[] {
            2008,
            0,
            0,
            0});
            this.nud_anofabricacion.ValueChanged += new System.EventHandler(this.nud_anofabricacion_ValueChanged);
            // 
            // cmb_pais
            // 
            this.cmb_pais.Ancho = 121;
            this.cmb_pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_pais.DropDownWidth = 121;
            this.cmb_pais.FormattingEnabled = true;
            this.cmb_pais.Location = new System.Drawing.Point(169, 184);
            this.cmb_pais.Name = "cmb_pais";
            this.cmb_pais.Size = new System.Drawing.Size(121, 24);
            this.cmb_pais.TabIndex = 26;
            // 
            // cmb_modelo
            // 
            this.cmb_modelo.Ancho = 121;
            this.cmb_modelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_modelo.DropDownWidth = 121;
            this.cmb_modelo.FormattingEnabled = true;
            this.cmb_modelo.Location = new System.Drawing.Point(95, 157);
            this.cmb_modelo.Name = "cmb_modelo";
            this.cmb_modelo.Size = new System.Drawing.Size(195, 24);
            this.cmb_modelo.TabIndex = 25;
            // 
            // cmb_Marca
            // 
            this.cmb_Marca.Ancho = 121;
            this.cmb_Marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Marca.DropDownWidth = 121;
            this.cmb_Marca.FormattingEnabled = true;
            this.cmb_Marca.Location = new System.Drawing.Point(94, 128);
            this.cmb_Marca.Name = "cmb_Marca";
            this.cmb_Marca.Size = new System.Drawing.Size(196, 24);
            this.cmb_Marca.TabIndex = 24;
            this.cmb_Marca.SelectedIndexChanged += new System.EventHandler(this.uc_VehiculoMarca1_SelectedIndexChanged);
            // 
            // cmb_color
            // 
            this.cmb_color.Ancho = 121;
            this.cmb_color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_color.DropDownWidth = 121;
            this.cmb_color.FormattingEnabled = true;
            this.cmb_color.Location = new System.Drawing.Point(134, 212);
            this.cmb_color.Name = "cmb_color";
            this.cmb_color.Size = new System.Drawing.Size(156, 24);
            this.cmb_color.TabIndex = 23;
            // 
            // frmVehiculo_Nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 416);
            this.Controls.Add(this.atxt_placaprovisional);
            this.Controls.Add(this.ntxt_cilindraje);
            this.Controls.Add(this.atxt_placa);
            this.Controls.Add(this.atxt_seriechasis);
            this.Controls.Add(this.atxt_seriemotor);
            this.Controls.Add(this.atxt_codigoanterior);
            this.Controls.Add(this.atxt_codigo);
            this.Controls.Add(this.chk_activo);
            this.Controls.Add(this.dtxt_costo);
            this.Controls.Add(this.nud_anocompra);
            this.Controls.Add(this.nud_anofabricacion);
            this.Controls.Add(this.cmb_pais);
            this.Controls.Add(this.cmb_modelo);
            this.Controls.Add(this.cmb_Marca);
            this.Controls.Add(this.cmb_color);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVehiculo_Nuevo";
            this.Load += new System.EventHandler(this.frmVehiculo_Nuevo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error_Provider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_anocompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_anofabricacion)).EndInit();
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
        private uc.uc_VehiculoColor cmb_color;
        private uc.uc_VehiculoMarca cmb_Marca;
        private uc.uc_VehiculoModelo cmb_modelo;
        private uc.uc_Pais cmb_pais;
        private uc.uc_NumericUpDown nud_anofabricacion;
        private uc.uc_NumericUpDown nud_anocompra;
        private Vivaldi.UserControls.DecimalTextBox dtxt_costo;
        private System.Windows.Forms.CheckBox chk_activo;
        private Vivaldi.AlfaTextBox atxt_codigo;
        private Vivaldi.AlfaTextBox atxt_codigoanterior;
        private Vivaldi.AlfaTextBox atxt_seriemotor;
        private Vivaldi.AlfaTextBox atxt_seriechasis;
        private Vivaldi.AlfaTextBox atxt_placa;
        private Vivaldi.UserControls.NumericTextBox ntxt_cilindraje;
        private Vivaldi.AlfaTextBox atxt_placaprovisional;
        private Vivaldi.UserControls.Error_Provider error_Provider1;
    }
}