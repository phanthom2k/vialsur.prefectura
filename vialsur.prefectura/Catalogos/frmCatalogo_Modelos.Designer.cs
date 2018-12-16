namespace vialsur.prefectura.Catalogos
{
    partial class frmCatalogo_Modelos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatalogo_Modelos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cl_ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cl_modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ve_vehiculo_marca_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_combustible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMBUSTIBLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_motor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ve_vehiculo_tipo_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ve_vehiculo_tipo_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clase_vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clase_vehiculo_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.uc_VehiculoMarca1 = new vialsur.prefectura.uc.uc_VehiculoMarca();
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
            this.toolStrip1.Size = new System.Drawing.Size(1092, 52);
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
            this.modelo,
            this.observacion,
            this.ve_vehiculo_marca_id,
            this.tipo_combustible,
            this.COMBUSTIBLE,
            this.traccion,
            this.tipo_motor,
            this.ve_vehiculo_tipo_id,
            this.ve_vehiculo_tipo_nombre,
            this.clase_vehiculo,
            this.clase_vehiculo_nombre});
            this.dataGridView1.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1068, 534);
            this.dataGridView1.TabIndex = 23;
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
            this.cl_modificar.Visible = false;
            this.cl_modificar.Width = 70;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // modelo
            // 
            this.modelo.DataPropertyName = "modelo";
            this.modelo.HeaderText = "MODELO";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            this.modelo.Width = 222;
            // 
            // observacion
            // 
            this.observacion.DataPropertyName = "observacion";
            this.observacion.HeaderText = "observacion";
            this.observacion.Name = "observacion";
            this.observacion.ReadOnly = true;
            this.observacion.Visible = false;
            // 
            // ve_vehiculo_marca_id
            // 
            this.ve_vehiculo_marca_id.DataPropertyName = "ve_vehiculo_marca_id";
            this.ve_vehiculo_marca_id.HeaderText = "ve_vehiculo_marca_id";
            this.ve_vehiculo_marca_id.Name = "ve_vehiculo_marca_id";
            this.ve_vehiculo_marca_id.ReadOnly = true;
            this.ve_vehiculo_marca_id.Visible = false;
            // 
            // tipo_combustible
            // 
            this.tipo_combustible.DataPropertyName = "tipo_combustible";
            this.tipo_combustible.HeaderText = "tipo_combustible";
            this.tipo_combustible.Name = "tipo_combustible";
            this.tipo_combustible.ReadOnly = true;
            this.tipo_combustible.Visible = false;
            // 
            // COMBUSTIBLE
            // 
            this.COMBUSTIBLE.DataPropertyName = "COMBUSTIBLE";
            this.COMBUSTIBLE.HeaderText = "TIPO COMBUSTIBLE";
            this.COMBUSTIBLE.Name = "COMBUSTIBLE";
            this.COMBUSTIBLE.ReadOnly = true;
            this.COMBUSTIBLE.Width = 200;
            // 
            // traccion
            // 
            this.traccion.DataPropertyName = "traccion";
            this.traccion.HeaderText = "traccion";
            this.traccion.Name = "traccion";
            this.traccion.ReadOnly = true;
            this.traccion.Visible = false;
            // 
            // tipo_motor
            // 
            this.tipo_motor.DataPropertyName = "tipo_motor";
            this.tipo_motor.HeaderText = "tipo_motor";
            this.tipo_motor.Name = "tipo_motor";
            this.tipo_motor.ReadOnly = true;
            this.tipo_motor.Visible = false;
            // 
            // ve_vehiculo_tipo_id
            // 
            this.ve_vehiculo_tipo_id.DataPropertyName = "ve_vehiculo_tipo_id";
            this.ve_vehiculo_tipo_id.HeaderText = "ve_vehiculo_tipo_id";
            this.ve_vehiculo_tipo_id.Name = "ve_vehiculo_tipo_id";
            this.ve_vehiculo_tipo_id.ReadOnly = true;
            this.ve_vehiculo_tipo_id.Visible = false;
            // 
            // ve_vehiculo_tipo_nombre
            // 
            this.ve_vehiculo_tipo_nombre.DataPropertyName = "ve_vehiculo_tipo_nombre";
            this.ve_vehiculo_tipo_nombre.HeaderText = "TIPO DE VEHICULO";
            this.ve_vehiculo_tipo_nombre.Name = "ve_vehiculo_tipo_nombre";
            this.ve_vehiculo_tipo_nombre.ReadOnly = true;
            this.ve_vehiculo_tipo_nombre.Width = 200;
            // 
            // clase_vehiculo
            // 
            this.clase_vehiculo.DataPropertyName = "clase_vehiculo";
            this.clase_vehiculo.HeaderText = "clase_vehiculo";
            this.clase_vehiculo.Name = "clase_vehiculo";
            this.clase_vehiculo.ReadOnly = true;
            this.clase_vehiculo.Visible = false;
            // 
            // clase_vehiculo_nombre
            // 
            this.clase_vehiculo_nombre.DataPropertyName = "clase_vehiculo_nombre";
            this.clase_vehiculo_nombre.HeaderText = "CLASE DE VEHICULO";
            this.clase_vehiculo_nombre.Name = "clase_vehiculo_nombre";
            this.clase_vehiculo_nombre.ReadOnly = true;
            this.clase_vehiculo_nombre.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Marcas registradas:";
            // 
            // uc_VehiculoMarca1
            // 
            this.uc_VehiculoMarca1.Ancho = 121;
            this.uc_VehiculoMarca1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uc_VehiculoMarca1.DropDownWidth = 121;
            this.uc_VehiculoMarca1.FormattingEnabled = true;
            this.uc_VehiculoMarca1.Location = new System.Drawing.Point(161, 73);
            this.uc_VehiculoMarca1.Name = "uc_VehiculoMarca1";
            this.uc_VehiculoMarca1.Size = new System.Drawing.Size(297, 24);
            this.uc_VehiculoMarca1.TabIndex = 25;
            this.uc_VehiculoMarca1.SelectedIndexChanged += new System.EventHandler(this.uc_VehiculoMarca1_SelectedIndexChanged);
            // 
            // frmCatalogo_Modelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 663);
            this.Controls.Add(this.uc_VehiculoMarca1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCatalogo_Modelos";
            this.Text = "Catálogo de Modelos";
            this.Load += new System.EventHandler(this.frmCatalogo_Modelos_Load);
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
        private System.Windows.Forms.Label label1;
        private uc.uc_VehiculoMarca uc_VehiculoMarca1;
        private System.Windows.Forms.DataGridViewButtonColumn cl_ver;
        private System.Windows.Forms.DataGridViewButtonColumn cl_modificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ve_vehiculo_marca_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_combustible;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMBUSTIBLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn traccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_motor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ve_vehiculo_tipo_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ve_vehiculo_tipo_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clase_vehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clase_vehiculo_nombre;
    }
}