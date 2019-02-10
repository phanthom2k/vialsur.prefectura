using System;
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

    public class cls_data_detalle_pedidos_aceite
    {

        private string _con = String.Empty; 
        public cls_data_detalle_pedidos_aceite()
        {
            this._con = ConfigurationManager.ConnectionStrings["db_mantenimiento"].ConnectionString;
        }
        ~cls_data_detalle_pedidos_aceite()
        {
            this._con = String.Empty;
        }        

        /// <summary>
        /// Inserta nuevo registro
        /// </summary>
        /// <param name="marca"></param>
        public void Insertar(entidades.vialsur.prefectura.detalle_pedidos_aceite detalle)
        {            
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                #region parametros              
   
                SqlParameter _pedidos_id = new SqlParameter("@pedidos_aceite_id", SqlDbType.Int);
                _pedidos_id.Value = detalle.pedidos_aceite_id;
                parameters.Add(_pedidos_id);

                SqlParameter _cantidad = new SqlParameter("@cantidad", SqlDbType.Int);
                _cantidad.Value = detalle.cantidad;
                parameters.Add(_cantidad);

                SqlParameter _detalle = new SqlParameter("@detalle", SqlDbType.Text);
                _detalle.Value = detalle.detalle;
                parameters.Add(_detalle);

                #endregion

                string _sql_insert = "INSERT INTO [dbo].[detalle_pedidos_aceite]([id],[pedidos_aceite_id],[cantidad],[detalle]) VALUES (dbo.FUN_DETALLE_PEDIDOS_ACEITE_SEC(),@pedidos_aceite_id,@cantidad,@detalle); ";                                                         

                SqlHelper.ExecuteNonQuery(_con, CommandType.Text, _sql_insert, parameters.ToArray());

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo registrar los datos del detalle de la orden de lubricantes", ex);
            }                    
        }
        /// <summary>
        /// Elimina el detalle
        /// </summary>
        /// <param name="id"></param>
        public void Eliminar( int id)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                #region parametros              

                SqlParameter _pedidos_id = new SqlParameter("@id", SqlDbType.Int);
                _pedidos_id.Value = id;
                parameters.Add(_pedidos_id);

                #endregion

                string _sql_insert = "DELETE FROM [dbo].[detalle_pedidos_aceite] WHERE id=@id; ";

                SqlHelper.ExecuteNonQuery(_con, CommandType.Text, _sql_insert, parameters.ToArray());

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo eliminara los datos", ex);
            }
        }

        public void Actualizar(entidades.vialsur.prefectura.detalle_pedidos_aceite detalle)
        {
            
            try
            {

                List<SqlParameter> parameters = new List<SqlParameter>();

                #region parametros                 
                SqlParameter _id = new SqlParameter("@id", SqlDbType.Int);
                _id.Value = detalle.id;
                parameters.Add(_id);

                SqlParameter _cantidad = new SqlParameter("@cantidad", SqlDbType.Int);
                _cantidad.Value = detalle.cantidad;
                parameters.Add(_cantidad);

                SqlParameter _detalle = new SqlParameter("@detalle", SqlDbType.Text);
                _detalle.Value = detalle.detalle;
                parameters.Add(_detalle);

                #endregion

                string _sql_UPDATE = "UPDATE [dbo].[detalle_pedidos_aceite] SET [cantidad] = @cantidad, [detalle] = @detalle WHERE [id]=@id";

                SqlHelper.ExecuteNonQuery(_con, CommandType.Text, _sql_UPDATE, parameters.ToArray());
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo actualizar los datos.", ex);
            }            
        }

        /// <summary>
        /// Consulta los detalles segun la ORDEN_ID
        /// </summary>
        /// <param name="orden_id"></param>
        /// <returns></returns>
        public DataTable ConsultarDetallesByOrden_Id(string orden_id)
        {
            string sql_Consulta = "SELECT detalle_pedidos_aceite.id, detalle_pedidos_aceite.pedidos_aceite_id, detalle_pedidos_aceite.cantidad, detalle_pedidos_aceite.detalle " +
                                  "FROM pedidos_aceite INNER JOIN detalle_pedidos_aceite ON pedidos_aceite.id = detalle_pedidos_aceite.pedidos_aceite_id AND pedidos_aceite.orden_id=@orden_id";
            try
            {

                List<SqlParameter> parameters = new List<SqlParameter>();
                SqlParameter _orden_id = new SqlParameter("@orden_id", SqlDbType.NVarChar, 10);
                _orden_id.Value = orden_id;
                parameters.Add(_orden_id);


                DataTable dt = new DataTable();                
                dt.Load(SqlHelper.ExecuteReader(_con, CommandType.Text, sql_Consulta, parameters.ToArray()), LoadOption.PreserveChanges);
                return dt;                
            }
            catch (Exception ex)
            {
                throw new Exception("cls_data_detalle_pedidos_aceite:" + ex.Message, ex);
            }
            finally
            {

            }
        } 

        /// <summary>
        /// CONSULTA EL CONJUNTO DE DETALLES DE UN DETERMINADO PEDIDO SEGUN EL [ID] DEL PEDIDO
        /// </summary>
        /// <param name="PedidoId"></param>
        /// <returns></returns>
        public DataTable ConsultarDetallesBy_PedidoId(int PedidoId)
        {
            string sql_Consulta = "SELECT id, pedidos_aceite_id, cantidad, detalle " +
                                  "FROM detalle_pedidos_aceite WHERE pedidos_aceite_id= @pedidos_id";
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                SqlParameter _pedidos_id = new SqlParameter("@pedidos_id", SqlDbType.Int);
                _pedidos_id.Value = PedidoId;
                parameters.Add(_pedidos_id);


                DataTable dt = new DataTable();
                dt.Load(SqlHelper.ExecuteReader(_con, CommandType.Text, sql_Consulta, parameters.ToArray()), LoadOption.PreserveChanges);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("cls_data_detalle_pedidos:" + ex.Message, ex);
            }
            finally
            {

            }
        }

        /*
                /// <summary>
                /// Retorna un SqlDataReader con todas las marcas disponibles en el catalogo
                /// </summary>
                /// <returns></returns>
                //public SqlDataReader ConsultarTodasMarcas()
                //{
                //    try
                //    {
                //        string _sql = "SELECT id, nombre, obserbacion, activo FROM ve_vehiculo_marca order by nombre asc;";
                //        return SqlHelper.ExecuteReader(_con, CommandType.Text, _sql);
                //    }
                //    catch (Exception ex)
                //    {
                //        throw new Exception("cls_data_ve_vehiculo_marca:" + ex.Message, ex);
                //    }
                //    finally
                //    {

                //    }
                //}
                */

        /// <summary>
        /// Consulta un detalle espepcifico segun su ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public entidades.vialsur.prefectura.detalle_pedidos_aceite ConsultarDetalleById(int id)
        {
            try
            {

                string consulta = "SELECT [id],[pedidos_aceite_id],[cantidad],[detalle] FROM [dbo].[detalle_pedidos_aceite] WHERE id = @id";

                SqlParameter parametro = new SqlParameter("@id", SqlDbType.Int);
                parametro.Value = id;

                entidades.vialsur.prefectura.detalle_pedidos_aceite obj_det = new entidades.vialsur.prefectura.detalle_pedidos_aceite();

                SqlDataReader dr_datos = SqlHelper.ExecuteReader(_con, CommandType.Text, consulta, parametro);
                while (dr_datos.Read())
                {
                    obj_det.id = (int)dr_datos["id"];
                    obj_det.pedidos_aceite_id = (int)dr_datos["pedidos_aceite_id"];
                    obj_det.cantidad = (int)dr_datos["cantidad"];
                    obj_det.detalle = dr_datos["detalle"].ToString();                    
                }
                dr_datos.Close();
                return obj_det;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
