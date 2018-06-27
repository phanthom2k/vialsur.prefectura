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

        public bool Nuevo(ve_vehiculo _ve_vehiculo)
        {
            bool _f = false;
            try
            {
                if (VerificarPlacasRegistrada(_ve_vehiculo.placa))
                    throw new Exception("Placa de vehiculo ya registrada");
                if (VerificarPlacasRegistrada(_ve_vehiculo.placa_provisional, true))
                    throw new Exception("Placa provisional de vehiculo ya registrada");
                if (VerificarSerieRegistrada(_ve_vehiculo.serie_chasis))
                    throw new Exception("Serie del chasis ya registrada");
                if (VerificarSerieRegistrada(_ve_vehiculo.serie_motor, false))
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
        /// Actualiza la informacion del vehiculo
        /// </summary>
        /// <param name="_ve_vehiculo"></param>
        /// <returns></returns>
        public bool ActualizarPorId(ve_vehiculo _ve_vehiculo)
        {

            try
            {
                return new datos.vialsur.prefectura.cls_data_ve_vehiculo().ActualizarVehiculo(_ve_vehiculo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
                if (PlacaPrvisional == true)
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
        public bool VerificarSerieRegistrada(string serie, bool SerieChasis = true)
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

        /// <summary>
        /// COnsulta un objeto ve_vehiculo segun el ID del mismo
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ve_vehiculo ConsultarDatosVehiculoPorId(int id)
        {
            try
            {
                ve_vehiculo obj_vehiculo =  new datos.vialsur.prefectura.cls_data_ve_vehiculo().ConsultarVerhiculo(id);
                ve_vehiculo_marca obj_marca = new datos.vialsur.prefectura.cls_data_ve_vehiculo_marca().Consultar_Marca(obj_vehiculo.ve_vehiculo_marca_id);
                ve_vehiculo_modelo obj_modelo = new datos.vialsur.prefectura.cls_data_ve_vehiculo_modelo().ConsultarModeloPorId(obj_vehiculo.ve_vehiculo_modelo_id);

                //return new datos.vialsur.prefectura.cls_data_ve_vehiculo().ConsultarVerhiculo(id);
                return obj_vehiculo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Consulta los datos de un vehiculo por su PLACA, PLACA PROVISIONAL, CODIGO Y CODIGO ANTERIOR
        /// </summary>
        /// <param name="parametro"></param>
        /// <param name="tipoBusqueda">0 <= PLACA, 1 <= PLACA PROVISIONAL, 2<= CODIGO, 3<=CODIGO ANTERIOR</param>
        /// <returns></returns>
        public ve_vehiculo ConsultarDatosVehiculo(string parametro, int tipoBusqueda)
        {
            try
            {
                return new datos.vialsur.prefectura.cls_data_ve_vehiculo().ConsultarVerhiculo(parametro, tipoBusqueda);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// obtiene el numero de registros de vehiculso registrados sin importar si estan activos o inactivos
        /// </summary>
        /// <returns></returns>
        public int ContarVehiculos()
        {
            try
            {
                return new datos.vialsur.prefectura.cls_data_ve_vehiculo().ContarVehiculos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar el numero de vehiculos registrados", ex);
            }
        }

        /// <summary>
        /// Permite listar todos los vehiculos registrados (consulta personalizada solo para el listado)
        /// </summary>
        /// <param name="parametro"></param>
        /// <returns></returns>
        public System.Data.DataTable ListarVehiculos_UX(string parametro = "")
        {
            try
            {
                return new datos.vialsur.prefectura.cls_data_ve_vehiculo().ListarVehiculos_UX(parametro);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un problema al realizar la busqueda",ex);
            }

        }


        /// <summary>
        /// Retorna la placa o placa provisional de un determinado vehiculo segun el ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetPlacaById(int id)
        {
            try
            {
                ve_vehiculo v_tmp = ConsultarDatosVehiculoPorId(id);
                return v_tmp.placa != null ? v_tmp.placa : v_tmp.placa_provisional;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
