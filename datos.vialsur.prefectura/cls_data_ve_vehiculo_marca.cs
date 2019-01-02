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

    public class cls_data_ve_vehiculo_marca
    {

        private string _con = String.Empty;
        public cls_data_ve_vehiculo_marca()
        {
            this._con = ConfigurationManager.ConnectionStrings["db_mantenimiento"].ConnectionString;
        }
        ~cls_data_ve_vehiculo_marca()
        {
            this._con = String.Empty;
        }

        

        /// <summary>
        /// Inserta nuevo registro
        /// </summary>
        /// <param name="marca"></param>
        public void Insertar(entidades.vialsur.prefectura.ve_vehiculo_marca marca)
        {            
            try
            {                
                    List<SqlParameter> parameters = new List<SqlParameter>();

                    #region parametros
                    SqlParameter _id = new SqlParameter("@id", SqlDbType.Int);
                    _id.Value = marca.id;
                    parameters.Add(_id);

                    SqlParameter _nombre = new SqlParameter("@nombre", SqlDbType.VarChar, 150);
                    _nombre.Value = marca.nombre;
                    parameters.Add(_nombre);

                    SqlParameter _obserbacion = new SqlParameter("@obserbacion", SqlDbType.VarChar, 150);
                    _obserbacion.Value = marca.obserbacion;
                    parameters.Add(_obserbacion);

                    SqlParameter _activo = new SqlParameter("@activo", SqlDbType.Bit);
                    _activo.Value = marca.activo;
                    parameters.Add(_activo);
                #endregion

                    string _sql_insert = "INSERT INTO[dbo].[ve_vehiculo_marca] ([id],[nombre],[obserbacion],[activo]) VALUES (dbo.FUN_MARCA_SEC(), @nombre, @obserbacion, @activo);";

                    SqlHelper.ExecuteNonQuery(_con, CommandType.Text, _sql_insert, parameters.ToArray());                    
             
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo registrar los datos de la persona", ex);
            }                    
        }
        public bool Actualizar(entidades.vialsur.prefectura.ve_vehiculo_marca marca)
        {
            bool k = false;
            try
            {
                
                    List<SqlParameter> parameters = new List<SqlParameter>();

                    #region parametros
                    SqlParameter _id = new SqlParameter("@id", SqlDbType.Int);
                    _id.Value = marca.id;
                    parameters.Add(_id);

                    SqlParameter _nombre = new SqlParameter("@nombre", SqlDbType.VarChar, 150);
                    _nombre.Value = marca.nombre;
                    parameters.Add(_nombre);

                    SqlParameter _obserbacion = new SqlParameter("@obserbacion", SqlDbType.VarChar, 150);
                    _obserbacion.Value = marca.obserbacion;
                    parameters.Add(_obserbacion);

                    SqlParameter _activo = new SqlParameter("@activo", SqlDbType.Bit);
                    _activo.Value = marca.activo;
                    parameters.Add(_activo);
                    #endregion

                    string _sql_UPDATE = "UPDATE[dbo].[ve_vehiculo_marca] SET [nombre] = @nombre, [obserbacion] = @obserbacion, [activo] = @activo WHERE [id] = @id;";

                    int customerId = SqlHelper.ExecuteNonQuery(_con, CommandType.Text, _sql_UPDATE, parameters.ToArray());

                    k = customerId > 0 ? true : false;             
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo registrar los datos de la persona", ex);
            }
            return k;                       
        }
        public SqlDataReader Consultar(bool activo=true)
        {

            string sql_Consulta =  "SELECT id, nombre, obserbacion FROM ve_vehiculo_marca where activo=1 order by nombre asc;";

            try
            {
                return SqlHelper.ExecuteReader(_con, CommandType.Text, sql_Consulta);
            }
            catch (Exception ex)
            {
                throw new Exception("cls_data_ve_vehiculo_marca:" + ex.Message, ex);
            }
            finally
            {

            }
        }
        /// <summary>
        /// Retorna un SqlDataReader con todas las marcas disponibles en el catalogo
        /// </summary>
        /// <returns></returns>
        public SqlDataReader ConsultarTodasMarcas()
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
        }

        /// <summary>
        /// Consulta los datos de la Marca segun el ID
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public entidades.vialsur.prefectura.ve_vehiculo_marca Consultar_Marca(int id )
        {
            try
            {

                string consulta = "SELECT [id],[nombre],[obserbacion],[activo] FROM [ve_vehiculo_marca] WHERE id = @id";
                
                SqlParameter parametro = new SqlParameter("@id", SqlDbType.Int);
                parametro.Value = id;

                entidades.vialsur.prefectura.ve_vehiculo_marca obj_marca = new entidades.vialsur.prefectura.ve_vehiculo_marca();

                SqlDataReader dr_datos = SqlHelper.ExecuteReader(_con, CommandType.Text, consulta, parametro);
                while (dr_datos.Read())
                {
                    obj_marca.id = (int)dr_datos["id"];
                    obj_marca.nombre = dr_datos["nombre"].ToString();
                    obj_marca.obserbacion = dr_datos["obserbacion"].ToString();
                    obj_marca.activo = (bool) dr_datos["activo"];                   
                }
                dr_datos.Close();
                return obj_marca;                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
