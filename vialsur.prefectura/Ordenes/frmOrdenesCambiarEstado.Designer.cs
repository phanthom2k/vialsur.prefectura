namespace vialsur.prefectura.Ordenes
{
    partial class frmOrdenesCambiarEstado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdenesCambiarEstado));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_EstadoActual = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uc_TipoEstadosOrdenes1 = new vialsur.prefectura.uc.uc_TipoEstadosOrdenes();
            this.toolStrip1.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(400, 52);
            this.toolStrip1.TabIndex = 43;
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
            this.toolStripButton2.Size = new System.Drawing.Size(104, 49);
            this.toolStripButton2.Text = "&Marcar Salida";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "ESTADO ACTUAL:";
            // 
            // lbl_EstadoActual
            // 
            this.lbl_EstadoActual.AutoSize = true;
            this.lbl_EstadoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EstadoActual.ForeColor = System.Drawing.Color.Blue;
            this.lbl_EstadoActual.Location = new System.Drawing.Point(178, 68);
            this.lbl_EstadoActual.Name = "lbl_EstadoActual";
            this.lbl_EstadoActual.Size = new System.Drawing.Size(52, 18);
            this.lbl_EstadoActual.TabIndex = 46;
            this.lbl_EstadoActual.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "CAMBIAR A ESTADO:";
            // 
            // uc_TipoEstadosOrdenes1
            // 
            this.uc_TipoEstadosOrdenes1.Ancho = 121;
            this.uc_TipoEstadosOrdenes1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uc_TipoEstadosOrdenes1.DropDownWidth = 121;
            this.uc_TipoEstadosOrdenes1.ForeColor = System.Drawing.Color.Blue;
            this.uc_TipoEstadosOrdenes1.FormattingEnabled = true;
            this.uc_TipoEstadosOrdenes1.Location = new System.Drawing.Point(181, 95);
            this.uc_TipoEstadosOrdenes1.Name = "uc_TipoEstadosOrdenes1";
            this.uc_TipoEstadosOrdenes1.Size = new System.Drawing.Size(195, 24);
            this.uc_TipoEstadosOrdenes1.TabIndex = 44;
            this.uc_TipoEstadosOrdenes1.SelectedIndexChanged += new System.EventHandler(this.uc_TipoEstadosOrdenes1_SelectedIndexChanged);
            // 
            // frmOrdenesCambiarEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 146);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_EstadoActual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uc_TipoEstadosOrdenes1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrdenesCambiarEstado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrdenesCambiarEstado";
            this.Load += new System.EventHandler(this.frmOrdenesCambiarEstado_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private uc.uc_TipoEstadosOrdenes uc_TipoEstadosOrdenes1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_EstadoActual;
        private System.Windows.Forms.Label label2;
    }
}