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
    public partial class frmOrdenesCambiarEstado : Form
    {
        public string OrdenID { set; get; }
        public string Cedula { set; get; }

        public entidades.vialsur.prefectura.emp_empleado Empleado { get; set; }

        public entidades.vialsur.prefectura.Orden_TipoEstado Estado { get; set; }


        public frmOrdenesCambiarEstado()
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


        }
        entidades.vialsur.prefectura.orden ord;
        private void frmOrdenesCambiarEstado_Load(object sender, EventArgs e)
        {
            try
            {
                ord = new logica.vialsur.prefectura.Catalogos.cls_logica_orden().ConsultarOrdenPorId(OrdenID);
                lbl_EstadoActual.Text = ((entidades.vialsur.prefectura.Orden_TipoEstado)ord.estado).ToString();
                uc_TipoEstadosOrdenes1.CargarDatos();

                if (entidades.vialsur.prefectura.TipoUsuario.ADMINISTRADOR == (entidades.vialsur.prefectura.TipoUsuario)((int)Empleado.tipo_usuario)  |
                    entidades.vialsur.prefectura.TipoUsuario.MECANICO == (entidades.vialsur.prefectura.TipoUsuario)((int)Empleado.tipo_usuario)  )
                {
                    toolStripButton2.Visible = true;
                    uc_TipoEstadosOrdenes1.Enabled = true;
                }
                else
                {
                    toolStripButton2.Visible = false;
                    uc_TipoEstadosOrdenes1.Enabled = false;
                }
                    

                //uc_TipoEstadosOrdenes1.CargarDatos();
                //lbl_EstadoActual.Text = ((entidades.vialsur.prefectura.Orden_TipoEstado)((int)new logica.vialsur.prefectura.Catalogos.cls_logica_orden().ConsultarOrdenPorId(OrdenID).estado)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }            
        }

        private void uc_TipoEstadosOrdenes1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(uc_TipoEstadosOrdenes1.SelectedIndex>0)
            {
                if (ord.estado >= uc_TipoEstadosOrdenes1.SelectedIndex)
                    MessageBox.Show("No puede cambiar a un estado igual o inferior","Cambio",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            ////FALTA IMPLEMENTAR UN CONTROL QUE SOLO PERMITA CAMBIAR ACORDE AL FORMULARIO QUE LO SOLICITA EN ESTE CASO HAY Q INGRESAR UN SWITCH PARA QUE SOLO ALMACENE LA AUTORIZACION
            try
            {
                //if (uc_TipoEstadosOrdenes1.SelectedIndex > 0 &&   uc_TipoEstadosOrdenes1.SelectedIndex  > ord.estado && uc_TipoEstadosOrdenes1.SelectedIndex == (int) Estado  )
                if (uc_TipoEstadosOrdenes1.SelectedIndex > 0 && uc_TipoEstadosOrdenes1.SelectedIndex > ord.estado   &&
                   (((entidades.vialsur.prefectura.Orden_TipoEstado)uc_TipoEstadosOrdenes1.SelectedIndex) == entidades.vialsur.prefectura.Orden_TipoEstado.AUTORIZADO |
                   ((entidades.vialsur.prefectura.Orden_TipoEstado)uc_TipoEstadosOrdenes1.SelectedIndex) == entidades.vialsur.prefectura.Orden_TipoEstado.DESCARTADO)
                   )
                {
                    if (MessageBox.Show("Desea registrar el cambio", "Cambio de estado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        entidades.vialsur.prefectura.Orden_TipoEstado _ii = (entidades.vialsur.prefectura.Orden_TipoEstado)uc_TipoEstadosOrdenes1.SelectedIndex;
                        //new logica.vialsur.prefectura.Catalogos.cls_logica_orde_detalle().ActualizarEstadoOrden(OrdenID, _ii, Cedula);
                        ///si el usuario es el administrador se registrara su cedula para identificar quien autorizo
                        if (entidades.vialsur.prefectura.TipoUsuario.ADMINISTRADOR == (entidades.vialsur.prefectura.TipoUsuario)((int)Empleado.tipo_usuario) )
                            new logica.vialsur.prefectura.Catalogos.cls_logica_orde_detalle().ActualizarEstadoOrden(OrdenID, _ii, Empleado.cedula);
                        else
                            new logica.vialsur.prefectura.Catalogos.cls_logica_orde_detalle().ActualizarEstadoOrden(OrdenID, _ii);
                        DialogResult = DialogResult.Yes;
                    }
                    else
                        DialogResult = DialogResult.No;
                                
                }
                else
                    MessageBox.Show("No puede cambiar a un estado igual o inferior", "Cambio de estado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);                
            }
        }
    }
}

//if you have DropDownList object called ddl you can do it as below
//    ddl.DataSource = Enum.GetNames(typeof(EmployeeType));
//    ddl.DataBind();

//if you want the Enum value Back on Selection....
//   EmployeeType empType = (EmployeeType)Enum.Parse(typeof(EmployeeType), ddl.SelectedValue);