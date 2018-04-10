using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.vialsur.prefectura.Catalogos
{
    using entidades.vialsur.prefectura;
    public class cls_logica_ve_vehiculo
    {

        public bool Nuevo(ve_vehiculo _ve_vehiculo )
        {
            bool _f = false;
            try
            {
                if (VerificarPlacasRegistrada(_ve_vehiculo.placa))
                    throw new Exception("Placa de vehiculo ya registrada");
                if (VerificarPlacasRegistrada(_ve_vehiculo.placa_provisional,true))
                    throw new Exception("Placa provisional de vehiculo ya registrada");
                if (VerificarSerieRegistrada(_ve_vehiculo.serie_chasis))
                    throw new Exception("Serie del chasis ya registrada");
                if (VerificarSerieRegistrada(_ve_vehiculo.serie_motor,false))
                    throw new Exception("Serie del motor ya registrada");

                 _f = new datos.vialsur.prefectura.cls_data_ve_vehiculo().Insertar(_ve_vehiculo);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _f;
        }

        /// <summary>
        /// Verifica si la placa esta registrada
        /// </summary>
        /// <param name="placa">PLACA A BUSCAR</param>
        /// <param name="PlacaTemporal">FALSE por defecto para buscar en placa oficial, TRUE para buscar en placas provisionales</param>
        /// <returns></returns>
        public bool VerificarPlacasRegistrada(string placa, bool PlacaPrvisional = false)
        {
            bool _f = false;
            try
            {                
                if(PlacaPrvisional==true )
                {
                    _f = new datos.vialsur.prefectura.cls_data_ve_vehiculo().VerificarExistencia(datos.vialsur.prefectura.TipoVerificacion.PlacaProvisional, placa);
                }
                else
                {
                   _f = new datos.vialsur.prefectura.cls_data_ve_vehiculo().VerificarExistencia(datos.vialsur.prefectura.TipoVerificacion.Placa, placa);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _f;
        }

        /// <summary>
        /// Verifica si esta registrada la serie del motor o la del chasis
        /// </summary>
        /// <param name="serie">SERIE A BUSCAR</param>
        /// <param name="SerieChasis">TRUE por defecto para buscar en si existe el chasis registrado, FLASE buscar serie del motor</param>
        /// <returns></returns>
        public bool VerificarSerieRegistrada(string serie, bool SerieChasis = true )
        {
            bool _f = false;
            try
            {
                if (SerieChasis == true)
                {
                    _f = new datos.vialsur.prefectura.cls_data_ve_vehiculo().VerificarExistencia(datos.vialsur.prefectura.TipoVerificacion.SerieChasis, serie);
                }
                else
                {
                    _f = new datos.vialsur.prefectura.cls_data_ve_vehiculo().VerificarExistencia(datos.vialsur.prefectura.TipoVerificacion.SerieMotor, serie);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _f;
        }


    }
}
