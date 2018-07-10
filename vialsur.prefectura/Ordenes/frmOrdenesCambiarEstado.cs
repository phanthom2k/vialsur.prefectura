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
        }
        entidades.vialsur.prefectura.orden ord;
        private void frmOrdenesCambiarEstado_Load(object sender, EventArgs e)
        {
            try
            {
                ord = new logica.vialsur.prefectura.Catalogos.cls_logica_orden().ConsultarOrdenPorId(OrdenID);
                lbl_EstadoActual.Text = ((entidades.vialsur.prefectura.Orden_TipoEstado)ord.estado).ToString();
                uc_TipoEstadosOrdenes1.CargarDatos();


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
                if (uc_TipoEstadosOrdenes1.SelectedIndex > 0 &&   uc_TipoEstadosOrdenes1.SelectedIndex  > ord.estado && uc_TipoEstadosOrdenes1.SelectedIndex == (int)Estado)
                {
                    if(MessageBox.Show("Desea registrar el cambio","Cambio de estado",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        entidades.vialsur.prefectura.Orden_TipoEstado _ii = (entidades.vialsur.prefectura.Orden_TipoEstado)uc_TipoEstadosOrdenes1.SelectedIndex;
                        //new logica.vialsur.prefectura.Catalogos.cls_logica_orde_detalle().ActualizarEstadoOrden(OrdenID, _ii, Cedula);                                                    
                        new logica.vialsur.prefectura.Catalogos.cls_logica_orde_detalle().ActualizarEstadoOrden(OrdenID, _ii, Empleado.cedula);
                    }                    
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