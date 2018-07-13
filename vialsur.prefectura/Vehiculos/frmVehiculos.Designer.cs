namespace vialsur.prefectura.Vehiculos
{
    partial class frmVehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehiculos));
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cl_ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cl_modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cl_historiado = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_codigo_anterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_ve_vehiculo_modelo_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_placa_provisional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_anio_fabricacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_anio_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_cilindraje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_serie_chasis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_serie_motor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_PaisCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lblPagFinal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPagActual = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::vialsur.prefectura.Properties.Resources.broom;
            this.button2.Location = new System.Drawing.Point(671, 62);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 28);
            this.button2.TabIndex = 11;
            this.button2.Text = "Limpiar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Image = global::vialsur.prefectura.Properties.Resources.search_icon;
            this.btn_Buscar.Location = new System.Drawing.Point(574, 62);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(89, 28);
            this.btn_Buscar.TabIndex = 10;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_input
            // 
            this.txt_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input.Location = new System.Drawing.Point(174, 62);
            this.txt_input.Margin = new System.Windows.Forms.Padding(4);
            this.txt_input.MaxLength = 125;
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(379, 26);
            this.txt_input.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Parametro de busqueda:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_ver,
            this.cl_modificar,
            this.cl_historiado,
            this.id,
            this.cl_codigo,
            this.cl_codigo_anterior,
            this.cl_ve_vehiculo_modelo_id,
            this.cl_marca,
            this.cl_placa,
            this.cl_placa_provisional,
            this.cl_anio_fabricacion,
            this.cl_anio_compra,
            this.cl_cilindraje,
            this.cl_serie_chasis,
            this.cl_serie_motor,
            this.cl_color,
            this.cl_costo,
            this.cl_estado,
            this.cl_PaisCodigo});
            this.dataGridView1.Location = new System.Drawing.Point(8, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1409, 549);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cl_ver
            // 
            this.cl_ver.DataPropertyName = "id";
            this.cl_ver.FillWeight = 55F;
            this.cl_ver.HeaderText = "Ver";
            this.cl_ver.MinimumWidth = 57;
            this.cl_ver.Name = "cl_ver";
            this.cl_ver.ReadOnly = true;
            this.cl_ver.Text = "Ver";
            this.cl_ver.UseColumnTextForButtonValue = true;
            this.cl_ver.Width = 57;
            // 
            // cl_modificar
            // 
            this.cl_modificar.DataPropertyName = "id";
            this.cl_modificar.FillWeight = 55F;
            this.cl_modificar.HeaderText = "Modificar";
            this.cl_modificar.MinimumWidth = 70;
            this.cl_modificar.Name = "cl_modificar";
            this.cl_modificar.ReadOnly = true;
            this.cl_modificar.Text = "Modificar";
            this.cl_modificar.UseColumnTextForButtonValue = true;
            this.cl_modificar.Width = 70;
            // 
            // cl_historiado
            // 
            this.cl_historiado.HeaderText = "Historiado";
            this.cl_historiado.Name = "cl_historiado";
            this.cl_historiado.ReadOnly = true;
            this.cl_historiado.Text = "Historiado";
            this.cl_historiado.UseColumnTextForButtonValue = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // cl_codigo
            // 
            this.cl_codigo.DataPropertyName = "codigo";
            this.cl_codigo.HeaderText = "CODIGO";
            this.cl_codigo.Name = "cl_codigo";
            this.cl_codigo.ReadOnly = true;
            // 
            // cl_codigo_anterior
            // 
            this.cl_codigo_anterior.DataPropertyName = "codigo_anterior";
            this.cl_codigo_anterior.HeaderText = "codigo_anterior";
            this.cl_codigo_anterior.Name = "cl_codigo_anterior";
            this.cl_codigo_anterior.ReadOnly = true;
            this.cl_codigo_anterior.Visible = false;
            // 
            // cl_ve_vehiculo_modelo_id
            // 
            this.cl_ve_vehiculo_modelo_id.DataPropertyName = "modelo";
            this.cl_ve_vehiculo_modelo_id.FillWeight = 150F;
            this.cl_ve_vehiculo_modelo_id.HeaderText = "MODELO";
            this.cl_ve_vehiculo_modelo_id.MaxInputLength = 125;
            this.cl_ve_vehiculo_modelo_id.MinimumWidth = 150;
            this.cl_ve_vehiculo_modelo_id.Name = "cl_ve_vehiculo_modelo_id";
            this.cl_ve_vehiculo_modelo_id.ReadOnly = true;
            this.cl_ve_vehiculo_modelo_id.Width = 150;
            // 
            // cl_marca
            // 
            this.cl_marca.DataPropertyName = "MARCA";
            this.cl_marca.FillWeight = 150F;
            this.cl_marca.HeaderText = "MARCA";
            this.cl_marca.MaxInputLength = 150;
            this.cl_marca.MinimumWidth = 150;
            this.cl_marca.Name = "cl_marca";
            this.cl_marca.ReadOnly = true;
            this.cl_marca.Width = 150;
            // 
            // cl_placa
            // 
            this.cl_placa.DataPropertyName = "placa";
            this.cl_placa.FillWeight = 80F;
            this.cl_placa.HeaderText = "PLACA";
            this.cl_placa.MaxInputLength = 10;
            this.cl_placa.MinimumWidth = 80;
            this.cl_placa.Name = "cl_placa";
            this.cl_placa.ReadOnly = true;
            this.cl_placa.Width = 80;
            // 
            // cl_placa_provisional
            // 
            this.cl_placa_provisional.DataPropertyName = "placa_provisional";
            this.cl_placa_provisional.FillWeight = 80F;
            this.cl_placa_provisional.HeaderText = "PLACA PROV.";
            this.cl_placa_provisional.MaxInputLength = 10;
            this.cl_placa_provisional.MinimumWidth = 80;
            this.cl_placa_provisional.Name = "cl_placa_provisional";
            this.cl_placa_provisional.ReadOnly = true;
            this.cl_placa_provisional.Width = 80;
            // 
            // cl_anio_fabricacion
            // 
            this.cl_anio_fabricacion.DataPropertyName = "anio_fabricacion";
            this.cl_anio_fabricacion.DividerWidth = 1;
            this.cl_anio_fabricacion.FillWeight = 60F;
            this.cl_anio_fabricacion.HeaderText = "A. FAB";
            this.cl_anio_fabricacion.MaxInputLength = 4;
            this.cl_anio_fabricacion.MinimumWidth = 60;
            this.cl_anio_fabricacion.Name = "cl_anio_fabricacion";
            this.cl_anio_fabricacion.ReadOnly = true;
            this.cl_anio_fabricacion.Width = 60;
            // 
            // cl_anio_compra
            // 
            this.cl_anio_compra.DataPropertyName = "anio_compra";
            this.cl_anio_compra.DividerWidth = 1;
            this.cl_anio_compra.FillWeight = 60F;
            this.cl_anio_compra.HeaderText = "A. COMP";
            this.cl_anio_compra.MaxInputLength = 4;
            this.cl_anio_compra.MinimumWidth = 60;
            this.cl_anio_compra.Name = "cl_anio_compra";
            this.cl_anio_compra.ReadOnly = true;
            this.cl_anio_compra.Width = 60;
            // 
            // cl_cilindraje
            // 
            this.cl_cilindraje.DataPropertyName = "cilindraje";
            this.cl_cilindraje.FillWeight = 75F;
            this.cl_cilindraje.HeaderText = "CILINDRAJE";
            this.cl_cilindraje.MaxInputLength = 5;
            this.cl_cilindraje.MinimumWidth = 75;
            this.cl_cilindraje.Name = "cl_cilindraje";
            this.cl_cilindraje.ReadOnly = true;
            this.cl_cilindraje.Width = 75;
            // 
            // cl_serie_chasis
            // 
            this.cl_serie_chasis.DataPropertyName = "serie_chasis";
            this.cl_serie_chasis.FillWeight = 250F;
            this.cl_serie_chasis.HeaderText = "serie_chasis";
            this.cl_serie_chasis.MaxInputLength = 100;
            this.cl_serie_chasis.MinimumWidth = 250;
            this.cl_serie_chasis.Name = "cl_serie_chasis";
            this.cl_serie_chasis.ReadOnly = true;
            this.cl_serie_chasis.Width = 250;
            // 
            // cl_serie_motor
            // 
            this.cl_serie_motor.DataPropertyName = "serie_motor";
            this.cl_serie_motor.FillWeight = 200F;
            this.cl_serie_motor.HeaderText = "serie_motor";
            this.cl_serie_motor.MaxInputLength = 100;
            this.cl_serie_motor.MinimumWidth = 200;
            this.cl_serie_motor.Name = "cl_serie_motor";
            this.cl_serie_motor.ReadOnly = true;
            this.cl_serie_motor.Width = 200;
            // 
            // cl_color
            // 
            this.cl_color.DataPropertyName = "COLOR";
            this.cl_color.HeaderText = "color";
            this.cl_color.Name = "cl_color";
            this.cl_color.ReadOnly = true;
            // 
            // cl_costo
            // 
            this.cl_costo.DataPropertyName = "costo";
            this.cl_costo.HeaderText = "costo";
            this.cl_costo.Name = "cl_costo";
            this.cl_costo.ReadOnly = true;
            this.cl_costo.Visible = false;
            // 
            // cl_estado
            // 
            this.cl_estado.DataPropertyName = "estado";
            this.cl_estado.HeaderText = "estado";
            this.cl_estado.Name = "cl_estado";
            this.cl_estado.ReadOnly = true;
            // 
            // cl_PaisCodigo
            // 
            this.cl_PaisCodigo.DataPropertyName = "PaisCodigo";
            this.cl_PaisCodigo.HeaderText = "PaisCodigo";
            this.cl_PaisCodigo.Name = "cl_PaisCodigo";
            this.cl_PaisCodigo.ReadOnly = true;
            this.cl_PaisCodigo.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1148, 58);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 37);
            this.button4.TabIndex = 13;
            this.button4.Text = "<< Anterior";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1261, 58);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 37);
            this.button5.TabIndex = 14;
            this.button5.Text = "Siguiente >>";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // lblPagFinal
            // 
            this.lblPagFinal.Location = new System.Drawing.Point(997, 68);
            this.lblPagFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPagFinal.Name = "lblPagFinal";
            this.lblPagFinal.Size = new System.Drawing.Size(52, 16);
            this.lblPagFinal.TabIndex = 18;
            this.lblPagFinal.Text = "lblPagFinal";
            this.lblPagFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPagFinal.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(964, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "de";
            this.label3.Visible = false;
            // 
            // lblPagActual
            // 
            this.lblPagActual.Location = new System.Drawing.Point(893, 68);
            this.lblPagActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPagActual.Name = "lblPagActual";
            this.lblPagActual.Size = new System.Drawing.Size(61, 16);
            this.lblPagActual.TabIndex = 16;
            this.lblPagActual.Text = "lblPagActual";
            this.lblPagActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPagActual.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(822, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "PAGINA";
            this.label2.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 662);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1429, 25);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
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
            this.toolStrip1.Size = new System.Drawing.Size(1429, 52);
            this.toolStrip1.TabIndex = 20;
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
            this.toolStripButton2.Size = new System.Drawing.Size(55, 49);
            this.toolStripButton2.Text = "&Nueva";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // frmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 687);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblPagFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPagActual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.label1);
            this.Name = "frmVehiculos";
            this.Text = "frmVehiculos";
            this.Load += new System.EventHandler(this.frmVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblPagFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPagActual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridViewButtonColumn cl_ver;
        private System.Windows.Forms.DataGridViewButtonColumn cl_modificar;
        private System.Windows.Forms.DataGridViewButtonColumn cl_historiado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_codigo_anterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_ve_vehiculo_modelo_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_placa_provisional;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_anio_fabricacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_anio_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_cilindraje;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_serie_chasis;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_serie_motor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_color;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_PaisCodigo;
    }
}