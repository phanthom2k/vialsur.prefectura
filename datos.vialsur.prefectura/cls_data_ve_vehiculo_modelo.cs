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

        /// <summary>
        /// Consulta un determinado MODELO segun el ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public entidades.vialsur.prefectura.ve_vehiculo_modelo ConsultarModeloPorId(int id)
        {
            try
            {
                string consulta =   "SELECT [id],[modelo],[observacion],[ve_vehiculo_marca_id],[tipo_combustible],[traccion]" +
                                    ",[imagen],[tipo_motor],[ve_vehiculo_tipo_id],[clase_vehiculo] " +
                                    "FROM[dbo].[ve_vehiculo_modelo] WHERE ID =@id";
;
                SqlParameter parametro = new SqlParameter("@id", SqlDbType.Int);
                parametro.Value = id;

                entidades.vialsur.prefectura.ve_vehiculo_modelo obj_modelo = new entidades.vialsur.prefectura.ve_vehiculo_modelo();

                SqlDataReader dr_datos = SqlHelper.ExecuteReader(_con, CommandType.Text, consulta, parametro);
                while (dr_datos.Read())
                {
                    obj_modelo.id = (int)dr_datos["id"];
                    obj_modelo.modelo = dr_datos["modelo"].ToString();
                    obj_modelo.observacion = dr_datos["observacion"].ToString();
                    obj_modelo.ve_vehiculo_marca_id = (int)dr_datos["ve_vehiculo_marca_id"];
                    obj_modelo.tipo_combustible = (int)dr_datos["tipo_combustible"];
                    obj_modelo.traccion = (bool)dr_datos["traccion"];
                    obj_modelo.tipo_motor = (int)dr_datos["tipo_motor"];
                    obj_modelo.ve_vehiculo_tipo_id = (int)dr_datos["ve_vehiculo_tipo_id"];
                    obj_modelo.clase_vehiculo = (int)dr_datos["clase_vehiculo"];                                        
                }
                return obj_modelo;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar los datos del vehiculo: " + ex.Message);
            }
        }

    }
}
