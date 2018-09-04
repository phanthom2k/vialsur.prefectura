namespace vialsur.prefectura.Ordenes
{
    partial class frmOrdenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdenes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lblPagActual = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPagFinal = new System.Windows.Forms.Label();
            this.uc_TipoEstadosOrdenes1 = new vialsur.prefectura.uc.uc_TipoEstadosOrdenes();
            this.cl_ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cl_modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_oden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ve_vehiculo_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ve_vehiculo_responsable_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chofer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.km_ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.km_egreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedula_responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.per_persona_cedula_crea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_cierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ve_vehiculo_responsable_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ve_vehiculo_responsable_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.toolStrip1.Size = new System.Drawing.Size(1211, 52);
            this.toolStrip1.TabIndex = 22;
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
            this.id,
            this.tipo_oden,
            this.ve_vehiculo_id,
            this.fecha,
            this.hora,
            this.estado,
            this.ve_vehiculo_responsable_id,
            this.chofer,
            this.observacion,
            this.km_ingreso,
            this.km_egreso,
            this.cedula_responsable,
            this.per_persona_cedula_crea,
            this.fecha_cierre,
            this.ve_vehiculo_responsable_estado,
            this.ve_vehiculo_responsable_fecha,
            this.tipo_responsable});
            this.dataGridView1.Location = new System.Drawing.Point(12, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1187, 505);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::vialsur.prefectura.Properties.Resources.broom;
            this.button2.Location = new System.Drawing.Point(1112, 57);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 33);
            this.button2.TabIndex = 36;
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
            this.btn_Buscar.Location = new System.Drawing.Point(1019, 57);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(84, 33);
            this.btn_Buscar.TabIndex = 35;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_input
            // 
            this.txt_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input.Location = new System.Drawing.Point(634, 60);
            this.txt_input.Margin = new System.Windows.Forms.Padding(4);
            this.txt_input.MaxLength = 125;
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(379, 26);
            this.txt_input.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Parametro de busqueda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Estado:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(842, 246);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 37);
            this.button4.TabIndex = 38;
            this.button4.Text = "<< Anterior";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(955, 245);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 37);
            this.button5.TabIndex = 39;
            this.button5.Text = "Siguiente >>";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // lblPagActual
            // 
            this.lblPagActual.Location = new System.Drawing.Point(664, 256);
            this.lblPagActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPagActual.Name = "lblPagActual";
            this.lblPagActual.Size = new System.Drawing.Size(61, 16);
            this.lblPagActual.TabIndex = 40;
            this.lblPagActual.Text = "lblPagActual";
            this.lblPagActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPagActual.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(735, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "de";
            this.label3.Visible = false;
            // 
            // lblPagFinal
            // 
            this.lblPagFinal.Location = new System.Drawing.Point(768, 256);
            this.lblPagFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPagFinal.Name = "lblPagFinal";
            this.lblPagFinal.Size = new System.Drawing.Size(52, 16);
            this.lblPagFinal.TabIndex = 42;
            this.lblPagFinal.Text = "lblPagFinal";
            this.lblPagFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPagFinal.Visible = false;
            // 
            // uc_TipoEstadosOrdenes1
            // 
            this.uc_TipoEstadosOrdenes1.Ancho = 121;
            this.uc_TipoEstadosOrdenes1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uc_TipoEstadosOrdenes1.DropDownWidth = 121;
            this.uc_TipoEstadosOrdenes1.FormattingEnabled = true;
            this.uc_TipoEstadosOrdenes1.Location = new System.Drawing.Point(86, 58);
            this.uc_TipoEstadosOrdenes1.Name = "uc_TipoEstadosOrdenes1";
            this.uc_TipoEstadosOrdenes1.Size = new System.Drawing.Size(276, 24);
            this.uc_TipoEstadosOrdenes1.TabIndex = 43;
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
            // cl_modificar
            // 
            this.cl_modificar.FillWeight = 55F;
            this.cl_modificar.HeaderText = "Modif.";
            this.cl_modificar.MinimumWidth = 70;
            this.cl_modificar.Name = "cl_modificar";
            this.cl_modificar.ReadOnly = true;
            this.cl_modificar.Text = "Modif.";
            this.cl_modificar.UseColumnTextForButtonValue = true;
            this.cl_modificar.Visible = false;
            this.cl_modificar.Width = 70;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "No Orden";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tipo_oden
            // 
            this.tipo_oden.DataPropertyName = "tipo_oden";
            this.tipo_oden.HeaderText = "Tipo oden mantenimiento";
            this.tipo_oden.MinimumWidth = 125;
            this.tipo_oden.Name = "tipo_oden";
            this.tipo_oden.ReadOnly = true;
            this.tipo_oden.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tipo_oden.Width = 125;
            // 
            // ve_vehiculo_id
            // 
            this.ve_vehiculo_id.DataPropertyName = "ve_vehiculo_id";
            this.ve_vehiculo_id.HeaderText = "Placa Vehiculo";
            this.ve_vehiculo_id.Name = "ve_vehiculo_id";
            this.ve_vehiculo_id.ReadOnly = true;
            this.ve_vehiculo_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.fecha.DefaultCellStyle = dataGridViewCellStyle2;
            this.fecha.HeaderText = "Fecha Ingreso";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // hora
            // 
            this.hora.DataPropertyName = "hora";
            dataGridViewCellStyle3.Format = "##:##";
            dataGridViewCellStyle3.NullValue = "00:00";
            this.hora.DefaultCellStyle = dataGridViewCellStyle3;
            this.hora.HeaderText = "Hora";
            this.hora.Name = "hora";
            this.hora.ReadOnly = true;
            this.hora.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ve_vehiculo_responsable_id
            // 
            this.ve_vehiculo_responsable_id.DataPropertyName = "ve_vehiculo_responsable_id";
            this.ve_vehiculo_responsable_id.HeaderText = "ve_vehiculo_responsable_id";
            this.ve_vehiculo_responsable_id.Name = "ve_vehiculo_responsable_id";
            this.ve_vehiculo_responsable_id.ReadOnly = true;
            this.ve_vehiculo_responsable_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ve_vehiculo_responsable_id.Visible = false;
            // 
            // chofer
            // 
            this.chofer.DataPropertyName = "chofer";
            this.chofer.HeaderText = "chofer";
            this.chofer.MinimumWidth = 25;
            this.chofer.Name = "chofer";
            this.chofer.ReadOnly = true;
            this.chofer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.chofer.Visible = false;
            this.chofer.Width = 150;
            // 
            // observacion
            // 
            this.observacion.DataPropertyName = "observacion";
            this.observacion.HeaderText = "observacion";
            this.observacion.Name = "observacion";
            this.observacion.ReadOnly = true;
            this.observacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.observacion.Visible = false;
            // 
            // km_ingreso
            // 
            this.km_ingreso.DataPropertyName = "km_ingreso";
            dataGridViewCellStyle4.Format = "######### km";
            dataGridViewCellStyle4.NullValue = "0 km";
            this.km_ingreso.DefaultCellStyle = dataGridViewCellStyle4;
            this.km_ingreso.HeaderText = "km_ingreso";
            this.km_ingreso.Name = "km_ingreso";
            this.km_ingreso.ReadOnly = true;
            this.km_ingreso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // km_egreso
            // 
            this.km_egreso.DataPropertyName = "km_egreso";
            dataGridViewCellStyle5.Format = "######### km";
            dataGridViewCellStyle5.NullValue = "0 km";
            this.km_egreso.DefaultCellStyle = dataGridViewCellStyle5;
            this.km_egreso.HeaderText = "km_egreso";
            this.km_egreso.Name = "km_egreso";
            this.km_egreso.ReadOnly = true;
            this.km_egreso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cedula_responsable
            // 
            this.cedula_responsable.DataPropertyName = "cedula_responsable";
            this.cedula_responsable.HeaderText = "Responsable de Mantenimiento";
            this.cedula_responsable.MaxInputLength = 125;
            this.cedula_responsable.MinimumWidth = 175;
            this.cedula_responsable.Name = "cedula_responsable";
            this.cedula_responsable.ReadOnly = true;
            this.cedula_responsable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cedula_responsable.Width = 175;
            // 
            // per_persona_cedula_crea
            // 
            this.per_persona_cedula_crea.DataPropertyName = "per_persona_cedula_crea";
            this.per_persona_cedula_crea.HeaderText = "Creador de orden";
            this.per_persona_cedula_crea.MinimumWidth = 175;
            this.per_persona_cedula_crea.Name = "per_persona_cedula_crea";
            this.per_persona_cedula_crea.ReadOnly = true;
            this.per_persona_cedula_crea.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.per_persona_cedula_crea.Width = 175;
            // 
            // fecha_cierre
            // 
            this.fecha_cierre.DataPropertyName = "fecha_cierre";
            this.fecha_cierre.FillWeight = 110F;
            this.fecha_cierre.HeaderText = "Fecha Salida";
            this.fecha_cierre.MinimumWidth = 125;
            this.fecha_cierre.Name = "fecha_cierre";
            this.fecha_cierre.ReadOnly = true;
            this.fecha_cierre.Width = 125;
            // 
            // ve_vehiculo_responsable_estado
            // 
            this.ve_vehiculo_responsable_estado.DataPropertyName = "ve_vehiculo_responsable_estado";
            this.ve_vehiculo_responsable_estado.HeaderText = "ve_vehiculo_responsable_estado";
            this.ve_vehiculo_responsable_estado.Name = "ve_vehiculo_responsable_estado";
            this.ve_vehiculo_responsable_estado.ReadOnly = true;
            this.ve_vehiculo_responsable_estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ve_vehiculo_responsable_estado.Visible = false;
            // 
            // ve_vehiculo_responsable_fecha
            // 
            this.ve_vehiculo_responsable_fecha.DataPropertyName = "ve_vehiculo_responsable_fecha";
            this.ve_vehiculo_responsable_fecha.HeaderText = "ve_vehiculo_responsable_fecha";
            this.ve_vehiculo_responsable_fecha.Name = "ve_vehiculo_responsable_fecha";
            this.ve_vehiculo_responsable_fecha.ReadOnly = true;
            this.ve_vehiculo_responsable_fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ve_vehiculo_responsable_fecha.Visible = false;
            // 
            // tipo_responsable
            // 
            this.tipo_responsable.DataPropertyName = "tipo_responsable";
            this.tipo_responsable.HeaderText = "tipo_responsable";
            this.tipo_responsable.Name = "tipo_responsable";
            this.tipo_responsable.ReadOnly = true;
            this.tipo_responsable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tipo_responsable.Visible = false;
            // 
            // frmOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 627);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uc_TipoEstadosOrdenes1);
            this.Controls.Add(this.lblPagFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPagActual);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmOrdenes";
            this.Text = "Ordenes";
            this.Load += new System.EventHandler(this.frmOrdenes_Load);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Label label1;
        private uc.uc_TipoEstadosOrdenes uc_TipoEstadosOrdenes1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblPagActual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPagFinal;
        private System.Windows.Forms.DataGridViewButtonColumn cl_ver;
        private System.Windows.Forms.DataGridViewButtonColumn cl_modificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_oden;
        private System.Windows.Forms.DataGridViewTextBoxColumn ve_vehiculo_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ve_vehiculo_responsable_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn chofer;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn km_ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn km_egreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula_responsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn per_persona_cedula_crea;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_cierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ve_vehiculo_responsable_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ve_vehiculo_responsable_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_responsable;
    }
}