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

        private string sql_Consulta = "SELECT id, nombre, obserbacion FROM ve_vehiculo_marca where activo=1 order by nombre asc;";

        public void Insertar()
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {

            }

        }
        public bool Actualizar()
        {
            return true;
        }
        public SqlDataReader Consultar()
        {
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
