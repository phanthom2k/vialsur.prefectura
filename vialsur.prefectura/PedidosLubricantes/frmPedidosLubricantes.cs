using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vialsur.prefectura.PedidosLubricantes
{
    public partial class frmPedidosLubricantes : Form
    {
        public frmPedidosLubricantes()
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

        private void frmPedidosLubricantes_Load(object sender, EventArgs e)
        {
            try
            {
                if (entidades.vialsur.prefectura.TipoUsuario.ADMINISTRADOR == (entidades.vialsur.prefectura.TipoUsuario)((int)Empleado.tipo_usuario))
                {   //EN EL CASO DEL ADMINISTRADOR
                    CargarDatosGrilla(entidades.vialsur.prefectura.Orden_TipoEstadoPedido.AUTORIZADO);
                }
                else
                {   //EN EL CASO DE QUE SE LOGUEE COMO MECANICO U OTRO                    
                    CargarDatosGrilla(entidades.vialsur.prefectura.Orden_TipoEstadoPedido.AUTORIZADO, Empleado.cedula);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un problema al intentar consultar los datos." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// cedula del usuario
        /// </summary>
        public string Cedula { get; set; }
        void CargarDatosGrilla(entidades.vialsur.prefectura.Orden_TipoEstadoPedido T, string C = "")
        {
            try
            {
                dataGridView1.DataSource = new logica.vialsur.prefectura.Catalogos.cls_logica_pedidos_aceite().ConnsultarOrdenesSegunEstado_UI_customized(
                                                                                                        T, C
                                                                                                      );
                //dataGridView1.DataSource = new logica.vialsur.prefectura.Catalogos.cls_logica_pedidos().ConnsultarOrdenesSegunEstado_UI_customized(
//                                                                                                        T, C
                                                                                                 //     );
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
            try
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "cl_ver")   ///VER LA ORDEN EN PDF
                {
                    
                    rpt.cls_RPT_orden_lubicantes objRpt = new rpt.cls_RPT_orden_lubicantes();
                    objRpt.Orden_Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                    objRpt.Generar();
                    Ordenes.frmVisorOrden_1 frmVisor = new Ordenes.frmVisorOrden_1();
                    frmVisor.StartPosition = FormStartPosition.CenterScreen;
                    frmVisor.Text = "Orden de pedido de lubricantes";
                    frmVisor.RutaArchivo = @"C:\Temp\4.pdf";
                    frmVisor.ShowDialog();                   
                   
                }

                //if (dataGridView1.Columns[e.ColumnIndex].Name == "cl_aprobar")  //PARA PODER CAMBIAR EL ESTADO A APROBADO
                //{
                //    //frmDetalleVistaControlador frmDetalle = new frmDetalleVistaControlador();
                //    //frmDetalle.OrdenID = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                //    //// frmDetalle.EsCambioEstado = true;  ///comento para que se habilite acorde al usuario esto controlo en el frm DetalleVistaCOntrolador
                //    ////frmDetalle.Cedula = this.Cedula;
                //    //frmDetalle.Empleado = Empleado;
                //    //frmDetalle.ShowDialog();
                //    //frmDetalle.Dispose();
                //    //CargarDatosGrilla();
                //}
                if (dataGridView1.Columns[e.ColumnIndex].Name == "cl_solicitar")  //solicitar partes por fondo rotativo
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                entidades.vialsur.prefectura.Orden_TipoEstadoPedido p =
                    (entidades.vialsur.prefectura.Orden_TipoEstadoPedido)Enum.Parse(typeof(entidades.vialsur.prefectura.Orden_TipoEstadoPedido),
                                                                                    uc_Orden_TipoEstadoPedido1.SelectedValue.ToString());
                //   EmployeeType empType = (EmployeeType)Enum.Parse(typeof(EmployeeType), ddl.SelectedValue);

                CargarDatosGrilla(p, Empleado.cedula);

                if (entidades.vialsur.prefectura.TipoUsuario.ADMINISTRADOR == (entidades.vialsur.prefectura.TipoUsuario)((int)Empleado.tipo_usuario))
                {   //EN EL CASO DEL ADMINISTRADOR
                    CargarDatosGrilla(p);
                }
                else
                {   //EN EL CASO DE QUE SE LOGUEE COMO MECANICO U OTRO                    
                    CargarDatosGrilla(p, Empleado.cedula);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema al intentar consultar los datos." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["aprobada"].Index)
            {
                if (e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = (value) ? "APROBADA" : "PENDIENTE APROB.";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
