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
    using entidades.vialsur.prefectura;

    public partial class frmSeleccionadorTrabajo : Form
    {
        public frmSeleccionadorTrabajo()
        {
            InitializeComponent();
            EsActualizacion = false;
            EsLectura = false;

            Resources.clsManejadorImagenes img = new Resources.clsManejadorImagenes();
            toolStrip1.ImageList = img.GetCatalog();
            // img.SetImage48("Actions-document-save-icon.png", "disk");
            img.SetImage48("blue-document-icon.png", "new");
            //toolStripButton2.ImageKey = "disk";
            toolStripButton2.ImageKey = "new";
            img.SetImage48("logout-icon.png", "door_out");
            toolStripButton1.ImageKey = "door_out";



        }
        
        public bool EsActualizacion { get; set; }
        public bool EsLectura { get; set; }
        public int EstadoOrden { get; set; }

        public bool EsMecanicoAtender { get; set; }

        void Congelar()
        {
            toolStripButton2.Enabled = !EsLectura;
            if (EsMecanicoAtender  )
            {
                uc_Catalogo_Parte_Principal1.Enabled = uc_Catalogo_Parte_Secundaria1.Enabled =
                uc_Accion1.Enabled = numericUpDown1.Enabled = false;
            }
            else uc_Accion2.Enabled = false;

            //if( EstadoOrden != 3 | EstadoOrden != 0 )
            if (EstadoOrden == (int)entidades.vialsur.prefectura.Orden_TipoEstado.FINALIZADO ) //|
                //EstadoOrden != (int)entidades.vialsur.prefectura.Orden_TipoEstado.NO_DEFINIDO )
            {
                uc_Catalogo_Parte_Principal1.Enabled = uc_Catalogo_Parte_Secundaria1.Enabled =
                uc_Accion1.Enabled = uc_Accion2.Enabled =  numericUpDown1.Enabled = lettersTextBox1.Enabled =
                toolStripButton2.Enabled = false;
            }

        //    NO_DEFINIDO = 0,
        //CREADO = 1,
        //AUTORIZADO = 2,
        //EJECUCION = 3,
        //FINALIZADO = 4,
        //DESCARTADO = 5

        }

        ve_vehiculo obj_vehiculo;
        /// <summary>
        /// Obtiene o establece la informacion del vehiculo que se usara
        /// </summary>
        public ve_vehiculo Obj_vehiculo
        {
            get
            {
                return obj_vehiculo;
            }

            set
            {
                obj_vehiculo = value;
            }
        }
        entidades.vialsur.prefectura.orde_detalle obj_orden_detalle;

        public orde_detalle Obj_orden_detalle
        {
            get
            {
                return obj_orden_detalle;
            }

            set
            {
                obj_orden_detalle = value;
            }
        }

        private void frmSeleccionadorTrabajo_Load(object sender, EventArgs e)
        {
            
            uc_Catalogo_Parte_Principal1.CargarDatos();
            uc_Catalogo_Parte_Secundaria1.CargarDatos();
            uc_Accion1.CargarDatos();
            uc_Accion2.CargarDatos();

            if (obj_orden_detalle != null )  //para mostrar para modificar
            {
                uc_Catalogo_Parte_Principal1.SelectedValue = obj_orden_detalle.catalogo_parte_principal_id;
                uc_Catalogo_Parte_Secundaria1.SelectedValue = obj_orden_detalle.catalogo_parte_secundaria_id;
                uc_Accion1.SelectedValue = obj_orden_detalle.accion_requerida;
                uc_Accion2.SelectedValue = obj_orden_detalle.accion_realizada;
                numericUpDown1.Value = Convert.ToInt32(obj_orden_detalle.cantidad);
                lettersTextBox1.Text = obj_orden_detalle.observacion;
                checkBox1.Checked = (bool)obj_orden_detalle.estado;
            }
            else  //en el caso de que sea nueva
                    obj_orden_detalle = new orde_detalle();

            Congelar();
        }


        private void uc_Catalogo_Parte_Principal1_SelectedIndexChanged(object sender, EventArgs e)
        {
            uc_Catalogo_Parte_Secundaria1.CargarDatos((int)uc_Catalogo_Parte_Principal1.SelectedValue,                                                        
                                                        (entidades.vialsur.prefectura.TipoSubParte__catalogo_parte_secundiaria)obj_vehiculo.ve_vehiculo_modelo.clase_vehiculo,
                                                        entidades.vialsur.prefectura.Estado_catalogo_parte_secundiaria.ACTIVO);
        }
        
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(!EsActualizacion) //si es nuevo
            {
                obj_orden_detalle.id = DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            }
                        
            obj_orden_detalle.catalogo_parte_principal_id = (int)uc_Catalogo_Parte_Principal1.SelectedValue;
            obj_orden_detalle.catalogo_parte_secundaria_id = (int)uc_Catalogo_Parte_Secundaria1.SelectedValue;
            obj_orden_detalle.accion_requerida = (int)uc_Accion1.SelectedValue;
            obj_orden_detalle.cantidad = (int)numericUpDown1.Value;
            obj_orden_detalle.observacion = lettersTextBox1.Text;
            obj_orden_detalle.estado = checkBox1.Enabled;
            if(EsMecanicoAtender) obj_orden_detalle.accion_realizada = (int)uc_Accion2.SelectedValue;

            this.DialogResult = DialogResult.Yes;
            this.Close();


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
