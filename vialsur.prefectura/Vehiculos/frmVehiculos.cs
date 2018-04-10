using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vialsur.prefectura.Vehiculos
{
    public partial class frmVehiculos : Form
    {
        public frmVehiculos()
        {
            InitializeComponent();
        }

        private void btn_NuevoVehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                frmVehiculo_Nuevo frm_Vehiculo = new frmVehiculo_Nuevo();
                frm_Vehiculo.EsNuevo = true;
                frm_Vehiculo.ShowDialog();

            }
            catch (Exception ex)
            {

                
            }
        }
    }
}
