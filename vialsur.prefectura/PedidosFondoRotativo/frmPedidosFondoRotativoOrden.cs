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
    public partial class frmPedidosFondoRotativoOrden : Form
    {
        public frmPedidosFondoRotativoOrden()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ID DE LA ORDEN DE TRABAJO
        /// </summary>
        public string OrdenID { get; set; }

        public bool FondoRotativo { get; set; }

        entidades.vialsur.prefectura.fondo_pedido pedido;
        private void frmPedidosFondoRotativoOrden_Load(object sender, EventArgs e)
        {
            try
            {  //verificar si esta grabado o si no consultar el pedido normal


                pedido = new logica.vialsur.prefectura.Catalogos.cls_logica_fondo_pedido().Consultar_Pedido(OrdenID);


                //pedido = new logica.vialsur.prefectura.Catalogos.cls_logica_pedidos().Consultar_Pedido(OrdenID);
                LBL_NUMERO_ORDEN.Text = pedido.id.ToString();
                LBL_FECHA.Text = Convert.ToDateTime(pedido.fecha).ToShortDateString();  //Convert.ToDateTime(row("campofecha")).ToString("dd/MM/yyyy");
                LBL_ESTADO.Text = pedido.aprobada ? "APROBADO" : "CREADO";
                if (pedido.aprobada)
                {
                    lettersTextBox1.Enabled = toolStripButton3.Enabled = toolStripButton2.Enabled = false;
                    dataGridView1.Columns["cl_ver"].Visible = dataGridView1.Columns["cl_modificar"].Visible = false;
                }
                LBL_ORDEN.Text = OrdenID;
                lettersTextBox1.Text = pedido.observaciones;
                CargarDatos();  ///implementar

            }
            catch (Exception ex)
            {
                MessageBox.Show("", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }


        void CargarDatos()
        {
            try
            {
                dataGridView1.DataSource = new logica.vialsur.prefectura.Catalogos.cls_logica_fondo_detalle_pedido().ConsultarDetallesByOrden_Id(OrdenID, pedido.id);
                //dataGridView1.DataSource = new logica.vialsur.prefectura.Catalogos.cls_logica_detalle_pedidos().ConsultarDetallesByOrden_Id(OrdenID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existio un error al intentar cargar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                if (MessageBox.Show("¿Desea guardar los cambios", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    pedido.observaciones = lettersTextBox1.Text.ToUpper();
                    //new logica.vialsur.prefectura.Catalogos.cls_logica_pedidos().ActualizarObservacion(pedido);
                    new logica.vialsur.prefectura.Catalogos.cls_logica_fondo_pedido().ActualizarObservacion(pedido);
                    MessageBox.Show("Datos guardados", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existio un error al intentar guardar la información.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (dataGridView1.Columns[e.ColumnIndex].Name == "cl_ver")
                {
                    var detallepedido = new frmPedidosFondoRotativoNuevo();   //new frmPedidosOrdenNuevo();
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
                    if (MessageBox.Show("¿Desea Eliminar el suministro ingresado?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {                        
                        new logica.vialsur.prefectura.Catalogos.cls_logica_fondo_detalle_pedido().EliminarDetallePedido((int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                        CargarDatos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //NUEVO
            try
            {
                var detallepedido = new frmPedidosFondoRotativoNuevo();  ///new frmPedidosOrdenNuevo();
                detallepedido.EsNuevo = true;
                detallepedido.PedidoId = pedido.id;
                /// detallepedido.DetallePedidoId =  ///este se pone en el caso de que sea actualizacion
                if (detallepedido.ShowDialog() == DialogResult.Yes)
                {
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPedidosFondoRotativoOrden_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
