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
        /// <summary>
        /// Usada para UIX
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
                                    "FROM [ve_vehiculo_modelo] WHERE ID =@id";
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

        /// <summary>
        /// Consulta los MODELOS, con datos para ser usados en la grilla principal SEGUN EL ID DE LA MARCA
        /// </summary>
        /// <param name="Id_Modelo"></param>
        /// <returns></returns>
        public DataTable ListarModelos_UX(int Id_Marca)
        {
            try
            {
                //--tipo_combustible { 1:GASOLINA / 2:DIESEL} "+
                //--CLASE_VEHICULO { 1:LIVIANO / 2:PESADO}
                string _sql_consulta_lista_marcas = "SELECT[id],[modelo],[observacion],[ve_vehiculo_marca_id] " +
                                                    ",[tipo_combustible],  CASE WHEN[tipo_combustible] = 1 THEN 'GASOLINA' ELSE 'DIESEL' END COMBUSTIBLE " +
                                                    ",[traccion],[tipo_motor] " +
                                                    ",[ve_vehiculo_tipo_id], (SELECT TIPO FROM ve_vehiculo_tipo WHERE ID =[ve_vehiculo_tipo_id]) ve_vehiculo_tipo_nombre " +
                                                    ",[clase_vehiculo], CASE WHEN[clase_vehiculo] = 1 THEN 'LIVIANO' ELSE 'PESADO' END clase_vehiculo_nombre " +
                                                    "FROM[dbo].[ve_vehiculo_modelo] WHERE[ve_vehiculo_marca_id] = @ve_vehiculo_marca_id  ORDER BY[modelo] ASC";

      

                SqlParameter ve_vehiculo_marca_id = new SqlParameter("@ve_vehiculo_marca_id", SqlDbType.Int);
                ve_vehiculo_marca_id.Value = Id_Marca;

                DataTable dt = new DataTable();

                dt.Load(SqlHelper.ExecuteReader(_con, CommandType.Text, _sql_consulta_lista_marcas, ve_vehiculo_marca_id), LoadOption.PreserveChanges);

                return dt;
                //SqlHelper.ExecuteReader(_con, CommandType.Text, _sql_consulta_lista_marcas, ve_vehiculo_marca_id), LoadOption.PreserveChanges);                               
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar consultar el listado", ex);
            }

        }

        /// <summary>
        /// ACTUALIZA EL MODELO
        /// </summary>
        /// <param name="modelo"></param>
        /// <returns></returns>
        public bool Actualizar(entidades.vialsur.prefectura.ve_vehiculo_modelo modelo)
        {
            bool k = false;
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                #region parametros
                SqlParameter _id = new SqlParameter("@id", SqlDbType.Int);
                _id.Value = modelo.id;
                parameters.Add(_id);

                SqlParameter _modelo = new SqlParameter("@modelo", SqlDbType.VarChar, 50);
                _modelo.Value = modelo.modelo;
                parameters.Add(_modelo);

                SqlParameter _obserbacion = new SqlParameter("@observacion", SqlDbType.Text);
                _obserbacion.Value = modelo.observacion;
                parameters.Add(_obserbacion);

                SqlParameter _tipo_combustible = new SqlParameter("@tipo_combustible", SqlDbType.Int);
                _tipo_combustible.Value = modelo.tipo_combustible;
                parameters.Add(_tipo_combustible);

                SqlParameter _traccion = new SqlParameter("@traccion", SqlDbType.Bit);
                _traccion.Value = modelo.traccion;
                parameters.Add(_traccion);

                SqlParameter _tipo_motor = new SqlParameter("@tipo_motor", SqlDbType.Int);
                _tipo_motor.Value = modelo.tipo_motor;
                parameters.Add(_tipo_motor);

                SqlParameter _ve_vehiculo_tipo_id = new SqlParameter("@ve_vehiculo_tipo_id", SqlDbType.Int);
                _ve_vehiculo_tipo_id.Value = modelo.ve_vehiculo_tipo_id;
                parameters.Add(_ve_vehiculo_tipo_id);

                SqlParameter _clase_vehiculo = new SqlParameter("@clase_vehiculo", SqlDbType.Int);
                _clase_vehiculo.Value = modelo.clase_vehiculo;
                parameters.Add(_clase_vehiculo);
                
                #endregion

                string _sql_UPDATE = "UPDATE [dbo].[ve_vehiculo_modelo] SET [modelo] = @modelo,[observacion] = @observacion,[tipo_combustible] =@tipo_combustible, " +
                                     "[traccion] = @traccion ,[tipo_motor] =@tipo_motor ,[ve_vehiculo_tipo_id] =@ve_vehiculo_tipo_id  ,[clase_vehiculo] = @clase_vehiculo " +
                                     "WHERE [id]= @id";

                int customerId = SqlHelper.ExecuteNonQuery(_con, CommandType.Text, _sql_UPDATE, parameters.ToArray());

                k = customerId > 0 ? true : false;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo registrar los datos de la persona", ex);
            }
            return k;
        }

        public void Insertar(entidades.vialsur.prefectura.ve_vehiculo_modelo modelo)
        {
            
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                #region parametros

                SqlParameter _modelo = new SqlParameter("@modelo", SqlDbType.VarChar, 50);
                _modelo.Value = modelo.modelo;
                parameters.Add(_modelo);

                SqlParameter _obserbacion = new SqlParameter("@observacion", SqlDbType.Text);
                _obserbacion.Value = modelo.observacion;
                parameters.Add(_obserbacion);

                SqlParameter _ve_vehiculo_marca_id = new SqlParameter("@ve_vehiculo_marca_id", SqlDbType.Int);
                _ve_vehiculo_marca_id.Value = modelo.ve_vehiculo_marca_id;
                parameters.Add(_ve_vehiculo_marca_id);

                SqlParameter _tipo_combustible = new SqlParameter("@tipo_combustible", SqlDbType.Int);
                _tipo_combustible.Value = modelo.tipo_combustible;
                parameters.Add(_tipo_combustible);

                SqlParameter _traccion = new SqlParameter("@traccion", SqlDbType.Bit);
                _traccion.Value = modelo.traccion;
                parameters.Add(_traccion);

                SqlParameter _tipo_motor = new SqlParameter("@tipo_motor", SqlDbType.Int);
                _tipo_motor.Value = modelo.tipo_motor == null ? 0: modelo.tipo_motor;
                parameters.Add(_tipo_motor);

                SqlParameter _ve_vehiculo_tipo_id = new SqlParameter("@ve_vehiculo_tipo_id", SqlDbType.Int);
                _ve_vehiculo_tipo_id.Value = modelo.ve_vehiculo_tipo_id;
                parameters.Add(_ve_vehiculo_tipo_id);

                SqlParameter _clase_vehiculo = new SqlParameter("@clase_vehiculo", SqlDbType.Int);
                _clase_vehiculo.Value = modelo.clase_vehiculo;
                parameters.Add(_clase_vehiculo);

                

                #endregion

                string _sql_INSERT = "INSERT INTO [dbo].[ve_vehiculo_modelo] VALUES (dbo.FUN_MODELO_SEC(), @modelo,@observacion,@ve_vehiculo_marca_id,@tipo_combustible,@traccion,NULL,@tipo_motor,@ve_vehiculo_tipo_id,@clase_vehiculo) ";

                SqlHelper.ExecuteNonQuery(_con, CommandType.Text, _sql_INSERT, parameters.ToArray());
                
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo registrar los datos del modelo", ex);
            }            
        }


    }
}
