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
                    int ks = Convert.ToInt32(dt_Ordenes.Compute("Max(km_egreso)", ""));
                    if (ki == ks)
                        klm =  ki;
                    else
                        if (ks > ki)
                        klm = ks;
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
                    int ks = Convert.ToInt32(dt_Ordenes.Compute("Max(km_egreso)", ""));
                    if (ki == ks)
                        klm = ki;
                    else
                        if (ks > ki)
                        klm = ks;
                }
                return klm;
            }
            catch (Exception ex)
            {
                throw new Exception("Problemas al determinar el kilometraje del vehiculo", ex);
            }
        }


    }
}
