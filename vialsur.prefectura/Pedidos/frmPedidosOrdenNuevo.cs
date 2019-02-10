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
    public partial class frmPedidosOrdenNuevo : Form
    {
        public frmPedidosOrdenNuevo()
        {
            InitializeComponent();

            Resources.clsManejadorImagenes img = new Resources.clsManejadorImagenes();
            toolStrip1.ImageList = img.GetCatalog();
            // img.SetImage48("Actions-document-save-icon.png", "disk");
            img.SetImage48("floppy-icon48x48.png", "save");
            //toolStripButton2.ImageKey = "disk";
            toolStripButton2.ImageKey = "save";
            img.SetImage48("logout-icon.png", "door_out");
            toolStripButton1.ImageKey = "door_out";

            //img.SetImage48("file-text-icon48x48.png", "new");          
            //toolStripButton2.ImageKey = "new";


        }
        
        /// <summary>
        /// ID DE LA ORDEN DE PEDIDO DE PARTE
        /// </summary>
        public int PedidoId { get; set; }

        /// <summary>
        /// ID DEL ELEMENTO DEL DETALLE DE LA ORDEN
        /// </summary>
        public int DetallePedidoId { get; set; }

        /// <summary>
        /// TRUE SI ES NUEVO
        /// FALSE SI ES ACTUALIZACION
        /// </summary>
        public bool EsNuevo { get; set; }


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("¿Desea guardar la información?","Alerta",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes && verificar())
                {
                    detalle.cantidad = numericTextBox1.IntValue;
                    detalle.detalle = lettersTextBox1.Text.ToUpper();
                    if (EsNuevo)
                        ///llamo a insert
                        new logica.vialsur.prefectura.Catalogos.cls_logica_detalle_pedidos().InsertarDetallePedido(detalle);
                    else
                        ///llamo a update
                        new logica.vialsur.prefectura.Catalogos.cls_logica_detalle_pedidos().Actualizar(detalle);

                    MessageBox.Show("Datos almacenados con exito", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.Yes;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existio un error al intentar guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Close();
            }
        }
        /// <summary>
        /// Verifica que esten llenos los campos
        /// </summary>
        bool verificar()
        {
            bool _k = true;
            if (numericTextBox1.IntValue < 1)
            {
                 error_Provider1.Alerta(numericTextBox1, "Ingrese un valor valido", Vivaldi.UserControls.Tipo_EP.Rechazar);
                 _k = false;
            }
            else error_Provider1.Alerta(numericTextBox1, "Ingrese un valor valido", Vivaldi.UserControls.Tipo_EP.Aceptar);
                                        
            if (lettersTextBox1.Text == "" || lettersTextBox1.TextLength < 1)
            {
                error_Provider1.Alerta(lettersTextBox1, "Ingrese un valor valido", Vivaldi.UserControls.Tipo_EP.Rechazar);
                _k = false;
            }                
            else error_Provider1.Alerta(lettersTextBox1, "Ingrese un valor valido", Vivaldi.UserControls.Tipo_EP.Aceptar);
            return _k;
        }

        entidades.vialsur.prefectura.detalle_pedidos detalle;

        private void frmPedidosOrdenNuevo_Load(object sender, EventArgs e)
        {
            try
            {
                if(EsNuevo)
                {
                    detalle = new entidades.vialsur.prefectura.detalle_pedidos();
                    detalle.pedidos_id = PedidoId;
                }
                else
                {
                    detalle = new logica.vialsur.prefectura.Catalogos.cls_logica_detalle_pedidos().ConsultarDetallePedidoById(DetallePedidoId);
                    numericTextBox1.Text = detalle.cantidad.ToString();
                    lettersTextBox1.Text = detalle.detalle;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema. "+ex.Message,"Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error); 
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPedidosOrdenNuevo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
