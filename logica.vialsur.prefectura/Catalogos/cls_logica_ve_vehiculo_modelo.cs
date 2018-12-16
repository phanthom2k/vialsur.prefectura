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


        /// <summary>
        /// Lista los modelos de una determinada marca para ser usados en la grilla principal
        /// </summary>
        /// <param name="id_marca"></param>
        /// <returns></returns>
        public DataTable ListarModelos_UX(int id_marca)
        {
            try
            {
                return new cls_data_ve_vehiculo_modelo().ListarModelos_UX(id_marca);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Consulta los datos de un determinado modelo
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public entidades.vialsur.prefectura.ve_vehiculo_modelo ConsultarModeloPorId(int id)
        {
            try
            {
                return new cls_data_ve_vehiculo_modelo().ConsultarModeloPorId(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Actualizar(entidades.vialsur.prefectura.ve_vehiculo_modelo modelo)
        {
            try
            {
                return new cls_data_ve_vehiculo_modelo().Actualizar(modelo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Insertar(entidades.vialsur.prefectura.ve_vehiculo_modelo modelo)
        {
            try
            {
                new cls_data_ve_vehiculo_modelo().Insertar(modelo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
