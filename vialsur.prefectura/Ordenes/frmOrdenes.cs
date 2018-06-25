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

        void CargarDatosGrilla(string cedula="", string Placa="", string id_orden="")
        {
            try
            {
                dataGridView1.DataSource = new logica.vialsur.prefectura.Orden.cls_logica_orden().ConnsultarOrdenesAsignadasTecnicosPorCedula_UI(cedula, Placa, id_orden);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmOrdenes_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatosGrilla("1104126626");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
