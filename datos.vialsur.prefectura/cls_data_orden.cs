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

    public class cls_data_orden
    {
        private string _con = String.Empty;
        public cls_data_orden()
        {
            this._con = ConfigurationManager.ConnectionStrings["db_mantenimiento"].ConnectionString;
        }
        ~cls_data_orden()
        {
            this._con = String.Empty;
        }


        /// <summary>
        /// Retorna todoas las ordenes de un vehiculo determinado segun su ID de Vehiculo (
        /// </summary>
        /// <param name="IdVehiculo"></param>
        /// <returns></returns>
        public DataTable ObtenerOrdenesByIdVehiculo(int IdVehiculo )
        {
            string consulta_sql =
                    "SELECT orden.id, orden.tipo_oden, orden.fecha, orden.hora, orden.estado, orden.ve_vehiculo_responsable_id, orden.per_persona_cedula, orden.observacion, orden.km_ingreso, " +
                    "orden.km_egreso, ve_vehiculo.id AS ve_vehiculo_id, ve_vehiculo.placa " +
                    "FROM orden INNER JOIN ve_vehiculo_responsable ON orden.ve_vehiculo_responsable_id = ve_vehiculo_responsable.id INNER JOIN " +
                    "ve_vehiculo ON ve_vehiculo_responsable.ve_vehiculo_id = ve_vehiculo.id " +
                    "WHERE ve_vehiculo.id = @IdVehiculo " +
                    "ORDER BY orden.id DESC ";
            try
            {
               
                SqlParameter parametro = new SqlParameter("@IdVehiculo", SqlDbType.Int);
                parametro.Value = IdVehiculo;

                return SqlHelper.ExecuteDataset(_con, CommandType.Text, consulta_sql, parametro).Tables[0];                
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar los datos del vehiculo: " + ex.Message);
            }
        }

        /// <summary>
        /// Consulta las ordenes segun un la placa del Vehiculo
        /// </summary>
        /// <param name="Placa"></param>
        /// <returns></returns>
        public DataTable ObtenerOrdenesByPlaca(string Placa)
        {
            string consulta_sql =
                    "SELECT orden.id, orden.tipo_oden, orden.fecha, orden.hora, orden.estado, orden.ve_vehiculo_responsable_id, orden.per_persona_cedula, orden.observacion, orden.km_ingreso, " +
                    "orden.km_egreso, ve_vehiculo.id AS ve_vehiculo_id, ve_vehiculo.placa " +
                    "FROM orden INNER JOIN ve_vehiculo_responsable ON orden.ve_vehiculo_responsable_id = ve_vehiculo_responsable.id INNER JOIN " +
                    "ve_vehiculo ON ve_vehiculo_responsable.ve_vehiculo_id = ve_vehiculo.id " +
                    "WHERE ve_vehiculo.placa = @Placa " +
                    "ORDER BY orden.id DESC ";
            try
            {

                SqlParameter parametro = new SqlParameter("@Placa", SqlDbType.VarChar);
                parametro.Value = Placa;

                return SqlHelper.ExecuteDataset(_con, CommandType.Text, consulta_sql, parametro).Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar los datos del vehiculo: " + ex.Message);
            }
        }

        /// <summary>
        /// Inserta el registro en la tabla orden, retorna el ID de la orden
        /// </summary>
        /// <param name="_orden">Obj. Orden</param>
        /// <returns></returns>
        public string Insertar_orden(entidades.vialsur.prefectura.orden _orden)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                #region parametros
                SqlParameter _id = new SqlParameter("@id", SqlDbType.NChar, 10 );
                _id.Direction = ParameterDirection.Output;
                _id.Value = _orden.id;
                parameters.Add(_id);
            
                SqlParameter _tipo_oden = new SqlParameter("@tipo_oden", SqlDbType.Int);
                _tipo_oden.Value = _orden.tipo_oden;
                parameters.Add(_tipo_oden);

                SqlParameter _fecha = new SqlParameter("@fecha", SqlDbType.Date);
                _fecha.Value = _orden.fecha;
                parameters.Add(_fecha);

                SqlParameter _hora = new SqlParameter("@hora", SqlDbType.Time );
                _hora.Value = _orden.hora;
                parameters.Add(_hora);


                SqlParameter _estado = new SqlParameter("@estado", SqlDbType.Int );
                _estado.Value = _orden.estado;
                parameters.Add(_estado);

                SqlParameter _ve_vehiculo_responsable_id = new SqlParameter("@ve_vehiculo_responsable_id", SqlDbType.Int);
                _ve_vehiculo_responsable_id.Value = _orden.ve_vehiculo_responsable_id;
                parameters.Add(_ve_vehiculo_responsable_id);

                SqlParameter _per_persona_cedula = new SqlParameter("@per_persona_cedula", SqlDbType.NChar, 10 );
                _per_persona_cedula.Value = _orden.per_persona_numero_cedula;
                parameters.Add(_per_persona_cedula);

                SqlParameter _observacion = new SqlParameter("@observacion", SqlDbType.Text);
                _observacion.Value = _orden.observacion;
                parameters.Add(_observacion);

                SqlParameter _km_ingreso = new SqlParameter("@km_ingreso", SqlDbType.Int);
                _km_ingreso.Value = _orden.km_ingreso;
                parameters.Add(_km_ingreso);

                SqlParameter _km_egreso = new SqlParameter("@km_egreso", SqlDbType.Int);
                _km_egreso.Value = _orden.km_egreso;
                parameters.Add(_km_egreso);

                #endregion

                SqlHelper.ExecuteNonQuery(_con, CommandType.StoredProcedure, "dbo.ORDEN_SP_INSERT", parameters.ToArray());

                return _id.Value.ToString().Trim();

                //  int customerId = SqlHelper.ExecuteNonQuery(_con, CommandType.Text, _sql_insert, parameters.ToArray());                 

            }
            catch (Exception ex)
            {
                throw ex;
                //throw new Exception("No se pudo registrar los datos de la persona", ex);
            }
        }

        /// <summary>
        /// Actualiza el estado de la orden. Ref. Orden_TipoEstado
        /// OPCIONAL: CEDULA DE QUIEN AUTORIZA ACTUALIZACIOn
        /// </summary>
        /// <param name="Id_Orden"></param>
        /// <param name="tipo"></param>
        /// <param name="ced_autoriza"></param>
        public void ActualizarEstadoOrden(string Id_Orden, entidades.vialsur.prefectura.Orden_TipoEstado tipo, string ced_autoriza="")
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                #region parametros
                SqlParameter _id = new SqlParameter("@id", SqlDbType.NChar, 10);
                _id.Value = Id_Orden;
                parameters.Add(_id);

                SqlParameter _estado = new SqlParameter("@estado", SqlDbType.Int);
                _estado.Value = (entidades.vialsur.prefectura.Orden_TipoEstado)tipo;
                parameters.Add(_estado);

                SqlParameter _cedula = new SqlParameter("@cedula", SqlDbType.NChar, 10);
                _cedula.Value = ced_autoriza;
                parameters.Add(_cedula);

                #endregion

                string _update_Sql = "UPDATE [dbo].[orden] SET[estado] = @estado, [per_persona_cedula_autoriza]=@cedula WHERE[id] = @id;";
                SqlHelper.ExecuteNonQuery(_con, CommandType.Text, _update_Sql, parameters.ToArray());                               

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo actualizar el estado de la orden", ex);
            }
        }

        /// <summary>
        /// Actualiza el estado de una orden y tambien permite registrar el kilometraje de egreso
        /// USADA PARA CERRAR EL ESTADO DE LA ORDEN
        /// </summary>
        /// <param name="Id_Orden"></param>
        /// <param name="tipo"></param>
        /// <param name="kegreso"></param>
        public void ActualizarEstadoOrden(string Id_Orden, entidades.vialsur.prefectura.Orden_TipoEstado tipo, int kegreso)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                #region parametros
                SqlParameter _id = new SqlParameter("@id", SqlDbType.NChar, 10);
                _id.Value = Id_Orden;
                parameters.Add(_id);

                SqlParameter _estado = new SqlParameter("@estado", SqlDbType.Int);
                _estado.Value = (entidades.vialsur.prefectura.Orden_TipoEstado)tipo;
                parameters.Add(_estado);

                SqlParameter _kegreso = new SqlParameter("@km_egreso", SqlDbType.Int);
                _kegreso.Value = kegreso;
                parameters.Add(_kegreso);

                #endregion

                string _update_Sql = "UPDATE [dbo].[orden] SET [estado] = @estado, [km_egreso] = @km_egreso WHERE [id] = @id;";
                SqlHelper.ExecuteNonQuery(_con, CommandType.Text, _update_Sql, parameters.ToArray());
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo actualizar el estado de la orden", ex);
            }
        }


        /// <summary>
        /// Retorna las ordenes de determinado mecanico segun su cedula
        /// </summary>
        /// <param name="Cedula"></param>
        /// <param name="Placa"></param>
        /// <param name="id_orden"></param>
        /// <returns></returns>
        public DataTable ObtenerOrdenesByTecnicoAsignado_UI(string Cedula, string Placa, string id_orden, int estado =-1)
        {
            string consulta_sql =            
                    "SELECT orden.id, orden.tipo_oden, orden.fecha, orden.hora, orden.estado, orden.ve_vehiculo_responsable_id, " +
                   "orden.per_persona_cedula as chofer,orden.observacion, orden.km_ingreso, orden.km_egreso,  " +
                   "ve_vehiculo_responsable.per_persona_cedula AS cedula_responsable, ve_vehiculo_responsable.ve_vehiculo_id, " +
                   "ve_vehiculo_responsable.estado AS ve_vehiculo_responsable_estado, " +
                   "ve_vehiculo_responsable.fecha AS ve_vehiculo_responsable_fecha, ve_vehiculo_responsable.tipo_responsable " +
                    "FROM   orden INNER JOIN ve_vehiculo_responsable ON orden.ve_vehiculo_responsable_id = ve_vehiculo_responsable.id " +
                    "INNER JOIN ve_vehiculo ON ve_vehiculo_responsable.ve_vehiculo_id = ve_vehiculo.id " +
                    //"WHERE ve_vehiculo_responsable.per_persona_cedula = @Cedula ";
                    "WHERE 1=1 ";

            if (Cedula!="")
                consulta_sql += " AND ve_vehiculo_responsable.per_persona_cedula = @Cedula ";

            if (Placa != "" & id_orden != "")
                consulta_sql += " AND ( ve_vehiculo.placa = @Placa OR orden.id LIKE @id_orden ) ";

            if (estado != -1) //cuando no se tenga q poner el estado 
                              //consulta_sql += " AND orden.estado  >= @estado ";
                consulta_sql += " AND orden.estado = @estado ";

            consulta_sql +=  " ORDER BY ve_vehiculo_responsable.fecha ASC, orden.hora DESC";

            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                SqlParameter parametro1 = new SqlParameter("@Cedula", SqlDbType.NChar,10 );
                parametro1.Value = Cedula;
                parameters.Add(parametro1);
                if (Placa != "" & id_orden != "")
                {
                    SqlParameter parametro2 = new SqlParameter("@Placa", SqlDbType.NChar, 10);
                    parametro2.Value = Placa;
                    parameters.Add(parametro2);

                    SqlParameter parametro3 = new SqlParameter("@id_orden", SqlDbType.NChar, 10);
                    parametro3.Value = id_orden + "%";
                    parameters.Add(parametro3);
                }
                                
                SqlParameter parametro4 = new SqlParameter("@estado", SqlDbType.Int);
                parametro4.Value = estado;
                parameters.Add(parametro4);

                //DataTable dt1 = SqlHelper.ExecuteDataset(_con, CommandType.Text, consulta_sql, parameters.ToArray()).Tables[0];                
                return SqlHelper.ExecuteDataset(_con, CommandType.Text, consulta_sql, parameters.ToArray() ).Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar los datos de las ordenes: " + ex.Message);
            }
        
        }

        /// <summary>
        /// Consulta las ordenes segun el estado
        /// </summary>
        /// <param name="estado"></param>
        /// <returns></returns>
        public DataTable ObtenerOrdenesByEstado_UI(entidades.vialsur.prefectura.Orden_TipoEstado  estado)
        {
            string consulta_sql =
                    "SELECT orden.id, orden.tipo_oden, orden.fecha, orden.hora, orden.estado, orden.ve_vehiculo_responsable_id, "+
                    "orden.per_persona_cedula as chofer,orden.observacion, orden.km_ingreso, orden.km_egreso,  "+
                    "ve_vehiculo_responsable.per_persona_cedula AS cedula_responsable, ve_vehiculo_responsable.ve_vehiculo_id,  "+
                    "ve_vehiculo_responsable.estado AS ve_vehiculo_responsable_estado,  "+
                    "ve_vehiculo_responsable.fecha AS ve_vehiculo_responsable_fecha, ve_vehiculo_responsable.tipo_responsable "+
                    "FROM   orden INNER JOIN ve_vehiculo_responsable ON orden.ve_vehiculo_responsable_id = ve_vehiculo_responsable.id  "+
                    "INNER JOIN ve_vehiculo ON ve_vehiculo_responsable.ve_vehiculo_id = ve_vehiculo.id "+
                    "WHERE orden.estado = @estado "+
                    "ORDER BY ve_vehiculo_responsable.fecha ASC, orden.hora DESC;";

            try
            {
                SqlParameter parametro1 = new SqlParameter("@estado", SqlDbType.Int);
                parametro1.Value = estado;
                                

                return SqlHelper.ExecuteDataset(_con, CommandType.Text, consulta_sql, parametro1).Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar los datos de las ordenes: " + ex.Message);
            }
        }

        /// <summary>
        /// Retorna las ordenes de un determinado vehiculo segun su id y con la facilidad de filtrar por ir_orden
        /// </summary>
        /// <param name="Cedula"></param>
        /// <param name="Placa"></param>
        /// <param name="id_orden"></param>
        /// <returns></returns>
        public DataTable ObtenerOrdenesByIdVehiculoOIdOrden_UI( string Placa, string id_orden="")
        {
            string consulta_sql =

                    "SELECT orden.id, orden.tipo_oden, orden.fecha, orden.hora, orden.estado, orden.ve_vehiculo_responsable_id, " +
                   "orden.per_persona_cedula as chofer,orden.observacion, orden.km_ingreso, orden.km_egreso,  " +
                   "ve_vehiculo_responsable.per_persona_cedula AS cedula_responsable, ve_vehiculo_responsable.ve_vehiculo_id, " +
                   "ve_vehiculo_responsable.estado AS ve_vehiculo_responsable_estado, " +
                   "ve_vehiculo_responsable.fecha AS ve_vehiculo_responsable_fecha, ve_vehiculo_responsable.tipo_responsable " +
                    "FROM   orden INNER JOIN ve_vehiculo_responsable ON orden.ve_vehiculo_responsable_id = ve_vehiculo_responsable.id " +
                    "INNER JOIN ve_vehiculo ON ve_vehiculo_responsable.ve_vehiculo_id = ve_vehiculo.id " +
                    "WHERE ve_vehiculo.placa = @Placa  ";

            consulta_sql += id_orden != "" ? "AND orden.id LIKE @id_orden " : "";

            consulta_sql += "ORDER BY ve_vehiculo_responsable.fecha ASC, orden.hora DESC";

            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();                

                SqlParameter parametro2 = new SqlParameter("@Placa", SqlDbType.NChar, 10);
                parametro2.Value = Placa;
                parameters.Add(parametro2);

                SqlParameter parametro3 = new SqlParameter("@id_orden", SqlDbType.NChar, 10);
                parametro3.Value = id_orden==""? id_orden :  id_orden + "%";
                parameters.Add(parametro3);


                return SqlHelper.ExecuteDataset(_con, CommandType.Text, consulta_sql, parameters.ToArray()).Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar los datos de las ordenes: " + ex.Message);
            }
        }


        /// <summary>
        /// Retorna un objeto >> orden , con informacion segun el id de la orden
        /// </summary>
        /// <param name="id_orden"></param>
        /// <returns></returns>
        public entidades.vialsur.prefectura.orden ConsultarOrdenPorId(string id_orden)
        {
            try
            {
                string consulta = "SELECT id, tipo_oden, fecha, hora, estado, ve_vehiculo_responsable_id, per_persona_cedula, observacion, km_ingreso, km_egreso " +
                                   "FROM orden where id = @id_orden";

                SqlParameter parametro = new SqlParameter("@id_orden", SqlDbType.NChar,10 );
                parametro.Value = id_orden;

                entidades.vialsur.prefectura.orden obj_orden = new entidades.vialsur.prefectura.orden();

                SqlDataReader dr_datos = SqlHelper.ExecuteReader(_con, CommandType.Text, consulta, parametro);
                while (dr_datos.Read())
                {
                    obj_orden.id = dr_datos["id"].ToString();
                    obj_orden.tipo_oden = int.Parse(dr_datos["tipo_oden"].ToString());
                    obj_orden.fecha = Convert.ToDateTime(dr_datos["fecha"]);
                    obj_orden.hora = (TimeSpan)dr_datos["hora"];
                    obj_orden.estado = int.Parse(dr_datos["estado"].ToString());
                    obj_orden.ve_vehiculo_responsable_id = int.Parse(dr_datos["ve_vehiculo_responsable_id"].ToString());
                    
                    obj_orden.per_persona_numero_cedula = dr_datos["per_persona_cedula"] == null ? "" : dr_datos["per_persona_cedula"].ToString();
                    obj_orden.observacion = dr_datos["observacion"].ToString();
                    int ki = 0, ke = 0;
                    int.TryParse(dr_datos["km_ingreso"].ToString(),out ki);
                    obj_orden.km_ingreso = ki;
                    int.TryParse(dr_datos["km_egreso"].ToString(), out ke);
                    obj_orden.km_egreso = ke;

                }                
                return obj_orden;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




    }
}
