﻿namespace vialsur.prefectura.Ordenes
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.lblPagFinal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPagActual = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cl_ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cl_modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_activacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(1035, 52);
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
            // lblPagFinal
            // 
            this.lblPagFinal.Location = new System.Drawing.Point(186, 118);
            this.lblPagFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPagFinal.Name = "lblPagFinal";
            this.lblPagFinal.Size = new System.Drawing.Size(52, 16);
            this.lblPagFinal.TabIndex = 42;
            this.lblPagFinal.Text = "lblPagFinal";
            this.lblPagFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "de";
            // 
            // lblPagActual
            // 
            this.lblPagActual.Location = new System.Drawing.Point(82, 118);
            this.lblPagActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPagActual.Name = "lblPagActual";
            this.lblPagActual.Size = new System.Drawing.Size(61, 16);
            this.lblPagActual.TabIndex = 40;
            this.lblPagActual.Text = "lblPagActual";
            this.lblPagActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(450, 108);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 37);
            this.button5.TabIndex = 39;
            this.button5.Text = "Siguiente >>";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(337, 108);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 37);
            this.button4.TabIndex = 38;
            this.button4.Text = "<< Anterior";
            this.button4.UseVisualStyleBackColor = true;
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
            this.cedula,
            this.nombres,
            this.apellidos,
            this.id,
            this.activo,
            this.fecha_activacion,
            this.tipo_usuario});
            this.dataGridView1.Location = new System.Drawing.Point(12, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1324, 495);
            this.dataGridView1.TabIndex = 37;
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
            this.cl_modificar.MinimumWidth = 75;
            this.cl_modificar.Name = "cl_modificar";
            this.cl_modificar.ReadOnly = true;
            this.cl_modificar.Text = "Modificar";
            this.cl_modificar.UseColumnTextForButtonValue = true;
            this.cl_modificar.Width = 75;
            // 
            // cedula
            // 
            this.cedula.DataPropertyName = "cedula";
            this.cedula.HeaderText = "cedula";
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            // 
            // nombres
            // 
            this.nombres.DataPropertyName = "nombres";
            this.nombres.FillWeight = 200F;
            this.nombres.HeaderText = "nombres";
            this.nombres.MaxInputLength = 150;
            this.nombres.MinimumWidth = 220;
            this.nombres.Name = "nombres";
            this.nombres.ReadOnly = true;
            this.nombres.Width = 220;
            // 
            // apellidos
            // 
            this.apellidos.DataPropertyName = "apellidos";
            this.apellidos.FillWeight = 200F;
            this.apellidos.HeaderText = "apellidos";
            this.apellidos.MinimumWidth = 220;
            this.apellidos.Name = "apellidos";
            this.apellidos.ReadOnly = true;
            this.apellidos.Width = 220;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "emp_empleado.id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // activo
            // 
            this.activo.DataPropertyName = "activo";
            this.activo.HeaderText = "activo";
            this.activo.Name = "activo";
            this.activo.ReadOnly = true;
            // 
            // fecha_activacion
            // 
            this.fecha_activacion.DataPropertyName = "fecha_activacion";
            this.fecha_activacion.HeaderText = "fecha_activacion";
            this.fecha_activacion.Name = "fecha_activacion";
            this.fecha_activacion.ReadOnly = true;
            // 
            // tipo_usuario
            // 
            this.tipo_usuario.DataPropertyName = "tipo_usuario";
            this.tipo_usuario.HeaderText = "tipo_usuario";
            this.tipo_usuario.Name = "tipo_usuario";
            this.tipo_usuario.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(701, 71);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 28);
            this.button2.TabIndex = 36;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(578, 71);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(115, 28);
            this.btn_Buscar.TabIndex = 35;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // txt_input
            // 
            this.txt_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input.Location = new System.Drawing.Point(178, 71);
            this.txt_input.Margin = new System.Windows.Forms.Padding(4);
            this.txt_input.MaxLength = 125;
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(379, 26);
            this.txt_input.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Parametro de busqueda:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 602);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1035, 25);
            this.statusStrip1.TabIndex = 43;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // frmOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 627);
            this.Controls.Add(this.statusStrip1);
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
            this.Text = "frmOrdenes";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Label lblPagFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPagActual;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn cl_ver;
        private System.Windows.Forms.DataGridViewButtonColumn cl_modificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_activacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_usuario;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}