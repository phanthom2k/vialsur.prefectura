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
                throw new Exception("No se pudo registrar los datos de la persona", ex);
            }
        }


        /// <summary>
        /// Retorna las ordenes de determinado mecanico segun su cedula
        /// </summary>
        /// <param name="Cedula"></param>
        /// <param name="Placa"></param>
        /// <param name="id_orden"></param>
        /// <returns></returns>
        public DataTable ObtenerOrdenesByTecnicoAsignado_UI(string Cedula, string Placa, string id_orden)
        {
            string consulta_sql =
                    //"SELECT orden.id, orden.tipo_oden, orden.fecha, orden.hora, orden.estado, orden.ve_vehiculo_responsable_id, " +
                    //"orden.per_persona_cedula as chofer,orden.observacion, orden.km_ingreso, orden.km_egreso, " +
                    //"ve_vehiculo_responsable.per_persona_cedula AS cedula_responsable, ve_vehiculo_responsable.ve_vehiculo_id," +
                    //"ve_vehiculo_responsable.estado AS ve_vehiculo_responsable_estado, " +
                    //"ve_vehiculo_responsable.fecha AS ve_vehiculo_responsable_fecha, ve_vehiculo_responsable.tipo_responsable " +
                    //"FROM   orden INNER JOIN ve_vehiculo_responsable ON orden.ve_vehiculo_responsable_id = ve_vehiculo_responsable.id " +
                    //"WHERE ve_vehiculo_responsable.per_persona_cedula = @Cedula " +
                    //"ORDER BY ve_vehiculo_responsable.fecha ASC, orden.hora DESC ";

                    "SELECT orden.id, orden.tipo_oden, orden.fecha, orden.hora, orden.estado, orden.ve_vehiculo_responsable_id, " +
                   "orden.per_persona_cedula as chofer,orden.observacion, orden.km_ingreso, orden.km_egreso,  " +
                   "ve_vehiculo_responsable.per_persona_cedula AS cedula_responsable, ve_vehiculo_responsable.ve_vehiculo_id, " +
                   "ve_vehiculo_responsable.estado AS ve_vehiculo_responsable_estado, " +
                   "ve_vehiculo_responsable.fecha AS ve_vehiculo_responsable_fecha, ve_vehiculo_responsable.tipo_responsable " +
                    "FROM   orden INNER JOIN ve_vehiculo_responsable ON orden.ve_vehiculo_responsable_id = ve_vehiculo_responsable.id " +
                    "INNER JOIN ve_vehiculo ON ve_vehiculo_responsable.ve_vehiculo_id = ve_vehiculo.id " +
                    "WHERE ve_vehiculo_responsable.per_persona_cedula = @Cedula " +
                    "OR ve_vehiculo.placa = @Placa  " +
                    "OR orden.id = @id_orden " +
                    "ORDER BY ve_vehiculo_responsable.fecha ASC, orden.hora DESC";

            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                SqlParameter parametro1 = new SqlParameter("@Cedula", SqlDbType.NChar,10 );
                parametro1.Value = Cedula;
                parameters.Add(parametro1);

                SqlParameter parametro2 = new SqlParameter("@Placa", SqlDbType.NChar, 10);
                parametro2.Value = Placa;
                parameters.Add(parametro2);

                SqlParameter parametro3 = new SqlParameter("@id_orden", SqlDbType.NChar, 10);
                parametro3.Value = id_orden;
                parameters.Add(parametro3);


                return SqlHelper.ExecuteDataset(_con, CommandType.Text, consulta_sql, parameters.ToArray() ).Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar los datos del vehiculo: " + ex.Message);
            }
        }






    }
}
