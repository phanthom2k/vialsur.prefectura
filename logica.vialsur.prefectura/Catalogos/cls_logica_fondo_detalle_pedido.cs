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

    public class cls_logica_fondo_detalle_pedido
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

        ///// <summary>
        ///// Retorna los datos de determinada marca segun el ID
        ///// </summary>
        ///// <returns></returns>
        //public entidades.vialsur.prefectura.ve_vehiculo_marca InformacionMarca(int IdMarca)
        //{
        //    try
        //    {
        //        return new cls_data_ve_vehiculo_marca().Consultar_Marca(IdMarca);                
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        /// <summary>
        /// Inserta un nuevo registro de un detalle
        /// </summary>
        /// <param name="detalle"></param>
        public void InsertarDetallePedido(entidades.vialsur.prefectura.fondo_detalle_pedido detalle)
        {
            try
            {
                new cls_data_fondo_detalle_pedido().Insertar(detalle);
                //new cls_data_detalle_pedidos().Insertar(detalle);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarDetallePedido(int id)
        {
            try
            {
                new datos.vialsur.prefectura.cls_data_fondo_detalle_pedido().Eliminar(id);
                //new datos.vialsur.prefectura.cls_data_detalle_pedidos().Eliminar(id);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo eliminara los datos", ex);
            }
        }

        /// <summary>
        /// Consulta un detalle de una orden segun el ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public entidades.vialsur.prefectura.fondo_detalle_pedido ConsultarDetallePedidoById(int id)
        {
            try
            {
                return new cls_data_fondo_detalle_pedido().ConsultarDetalleById(id);
              //return new cls_data_detalle_pedidos().ConsultarDetalleById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Actualiza el detalle segun el ID
        /// </summary>
        /// <param name="detalle"></param>
        public void Actualizar (entidades.vialsur.prefectura.fondo_detalle_pedido detalle)
        {
            try
            {
                new cls_data_fondo_detalle_pedido().Actualizar(detalle);
                //new cls_data_detalle_pedidos().Actualizar(detalle);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// CONSULTA EL DETALLE DE UNA ORDEN DE PARTES Y PIEZAS ACORDE AL  ORDEN_ID
        /// </summary>
        /// <param name="orden_id"></param>
        /// <returns></returns>
        public DataTable ConsultarDetallesByOrden_Id(string orden_id)
        {

            try
            {
                //consulto las registradas
                DataTable dt_partes_fondo_rotativo = new datos.vialsur.prefectura.cls_data_fondo_detalle_pedido().ConsultarDetallesByOrden_Id(orden_id);
                if(dt_partes_fondo_rotativo.Rows.Count==0) // si no hay
                {
                    //consulto las registradas en el pedido normal                    
                    DataTable dt_detalle_pedido_piezas = new datos.vialsur.prefectura.cls_data_detalle_pedidos().ConsultarDetallesByOrden_Id(orden_id);
                    foreach (DataRow dr in dt_detalle_pedido_piezas.Rows)
                    {
                        //mando a insertar
                        string g = dr["detalle"].ToString();
                        //insert
                    }
                    //consulto de nuevo para sacar la informacion
                    dt_partes_fondo_rotativo = new datos.vialsur.prefectura.cls_data_fondo_detalle_pedido().ConsultarDetallesByOrden_Id(orden_id);
                }
                return dt_partes_fondo_rotativo;                                
                //return new datos.vialsur.prefectura.cls_data_detalle_pedidos().ConsultarDetallesByOrden_Id(orden_id);
            }
            catch (Exception ex)
            {
                throw new Exception("cls_logica_fondo_detalle_pedidos:" + ex.Message, ex);
            }
            finally
            {
            }
        }


        /// <summary>
        /// CONSULTA EL CONJUNTO DE DETALLES DE UN DETERMINADO PEDIDO SEGUN EL [ID] DEL PEDIDO
        /// </summary>
        /// <param name="pedido_id"></param>
        /// <returns></returns>
        public DataTable ConsultarDetallesBy_PedidoId(int pedido_id)
        {
            try
            {
                return new datos.vialsur.prefectura.cls_data_fondo_detalle_pedido().ConsultarDetallesBy_PedidoId(pedido_id);
                //return new datos.vialsur.prefectura.cls_data_detalle_pedidos().ConsultarDetallesBy_PedidoId(pedido_id);
            }
            catch (Exception ex)
            {
                throw new Exception("cls_logica_detalle_pedidos:" + ex.Message, ex);
            }
            finally
            {

            }
        }



    }
}
