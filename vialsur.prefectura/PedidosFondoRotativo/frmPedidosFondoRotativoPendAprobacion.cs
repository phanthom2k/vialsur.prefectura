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
    public partial class frmPedidosFondoRotativoPendAprobacion : Form
    {
        public frmPedidosFondoRotativoPendAprobacion()
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

        void CargarDatosGrilla()
        {
            try
            {
                //dataGridView1.DataSource = new logica.vialsur.prefectura.Catalogos.cls_logica_pedidos().ConnsultarOrdenesSegunEstado_UI_customized(entidades.vialsur.prefectura.Orden_TipoEstadoPedido.CREADO);
                dataGridView1.DataSource = new logica.vialsur.prefectura.Catalogos.cls_logica_fondo_pedido().ConnsultarOrdenesSegunEstado_UI_customized(entidades.vialsur.prefectura.Orden_TipoEstadoPedido.CREADO);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmPedidosFondoRotativoPendAprobacion_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatosGrilla();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un problema al intentar consultar los datos." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "cl_ver")   ///VER LA ORDEN EN PDF
            {
                //rpt.cls_RPT_orden_partes_y_piezas objRpt = new rpt.cls_RPT_orden_partes_y_piezas();
                rpt.cls_RPT_orden_fondo_partes_y_piezas objRpt = new rpt.cls_RPT_orden_fondo_partes_y_piezas();
                objRpt.Orden_Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                objRpt.Generar();
                Ordenes.frmVisorOrden_1 frmVisor = new Ordenes.frmVisorOrden_1();
                frmVisor.StartPosition = FormStartPosition.CenterScreen;
                frmVisor.Text = "Orden de pedido de piezas por fondo rotativo";
                frmVisor.RutaArchivo = @"C:\Temp\3.pdf";
                frmVisor.ShowDialog();

            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "cl_aprobar")  //PARA PODER CAMBIAR EL ESTADO A APROBADO
            {
                if (MessageBox.Show("¿Desea aprobar la orden?", "APROBACIÓN DE ORDEN DE PARTES Y PIEZAS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //new logica.vialsur.prefectura.Catalogos.cls_logica_pedidos().ActualizarEstado(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value), true,
                    new logica.vialsur.prefectura.Catalogos.cls_logica_fondo_pedido().ActualizarEstado(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value), true,
                        Empleado.cedula);
                    CargarDatosGrilla();
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["aprobada"].Index)
            {
                if (e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = (value) ? "APROBADA" : "PENDIENTE";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
