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

    public class cls_data_orde_detalle
    {

        private string _con = String.Empty;
        public cls_data_orde_detalle()
        {
            this._con = ConfigurationManager.ConnectionStrings["db_mantenimiento"].ConnectionString;
        }
        ~cls_data_orde_detalle()
        {
            this._con = String.Empty;
        }

        /// <summary>
        /// Inserta un registro de orde_detalle, y retorna el id 
        /// </summary>
        /// <param name="_orde_detalle"></param>
        /// <returns></returns>
        public string Insertar_orde_detalle(entidades.vialsur.prefectura.orde_detalle _orde_detalle)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                #region parametros
                SqlParameter _id = new SqlParameter("@id", SqlDbType.NChar, 10);
                _id.Direction = ParameterDirection.Output;
                _id.Value = _orde_detalle.id;
                parameters.Add(_id);

                SqlParameter _catalogo_parte_principal_id = new SqlParameter("@catalogo_parte_principal_id", SqlDbType.Int);
                _catalogo_parte_principal_id.Value = _orde_detalle.catalogo_parte_principal_id;
                parameters.Add(_catalogo_parte_principal_id);

                SqlParameter _catalogo_parte_secundaria_id = new SqlParameter("@catalogo_parte_secundaria_id", SqlDbType.Int);
                _catalogo_parte_secundaria_id.Value = _orde_detalle.catalogo_parte_secundaria_id;
                parameters.Add(_catalogo_parte_secundaria_id);

                SqlParameter _accion_realizada = new SqlParameter("@accion_realizada", SqlDbType.Int);
                _accion_realizada.Value = _orde_detalle.accion_realizada;
                parameters.Add(_accion_realizada);

                SqlParameter _cantidad = new SqlParameter("@cantidad", SqlDbType.Decimal );
                _cantidad.Value = _orde_detalle.cantidad;
                parameters.Add(_cantidad);

                SqlParameter _observacion = new SqlParameter("@observacion", SqlDbType.Text);
                _observacion.Value = _orde_detalle.observacion;
                parameters.Add(_observacion);

                SqlParameter _estado = new SqlParameter("@estado", SqlDbType.Bit);
                _estado.Value = _orde_detalle.estado;
                parameters.Add(_estado);

                SqlParameter _accion_requerida = new SqlParameter("@accion_requerida", SqlDbType.Bit);
                _accion_requerida.Value = _orde_detalle.accion_requerida;
                parameters.Add(_accion_requerida);

                SqlParameter _orden_id = new SqlParameter("@orden_id", SqlDbType.NChar, 10 );
                _orden_id.Value = _orde_detalle.orden_id;
                parameters.Add(_orden_id);

                #endregion

                SqlHelper.ExecuteNonQuery(_con, CommandType.StoredProcedure, "dbo.orde_detalle_SP_INSERT", parameters.ToArray());

                return _id.Value.ToString();                

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo registrar los datos de la orden", ex);
            }
        }


        /// <summary>
        /// Inserta un registro de orde_detalle, y retorna el id 
        /// </summary>
        /// <param name="_orde_detalle"></param>
        /// <returns></returns>
        public void Actualizar_orde_detalle(entidades.vialsur.prefectura.orde_detalle _orde_detalle)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                #region parametros
                SqlParameter _id = new SqlParameter("@id", SqlDbType.NChar, 10);
                //_id.Direction = ParameterDirection.Output;
                _id.Value = _orde_detalle.id;
                parameters.Add(_id);

                SqlParameter _catalogo_parte_principal_id = new SqlParameter("@catalogo_parte_principal_id", SqlDbType.Int);
                _catalogo_parte_principal_id.Value = _orde_detalle.catalogo_parte_principal_id;
                parameters.Add(_catalogo_parte_principal_id);

                SqlParameter _catalogo_parte_secundaria_id = new SqlParameter("@catalogo_parte_secundaria_id", SqlDbType.Int);
                _catalogo_parte_secundaria_id.Value = _orde_detalle.catalogo_parte_secundaria_id;
                parameters.Add(_catalogo_parte_secundaria_id);

                SqlParameter _accion_realizada = new SqlParameter("@accion_realizada", SqlDbType.Int);
                _accion_realizada.Value = _orde_detalle.accion_realizada;
                parameters.Add(_accion_realizada);

                SqlParameter _cantidad = new SqlParameter("@cantidad", SqlDbType.Decimal);
                _cantidad.Value = _orde_detalle.cantidad;
                parameters.Add(_cantidad);

                SqlParameter _observacion = new SqlParameter("@observacion", SqlDbType.Text);
                _observacion.Value = _orde_detalle.observacion;
                parameters.Add(_observacion);

                SqlParameter _estado = new SqlParameter("@estado", SqlDbType.Bit);
                _estado.Value = _orde_detalle.estado;
                parameters.Add(_estado);

                SqlParameter _accion_requerida = new SqlParameter("@accion_requerida", SqlDbType.Bit);
                _accion_requerida.Value = _orde_detalle.accion_requerida;
                parameters.Add(_accion_requerida);

        
                #endregion

                string sql_update = "UPDATE [dbo].[orde_detalle] " +
                                            "SET[catalogo_parte_principal_id] = @catalogo_parte_principal_id " +
                                            ",[catalogo_parte_secundaria_id] = @catalogo_parte_secundaria_id " +
                                            ",[accion_realizada] = @accion_realizada " +
                                            ",[cantidad] = @cantidad " +
                                            ",[observacion] = @observacion " +
                                            ",[estado] = @estado " +
                                            ",[accion_requerida] = @accion_requerida " +
                                            "WHERE [id] = @id ";

                SqlHelper.ExecuteNonQuery(_con, CommandType.Text, sql_update, parameters.ToArray());
                
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo actualizar los datos del detalle", ex);
            }
        }

        /// <summary>
        /// Retorna un DT con informacion para la UI
        /// </summary>
        /// <param name="id_orden"></param>
        /// <returns></returns>
        public DataTable ConsultarDetalleOrdenesByIdOrden_UI(string id_orden )
        {
            string consulta_sql = "SELECT orde_detalle.id, catalogo_parte_principal.nombre as nombrePP, catalogo_parte_secundaria.nombre AS nombrePS," +
                                    "orde_detalle.accion_requerida, orde_detalle.accion_realizada, orde_detalle.cantidad, " +
                                    "orde_detalle.observacion, orde_detalle.estado, orde_detalle.orden_id " +
                                    "FROM     orde_detalle INNER JOIN " +
                                    "catalogo_parte_principal ON orde_detalle.catalogo_parte_principal_id = catalogo_parte_principal.id INNER JOIN " +
                                    "catalogo_parte_secundaria ON orde_detalle.catalogo_parte_secundaria_id = catalogo_parte_secundaria.id AND " +
                                    "catalogo_parte_principal.id = catalogo_parte_secundaria.catalogo_parte_principal_id " +
                                    "WHERE orde_detalle.orden_id = @id_orden " +
                                    "order by orde_detalle.id asc";
            try
            {
                

                SqlParameter parametro1 = new SqlParameter("@id_orden", SqlDbType.NChar, 10);
                parametro1.Value = id_orden;
                
                return SqlHelper.ExecuteDataset(_con, CommandType.Text, consulta_sql, parametro1).Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar los datos del vehiculo: " + ex.Message);
            }

        }

        /// <summary>
        /// Retorna un objeto orde_detalle segun su ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public entidades.vialsur.prefectura.orde_detalle ConsultarOrde_DetalleById(string id)
        {
            try
            {
                string consulta = "SELECT id, catalogo_parte_principal_id, catalogo_parte_secundaria_id, accion_realizada, cantidad, observacion, estado, accion_requerida, orden_id " +
                                  "FROM orde_detalle where id = @id";

                SqlParameter parametro = new SqlParameter("@id", SqlDbType.NChar,10);
                parametro.Value = id;

                entidades.vialsur.prefectura.orde_detalle obj_orde_detalle = new entidades.vialsur.prefectura.orde_detalle();

                SqlDataReader dr_datos = SqlHelper.ExecuteReader(_con, CommandType.Text, consulta, parametro);
                while (dr_datos.Read())
                {
                    obj_orde_detalle.id = dr_datos["id"].ToString();
                    obj_orde_detalle.catalogo_parte_principal_id = int.Parse(dr_datos["catalogo_parte_principal_id"].ToString());
                    obj_orde_detalle.catalogo_parte_secundaria_id = int.Parse(dr_datos["catalogo_parte_secundaria_id"].ToString());
                    int ar = 0;
                    int.TryParse(dr_datos["accion_realizada"].ToString(), out ar);
                    obj_orde_detalle.accion_realizada = ar;
                    obj_orde_detalle.cantidad = decimal.Parse(dr_datos["cantidad"].ToString());
                    obj_orde_detalle.observacion = dr_datos["observacion"].ToString();
                    obj_orde_detalle.estado = (bool)dr_datos["estado"];
                    obj_orde_detalle.accion_requerida = int.Parse(dr_datos["accion_requerida"].ToString());
                    obj_orde_detalle.orden_id = dr_datos["orden_id"].ToString();                    
                }                
                return obj_orde_detalle;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar los datos del ord_detalle: " + ex.Message);
            }

        }

        /// <summary>
        /// Verifica el cumplimiento de las actividades designadas para la orden
        /// </summary>
        /// <param name="id_orden"></param>
        /// <returns></returns>
        public int VerificarCumplimientoDetallesAsignados(string id_orden)
        {
            try
            {
                string consulta = "SELECT count(accion_realizada) realizadas, count (accion_requerida) requeridas FROM  orde_detalle WHERE orden_id =@id";

                SqlParameter parametro = new SqlParameter("@id", SqlDbType.NChar, 10);
                parametro.Value = id_orden;

                SqlDataReader dr_datos = SqlHelper.ExecuteReader(_con, CommandType.Text, consulta, parametro);
                int realizadas = 0, requeridas = 0;
                while(dr_datos.Read())
                {
                    realizadas = int.Parse(dr_datos["realizadas"].ToString());
                    requeridas = int.Parse(dr_datos["requeridas"].ToString());
                }
                dr_datos.Close();

                return requeridas - realizadas;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar los datos del ord_detalle: " + ex.Message);
            }
        }


    }
}
