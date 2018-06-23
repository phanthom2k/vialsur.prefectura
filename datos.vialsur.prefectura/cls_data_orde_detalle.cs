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

    public class cls_data_orde_detalle
    {

        private string _con = String.Empty;
        public cls_data_orde_detalle()
        {
            this._con = ConfigurationManager.ConnectionStrings["db_mantenimiento"].ConnectionString;
        }
        ~cls_data_orde_detalle()
        {
            this._con = String.Empty;
        }

        /// <summary>
        /// Inserta un registro de orde_detalle, y retorna el id 
        /// </summary>
        /// <param name="_orde_detalle"></param>
        /// <returns></returns>
        public string Insertar_orde_detalle(entidades.vialsur.prefectura.orde_detalle _orde_detalle)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                #region parametros
                SqlParameter _id = new SqlParameter("@id", SqlDbType.NChar, 10);
                _id.Direction = ParameterDirection.Output;
                _id.Value = _orde_detalle.id;
                parameters.Add(_id);

                SqlParameter _catalogo_parte_principal_id = new SqlParameter("@catalogo_parte_principal_id", SqlDbType.Int);
                _catalogo_parte_principal_id.Value = _orde_detalle.catalogo_parte_principal_id;
                parameters.Add(_catalogo_parte_principal_id);

                SqlParameter _catalogo_parte_secundaria_id = new SqlParameter("@catalogo_parte_secundaria_id", SqlDbType.Int);
                _catalogo_parte_secundaria_id.Value = _orde_detalle.catalogo_parte_secundaria_id;
                parameters.Add(_catalogo_parte_secundaria_id);

                SqlParameter _accion_realizada = new SqlParameter("@accion_realizada", SqlDbType.Int);
                _accion_realizada.Value = _orde_detalle.accion_realizada;
                parameters.Add(_accion_realizada);

                SqlParameter _cantidad = new SqlParameter("@cantidad", SqlDbType.Decimal );
                _cantidad.Value = _orde_detalle.cantidad;
                parameters.Add(_cantidad);

                SqlParameter _observacion = new SqlParameter("@observacion", SqlDbType.Text);
                _observacion.Value = _orde_detalle.observacion;
                parameters.Add(_observacion);

                SqlParameter _estado = new SqlParameter("@estado", SqlDbType.Bit);
                _estado.Value = _orde_detalle.estado;
                parameters.Add(_estado);

                SqlParameter _accion_requerida = new SqlParameter("@accion_requerida", SqlDbType.Bit);
                _accion_requerida.Value = _orde_detalle.accion_requerida;
                parameters.Add(_accion_requerida);

                SqlParameter _orden_id = new SqlParameter("@orden_id", SqlDbType.NChar, 10 );
                _orden_id.Value = _orde_detalle.orden_id;
                parameters.Add(_orden_id);

                #endregion

                SqlHelper.ExecuteNonQuery(_con, CommandType.StoredProcedure, "dbo.orde_detalle_SP_INSERT", parameters.ToArray());

                return _id.Value.ToString();                

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo registrar los datos de la persona", ex);
            }
        }



    }
}
