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
    public partial class frmDetalleVistaControlador : Form
    {
        public frmDetalleVistaControlador()
        {
            InitializeComponent();
        }


        public string OrdenID { get; set; }

        private void frmDetalleVistaControlador_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatosGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente error: " +ex.Message);              
            }
        }

        void CargarDatosGrilla()
        {
            try
            {
                dataGridView1.DataSource = new logica.vialsur.prefectura.Catalogos.cls_logica_orde_detalle().ConsultarDetalleOrdenesByIdOrden_UI(OrdenID);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
