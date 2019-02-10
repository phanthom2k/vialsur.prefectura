using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.vialsur.prefectura.Catalogos
{
    using datos.vialsur.prefectura;
    using System.Data.SqlClient;
    using System.Data;

    public    class cls_logica_pedidos_aceite
    {
        //public DataTable UX_Consulta_Todos_Registros()
        //{
        //    try
        //    {
        //        SqlDataReader datos_para_control = new cls_data_ve_vehiculo_marca().Consultar();

        //        DataTable dt_datos = new DataTable("ve_vehiculo_marca");
        //        dt_datos.Load(datos_para_control);                
        //        DataRow dr0 = dt_datos.NewRow();
        //        dr0["id"] = 0;
        //        dr0["nombre"] = "Seleccione";
        //        dt_datos.Rows.InsertAt(dr0, 0);
        //        return dt_datos;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        ///// <summary>
        ///// Lista todos las Marcas Registradas
        ///// </summary>
        ///// <returns></returns>
        //public DataTable Consulta_Todas_Marcas()
        //{
        //    try
        //    {
        //        SqlDataReader datos_para_control = new cls_data_ve_vehiculo_marca().ConsultarTodasMarcas();

        //        DataTable dt_datos = new DataTable("ve_vehiculo_marca");
        //        dt_datos.Load(datos_para_control);               
        //        return dt_datos;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        /// <summary>
        /// CONSULTA EL PEDIDO DE UNA DETERMINADA ORDEN SEGUN ID DE LA ORDEN DE MANTENIMIENTO
        /// </summary>
        /// <param name="ByOrdenID"></param>
        /// <returns></returns>
        public entidades.vialsur.prefectura.pedidos_aceite Consultar_Pedido(string ByOrdenID)
        {
            try
            {
                return new cls_data_pedidos_aceite().Consultar_Pedido(ByOrdenID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// CONSULTA EL PEDIDO ACORDE A SU [ID]
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public entidades.vialsur.prefectura.pedidos_aceite Consultar_PedidoById(int ID)
        {
            try
            {
                return new cls_data_pedidos_aceite().Consultar_PedidoById(ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Inserta un nuevo registro de una nuevo pedido
        /// </summary>
        /// <param name="pedido"></param>
        public void InsertarPedido(entidades.vialsur.prefectura.pedidos_aceite pedido)
        {
            try
            {
                new cls_data_pedidos_aceite().Insertar(pedido);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarObservacion(entidades.vialsur.prefectura.pedidos_aceite pedido)
        {
            try
            {
                new cls_data_pedidos_aceite().ActualizarObservacion(pedido);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarEstado(int pedido_id, bool estado, string cedula_autoriza)
        {
            try
            { 
                new cls_data_pedidos_aceite().ActualizarEstado(pedido_id, estado, cedula_autoriza);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retorna las ordenes de pedidos de piezas para ser mostradas en la UI por estado o con incluido el creador
        /// </summary>
        /// <param name="estado"></param>
        /// <param name="Cedula">Por defecto cedula es ""</param>
        /// <returns></returns>
        public System.Data.DataTable ConnsultarOrdenesSegunEstado_UI_customized(entidades.vialsur.prefectura.Orden_TipoEstadoPedido estado, string Cedula="")
        {
            try
            {
                return new cls_data_pedidos_aceite().ObtenerOrdenesByEstado_UI(estado, Cedula); 
                ///System.Data.DataTable dt = new cls_data_pedidos().ObtenerOrdenesByEstado_UI(estado);

                //System.Data.DataTable dt_clodana = dt.Clone();
                //dt_clodana.Columns["tipo_oden"].DataType = typeof(string);
                //dt_clodana.Columns["ve_vehiculo_id"].DataType = typeof(string);
                //dt_clodana.Columns["estado"].DataType = typeof(string);
                //dt_clodana.Columns["hora"].DataType = typeof(string);

                //foreach (System.Data.DataRow dr in dt.Rows)
                //{
                //    dt_clodana.LoadDataRow(dr.ItemArray, false);
                //}
                //dt.Clear();
                //dt.Dispose();


                //for (int i = 0; i < dt_clodana.Rows.Count; i++)
                //{
                //    entidades.vialsur.prefectura.per_persona persona_responsable = new logica.vialsur.prefectura.Catalogos.cls_logica_per_persona().Consultar_Per_Persona(
                //                                                                dt_clodana.Rows[i]["cedula_responsable"].ToString());

                //    dt_clodana.Rows[i]["cedula_responsable"] = persona_responsable.apellidos + ", " + persona_responsable.nombres;

                //    entidades.vialsur.prefectura.per_persona persona_chofer = new logica.vialsur.prefectura.Catalogos.cls_logica_per_persona().Consultar_Per_Persona(
                //                                                                dt_clodana.Rows[i]["chofer"].ToString());

                //    dt_clodana.Rows[i]["chofer"] = persona_chofer.apellidos + ", " + persona_chofer.nombres;

                //    dt_clodana.Rows[i]["tipo_oden"] = Orden_TipoMantenimientoById(int.Parse(dt_clodana.Rows[i]["tipo_oden"].ToString()));

                //    dt_clodana.Rows[i]["ve_vehiculo_id"] = new logica.vialsur.prefectura.Catalogos.cls_logica_ve_vehiculo().GetPlacaById(int.Parse(dt_clodana.Rows[i]["ve_vehiculo_id"].ToString()));

                //    dt_clodana.Rows[i]["estado"] = Orden_TipoEstadoById(int.Parse(dt_clodana.Rows[i]["estado"].ToString()));
                //    dt_clodana.Rows[i]["hora"] = dt_clodana.Rows[i]["hora"].ToString().Substring(0, 5);

                //    dt_clodana.Rows[i]["per_persona_cedula_crea"] = new logica.vialsur.prefectura.Catalogos.cls_logica_per_persona().Consultar_Per_Persona(
                //                                                               dt_clodana.Rows[i]["per_persona_cedula_crea"].ToString()).ApellidosNombres;
                //}
                //return dt_clodana;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public bool ActualizarMarca(entidades.vialsur.prefectura.ve_vehiculo_marca marca)
        //{
        //    try
        //    {
        //        return new cls_data_ve_vehiculo_marca().Actualizar(marca);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}





    }
}
