using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.vialsur.prefectura.Orden
{
    using entidades.vialsur.prefectura;
    using datos.vialsur.prefectura;

    public class cls_logica_orden
    {

     
        /// <summary>
        /// Registra una orden y retorna el ID de la orden
        /// </summary>
        /// <param name="mi_ve_vehiculo"></param>
        /// <param name="mi_orden"></param>
        /// <param name="mi_orde_detalle"></param>
        /// <returns>IR DE LA ORDEN</returns>
        public string RegistrarOrdenMantenimiento(ve_vehiculo mi_ve_vehiculo, orden mi_orden, List<orde_detalle> mi_orde_detalle) //, ve_vehiculo_responsable mi_ve_vehiculo_responsable)
        {
            try
            {
                var _ve_vehiculo_responsable = new cls_data_ve_vehiculo_responsable();
                ve_vehiculo_responsable mi_ve_vehiculo_responsable = mi_orden.ve_vehiculo_responsable.First();
                int ve_vehiculo_responsable_id = _ve_vehiculo_responsable.Insertar_ve_vehiculo_responsable(mi_ve_vehiculo_responsable);
                
                var _orden = new cls_data_orden();
                mi_orden.ve_vehiculo_responsable_id = ve_vehiculo_responsable_id;
                string orden_id = _orden.Insertar_orden(mi_orden);

                for(int i= 0; i< mi_orde_detalle.Count; i++  )
                {
                    var _orde_detalle = mi_orde_detalle[i];
                    _orde_detalle.orden_id = orden_id;
                    new cls_data_orde_detalle().Insertar_orde_detalle(_orde_detalle);
                }
                return orden_id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
