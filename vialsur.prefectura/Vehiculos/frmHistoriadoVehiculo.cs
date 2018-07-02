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
    public partial class frmHistoriadoVehiculo : Form
    {
        public frmHistoriadoVehiculo()
        {
            InitializeComponent();
        }


        /// <summary>
        /// ID del Behiculo
        /// </summary>
        public int IdVehiculo { get; set; }

        private void frmHistoriadoVehiculo_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatosGrilla();

            }
            catch (Exception ex)
            {
                MessageBox.Show("eRROR:"+ex.Message);
            }
        }




        void CargarDatosGrilla(string id_orden = "")
        {
            try
            {
                DataTable dt = new logica.vialsur.prefectura.Orden.cls_logica_orden().ConnsultarOrdenesAsignadasVehiculoPorIdVehiculo_UI_customized(IdVehiculo, id_orden);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
