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
    public partial class frmPedidosFondoRotativoOrden : Form
    {
        public frmPedidosFondoRotativoOrden()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ID DE LA ORDEN DE TRABAJO
        /// </summary>
        public string OrdenID { get; set; }

        public bool FondoRotativo { get; set; }


        private void frmPedidosFondoRotativoOrden_Load(object sender, EventArgs e)
        {

        }
    }
}
