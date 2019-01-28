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
    public partial class frmDetalleVistaControlador : Form
    {
        public frmDetalleVistaControlador()
        {
            InitializeComponent();
            toolStripButton3.Visible = false;


            //printer-icon.png

            Resources.clsManejadorImagenes img = new Resources.clsManejadorImagenes();
            toolStrip1.ImageList = img.GetCatalog();            
            img.SetImage48("box-out-icon.png", "mark");           
            toolStripButton2.ImageKey = "mark";

            img.SetImage48("logout-icon.png", "door_out");
            toolStripButton1.ImageKey = "door_out";

            img.SetImage48("cloud-sync-icon.png", "disk");
            toolStripButton3.ImageKey = "disk";

            img.SetImage48("Shopping-basket-add-icon.png", "basket");
            toolStripButton4.ImageKey = "basket";

            img.SetImage48("printer-icon.png", "printer-icon");
            toolStripButton6.ImageKey = "printer-icon";

            img.SetImage48("oil-drum-icon.png", "oil-drum-icon");
            toolStripButton5.ImageKey = "oil-drum-icon";
        }
        /// <summary>
        /// Num. CEdula del aprovador
        /// </summary>
        public string Cedula { get; set; }

        public string Cedula_mecanico { get; set; }

        public bool EsCambioEstado { set { toolStripButton3.Visible = value;  } }

        public string OrdenID { get; set; }

        public entidades.vialsur.prefectura.emp_empleado Empleado { get; set; }

        orden obj_orden;

        ve_vehiculo obj_vehiculo;
        /// <summary>
        /// Obtiene o establece la informacion del vehiculo que se usara
        /// </summary>
     /*   public ve_vehiculo Obj_vehiculo
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
        */

       
        private void frmDetalleVistaControlador_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatosGrilla();
                obj_orden = new logica.vialsur.prefectura.Orden.cls_logica_orden().ConsultarOrden(OrdenID);
                ve_vehiculo_responsable obj_ve_resp = obj_orden.ve_vehiculo_responsable.FirstOrDefault();
                obj_vehiculo = obj_ve_resp.ve_vehiculo;

                MostrarInformacionVehiculo(obj_vehiculo, obj_orden);
                //EN EL CASO DE QUE ESTE FINALIZADO O DESCARTADO
                if (obj_orden.estado == (int) entidades.vialsur.prefectura.Orden_TipoEstado.FINALIZADO |
                    obj_orden.estado == (int)entidades.vialsur.prefectura.Orden_TipoEstado.DESCARTADO )
                {
                    toolStripButton4.Visible = toolStripButton2.Enabled = toolStripButton4.Enabled = false;
                    //toolStripButton2.Enabled =
                }
                
                //habilita para que el administrador pueda cambiar el estado
                if (entidades.vialsur.prefectura.TipoUsuario.ADMINISTRADOR == (entidades.vialsur.prefectura.TipoUsuario)((int)Empleado.tipo_usuario))
                     toolStripButton3.Visible = true;
                
                //HABILITA PARA QUE EL MECANICO O EL DESIGNADO PUEDA MARCAR salida y soliictar partes
                if (entidades.vialsur.prefectura.TipoUsuario.MECANICO == (entidades.vialsur.prefectura.TipoUsuario)((int)Empleado.tipo_usuario)
                    || obj_ve_resp.per_persona_cedula == Empleado.cedula  )
                    toolStripButton4.Visible =  toolStripButton2.Visible = true;
                
                ///EN EL CASO DE QUE ESTE EN ESTADO CREADO Y SEA  MECANICO
                if(entidades.vialsur.prefectura.Orden_TipoEstado.CREADO  == (entidades.vialsur.prefectura.Orden_TipoEstado)((int)obj_orden.estado) &&
                    entidades.vialsur.prefectura.TipoUsuario.MECANICO == (entidades.vialsur.prefectura.TipoUsuario)((int)Empleado.tipo_usuario)   )
                {
                    toolStripButton2.Visible = false;
                    dataGridView1.Columns["cl_ver"].Visible = false;
                }  //toolStripButton2

                //PARA QUE SE HABILITE LA COLUMNA PARA QUITAR O AÑADIR UN TRABAJO
                if (entidades.vialsur.prefectura.TipoUsuario.ADMINISTRADOR == (entidades.vialsur.prefectura.TipoUsuario)((int)Empleado.tipo_usuario) &
                    obj_orden.estado == (int)entidades.vialsur.prefectura.Orden_TipoEstado.CREADO )
                {                    
                    dataGridView1.Columns["cl_modificar"].Visible = true;
                }

                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente error: " +ex.Message);              
            }
        }


        void MostrarInformacionVehiculo(entidades.vialsur.prefectura.ve_vehiculo vehiculo, entidades.vialsur.prefectura.orden ord)
        {
            try
            {
                if (vehiculo != null)
                {
                    lbk_codigo.Text = vehiculo.codigo;
                    // lbl_codigo_anterior.Text = vehiculo.codigo_anterior;
                    entidades.vialsur.prefectura.ve_vehiculo_modelo mod = vehiculo.ve_vehiculo_modelo;
                    entidades.vialsur.prefectura.ve_vehiculo_marca mar = mod.ve_vehiculo_marca;
                    lbl_marca.Text = mar.nombre;
                    lbl_modelo.Text = mod.modelo;
                    //  lbl_pais_fabricacion.Text = vehiculo.PaisCodigo;
                    entidades.vialsur.prefectura.ve_vehiculo_color col = vehiculo.ve_vehiculo_color;
                    lbl_color.Text = col.nombre_comun;
                    lbl_seriemotor.Text = vehiculo.serie_motor;
                    lbl_seriechasis.Text = vehiculo.serie_chasis;
                    // lbl_anofab.Text = vehiculo.anio_fabricacion.ToString();
                    //  lbl_anocomp.Text = vehiculo.anio_compra.ToString();
                    lbl_placa.Text = vehiculo.placa;
                    lbl_placa_prov.Text = vehiculo.placa_provisional;
                    if (vehiculo.estado != null)
                        lbl_estado.Text = (bool)vehiculo.estado ? "Activo" : "Inactivo";
                    lbl_TipoCombustible.Text = ((TipoCombustible)mod.tipo_combustible).ToString(); // == 1 ? "GASOLINA" : "DIESEL";
                    //lbl_TipoVehiculo.Text = (int)mod.clase_vehiculo == 1 ? "LIVIANO" :
                    //                        (int)mod.clase_vehiculo == 2 ? "PESADO" : "NO DEFINIDO";
                    lbl_TipoVehiculo.Text = ((ClaseVehiculo)mod.clase_vehiculo).ToString();


                    lblTipoMantenimiento.Text = ((Orden_TipoMantenimiento)ord.tipo_oden).ToString();
                    per_persona per = new logica.vialsur.prefectura.Catalogos.cls_logica_per_persona().Consultar_Per_Persona(ord.ve_vehiculo_responsable.FirstOrDefault().per_persona_cedula);
                    lblNombresMecanicoResponsable.Text = per.ApellidosNombres;
                    lblKmIn.Text = ord.km_ingreso + "Km";
                    lblKmOut.Text = ord.km_egreso + "Km";
                    numericTextBox1.Text = ord.km_egreso.ToString();
                    lblFecha.Text = ((DateTime)ord.fecha).ToShortDateString();
                    lblFechaSalida.Text = ord.fecha_cierre!=null?((DateTime)ord.fecha_cierre).ToString():"";
                    LBL_ORDENNO.Text = string.Format("{0:0000000}", int.Parse(ord.id) );
                    LBK_ESTADO.Text = ((entidades.vialsur.prefectura.Orden_TipoEstado)int.Parse(ord.estado.ToString())).ToString();
                    txtObservacion.Text = ord.observacion;

                    label22.Text = new logica.vialsur.prefectura.Catalogos.cls_logica_per_persona().Consultar_Per_Persona(ord.per_persona_cedula_crea).ApellidosNombres;
                    ///obtengo la cedula del mecanico
                    Cedula_mecanico = ord.ve_vehiculo_responsable.FirstOrDefault().per_persona_cedula;
                    //per_persona_cedula_crea

                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (dataGridView1.Columns[e.ColumnIndex].Name == "cl_ver")
                {                    
                    orde_detalle obj_ord_det_temp = new logica.vialsur.prefectura.Catalogos.cls_logica_orde_detalle().ConsultarOrde_DetalleById(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
                    frmSeleccionadorTrabajo objSelecTrab = new frmSeleccionadorTrabajo();
                    objSelecTrab.Obj_orden_detalle = obj_ord_det_temp;
                    objSelecTrab.Obj_vehiculo = obj_vehiculo;
                    objSelecTrab.EstadoOrden  = (int)obj_orden.estado;

                    if (entidades.vialsur.prefectura.TipoUsuario.ADMINISTRADOR == (entidades.vialsur.prefectura.TipoUsuario)((int)Empleado.tipo_usuario) & 
                        obj_orden.ve_vehiculo_responsable.First().per_persona_cedula != Empleado.cedula)
                    {
                        objSelecTrab.EsLectura = true;                        
                    }

                    objSelecTrab.EsMecanicoAtender = objSelecTrab.EsActualizacion = true;
                              
                    objSelecTrab.Tipo_Usuario = (entidades.vialsur.prefectura.TipoUsuario)((int)Empleado.tipo_usuario);
                    if (objSelecTrab.ShowDialog() == DialogResult.Yes )
                    {
                        entidades.vialsur.prefectura.orde_detalle obj_orden_detalle = objSelecTrab.Obj_orden_detalle;
                        new logica.vialsur.prefectura.Catalogos.cls_logica_orde_detalle().ActualizarOrde_Detalle(obj_orden_detalle);
                        CargarDatosGrilla();
                        new logica.vialsur.prefectura.Catalogos.cls_logica_orde_detalle().ActualizarEstadoOrden(OrdenID, entidades.vialsur.prefectura.Orden_TipoEstado.EJECUCION);
                    }
                }

              //   frmPersonal_Nuevo frm_personal = new frmPersonal_Nuevo();
                 if (dataGridView1.Columns[e.ColumnIndex].Name == "cl_modificar" & dataGridView1.RowCount > 0)
                 {
                    if (MessageBox.Show("¿Desea cambiar el estado?","Alerta",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        new logica.vialsur.prefectura.Catalogos.cls_logica_orde_detalle().Actualizar_Estado_Agendado(Convert.ToInt32( dataGridView1.Rows[e.RowIndex].Cells["id"].Value),
                            dataGridView1.Rows[e.RowIndex].Cells["estado_agendado"].Value.ToString()== "Programado" ? false:true
                            );
                        CargarDatosGrilla();
                    }
                    //"Programado"True : "Descartado"False





                 /*    frm_personal.EsVer = true;
                     frm_personal.EsNuevo = false;
                     frm_personal.EsModificar = true;
                     frm_personal.Cedula = dataGridView1.Rows[e.RowIndex].Cells["cedula"].Value.ToString();
                     */

                    //frmVehiculo_Nuevo frm_Vehiculo = new frmVehiculo_Nuevo();
                    //frm_Vehiculo.EsNuevo = false;
                    //frm_Vehiculo.Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
                    //frm_Vehiculo.EsVer = dataGridView1.Columns[e.ColumnIndex].Name == "cl_ver" ? true : false;
                    //frm_Vehiculo.ShowDialog();
                    //frm_Vehiculo.Dispose();
                    //btn_Buscar_Click(sender, e);
                }  

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("¿Desea marcar la salida del vehiculo?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)==DialogResult.Yes)
                {
                    if(numericTextBox1.Text!="")
                    {
                        if (numericTextBox1.IntValue > 0)
                        {
                            if (new logica.vialsur.prefectura.Catalogos.cls_logica_orden().ConsultarKilometrajeDeVehiculo(obj_vehiculo.placa) <= numericTextBox1.IntValue)
                            {
                                if (new logica.vialsur.prefectura.Orden.cls_logica_orden().VerificarCumplimientoDetallesAsignados(OrdenID))
                                {

                                    new logica.vialsur.prefectura.Catalogos.cls_logica_orde_detalle().ActualizarEstadoOrden(OrdenID, Orden_TipoEstado.FINALIZADO, numericTextBox1.IntValue);
                                    this.Close();
                                }
                                else
                                    MessageBox.Show("Aun tiene trabajos pendientes que realizar en la orden","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                MessageBox.Show("Kilometraje de salida ingresado es inferior al registrado (" + new logica.vialsur.prefectura.Catalogos.cls_logica_orden().ConsultarKilometrajeDeVehiculo(obj_vehiculo.placa) + "Km)");
                            }
                        }
                        else
                            MessageBox.Show("Kilometraje de salida es 0");
                    }
                    else
                    {
                        MessageBox.Show("No ha ingresado un kilometraje", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                                        
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error"+ex.Message);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                var objFrmCambioEstado = new frmOrdenesCambiarEstado();
                objFrmCambioEstado.OrdenID = this.OrdenID;
                //                objFrmCambioEstado.Cedula = this.Cedula;
                //objFrmCambioEstado.Cedula = Empleado.cedula;
                objFrmCambioEstado.Empleado = Empleado;                

            //    objFrmCambioEstado.Estado = entidades.vialsur.prefectura.Orden_TipoEstado.AUTORIZADO | entidades.vialsur.prefectura.Orden_TipoEstado.DESCARTADO;  //COMENTO ESTO
               
                if (objFrmCambioEstado.ShowDialog() == DialogResult.Yes) 
                {
                    obj_orden = new logica.vialsur.prefectura.Orden.cls_logica_orden().ConsultarOrden(OrdenID);
                    MostrarInformacionVehiculo(obj_vehiculo, obj_orden);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error "+ex.Message);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {  ///SOLICITAR PARTES
            try
            {                
                var _pedido = new entidades.vialsur.prefectura.pedidos();
                _pedido.cedula = Cedula_mecanico;
                _pedido.orden_id = OrdenID;  //id de la orden de mantenimiento
                    

                var objPedido = new logica.vialsur.prefectura.Catalogos.cls_logica_pedidos();
                //verificar que ya este creado la orden
                if(  objPedido.Consultar_Pedido(OrdenID).cedula == null)
                {
                    if (MessageBox.Show("¿Desea solicitar partes?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        objPedido.InsertarPedido(_pedido);
                }
                if(  objPedido.Consultar_Pedido(OrdenID).cedula != null)
                {
                    var frmPedido = new vialsur.prefectura.Pedidos.frmPedidosOrden();
                    frmPedido.OrdenID = OrdenID;
                    frmPedido.ShowDialog();
                }
                
                                

                /*
                var objFrmCambioEstado = new frmOrdenesCambiarEstado();
                objFrmCambioEstado.OrdenID = this.OrdenID;
                //                objFrmCambioEstado.Cedula = this.Cedula;
                //objFrmCambioEstado.Cedula = Empleado.cedula;
                objFrmCambioEstado.Empleado = Empleado;

                //    objFrmCambioEstado.Estado = entidades.vialsur.prefectura.Orden_TipoEstado.AUTORIZADO | entidades.vialsur.prefectura.Orden_TipoEstado.DESCARTADO;  //COMENTO ESTO

                if (objFrmCambioEstado.ShowDialog() == DialogResult.Yes)
                {
                    obj_orden = new logica.vialsur.prefectura.Orden.cls_logica_orden().ConsultarOrden(OrdenID);
                    MostrarInformacionVehiculo(obj_vehiculo, obj_orden);
                }  */
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        { ///lubricantes




        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            try
            {
                rpt.cls_RPT_orden_individual objRpt = new rpt.cls_RPT_orden_individual();
                objRpt.Orden_Id = OrdenID;
                objRpt.Generar();
                Ordenes.frmVisorOrden_1 frmVisor = new Ordenes.frmVisorOrden_1();
                frmVisor.RutaArchivo = @"C:\Temp\1.pdf";
                frmVisor.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema al intentar mostrar la orden","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);                
            }
        }
    }
}
