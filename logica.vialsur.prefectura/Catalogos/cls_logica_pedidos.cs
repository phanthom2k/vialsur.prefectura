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

    public    class cls_logica_pedidos
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
        /// CONSULTA EL PEDIDO DE UNA DETERMINADA ORDEN SEGUN ID DE LA ORDEN
        /// </summary>
        /// <param name="ByOrdenID"></param>
        /// <returns></returns>
        public entidades.vialsur.prefectura.pedidos Consultar_Pedido(string ByOrdenID)
        {
            try
            {
                return new cls_data_pedidos().Consultar_Pedido(ByOrdenID);
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
        public void InsertarPedido(entidades.vialsur.prefectura.pedidos pedido)
        {
            try
            {
                new cls_data_pedidos().Insertar(pedido);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarObservacion(entidades.vialsur.prefectura.pedidos pedido)
        {
            try
            {
                new cls_data_pedidos().ActualizarObservacion(pedido);
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
