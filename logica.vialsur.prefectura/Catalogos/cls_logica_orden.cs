using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.vialsur.prefectura.Catalogos
{
    using entidades.vialsur.prefectura;
    using System.Data;

    public  class cls_logica_orden
    {
        /// <summary>
        /// Consulta el Kilimetraje mayor del vehiculo segun el Id de Vehiculo
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int ConsultarKilometrajeDeVehiculo(int id)
        {
            try
            {
                int klm = 0;
                DataTable dt_Ordenes = new datos.vialsur.prefectura.cls_data_orden().ObtenerOrdenesByIdVehiculo(id);
                if (dt_Ordenes.Rows.Count == 0)
                    klm = 0;
                else
                {
                    int ki = Convert.ToInt32(dt_Ordenes.Compute("Max(km_ingreso)", ""));
                    int ks = 0;
                    int.TryParse(dt_Ordenes.Compute("Max(km_egreso)", "").ToString(), out ks);
                    if (ki == ks)
                        klm =  ki;
                    else
                        if (ks > ki)
                        klm = ks;
                    else if (ks < ki)
                        klm = ki;
                }
                return klm;   
            }
            catch (Exception ex)
            {
                throw new Exception("Problemas al determinar el kilometraje del vehiculo",ex );
            }
        }

        /// <summary>
        /// Consulta el kilometraje de un vehiculo segun su PLACA
        /// </summary>
        /// <param name="Placa"></param>
        /// <returns></returns>
        public int ConsultarKilometrajeDeVehiculo(string Placa)
        {
            try
            {
                int klm = 0;
                DataTable dt_Ordenes = new datos.vialsur.prefectura.cls_data_orden().ObtenerOrdenesByPlaca(Placa);
                if (dt_Ordenes.Rows.Count == 0)
                    klm = 0;
                else
                {
                    int ki = Convert.ToInt32(dt_Ordenes.Compute("Max(km_ingreso)", ""));
                    int ks = 0;
                    int.TryParse(dt_Ordenes.Compute("Max(km_egreso)", "").ToString(), out ks);
                    if (ki == ks)
                        klm = ki;
                    else
                        if (ks > ki)
                            klm = ks;
                        else if (ks < ki)
                            klm = ki;
                }
                return klm;
            }
            catch (Exception ex)
            {
                throw new Exception("Problemas al determinar el kilometraje del vehiculo", ex);
            }
        }




        public orden ConsultarOrdenPorId(string id_orden)
        {
            try
            {
                orden obj_orden = new datos.vialsur.prefectura.cls_data_orden().ConsultarOrdenPorId(id_orden);
                ve_vehiculo_responsable obj_ve_responsable = new datos.vialsur.prefectura.cls_data_ve_vehiculo_responsable().ConsultarVe_VehiculoResponsablePorId((int)obj_orden.ve_vehiculo_responsable_id);                
                ve_vehiculo obj_vehiculo = new cls_logica_ve_vehiculo().ConsultarDatosVehiculoPorId((int)obj_ve_responsable.ve_vehiculo_id);
                ve_vehiculo_color obj_col = new datos.vialsur.prefectura.cls_data_ve_vehiculo_color().Consultar_Color(obj_vehiculo.ve_vehiculo_color_id);
                obj_vehiculo.ve_vehiculo_color = obj_col;
                obj_ve_responsable.ve_vehiculo = obj_vehiculo;
                obj_orden.ve_vehiculo_responsable.Add(obj_ve_responsable);

                return obj_orden;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
