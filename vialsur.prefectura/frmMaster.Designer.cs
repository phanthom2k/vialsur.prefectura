namespace vialsur.prefectura
{
    partial class frmMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaster));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tareasAsignadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tareasPendientesDeAprobarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeOrdenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosDePartesYPiezasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaOrdenDePartesYPiezasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAprobarOrdenesPartesPiezas = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesDePartesYPiezasSolicitadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesDePartesYPiezasRealizadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAprobarOrdenesFondoRotativo = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesPorFondoRotativosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lubricantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aprobarOrdenesDeLubricantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesDeLubricantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogoDeMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogoDeModelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.ordenesToolStripMenuItem,
            this.pedidosDePartesYPiezasToolStripMenuItem,
            this.administraciónToolStripMenuItem,
            this.miPerfilToolStripMenuItem,
            this.caToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1160, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ordenesToolStripMenuItem
            // 
            this.ordenesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaToolStripMenuItem,
            this.tareasAsignadasToolStripMenuItem,
            this.tareasPendientesDeAprobarToolStripMenuItem,
            this.historialDeOrdenesToolStripMenuItem});
            this.ordenesToolStripMenuItem.Name = "ordenesToolStripMenuItem";
            this.ordenesToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.ordenesToolStripMenuItem.Text = "Ordenes de Mantenimiento";
            this.ordenesToolStripMenuItem.Click += new System.EventHandler(this.ordenesToolStripMenuItem_Click);
            // 
            // nuevaToolStripMenuItem
            // 
            this.nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            this.nuevaToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
            this.nuevaToolStripMenuItem.Text = "Nueva Orden de Mantenimiento";
            this.nuevaToolStripMenuItem.Click += new System.EventHandler(this.nuevaToolStripMenuItem_Click);
            // 
            // tareasAsignadasToolStripMenuItem
            // 
            this.tareasAsignadasToolStripMenuItem.Name = "tareasAsignadasToolStripMenuItem";
            this.tareasAsignadasToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
            this.tareasAsignadasToolStripMenuItem.Text = "Tareas de Mantenimiento Asignadas";
            this.tareasAsignadasToolStripMenuItem.Click += new System.EventHandler(this.tareasAsignadasToolStripMenuItem_Click);
            // 
            // tareasPendientesDeAprobarToolStripMenuItem
            // 
            this.tareasPendientesDeAprobarToolStripMenuItem.Name = "tareasPendientesDeAprobarToolStripMenuItem";
            this.tareasPendientesDeAprobarToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
            this.tareasPendientesDeAprobarToolStripMenuItem.Text = "Aprobar Ordenes de Mantenimiento";
            this.tareasPendientesDeAprobarToolStripMenuItem.Visible = false;
            this.tareasPendientesDeAprobarToolStripMenuItem.Click += new System.EventHandler(this.tareasPendientesDeAprobarToolStripMenuItem_Click);
            // 
            // historialDeOrdenesToolStripMenuItem
            // 
            this.historialDeOrdenesToolStripMenuItem.Name = "historialDeOrdenesToolStripMenuItem";
            this.historialDeOrdenesToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
            this.historialDeOrdenesToolStripMenuItem.Text = "Historial de Ordenes de Mantenimiento";
            this.historialDeOrdenesToolStripMenuItem.Visible = false;
            this.historialDeOrdenesToolStripMenuItem.Click += new System.EventHandler(this.historialDeOrdenesToolStripMenuItem_Click);
            // 
            // pedidosDePartesYPiezasToolStripMenuItem
            // 
            this.pedidosDePartesYPiezasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaOrdenDePartesYPiezasToolStripMenuItem,
            this.ordenesDePartesYPiezasRealizadasToolStripMenuItem,
            this.lubricantesToolStripMenuItem});
            this.pedidosDePartesYPiezasToolStripMenuItem.Name = "pedidosDePartesYPiezasToolStripMenuItem";
            this.pedidosDePartesYPiezasToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.pedidosDePartesYPiezasToolStripMenuItem.Text = "Pedidos";
            // 
            // nuevaOrdenDePartesYPiezasToolStripMenuItem
            // 
            this.nuevaOrdenDePartesYPiezasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAprobarOrdenesPartesPiezas,
            this.ordenesDePartesYPiezasSolicitadasToolStripMenuItem});
            this.nuevaOrdenDePartesYPiezasToolStripMenuItem.Name = "nuevaOrdenDePartesYPiezasToolStripMenuItem";
            this.nuevaOrdenDePartesYPiezasToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.nuevaOrdenDePartesYPiezasToolStripMenuItem.Text = "Orden de Partes y Piezas";
            this.nuevaOrdenDePartesYPiezasToolStripMenuItem.Click += new System.EventHandler(this.nuevaOrdenDePartesYPiezasToolStripMenuItem_Click);
            // 
            // tsmiAprobarOrdenesPartesPiezas
            // 
            this.tsmiAprobarOrdenesPartesPiezas.Name = "tsmiAprobarOrdenesPartesPiezas";
            this.tsmiAprobarOrdenesPartesPiezas.Size = new System.Drawing.Size(336, 26);
            this.tsmiAprobarOrdenesPartesPiezas.Text = "Aprobar Orden de Partes y Piezas";
            this.tsmiAprobarOrdenesPartesPiezas.Visible = false;
            this.tsmiAprobarOrdenesPartesPiezas.Click += new System.EventHandler(this.aprobarOrdenDePartesYPiezasToolStripMenuItem_Click);
            // 
            // ordenesDePartesYPiezasSolicitadasToolStripMenuItem
            // 
            this.ordenesDePartesYPiezasSolicitadasToolStripMenuItem.Name = "ordenesDePartesYPiezasSolicitadasToolStripMenuItem";
            this.ordenesDePartesYPiezasSolicitadasToolStripMenuItem.Size = new System.Drawing.Size(336, 26);
            this.ordenesDePartesYPiezasSolicitadasToolStripMenuItem.Text = "Ordenes de Partes y Piezas Solicitadas";
            this.ordenesDePartesYPiezasSolicitadasToolStripMenuItem.Click += new System.EventHandler(this.ordenesDePartesYPiezasSolicitadasToolStripMenuItem_Click);
            // 
            // ordenesDePartesYPiezasRealizadasToolStripMenuItem
            // 
            this.ordenesDePartesYPiezasRealizadasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAprobarOrdenesFondoRotativo,
            this.ordenesPorFondoRotativosToolStripMenuItem});
            this.ordenesDePartesYPiezasRealizadasToolStripMenuItem.Name = "ordenesDePartesYPiezasRealizadasToolStripMenuItem";
            this.ordenesDePartesYPiezasRealizadasToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.ordenesDePartesYPiezasRealizadasToolStripMenuItem.Text = "Fondos Rotativos";
            this.ordenesDePartesYPiezasRealizadasToolStripMenuItem.Click += new System.EventHandler(this.ordenesDePartesYPiezasRealizadasToolStripMenuItem_Click);
            // 
            // tsmiAprobarOrdenesFondoRotativo
            // 
            this.tsmiAprobarOrdenesFondoRotativo.Name = "tsmiAprobarOrdenesFondoRotativo";
            this.tsmiAprobarOrdenesFondoRotativo.Size = new System.Drawing.Size(329, 26);
            this.tsmiAprobarOrdenesFondoRotativo.Text = "Aprobar Orden por Fondos Rotativos";
            this.tsmiAprobarOrdenesFondoRotativo.Visible = false;
            this.tsmiAprobarOrdenesFondoRotativo.Click += new System.EventHandler(this.tsmiAprobarOrdenesFondoRotativo_Click);
            // 
            // ordenesPorFondoRotativosToolStripMenuItem
            // 
            this.ordenesPorFondoRotativosToolStripMenuItem.Name = "ordenesPorFondoRotativosToolStripMenuItem";
            this.ordenesPorFondoRotativosToolStripMenuItem.Size = new System.Drawing.Size(329, 26);
            this.ordenesPorFondoRotativosToolStripMenuItem.Text = "Ordenes por Fondo Rotativos";
            this.ordenesPorFondoRotativosToolStripMenuItem.Click += new System.EventHandler(this.ordenesPorFondoRotativosToolStripMenuItem_Click);
            // 
            // lubricantesToolStripMenuItem
            // 
            this.lubricantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aprobarOrdenesDeLubricantesToolStripMenuItem,
            this.ordenesDeLubricantesToolStripMenuItem});
            this.lubricantesToolStripMenuItem.Name = "lubricantesToolStripMenuItem";
            this.lubricantesToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.lubricantesToolStripMenuItem.Text = "Lubricantes";
            // 
            // aprobarOrdenesDeLubricantesToolStripMenuItem
            // 
            this.aprobarOrdenesDeLubricantesToolStripMenuItem.Name = "aprobarOrdenesDeLubricantesToolStripMenuItem";
            this.aprobarOrdenesDeLubricantesToolStripMenuItem.Size = new System.Drawing.Size(298, 26);
            this.aprobarOrdenesDeLubricantesToolStripMenuItem.Text = "Aprobar Ordenes de Lubricantes";
            this.aprobarOrdenesDeLubricantesToolStripMenuItem.Visible = false;
            this.aprobarOrdenesDeLubricantesToolStripMenuItem.Click += new System.EventHandler(this.aprobarOrdenesDeLubricantesToolStripMenuItem_Click);
            // 
            // ordenesDeLubricantesToolStripMenuItem
            // 
            this.ordenesDeLubricantesToolStripMenuItem.Name = "ordenesDeLubricantesToolStripMenuItem";
            this.ordenesDeLubricantesToolStripMenuItem.Size = new System.Drawing.Size(298, 26);
            this.ordenesDeLubricantesToolStripMenuItem.Text = "Ordenes de Lubricantes";
            this.ordenesDeLubricantesToolStripMenuItem.Click += new System.EventHandler(this.ordenesDeLubricantesToolStripMenuItem_Click);
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehiculosToolStripMenuItem,
            this.personalToolStripMenuItem});
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.administraciónToolStripMenuItem.Text = "Administración";
            // 
            // vehiculosToolStripMenuItem
            // 
            this.vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            this.vehiculosToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.vehiculosToolStripMenuItem.Text = "Vehículos";
            this.vehiculosToolStripMenuItem.Click += new System.EventHandler(this.vehiculosToolStripMenuItem_Click);
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.personalToolStripMenuItem.Text = "Personal";
            this.personalToolStripMenuItem.Visible = false;
            this.personalToolStripMenuItem.Click += new System.EventHandler(this.personalToolStripMenuItem_Click);
            // 
            // miPerfilToolStripMenuItem
            // 
            this.miPerfilToolStripMenuItem.Name = "miPerfilToolStripMenuItem";
            this.miPerfilToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.miPerfilToolStripMenuItem.Text = "Mi Perfil";
            this.miPerfilToolStripMenuItem.Click += new System.EventHandler(this.miPerfilToolStripMenuItem_Click);
            // 
            // caToolStripMenuItem
            // 
            this.caToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogoDeMarcasToolStripMenuItem,
            this.catálogoDeModelosToolStripMenuItem});
            this.caToolStripMenuItem.Name = "caToolStripMenuItem";
            this.caToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.caToolStripMenuItem.Text = "Catálogos";
            this.caToolStripMenuItem.Visible = false;
            // 
            // catalogoDeMarcasToolStripMenuItem
            // 
            this.catalogoDeMarcasToolStripMenuItem.Name = "catalogoDeMarcasToolStripMenuItem";
            this.catalogoDeMarcasToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.catalogoDeMarcasToolStripMenuItem.Text = "Catálogo de Marcas";
            this.catalogoDeMarcasToolStripMenuItem.Click += new System.EventHandler(this.catalogoDeMarcasToolStripMenuItem_Click);
            // 
            // catálogoDeModelosToolStripMenuItem
            // 
            this.catálogoDeModelosToolStripMenuItem.Name = "catálogoDeModelosToolStripMenuItem";
            this.catálogoDeModelosToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.catálogoDeModelosToolStripMenuItem.Text = "Catálogo de Modelos";
            this.catálogoDeModelosToolStripMenuItem.Click += new System.EventHandler(this.catálogoDeModelosToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.toolStripMenuItem1});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.acercaDeToolStripMenuItem.Text = "Ayuda";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.manualToolStripMenuItem.Text = "Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(163, 26);
            this.toolStripMenuItem1.Text = "Acerca de ...";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 593);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1160, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(160, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // frmMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::vialsur.prefectura.Properties.Resources.logo_vialsur;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1160, 618);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMaster";
            this.Text = "Master";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMaster_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tareasAsignadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tareasPendientesDeAprobarToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem miPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeOrdenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogoDeMarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogoDeModelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosDePartesYPiezasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaOrdenDePartesYPiezasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesDePartesYPiezasRealizadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAprobarOrdenesPartesPiezas;
        private System.Windows.Forms.ToolStripMenuItem ordenesDePartesYPiezasSolicitadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAprobarOrdenesFondoRotativo;
        private System.Windows.Forms.ToolStripMenuItem ordenesPorFondoRotativosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lubricantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aprobarOrdenesDeLubricantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesDeLubricantesToolStripMenuItem;
    }
}