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




    }
}
