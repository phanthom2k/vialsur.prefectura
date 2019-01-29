using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vialsur.prefectura.PedidosFondoRotativo
{
    public partial class frmPedidosFondoRotativo : Form
    {
        public frmPedidosFondoRotativo()
        {
            InitializeComponent();

            Resources.clsManejadorImagenes img = new Resources.clsManejadorImagenes();
            toolStrip1.ImageList = img.GetCatalog();
            // img.SetImage48("Actions-document-save-icon.png", "disk");
            //toolStripButton2.ImageKey = "disk";

            //img.SetImage48("file-text-icon48x48.png", "new");            
            // toolStripButton2.ImageKey = "new";
            img.SetImage48("logout-icon.png", "door_out");
            toolStripButton1.ImageKey = "door_out";
            uc_Orden_TipoEstadoPedido1.CargarDatos();
            uc_Orden_TipoEstadoPedido1.SelectedItem = entidades.vialsur.prefectura.Orden_TipoEstadoPedido.AUTORIZADO.ToString();

        }

        public entidades.vialsur.prefectura.emp_empleado Empleado { get; set; }

        /// <summary>
        /// cedula del usuario
        /// </summary>
        public string Cedula { get; set; }


        private void frmPedidosFondoRotativo_Load(object sender, EventArgs e)
        {

        }
    }
}
