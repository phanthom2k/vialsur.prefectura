namespace vialsur.prefectura.Pedidos
{
    partial class frmPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cl_ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cl_aprobar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orden_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aprobada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solicitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uc_Orden_TipoEstadoPedido1 = new vialsur.prefectura.uc.uc_Orden_TipoEstadoPedido();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(1359, 52);
            this.toolStrip1.TabIndex = 24;
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
            this.toolStripButton2.Visible = false;
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
            this.cl_aprobar,
            this.id,
            this.fecha,
            this.cedula,
            this.observaciones,
            this.orden_id,
            this.aprobada,
            this.solicitante,
            this.codigo,
            this.placa,
            this.nombre,
            this.modelo});
            this.dataGridView1.Location = new System.Drawing.Point(0, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1359, 510);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cl_ver
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "#######km";
            dataGridViewCellStyle1.NullValue = "0";
            this.cl_ver.DefaultCellStyle = dataGridViewCellStyle1;
            this.cl_ver.FillWeight = 55F;
            this.cl_ver.HeaderText = "Ver";
            this.cl_ver.MinimumWidth = 57;
            this.cl_ver.Name = "cl_ver";
            this.cl_ver.ReadOnly = true;
            this.cl_ver.Text = "Ver";
            this.cl_ver.UseColumnTextForButtonValue = true;
            this.cl_ver.Width = 57;
            // 
            // cl_aprobar
            // 
            this.cl_aprobar.FillWeight = 55F;
            this.cl_aprobar.HeaderText = "Aprobar";
            this.cl_aprobar.MinimumWidth = 70;
            this.cl_aprobar.Name = "cl_aprobar";
            this.cl_aprobar.ReadOnly = true;
            this.cl_aprobar.Text = "Aprobar";
            this.cl_aprobar.UseColumnTextForButtonValue = true;
            this.cl_aprobar.Visible = false;
            this.cl_aprobar.Width = 70;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Yellow;
            this.id.DefaultCellStyle = dataGridViewCellStyle2;
            this.id.HeaderText = "Orden No.";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha de creación";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 95;
            // 
            // cedula
            // 
            this.cedula.DataPropertyName = "cedula";
            this.cedula.HeaderText = "cedula";
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            this.cedula.Visible = false;
            // 
            // observaciones
            // 
            this.observaciones.DataPropertyName = "observaciones";
            dataGridViewCellStyle3.NullValue = "-----------";
            this.observaciones.DefaultCellStyle = dataGridViewCellStyle3;
            this.observaciones.FillWeight = 250F;
            this.observaciones.HeaderText = "Observaciones";
            this.observaciones.MaxInputLength = 100;
            this.observaciones.Name = "observaciones";
            this.observaciones.ReadOnly = true;
            this.observaciones.Width = 250;
            // 
            // orden_id
            // 
            this.orden_id.DataPropertyName = "orden_id";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Lime;
            this.orden_id.DefaultCellStyle = dataGridViewCellStyle4;
            this.orden_id.HeaderText = "Orden de mantenimiento No.";
            this.orden_id.Name = "orden_id";
            this.orden_id.ReadOnly = true;
            this.orden_id.Width = 115;
            // 
            // aprobada
            // 
            this.aprobada.DataPropertyName = "aprobada";
            this.aprobada.HeaderText = "aprobada";
            this.aprobada.Name = "aprobada";
            this.aprobada.ReadOnly = true;
            this.aprobada.Visible = false;
            // 
            // solicitante
            // 
            this.solicitante.DataPropertyName = "solicitante";
            this.solicitante.FillWeight = 200F;
            this.solicitante.HeaderText = "Solicitante";
            this.solicitante.MaxInputLength = 200;
            this.solicitante.Name = "solicitante";
            this.solicitante.ReadOnly = true;
            this.solicitante.Width = 225;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "Código del vehículo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 95;
            // 
            // placa
            // 
            this.placa.DataPropertyName = "placa";
            this.placa.HeaderText = "Placa";
            this.placa.Name = "placa";
            this.placa.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Marca";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // modelo
            // 
            this.modelo.DataPropertyName = "modelo";
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            this.modelo.Width = 185;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "Estado:";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::vialsur.prefectura.Properties.Resources.broom;
            this.button2.Location = new System.Drawing.Point(1013, 64);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 33);
            this.button2.TabIndex = 48;
            this.button2.Text = "Limpiar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Image = global::vialsur.prefectura.Properties.Resources.search_icon;
            this.btn_Buscar.Location = new System.Drawing.Point(266, 59);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(104, 33);
            this.btn_Buscar.TabIndex = 47;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_input
            // 
            this.txt_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input.Location = new System.Drawing.Point(626, 66);
            this.txt_input.Margin = new System.Windows.Forms.Padding(4);
            this.txt_input.MaxLength = 125;
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(379, 26);
            this.txt_input.TabIndex = 46;
            this.txt_input.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Parametro de busqueda:";
            this.label1.Visible = false;
            // 
            // uc_Orden_TipoEstadoPedido1
            // 
            this.uc_Orden_TipoEstadoPedido1.Ancho = 121;
            this.uc_Orden_TipoEstadoPedido1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uc_Orden_TipoEstadoPedido1.DropDownWidth = 121;
            this.uc_Orden_TipoEstadoPedido1.FormattingEnabled = true;
            this.uc_Orden_TipoEstadoPedido1.Location = new System.Drawing.Point(68, 64);
            this.uc_Orden_TipoEstadoPedido1.Name = "uc_Orden_TipoEstadoPedido1";
            this.uc_Orden_TipoEstadoPedido1.Size = new System.Drawing.Size(180, 24);
            this.uc_Orden_TipoEstadoPedido1.TabIndex = 51;
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 625);
            this.Controls.Add(this.uc_Orden_TipoEstadoPedido1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmPedidos";
            this.Text = "Pedidos de Partes y Piezas Realizados";
            this.Load += new System.EventHandler(this.frmPedidosPendientesAprobacion_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Label label1;
        private uc.uc_Orden_TipoEstadoPedido uc_Orden_TipoEstadoPedido1;
        private System.Windows.Forms.DataGridViewButtonColumn cl_ver;
        private System.Windows.Forms.DataGridViewButtonColumn cl_aprobar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn orden_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn aprobada;
        private System.Windows.Forms.DataGridViewTextBoxColumn solicitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
    }
}