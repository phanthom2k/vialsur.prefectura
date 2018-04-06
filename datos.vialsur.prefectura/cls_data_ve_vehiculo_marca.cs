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

        private string sql_Consulta = "SELECT id, nombre, obserbacion FROM ve_vehiculo_marca order by nombre asc;";

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

    }
}
