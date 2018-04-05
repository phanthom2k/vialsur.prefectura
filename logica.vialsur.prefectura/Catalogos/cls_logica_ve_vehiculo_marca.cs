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

    public    class cls_logica_ve_vehiculo_marca
    {
        public DataTable UX_Consulta_Todos_Registros()
        {
            try
            {
                SqlDataReader datos_para_control = new cls_data_ve_vehiculo_color().Consultar();

                DataTable dt_datos = new DataTable("ve_vehiculo_color");
                dt_datos.Load(datos_para_control);                
                DataRow dr0 = dt_datos.NewRow();
                dr0["id"] = 0;
                dr0["nombre"] = "Seleccione";
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
