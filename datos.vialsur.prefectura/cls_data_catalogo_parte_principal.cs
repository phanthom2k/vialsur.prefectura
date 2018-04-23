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

    public class cls_data_catalogo_parte_principal
    {
        private string _con = String.Empty;
        public cls_data_catalogo_parte_principal()
        {
            this._con = ConfigurationManager.ConnectionStrings["db_mantenimiento"].ConnectionString;
        }
        ~cls_data_catalogo_parte_principal()
        {
            this._con = String.Empty;
        }

        /// <summary>
        /// Retorna el ID y NOmbre de las partes
        /// </summary>
        /// <returns></returns>
        public DataTable ListarPartePrincipal()
        {
            try
            {
                string _sql_consulta = "SELECT[id],[nombre] FROM[catalogo_parte_principal] order by[nombre] asc; ";

                DataTable dt = new DataTable();

                dt.Load(SqlHelper.ExecuteReader(_con, CommandType.Text, _sql_consulta), LoadOption.PreserveChanges);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar el catalogo de Partes Principales",ex);
            }
        }


    }
}
