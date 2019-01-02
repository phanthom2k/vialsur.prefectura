using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vialsur.prefectura.Pedidos
{
    public partial class frmPedidosPendientesAprobacion : Form
    {
        public frmPedidosPendientesAprobacion()
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

        }

        public entidades.vialsur.prefectura.emp_empleado Empleado { get; set; }

        private void frmPedidosPendientesAprobacion_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatosGrilla();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un problema al intentar consultar los datos."+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        void CargarDatosGrilla()
        {
            try
            {
                dataGridView1.DataSource = new logica.vialsur.prefectura.Catalogos.cls_logica_pedidos().ConnsultarOrdenesSegunEstado_UI_customized(entidades.vialsur.prefectura.Orden_TipoEstadoPedido.CREADO);
             //   DataTable dt = new logica.vialsur.prefectura.Orden.cls_logica_orden().ConnsultarOrdenesSegunEstado_UI_customized(Estado);
              //  dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "cl_ver")   ///VER LA ORDEN EN PDF
            {
                rpt.cls_RPT_orden_partes_y_piezas objRpt = new rpt.cls_RPT_orden_partes_y_piezas();
                objRpt.Orden_Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                objRpt.Generar();
                Ordenes.frmVisorOrden_1 frmVisor = new Ordenes.frmVisorOrden_1();
                frmVisor.Text = "Orden de pedido de piezas";
                frmVisor.RutaArchivo = @"C:\Temp\2.pdf";
                frmVisor.ShowDialog();


                //rpt.cls_RPT_orden_individual objRpt = new rpt.cls_RPT_orden_individual();
                //objRpt.Orden_Id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                //objRpt.Generar();
                //Ordenes.frmVisorOrden_1 frmVisor = new Ordenes.frmVisorOrden_1();
                //frmVisor.RutaArchivo = @"C:\Temp\1.pdf";
                //frmVisor.ShowDialog();
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "cl_aprobar")  //PARA PODER CAMBIAR EL ESTADO A APROBADO
            {
                //frmDetalleVistaControlador frmDetalle = new frmDetalleVistaControlador();
                //frmDetalle.OrdenID = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                //// frmDetalle.EsCambioEstado = true;  ///comento para que se habilite acorde al usuario esto controlo en el frm DetalleVistaCOntrolador
                ////frmDetalle.Cedula = this.Cedula;
                //frmDetalle.Empleado = Empleado;
                //frmDetalle.ShowDialog();
                //frmDetalle.Dispose();
                //CargarDatosGrilla();
            }
        }
    }
}
