﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos.vialsur.prefectura
{
    using System.Data;
    using System.Configuration;
    using System.Data.SqlClient;
    using Microsoft.ApplicationBlocks.Data;

    public class cls_data_pedidos
    {

        private string _con = String.Empty;
        public cls_data_pedidos()
        {
            this._con = ConfigurationManager.ConnectionStrings["db_mantenimiento"].ConnectionString;
        }
        ~cls_data_pedidos()
        {
            this._con = String.Empty;
        }

     /////   private string sql_Consulta = "SELECT id, nombre, obserbacion FROM ve_vehiculo_marca where activo=1 order by nombre asc;";

        /// <summary>
        /// Inserta nuevo registro
        /// </summary>
        /// <param name="marca"></param>
        public void Insertar(entidades.vialsur.prefectura.pedidos pedido)
        {            
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                #region parametros              
                SqlParameter _fecha = new SqlParameter("@fecha", SqlDbType.Date);
                _fecha.Value = DateTime.Now;
                parameters.Add(_fecha);

                SqlParameter _obserbacion = new SqlParameter("@cedula", SqlDbType.VarChar, 10);
                _obserbacion.Value = pedido.cedula;
                parameters.Add(_obserbacion);

                SqlParameter _orden_id = new SqlParameter("@orden_id", SqlDbType.VarChar, 10);
                _orden_id.Value = pedido.orden_id;
                parameters.Add(_orden_id);

                #endregion

                string _sql_insert = "INSERT INTO[dbo].[pedidos]([id],[fecha],[cedula],[orden_id],[aprobada]) VALUES(dbo.FUN_PEDIDOS_SEC(),@fecha,@cedula,@orden_id,0); ";                                                         

                SqlHelper.ExecuteNonQuery(_con, CommandType.Text, _sql_insert, parameters.ToArray());

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo registrar los datos de la persona", ex);
            }                    
        }

        
        public void ActualizarObservacion(entidades.vialsur.prefectura.pedidos pedido)
        {            
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                #region parametros
                SqlParameter _orden_id = new SqlParameter("@orden_id", SqlDbType.NVarChar,10 );
                _orden_id.Value = pedido.orden_id;
                parameters.Add(_orden_id);

                SqlParameter _observaciones = new SqlParameter("@observaciones", SqlDbType.Text);
                _observaciones.Value = pedido.observaciones;
                parameters.Add(_observaciones);

                //SqlParameter _obserbacion = new SqlParameter("@obserbacion", SqlDbType.VarChar, 150);
                //_obserbacion.Value = marca.obserbacion;
                //parameters.Add(_obserbacion);

                //SqlParameter _activo = new SqlParameter("@activo", SqlDbType.Bit);
                //_activo.Value = marca.activo;
                //parameters.Add(_activo);
                #endregion

                string _sql_UPDATE = "UPDATE[dbo].[pedidos] SET [observaciones] = @observaciones  WHERE[orden_id] = @orden_id;";

                SqlHelper.ExecuteNonQuery(_con, CommandType.Text, _sql_UPDATE, parameters.ToArray());
                            
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo registrar los datos de la persona", ex);
            }
        }
        /// <summary>
        /// Actualiza el estado segun su ID
        /// </summary>
        /// <param name="pedido_id"></param>
        /// <param name="estado"></param>
        public void ActualizarEstado(int pedido_id, bool estado, string cedula)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                #region parametros
                SqlParameter _pedido_id = new SqlParameter("@pedido_id", SqlDbType.Int);
                _pedido_id.Value = pedido_id;
                parameters.Add(_pedido_id);


                SqlParameter _aprobada = new SqlParameter("@aprobada", SqlDbType.Bit);
                _aprobada.Value = estado;
                parameters.Add(_aprobada);

                SqlParameter _cedula = new SqlParameter("@cedula_autoriza", SqlDbType.VarChar, 10);
                _cedula.Value = cedula;
                parameters.Add(_cedula);

                #endregion

                string _sql_UPDATE = "UPDATE[dbo].[pedidos] SET [aprobada] = @aprobada, [cedula_autoriza] =@cedula_autoriza   WHERE [id] = @pedido_id;";
                
                //FALTA INCLUIR QUIEN AUTORIZA EL NUMERO DE CEDULA

                SqlHelper.ExecuteNonQuery(_con, CommandType.Text, _sql_UPDATE, parameters.ToArray());

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo registrar los datos", ex);
            }
        }


        ///// <summary>
        ///// COnsulta los detalles segun la ORDEN_ID
        ///// </summary>
        ///// <param name="orden_id"></param>
        ///// <returns></returns>
        //public SqlDataReader Consultar(string orden_id)
        //{
        //    string sql_Consulta = "SELECT detalle_pedidos.id, detalle_pedidos.pedidos_id, detalle_pedidos.cantidad, detalle_pedidos.detalle, pedidos.orden_id " +
        //                          "FROM pedidos INNER JOIN detalle_pedidos ON pedidos.id = detalle_pedidos.pedidos_id AND pedidos.orden_id=@orden_id";
        //    try
        //    {

        //        List<SqlParameter> parameters = new List<SqlParameter>();
        //        SqlParameter _orden_id = new SqlParameter("@orden_id", SqlDbType.NVarChar, 10);
        //        _orden_id.Value = orden_id;
        //        parameters.Add(_orden_id);

        //        return SqlHelper.ExecuteReader(_con, CommandType.Text, sql_Consulta, parameters.ToArray());
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("cls_data_pedidos:" + ex.Message, ex);
        //    }
        //    finally
        //    {

        //    }
        //}


        /// <summary>
        /// Retorna un SqlDataReader con todas las marcas disponibles en el catalogo
        /// </summary>
        /// <returns></returns>
        /*   public SqlDataReader ConsultarTodasMarcas()
           {
               try
               {
                   string _sql = "SELECT id, nombre, obserbacion, activo FROM ve_vehiculo_marca order by nombre asc;";
                   return SqlHelper.ExecuteReader(_con, CommandType.Text, _sql);
               }
               catch (Exception ex)
               {
                   throw new Exception("cls_data_ve_vehiculo_marca:" + ex.Message, ex);
               }
               finally
               {

               }
           }  */

        /// <summary>
        /// Consulta los datos de la PEDIDO segun ORDEN_ID
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public entidades.vialsur.prefectura.pedidos Consultar_Pedido(string ByOrdenID )
        {
            try
            {

                string consulta = "SELECT [id],[fecha],[cedula],[observaciones],[orden_id],[aprobada] FROM [dbo].[pedidos] WHERE [orden_id] = @orden_id";

                SqlParameter parametro = new SqlParameter("@orden_id", SqlDbType.VarChar,10 );
                parametro.Value = ByOrdenID.Replace(" ", "");

                entidades.vialsur.prefectura.pedidos obj_pedido = new entidades.vialsur.prefectura.pedidos();

                SqlDataReader dr_datos = SqlHelper.ExecuteReader(_con, CommandType.Text, consulta, parametro);
                while (dr_datos.Read())
                {
                    obj_pedido.id = (int)dr_datos["id"];
                    obj_pedido.fecha = Convert.ToDateTime(dr_datos["fecha"]);
                    obj_pedido.cedula = dr_datos["cedula"].ToString();
                    obj_pedido.observaciones = dr_datos["observaciones"].ToString();
                    obj_pedido.orden_id = dr_datos["orden_id"].ToString();
                    obj_pedido.aprobada = (bool) dr_datos["aprobada"];

                    //obj_marca.id = (int)dr_datos["id"];
                    //obj_marca.nombre = dr_datos["nombre"].ToString();
                    //obj_marca.obserbacion = dr_datos["obserbacion"].ToString();
                    //obj_marca.activo = (bool)dr_datos["activo"];
                }
                dr_datos.Close();
                return obj_pedido;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// Consulta un determinado pedido segun su ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public entidades.vialsur.prefectura.pedidos Consultar_PedidoById(int ID)
        {
            try
            {

                string consulta = "SELECT [id],[fecha],[cedula],[observaciones],[orden_id],[aprobada] FROM [dbo].[pedidos] WHERE [id] = @id";

                SqlParameter parametro = new SqlParameter("@id", SqlDbType.Int);
                parametro.Value = ID;

                entidades.vialsur.prefectura.pedidos obj_pedido = new entidades.vialsur.prefectura.pedidos();

                SqlDataReader dr_datos = SqlHelper.ExecuteReader(_con, CommandType.Text, consulta, parametro);
                while (dr_datos.Read())
                {
                    obj_pedido.id = (int)dr_datos["id"];
                    obj_pedido.fecha = Convert.ToDateTime(dr_datos["fecha"]);
                    obj_pedido.cedula = dr_datos["cedula"].ToString();
                    obj_pedido.observaciones = dr_datos["observaciones"].ToString();
                    obj_pedido.orden_id = dr_datos["orden_id"].ToString();
                    obj_pedido.aprobada = (bool)dr_datos["aprobada"];

                    //obj_marca.id = (int)dr_datos["id"];
                    //obj_marca.nombre = dr_datos["nombre"].ToString();
                    //obj_marca.obserbacion = dr_datos["obserbacion"].ToString();
                    //obj_marca.activo = (bool)dr_datos["activo"];
                }
                dr_datos.Close();
                return obj_pedido;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        /// <summary>
        /// Consulta las ordenes DE PEDIDO DE PARTES segun el estado
        /// </summary>
        /// <param name="estado"></param>
        /// <param name="cedula">POR DEFECTO SE MUESTRA ACORDE AL ESTADO</param>
        /// <returns></returns>
        public DataTable ObtenerOrdenesByEstado_UI(entidades.vialsur.prefectura.Orden_TipoEstadoPedido estado, string cedula="")
        {
            string consulta_sql =
                                entidades.vialsur.prefectura.Orden_TipoEstadoPedido.CREADO == estado ?
                                "SELECT pedidos.id, pedidos.fecha, pedidos.cedula, pedidos.observaciones, pedidos.orden_id, pedidos.aprobada, CONCAT(per_persona.apellidos,', ',per_persona.nombres) solicitante, " +
                                "vehiculo.codigo, vehiculo.placa,  marca.nombre, modelo.modelo, '-----' autoriza " +
                                "FROM   pedidos, per_persona, orden, ve_vehiculo_responsable, ve_vehiculo vehiculo, ve_vehiculo_modelo modelo,ve_vehiculo_marca marca " +
                                "WHERE pedidos.cedula = per_persona.cedula AND pedidos.orden_id = orden.id AND orden.ve_vehiculo_responsable_id = ve_vehiculo_responsable.id " +
                                "AND ve_vehiculo_responsable.ve_vehiculo_id = vehiculo.id AND  " +
                                "vehiculo.ve_vehiculo_modelo_id = modelo.id AND modelo.ve_vehiculo_marca_id = marca.id AND pedidos.aprobada=@aprobada " :

                                "SELECT pedidos.id, pedidos.fecha, pedidos.cedula, pedidos.observaciones, pedidos.orden_id, pedidos.aprobada, CONCAT(per_persona.apellidos,', ',per_persona.nombres) solicitante, " +
                                "vehiculo.codigo, vehiculo.placa,  marca.nombre, modelo.modelo, CONCAT(p2.apellidos,', ', p2.nombres) autoriza " +
                                "FROM   pedidos, per_persona, orden, ve_vehiculo_responsable, ve_vehiculo vehiculo, ve_vehiculo_modelo modelo,ve_vehiculo_marca marca, per_persona p2 " +
                                "WHERE pedidos.cedula = per_persona.cedula AND pedidos.orden_id = orden.id AND orden.ve_vehiculo_responsable_id = ve_vehiculo_responsable.id " +
                                "AND ve_vehiculo_responsable.ve_vehiculo_id = vehiculo.id AND p2.cedula=pedidos.cedula_autoriza AND " +
                                "vehiculo.ve_vehiculo_modelo_id = modelo.id AND modelo.ve_vehiculo_marca_id = marca.id AND pedidos.aprobada=@aprobada ";





            List <SqlParameter> parameters = new List<SqlParameter>();
            //        SqlParameter _orden_id = new SqlParameter("@orden_id", SqlDbType.NVarChar, 10);
            //        _orden_id.Value = orden_id;
            //        parameters.Add(_orden_id);

            SqlParameter parametro1 = new SqlParameter("@aprobada", SqlDbType.Bit);
            parametro1.Value = estado;
            parameters.Add(parametro1);

            if (cedula != "")
            {
                consulta_sql += " AND pedidos.cedula = @cedula";
                SqlParameter _cedula = new SqlParameter("@cedula", SqlDbType.NVarChar, 10);
                _cedula.Value = cedula;
                parameters.Add(_cedula);
            }
            try
            {
                return SqlHelper.ExecuteDataset(_con, CommandType.Text, consulta_sql, parameters.ToArray() ).Tables[0];
                //return SqlHelper.ExecuteDataset(_con, CommandType.Text, consulta_sql, parametro1).Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar los datos de las ordenes de pedidos de piezas: " + ex.Message);
            }
        }


    }
}
