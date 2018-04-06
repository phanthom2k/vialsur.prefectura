using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace logica.vialsur.prefectura.Catalogos
{
    using datos.vialsur.prefectura;
    using System.Data.SqlClient;

    public class cls_logica_pais
    {
        public DataTable UX_Consulta_Todos_Registros()
        {
            try
            {
                SqlDataReader datos_para_control = new cls_data_pais().Consultar();

                DataTable dt_datos = new DataTable("pais");

                dt_datos.Load(datos_para_control);                
                DataRow dr0 = dt_datos.NewRow();
                dr0["PaisCodigo"] = 0;
                dr0["PaisNombre"] = "Seleccione";
                dt_datos.Rows.InsertAt(dr0, 0);
                return dt_datos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
