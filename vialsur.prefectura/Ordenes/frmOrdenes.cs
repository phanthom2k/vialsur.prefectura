using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vialsur.prefectura.Ordenes
{
    public partial class frmOrdenes : Form
    {
        public frmOrdenes()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ///NUEVA ORDERDEN
            ///
            frmSeleccionarVehiculo Paso_1 = new frmSeleccionarVehiculo();

            Paso_1.ShowDialog();




        }
    }
}
