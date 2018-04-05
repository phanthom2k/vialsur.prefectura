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
    public partial class frmVehiculo_Nuevo : Form
    {
        public frmVehiculo_Nuevo()
        {
            InitializeComponent();
        }

        private void frmVehiculo_Nuevo_Load(object sender, EventArgs e)
        {
            try
            {
                uc_VehiculoColor1.CargarDatos();
                uc_VehiculoMarca1.CargarDatos();


            }
            catch (Exception ex)
            {
                MessageBox.Show( "Ocrrio un error: "+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
            }
        }
    }
}
