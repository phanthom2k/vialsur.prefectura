namespace vialsur.prefectura
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.uc_Catalogo_Parte_Principal1 = new vialsur.prefectura.uc.uc_Catalogo_Parte_Principal();
            this.SuspendLayout();
            // 
            // uc_Catalogo_Parte_Principal1
            // 
            this.uc_Catalogo_Parte_Principal1.Ancho = 121;
            this.uc_Catalogo_Parte_Principal1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uc_Catalogo_Parte_Principal1.DropDownWidth = 121;
            this.uc_Catalogo_Parte_Principal1.FormattingEnabled = true;
            this.uc_Catalogo_Parte_Principal1.Location = new System.Drawing.Point(55, 48);
            this.uc_Catalogo_Parte_Principal1.Name = "uc_Catalogo_Parte_Principal1";
            this.uc_Catalogo_Parte_Principal1.Size = new System.Drawing.Size(121, 24);
            this.uc_Catalogo_Parte_Principal1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.uc_Catalogo_Parte_Principal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private uc.uc_Catalogo_Parte_Principal uc_Catalogo_Parte_Principal1;
    }
}

