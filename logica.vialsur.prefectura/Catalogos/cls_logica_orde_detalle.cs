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
                DataTable dt = new datos.vialsur.prefectura.cls_data_orde_detalle().ConsultarDetalleOrdenesByIdOrden_UI(id_orden);
                DataTable dt_clonada = dt.Clone();
                dt_clonada.Columns["accion_realizada"].DataType = typeof(string);
                dt_clonada.Columns["accion_requerida"].DataType = typeof(string);

                foreach(DataRow dr in dt.Rows)
                {
                    dt_clonada.LoadDataRow(dr.ItemArray, false);
                }
                dt.Clear();
                dt.Dispose();

                for (int i = 0; i<dt_clonada.Rows.Count; i++)
                {
                    dt_clonada.Rows[i]["accion_requerida"] = ((Orde_Detalle_ACCION)int.Parse(dt_clonada.Rows[i]["accion_requerida"].ToString())).ToString();
                    int j = 0;
                    int.TryParse(dt_clonada.Rows[i]["accion_realizada"].ToString(), out j);
                    dt_clonada.Rows[i]["accion_realizada"] = ((Orde_Detalle_ACCION)j).ToString();

                }
                return dt_clonada;
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

        /// <summary>
        /// Actualizar el detalle de una orden
        /// </summary>
        /// <param name="_orde_detalle"></param>
        public void ActualizarOrde_Detalle(orde_detalle _orde_detalle)
        {
            try
            {
                new datos.vialsur.prefectura.cls_data_orde_detalle().Actualizar_orde_detalle(_orde_detalle);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar los datos del detalle: " + ex.Message);
            }
        }

    }
}
