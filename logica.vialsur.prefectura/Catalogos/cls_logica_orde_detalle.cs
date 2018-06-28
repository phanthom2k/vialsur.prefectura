using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.vialsur.prefectura.Catalogos
{
    using entidades.vialsur.prefectura;
    using System.Data;

    public class cls_logica_orde_detalle
    {

        /// <summary>
        /// Retorna un DT con la informacion del detalle
        /// </summary>
        /// <param name="id_orden"></param>
        /// <returns></returns>
        public DataTable ConsultarDetalleOrdenesByIdOrden_UI(string id_orden)
        {           
            try
            {
                return new datos.vialsur.prefectura.cls_data_orde_detalle().ConsultarDetalleOrdenesByIdOrden_UI(id_orden);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar los datos del detalle: " + ex.Message);
            }

        }

        /// <summary>
        /// COonsulta un objeto  orde_detalle segun su ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public orde_detalle ConsultarOrde_DetalleById(string ID)
        {
            try
            {
                return new datos.vialsur.prefectura.cls_data_orde_detalle().ConsultarOrde_DetalleById( ID);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar los datos del detalle: " + ex.Message);
            }
        }


    }
}
