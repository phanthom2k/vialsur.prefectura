using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos.vialsur.prefectura
{
    using System.Data;
    using System.Configuration;
    using System.Data.SqlClient;
    using Microsoft.ApplicationBlocks.Data;

    public enum TipoVerificacion
    {
        SerieChasis,
        SerieMotor,
        Placa,
        PlacaProvisional
    }

    public class cls_data_ve_vehiculo
    {
        private string _con = String.Empty;
        public cls_data_ve_vehiculo()
        {
            this._con = ConfigurationManager.ConnectionStrings["db_mantenimiento"].ConnectionString;
        }
        ~cls_data_ve_vehiculo()
        {
            this._con = String.Empty;
        }

        /*
         
            CREATE SEQUENCE dbo.SEC_VEHICULO_ID 
    AS int  
    START WITH 1  
    INCREMENT BY 1 ; 

            SELECT NEXT VALUE FOR dbo.SEC_VEHICULO_ID

ALTER SEQUENCE Samples.IDLabel  
RESTART WITH 1 ;



   CREATE SEQUENCE CountBy5  
   AS int  
    START WITH 1  
    INCREMENT BY 1  
    MINVALUE 1  
 ->   MAXVALUE 5  
    CYCLE ;  
GO  



             */
        private string _sql_sec = "SELECT NEXT VALUE FOR dbo.SEC_VEHICULO_ID";
        private int Secuencial ()
        {
            try
            {
                return (int)SqlHelper.ExecuteScalar(_con, CommandType.Text, _sql_sec);
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede general el secuencial", ex);
            }
            finally
            {

            }
        }

        private string _sql_insert =    "INSERT INTO[dbo].[ve_vehiculo]([id],[ve_vehiculo_modelo_id],[ve_vehiculo_color_id],[anio_fabricacion],[anio_compra] " +
                                        ",[cilindraje],[codigo],[codigo_anterior],[costo],[estado],[PaisCodigo],[placa],[placa_provisional] " +
                                        ",[serie_chasis],[serie_motor]) " +
                                        "VALUES(@id, @ve_vehiculo_modelo_id, @ve_vehiculo_color_id, @anio_fabricacion, @anio_compra, " +
                                        "@cilindraje, @codigo, @codigo_anterior, @costo, @estado, @PaisCodigo, @placa, @placa_provisional, " +
                                        "@serie_chasis, @serie_motor)";
        public bool Insertar(entidades.vialsur.prefectura.ve_vehiculo _ve_vehiculo)
        {
            bool k = false;
            try
            {
                _ve_vehiculo.id = Secuencial();

                List<SqlParameter> parameters = new List<SqlParameter>();

                #region parametros
                SqlParameter _id = new SqlParameter("@id", SqlDbType.Int);
                _id.Value = _ve_vehiculo.id;
                _id.Direction = ParameterDirection.Input;
                parameters.Add(_id);

                SqlParameter _codigo = new SqlParameter("@codigo",SqlDbType.VarChar,20);
                _codigo.Value = _ve_vehiculo.codigo;
                parameters.Add(_codigo);    
                            
                SqlParameter _codigo_anterior = new SqlParameter("@codigo_anterior", SqlDbType.VarChar, 20);
                _codigo_anterior.Value = _ve_vehiculo.codigo_anterior;
                parameters.Add(_codigo_anterior);

                SqlParameter _costo = new SqlParameter("@costo", SqlDbType.Decimal);
                _costo.Value = _ve_vehiculo.costo;
                parameters.Add(_costo);

                SqlParameter _ve_vehiculo_modelo_id = new SqlParameter("@ve_vehiculo_modelo_id", SqlDbType.Int);
                _ve_vehiculo_modelo_id.Value = _ve_vehiculo.ve_vehiculo_modelo_id;
                parameters.Add(_ve_vehiculo_modelo_id);

                SqlParameter _PaisCodigo = new SqlParameter("@PaisCodigo", SqlDbType.Char, 3);
                _PaisCodigo.Value = _ve_vehiculo.PaisCodigo;
                parameters.Add(_PaisCodigo);

                SqlParameter _ve_vehiculo_color_id = new SqlParameter("@ve_vehiculo_color_id", SqlDbType.Int);
                _ve_vehiculo_color_id.Value = _ve_vehiculo.ve_vehiculo_color_id;
                parameters.Add(_ve_vehiculo_color_id);

                SqlParameter _serie_motor = new SqlParameter("@serie_motor", SqlDbType.VarChar, 500);
                _serie_motor.Value = _ve_vehiculo.serie_motor;
                parameters.Add(_serie_motor);

                SqlParameter _serie_chasis = new SqlParameter("@serie_chasis", SqlDbType.VarChar, 500);
                _serie_chasis.Value = _ve_vehiculo.serie_chasis;
                parameters.Add(_serie_chasis);

                SqlParameter _anio_fabricacion = new SqlParameter("@anio_fabricacion", SqlDbType.Int);
                _anio_fabricacion.Value = _ve_vehiculo.anio_fabricacion;
                parameters.Add(_anio_fabricacion);

                SqlParameter _anio_compra = new SqlParameter("@anio_compra", SqlDbType.Int);
                _anio_compra.Value = _ve_vehiculo.anio_compra;
                parameters.Add(_anio_compra);

                SqlParameter _placa = new SqlParameter("@placa", SqlDbType.VarChar, 50);
                _placa.Value = _ve_vehiculo.placa;
                parameters.Add(_placa);

                SqlParameter _placa_provisional = new SqlParameter("@placa_provisional", SqlDbType.VarChar, 50);
                _placa_provisional.Value = _ve_vehiculo.placa_provisional;
                parameters.Add(_placa_provisional);

                SqlParameter _cilindraje = new SqlParameter("@cilindraje", SqlDbType.VarChar, 50);
                _cilindraje.Value = _ve_vehiculo.cilindraje;
                parameters.Add(_cilindraje);

                SqlParameter _estado = new SqlParameter("@estado", SqlDbType.VarChar, 50);
                _estado.Value = _ve_vehiculo.estado;
                parameters.Add(_estado);


                #endregion

                int customerId = SqlHelper.ExecuteNonQuery(_con, CommandType.Text, _sql_insert, parameters.ToArray());
                //int execute = Convert.ToInt32(SqlHelper.ExecuteScalar(constr, CommandType.Text, query, parameters.ToArray()));

               
                k = customerId > 0 ? true : false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            //finally
            //{
                
            //}
            return k;
        }


        private string _sql_verificar_serie_chasis = "select serie_chasis from ve_vehiculo where UPPER(serie_chasis) = UPPER(@parametroBusqueda)";
        private string _sql_verificar_serie_motor = "select serie_motor from ve_vehiculo where UPPER(serie_motor) = UPPER(@parametroBusqueda)";
        private string _sql_verificar_placa = "select placa from ve_vehiculo where UPPER(placa) = UPPER(@parametroBusqueda)";
        private string _sql_verificar_placa_provisional = "select placa_provisional from ve_vehiculo where UPPER(placa_provisional) = UPPER(@parametroBusqueda)";


        public bool VerificarExistencia(TipoVerificacion tipo, string parametroBusqueda )
        {
            bool f = false;
            int _r = 0;
            try
            {
                SqlParameter parametro = new SqlParameter("@parametroBusqueda", SqlDbType.VarChar);
                parametro.Value = parametroBusqueda;
                switch(tipo)
                {
                    case TipoVerificacion.SerieChasis:
                        f = SqlHelper.ExecuteScalar(_con, CommandType.Text, _sql_verificar_serie_chasis, parametro).ToString() != String.Empty ? true : false;
                        break;
                    case TipoVerificacion.SerieMotor:
                        f = SqlHelper.ExecuteScalar(_con, CommandType.Text, _sql_verificar_serie_motor,parametro).ToString() != String.Empty ? true : false;
                        break;
                    case TipoVerificacion.Placa:                        
                        f = SqlHelper.ExecuteScalar(_con, CommandType.Text, _sql_verificar_placa, parametro).ToString() != String.Empty ? true : false;
                        break;
                    case TipoVerificacion.PlacaProvisional:
                        f = SqlHelper.ExecuteScalar(_con, CommandType.Text, _sql_verificar_placa_provisional,parametro).ToString() != String.Empty ? true : false;
                        break;
                    default: break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return f;
        }

        /// <summary>
        /// Consulta los datos de un vehiculo
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public entidades.vialsur.prefectura.ve_vehiculo ConsultarVerhiculo(int id)
        {
            try
            {
                string consulta =   "SELECT [id],[ve_vehiculo_modelo_id],[ve_vehiculo_color_id],[anio_fabricacion],[anio_compra]" +
                                    ",[cilindraje],[codigo],[codigo_anterior],[color],[costo],[estado],[PaisCodigo],[placa]" +
                                    ",[placa_provisional],[serie_chasis],[serie_motor] " +
                                    "FROM[dbo].[ve_vehiculo] WHERE ID = @id";

                SqlParameter parametro = new SqlParameter("@id",SqlDbType.Int );
                parametro.Value = id;

                entidades.vialsur.prefectura.ve_vehiculo obj_vehiculo = new entidades.vialsur.prefectura.ve_vehiculo();

                SqlDataReader dr_datos = SqlHelper.ExecuteReader(_con, CommandType.Text, consulta, parametro);
                while(dr_datos.Read())
                {
                    obj_vehiculo.id = int.Parse(dr_datos["id"].ToString());
                    obj_vehiculo.ve_vehiculo_modelo_id = int.Parse(dr_datos["ve_vehiculo_modelo_id"].ToString());
                    obj_vehiculo.ve_vehiculo_color_id = int.Parse(dr_datos["ve_vehiculo_color_id"].ToString());
                    obj_vehiculo.anio_fabricacion = int.Parse(dr_datos["anio_fabricacion"].ToString());
                    obj_vehiculo.anio_compra = int.Parse(dr_datos["anio_compra"].ToString());
                    obj_vehiculo.cilindraje = dr_datos["cilindraje"].ToString();
                    obj_vehiculo.codigo = dr_datos["codigo"].ToString();
                    obj_vehiculo.codigo_anterior = dr_datos["codigo_anterior"].ToString();
                    obj_vehiculo.color = dr_datos["color"].ToString();
                    obj_vehiculo.costo = decimal.Parse(dr_datos["costo"].ToString());
                    obj_vehiculo.estado = (bool)dr_datos["estado"];
                    obj_vehiculo.PaisCodigo = dr_datos["PaisCodigo"].ToString();
                    obj_vehiculo.placa = dr_datos["placa"].ToString();
                    obj_vehiculo.placa_provisional = dr_datos["placa_provisional"].ToString();
                    obj_vehiculo.serie_chasis = dr_datos["serie_chasis"].ToString();
                    obj_vehiculo.serie_motor = dr_datos["serie_motor"].ToString();
                }
                obj_vehiculo.ve_vehiculo_marca_id = (int) new cls_data_ve_vehiculo_modelo().ConsultarModeloPorId(obj_vehiculo.ve_vehiculo_modelo_id).ve_vehiculo_marca_id;


                return obj_vehiculo;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar los datos del vehiculo: "+ex.Message); 
            }
        }

    }
}
