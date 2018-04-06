using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.vialsur.prefectura.Catalogos
{
    using datos.vialsur.prefectura;
    using System.Data.SqlClient;
    using System.Data;

    public class cls_logica_ve_vehiculo_modelo
    {
        public DataTable UX_Consulta_Todos_Registros(int id)
        {
            try
            {
                SqlDataReader datos_para_control = new cls_data_ve_vehiculo_modelo().ConsultarByIdMarca(id);

                DataTable dt_datos = new DataTable("ve_vehiculo_modelo");
                dt_datos.Load(datos_para_control);
                DataRow dr0 = dt_datos.NewRow();
                dr0["id"] = 0;
                dr0["modelo"] = "Seleccione";
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
