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

    public class cls_data_ve_vehiculo_modelo
    {
        private string _con = String.Empty;
        public cls_data_ve_vehiculo_modelo()
        {
            this._con = ConfigurationManager.ConnectionStrings["db_mantenimiento"].ConnectionString;
        }
        ~cls_data_ve_vehiculo_modelo()
        {
            this._con = String.Empty;
        }

        private string sql_consulta = "select id, modelo, observacion, ve_vehiculo_marca_id,tipo_combustible,traccion,tipo_motor,ve_vehiculo_tipo_id, clase_vehiculo from ve_vehiculo_modelo order by ve_vehiculo_marca_id, modelo";
        public SqlDataReader Consultar()
        {
            try
            {
                return SqlHelper.ExecuteReader(_con, CommandType.Text, sql_consulta);
            }
            catch (Exception ex)
            {
                throw new Exception("cls_data_ve_vehiculo_modelo:" + ex.Message, ex);
            }
            finally
            {

            }
        }

        private string sql_consulta_by_IdMarca = "select id, modelo, observacion, ve_vehiculo_marca_id,tipo_combustible,traccion,tipo_motor,ve_vehiculo_tipo_id, clase_vehiculo from ve_vehiculo_modelo where ve_vehiculo_marca_id={0} order by modelo";
        public SqlDataReader ConsultarByIdMarca(int id)
        {
            try
            {
                return SqlHelper.ExecuteReader(_con, CommandType.Text, string.Format(sql_consulta_by_IdMarca,id) );
            }
            catch (Exception ex)
            {
                throw new Exception("cls_data_ve_vehiculo_modelo:" + ex.Message, ex);
            }
            finally
            {

            }
        }


    }
}
