namespace vialsur.prefectura.Pedidos
{
    partial class frmPedidosOrden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidosOrden));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lettersTextBox1 = new Vivaldi.UserControls.LettersTextBox();
            this.LBL_ESTADO = new System.Windows.Forms.Label();
            this.LBL_VEHICULO = new System.Windows.Forms.Label();
            this.LBL_FECHA = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LBL_ORDEN = new System.Windows.Forms.Label();
            this.cl_ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cl_modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidos_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.pedidos_id,
            this.cantidad,
            this.detalle});
            this.dataGridView1.Location = new System.Drawing.Point(12, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(783, 332);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(807, 52);
            this.toolStrip1.TabIndex = 62;
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
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(66, 49);
            this.toolStripButton3.Text = "&Guardar";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(55, 49);
            this.toolStripButton2.Text = "&Nueva";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "FECHA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(432, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 64;
            this.label2.Text = "VEHICULO:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "ESTADO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 66;
            this.label4.Text = "OBSERVACIONES:";
            // 
            // lettersTextBox1
            // 
            this.lettersTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lettersTextBox1.Location = new System.Drawing.Point(147, 111);
            this.lettersTextBox1.MaxLength = 500;
            this.lettersTextBox1.Multiline = true;
            this.lettersTextBox1.Name = "lettersTextBox1";
            this.lettersTextBox1.Size = new System.Drawing.Size(648, 91);
            this.lettersTextBox1.TabIndex = 67;
            // 
            // LBL_ESTADO
            // 
            this.LBL_ESTADO.AutoSize = true;
            this.LBL_ESTADO.Location = new System.Drawing.Point(144, 88);
            this.LBL_ESTADO.Name = "LBL_ESTADO";
            this.LBL_ESTADO.Size = new System.Drawing.Size(98, 17);
            this.LBL_ESTADO.TabIndex = 68;
            this.LBL_ESTADO.Text = "LBL_ESTADO";
            // 
            // LBL_VEHICULO
            // 
            this.LBL_VEHICULO.AutoSize = true;
            this.LBL_VEHICULO.Location = new System.Drawing.Point(564, 91);
            this.LBL_VEHICULO.Name = "LBL_VEHICULO";
            this.LBL_VEHICULO.Size = new System.Drawing.Size(110, 17);
            this.LBL_VEHICULO.TabIndex = 69;
            this.LBL_VEHICULO.Text = "LBL_VEHICULO";
            this.LBL_VEHICULO.Visible = false;
            // 
            // LBL_FECHA
            // 
            this.LBL_FECHA.AutoSize = true;
            this.LBL_FECHA.Location = new System.Drawing.Point(144, 63);
            this.LBL_FECHA.Name = "LBL_FECHA";
            this.LBL_FECHA.Size = new System.Drawing.Size(86, 17);
            this.LBL_FECHA.TabIndex = 70;
            this.LBL_FECHA.Text = "LBL_FECHA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(432, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 17);
            this.label5.TabIndex = 71;
            this.label5.Text = "ORDEN DE MANTENIMIENTO:";
            // 
            // LBL_ORDEN
            // 
            this.LBL_ORDEN.AutoSize = true;
            this.LBL_ORDEN.Location = new System.Drawing.Point(652, 63);
            this.LBL_ORDEN.Name = "LBL_ORDEN";
            this.LBL_ORDEN.Size = new System.Drawing.Size(91, 17);
            this.LBL_ORDEN.TabIndex = 72;
            this.LBL_ORDEN.Text = "LBL_ORDEN";
            // 
            // cl_ver
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "#######km";
            dataGridViewCellStyle1.NullValue = "0";
            this.cl_ver.DefaultCellStyle = dataGridViewCellStyle1;
            this.cl_ver.FillWeight = 55F;
            this.cl_ver.HeaderText = "Modif.";
            this.cl_ver.MinimumWidth = 57;
            this.cl_ver.Name = "cl_ver";
            this.cl_ver.ReadOnly = true;
            this.cl_ver.Text = "Modif.";
            this.cl_ver.UseColumnTextForButtonValue = true;
            this.cl_ver.Width = 57;
            // 
            // cl_modificar
            // 
            this.cl_modificar.FillWeight = 55F;
            this.cl_modificar.HeaderText = "Elimar";
            this.cl_modificar.MinimumWidth = 70;
            this.cl_modificar.Name = "cl_modificar";
            this.cl_modificar.ReadOnly = true;
            this.cl_modificar.Text = "Eliminar";
            this.cl_modificar.UseColumnTextForButtonValue = true;
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
            // pedidos_id
            // 
            this.pedidos_id.DataPropertyName = "pedidos_id";
            this.pedidos_id.HeaderText = "pedidos_id";
            this.pedidos_id.Name = "pedidos_id";
            this.pedidos_id.ReadOnly = true;
            this.pedidos_id.Visible = false;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // detalle
            // 
            this.detalle.DataPropertyName = "detalle";
            this.detalle.HeaderText = "detalle";
            this.detalle.MinimumWidth = 550;
            this.detalle.Name = "detalle";
            this.detalle.ReadOnly = true;
            this.detalle.Width = 550;
            // 
            // frmPedidosOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 569);
            this.Controls.Add(this.LBL_ORDEN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LBL_FECHA);
            this.Controls.Add(this.LBL_VEHICULO);
            this.Controls.Add(this.LBL_ESTADO);
            this.Controls.Add(this.lettersTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPedidosOrden";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitud de partes";
            this.Load += new System.EventHandler(this.frmPedidosOrden_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPedidosOrden_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Vivaldi.UserControls.LettersTextBox lettersTextBox1;
        private System.Windows.Forms.Label LBL_ESTADO;
        private System.Windows.Forms.Label LBL_VEHICULO;
        private System.Windows.Forms.Label LBL_FECHA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBL_ORDEN;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridViewButtonColumn cl_ver;
        private System.Windows.Forms.DataGridViewButtonColumn cl_modificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedidos_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle;
    }
}