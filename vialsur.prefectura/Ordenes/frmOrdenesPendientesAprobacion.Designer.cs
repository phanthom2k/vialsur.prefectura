namespace vialsur.prefectura.Ordenes
{
    partial class frmOrdenesPendientesAprobacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdenesPendientesAprobacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cl_ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cl_modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_oden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ve_vehiculo_responsable_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chofer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.km_ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.km_egreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedula_responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ve_vehiculo_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.toolStrip1.Size = new System.Drawing.Size(1232, 52);
            this.toolStrip1.TabIndex = 23;
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
            this.cl_modificar,
            this.id,
            this.tipo_oden,
            this.fecha,
            this.hora,
            this.estado,
            this.ve_vehiculo_responsable_id,
            this.chofer,
            this.observacion,
            this.km_ingreso,
            this.km_egreso,
            this.cedula_responsable,
            this.ve_vehiculo_id,
            this.ve_vehiculo_responsable_estado,
            this.ve_vehiculo_responsable_fecha,
            this.tipo_responsable});
            this.dataGridView1.Location = new System.Drawing.Point(0, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1232, 531);
            this.dataGridView1.TabIndex = 38;
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
            // cl_modificar
            // 
            this.cl_modificar.FillWeight = 55F;
            this.cl_modificar.HeaderText = "Aprobar";
            this.cl_modificar.MinimumWidth = 70;
            this.cl_modificar.Name = "cl_modificar";
            this.cl_modificar.ReadOnly = true;
            this.cl_modificar.Text = "Aprobar";
            this.cl_modificar.UseColumnTextForButtonValue = true;
            this.cl_modificar.Width = 70;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Orden No.";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // tipo_oden
            // 
            this.tipo_oden.DataPropertyName = "tipo_oden";
            this.tipo_oden.HeaderText = "Tipo oden";
            this.tipo_oden.MinimumWidth = 70;
            this.tipo_oden.Name = "tipo_oden";
            this.tipo_oden.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.fecha.DefaultCellStyle = dataGridViewCellStyle2;
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
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
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // ve_vehiculo_responsable_id
            // 
            this.ve_vehiculo_responsable_id.DataPropertyName = "ve_vehiculo_responsable_id";
            this.ve_vehiculo_responsable_id.HeaderText = "ve_vehiculo_responsable_id";
            this.ve_vehiculo_responsable_id.Name = "ve_vehiculo_responsable_id";
            this.ve_vehiculo_responsable_id.ReadOnly = true;
            this.ve_vehiculo_responsable_id.Visible = false;
            // 
            // chofer
            // 
            this.chofer.DataPropertyName = "chofer";
            this.chofer.HeaderText = "chofer";
            this.chofer.MinimumWidth = 125;
            this.chofer.Name = "chofer";
            this.chofer.ReadOnly = true;
            this.chofer.Visible = false;
            this.chofer.Width = 150;
            // 
            // observacion
            // 
            this.observacion.DataPropertyName = "observacion";
            this.observacion.HeaderText = "Bbservación";
            this.observacion.Name = "observacion";
            this.observacion.ReadOnly = true;
            this.observacion.Visible = false;
            // 
            // km_ingreso
            // 
            this.km_ingreso.DataPropertyName = "km_ingreso";
            dataGridViewCellStyle4.Format = "######### km";
            dataGridViewCellStyle4.NullValue = "0 km";
            this.km_ingreso.DefaultCellStyle = dataGridViewCellStyle4;
            this.km_ingreso.HeaderText = "Km (Ingreso)";
            this.km_ingreso.Name = "km_ingreso";
            this.km_ingreso.ReadOnly = true;
            // 
            // km_egreso
            // 
            this.km_egreso.DataPropertyName = "km_egreso";
            dataGridViewCellStyle5.Format = "######### km";
            dataGridViewCellStyle5.NullValue = "0 km";
            this.km_egreso.DefaultCellStyle = dataGridViewCellStyle5;
            this.km_egreso.HeaderText = "Km (Egreso)";
            this.km_egreso.Name = "km_egreso";
            this.km_egreso.ReadOnly = true;
            // 
            // cedula_responsable
            // 
            this.cedula_responsable.DataPropertyName = "cedula_responsable";
            this.cedula_responsable.HeaderText = "Responsable mantenimiento";
            this.cedula_responsable.MaxInputLength = 125;
            this.cedula_responsable.MinimumWidth = 125;
            this.cedula_responsable.Name = "cedula_responsable";
            this.cedula_responsable.ReadOnly = true;
            this.cedula_responsable.Width = 175;
            // 
            // ve_vehiculo_id
            // 
            this.ve_vehiculo_id.DataPropertyName = "ve_vehiculo_id";
            this.ve_vehiculo_id.HeaderText = "Placa Vehiculo";
            this.ve_vehiculo_id.Name = "ve_vehiculo_id";
            this.ve_vehiculo_id.ReadOnly = true;
            // 
            // ve_vehiculo_responsable_estado
            // 
            this.ve_vehiculo_responsable_estado.DataPropertyName = "ve_vehiculo_responsable_estado";
            this.ve_vehiculo_responsable_estado.HeaderText = "ve_vehiculo_responsable_estado";
            this.ve_vehiculo_responsable_estado.Name = "ve_vehiculo_responsable_estado";
            this.ve_vehiculo_responsable_estado.ReadOnly = true;
            this.ve_vehiculo_responsable_estado.Visible = false;
            // 
            // ve_vehiculo_responsable_fecha
            // 
            this.ve_vehiculo_responsable_fecha.DataPropertyName = "ve_vehiculo_responsable_fecha";
            this.ve_vehiculo_responsable_fecha.HeaderText = "ve_vehiculo_responsable_fecha";
            this.ve_vehiculo_responsable_fecha.Name = "ve_vehiculo_responsable_fecha";
            this.ve_vehiculo_responsable_fecha.ReadOnly = true;
            this.ve_vehiculo_responsable_fecha.Visible = false;
            // 
            // tipo_responsable
            // 
            this.tipo_responsable.DataPropertyName = "tipo_responsable";
            this.tipo_responsable.HeaderText = "tipo_responsable";
            this.tipo_responsable.Name = "tipo_responsable";
            this.tipo_responsable.ReadOnly = true;
            this.tipo_responsable.Visible = false;
            // 
            // frmOrdenesPendientesAprobacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 591);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmOrdenesPendientesAprobacion";
            this.Text = "Ordenes Pendientes de Aprobacion";
            this.Load += new System.EventHandler(this.frmOrdenesPendientesAprobacion_Load);
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
        private System.Windows.Forms.DataGridViewButtonColumn cl_ver;
        private System.Windows.Forms.DataGridViewButtonColumn cl_modificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_oden;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ve_vehiculo_responsable_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn chofer;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn km_ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn km_egreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula_responsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ve_vehiculo_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ve_vehiculo_responsable_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ve_vehiculo_responsable_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_responsable;
    }
}