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

    public class cls_data_ve_vehiculo_responsable
    {
        private string _con = String.Empty;
        public cls_data_ve_vehiculo_responsable()
        {
            this._con = ConfigurationManager.ConnectionStrings["db_mantenimiento"].ConnectionString;
        }
        ~cls_data_ve_vehiculo_responsable()
        {
            this._con = String.Empty;
        }


        /// <summary>
        /// Inserta un nuevo registro de ve_vehiculo_responsable y retorna el ID
        /// </summary>
        /// <param name="_ve_vehiculo_responsable">Retorna el ID del registro</param>
        /// <returns></returns>
        public int Insertar_ve_vehiculo_responsable(entidades.vialsur.prefectura.ve_vehiculo_responsable _ve_vehiculo_responsable)
        {
                        
            try
            {                                
                List<SqlParameter> parameters = new List<SqlParameter>();

                #region parametros
                SqlParameter _id = new SqlParameter("@id", SqlDbType.Int);
                _id.Direction = ParameterDirection.Output;
                _id.Value = _ve_vehiculo_responsable.id;
                parameters.Add(_id);

                SqlParameter _per_persona_cedula = new SqlParameter("@per_persona_cedula", SqlDbType.VarChar, 10);
                _per_persona_cedula.Value = _ve_vehiculo_responsable.per_persona_cedula;
                parameters.Add(_per_persona_cedula);

                SqlParameter _ve_vehiculo_id = new SqlParameter("@ve_vehiculo_id", SqlDbType.Int);
                _ve_vehiculo_id.Value = _ve_vehiculo_responsable.ve_vehiculo_id;
                parameters.Add(_ve_vehiculo_id);

                SqlParameter _estado = new SqlParameter("@estado", SqlDbType.Bit);
                _estado.Value = _ve_vehiculo_responsable.estado;
                parameters.Add(_estado);

                SqlParameter _fecha = new SqlParameter("@fecha", SqlDbType.Date );
                _fecha.Value = _ve_vehiculo_responsable.fecha;
                parameters.Add(_fecha);

                SqlParameter _tipo_responsable = new SqlParameter("@tipo_responsable", SqlDbType.Int);
                _tipo_responsable.Value = _ve_vehiculo_responsable.tipo_responsable;
                parameters.Add(_tipo_responsable);

                #endregion

                SqlHelper.ExecuteNonQuery(_con, CommandType.StoredProcedure, "dbo.VE_VEHICULO_RESPONSABLE_SP_INSERT", parameters.ToArray());

                return (int)_id.Value;

                  //  int customerId = SqlHelper.ExecuteNonQuery(_con, CommandType.Text, _sql_insert, parameters.ToArray());                 
         
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo registrar los datos de la persona", ex);
            }            
        }



    }
}
