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

    public class cls_data_pais
    {
        private string _con = String.Empty;
        public cls_data_pais()
        {
            this._con = ConfigurationManager.ConnectionStrings["db_mantenimiento"].ConnectionString;
        }
        ~cls_data_pais()
        {
            this._con = String.Empty;
        }

        private string sql_Consulta = "select PaisCodigo, PaisNombre from Pais order by PaisNombre asc";

        public SqlDataReader Consultar()
        {
            try
            {
                return SqlHelper.ExecuteReader(_con, CommandType.Text, sql_Consulta);
            }
            catch (Exception ex)
            {
                throw new Exception("cls_data_pais:" + ex.Message, ex);
            }
            finally
            {

            }
        }


    }
}
