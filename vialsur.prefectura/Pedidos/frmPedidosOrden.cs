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
    public partial class frmPedidosOrden : Form
    {
        public frmPedidosOrden()
        {
            InitializeComponent();

            Resources.clsManejadorImagenes img = new Resources.clsManejadorImagenes();
            toolStrip1.ImageList = img.GetCatalog();
            // img.SetImage48("Actions-document-save-icon.png", "disk");
            img.SetImage48("floppy-icon48x48.png", "save");
            //toolStripButton2.ImageKey = "disk";
            toolStripButton3.ImageKey = "save";
            img.SetImage48("logout-icon.png", "door_out");
            toolStripButton1.ImageKey = "door_out";

            img.SetImage48("file-text-icon48x48.png", "new");
            //toolStripButton2.ImageKey = "disk";
            toolStripButton2.ImageKey = "new";

            ///por defecto NO es fondo rotativo
            ///se usa TRUE para cuando mandemos a copiar las columnas para hacer un update
            ///de los items que van a fondo rotativo
            FondoRotativo = false;


        }

        /// <summary>
        /// ID DE LA ORDEN DE TRABAJO
        /// </summary>
        public string OrdenID { get; set; }

        public bool FondoRotativo { get; set; }

        entidades.vialsur.prefectura.pedidos pedido;

        private void frmPedidosOrden_Load(object sender, EventArgs e)
        {
            try
            {

                pedido = new logica.vialsur.prefectura.Catalogos.cls_logica_pedidos().Consultar_Pedido(OrdenID);
                LBL_FECHA.Text = Convert.ToDateTime(pedido.fecha).ToShortDateString();  //Convert.ToDateTime(row("campofecha")).ToString("dd/MM/yyyy");
                LBL_ESTADO.Text = pedido.aprobada ? "APROBADO" : "CREADO";
                LBL_NUMERO_ORDEN.Text = pedido.id.ToString();
                if(pedido.aprobada)
                {
                    lettersTextBox1.Enabled = toolStripButton3.Enabled = toolStripButton2.Enabled = false;
                    dataGridView1.Columns["cl_ver"].Visible = dataGridView1.Columns["cl_modificar"].Visible = false;
                }
                LBL_ORDEN.Text = OrdenID;
                lettersTextBox1.Text = pedido.observaciones;
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        
        void CargarDatos()
        {
            try
            {
                dataGridView1.DataSource = new logica.vialsur.prefectura.Catalogos.cls_logica_detalle_pedidos().ConsultarDetallesByOrden_Id(OrdenID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existio un error al intentar cargar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            /// guarda

            try
            {
                if(MessageBox.Show("¿Desea guardar los cambios","Alerta",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    pedido.observaciones = lettersTextBox1.Text.ToUpper();
                    new logica.vialsur.prefectura.Catalogos.cls_logica_pedidos().ActualizarObservacion(pedido);
                    MessageBox.Show("Datos guardados","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existio un error al intentar guardar la información.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPedidosOrden_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        { //NUEVO
            try
            {
                var detallepedido = new frmPedidosOrdenNuevo();
                detallepedido.EsNuevo = true;
                detallepedido.PedidoId = pedido.id;
                /// detallepedido.DetallePedidoId =  ///este se pone en el caso de que sea actualizacion
                if (detallepedido.ShowDialog() == DialogResult.Yes )
                {
                    CargarDatos();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (dataGridView1.Columns[e.ColumnIndex].Name == "cl_ver")
                {

                    var detallepedido = new frmPedidosOrdenNuevo();
                    detallepedido.EsNuevo = false;
                    detallepedido.PedidoId = pedido.id;
                    detallepedido.DetallePedidoId = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;

                    if (detallepedido.ShowDialog() == DialogResult.Yes)
                    {
                        CargarDatos();
                    }
                    detallepedido.Dispose();

                }
                 
                 if (dataGridView1.Columns[e.ColumnIndex].Name == "cl_modificar" & dataGridView1.RowCount > 0)
                 {
                    if(MessageBox.Show("¿Desea Eliminar el suministro ingresado?","Alerta",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        new logica.vialsur.prefectura.Catalogos.cls_logica_detalle_pedidos().EliminarDetallePedido((int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                        CargarDatos();
                    }                                            
                 }  

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {   
            ///DESPLEGA LA VENTA A DE FONDOS ROTATIVOS
            try
            {
                var _pedidoFondo = new entidades.vialsur.prefectura.fondo_pedido();
                _pedidoFondo.cedula = pedido.cedula; //registra el mecanico que solicita
                _pedidoFondo.orden_id = pedido.orden_id; //registra el la orden de mantenimiento a la que esta vinculada
                
                var objPedido = new logica.vialsur.prefectura.Catalogos.cls_logica_fondo_pedido();
                //verificar que ya este creado la orden
                if (objPedido.Consultar_Pedido(OrdenID).cedula == null)
                {
                    if (MessageBox.Show("¿Desea solicitar partes?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        objPedido.InsertarPedido(_pedidoFondo);
                }
                if (objPedido.Consultar_Pedido(OrdenID).cedula != null)
                {
                    var frmPedido = new vialsur.prefectura.PedidosFondoRotativo.frmPedidosFondoRotativoOrden();
                    frmPedido.OrdenID = OrdenID;
                    frmPedido.ShowDialog();
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }
    }
}
