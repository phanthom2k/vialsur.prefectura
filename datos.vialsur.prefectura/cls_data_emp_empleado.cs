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

    public class cls_data_emp_empleado
    {
        private string _con = String.Empty;
        public cls_data_emp_empleado()
        {
            this._con = ConfigurationManager.ConnectionStrings["db_mantenimiento"].ConnectionString;
        }
        ~cls_data_emp_empleado()
        {
            this._con = String.Empty;
        }


        public bool InsertarNuevaPer_persona(entidades.vialsur.prefectura.emp_empleado _emp_empleado)
        {
            bool k = false;
            try
            {
                if (!VerificarExistenciaCedula(_emp_empleado.cedula))
                {
                    List<SqlParameter> parameters = new List<SqlParameter>();

                    #region parametros

                    SqlParameter _cedula = new SqlParameter("@cedula", SqlDbType.VarChar, 10);
                    _cedula.Value = _emp_empleado.cedula;
                    parameters.Add(_cedula);

                    SqlParameter _cargo_id = new SqlParameter("@cargo_id", SqlDbType.Int);
                    _cargo_id.Value = _emp_empleado.cargo_id;
                    parameters.Add(_cargo_id);

                    SqlParameter _pwd = new SqlParameter("@pwd", SqlDbType.Text);
                    _pwd.Value = _emp_empleado.pwd;
                    parameters.Add(_pwd);

                    SqlParameter _activo = new SqlParameter("@activo", SqlDbType.Bit);
                    _activo.Value = _emp_empleado.activo;
                    parameters.Add(_activo);

                    SqlParameter _fecha_activacion = new SqlParameter("@fecha_activacion", SqlDbType.DateTime);
                    _fecha_activacion.Value = _emp_empleado.fecha_activacion;
                    parameters.Add(_fecha_activacion);


                    SqlParameter _fecha_desactivacion = new SqlParameter("@fecha_desactivacion", SqlDbType.DateTime);
                    _fecha_desactivacion.Value = _emp_empleado.fecha_activacion;
                    parameters.Add(_fecha_desactivacion);


                    SqlParameter _per_persona_cedula_activacion = new SqlParameter("@per_persona_cedula_activacion", SqlDbType.VarChar, 10);
                    _per_persona_cedula_activacion.Value = _emp_empleado.per_persona_cedula_activacion;
                    parameters.Add(_per_persona_cedula_activacion);

                    SqlParameter _tipo_usuario = new SqlParameter("@tipo_usuario", SqlDbType.Int);
                    _tipo_usuario.Value = _emp_empleado.tipo_usuario;
                    parameters.Add(_tipo_usuario);

                    SqlParameter _observaciones_activacion = new SqlParameter("@observaciones_activacion", SqlDbType.Text);
                    _observaciones_activacion.Value = _emp_empleado.observaciones_activacion;
                    parameters.Add(_observaciones_activacion);

                    SqlParameter _observaciones_desactivacion = new SqlParameter("@observaciones_desactivacion", SqlDbType.Text);
                    _observaciones_desactivacion.Value = _emp_empleado.observaciones_desactivacion;
                    parameters.Add(_observaciones_desactivacion);  

                    #endregion

                    string _sql_insert =    "INSERT INTO [dbo].[emp_empleado] "+
                                            "([cedula],[cargo_id],[pwd],[activo],  "+
                                            "[fecha_activacion],[fecha_desactivacion],[per_persona_cedula_activacion],"+
                                            "[tipo_usuario],[observaciones_activacion],[observaciones_desactivacion]) "+
                                            "VALUES([@cedula],[@cargo_id],[@pwd],[@activo],"+
                                            "[@fecha_activacion],[@fecha_desactivacion],[@per_persona_cedula_activacion],"+
                                            "[@tipo_usuario],[@observaciones_activacion],[@observaciones_desactivacion])";

                    int customerId = SqlHelper.ExecuteNonQuery(_con, CommandType.Text, _sql_insert, parameters.ToArray());

                    k = customerId > 0 ? true : false;
                }
                else
                    throw new Exception("Cédula ya registrada");
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo registrar los datos de la persona", ex);
            }
            return k;
        }

        /// <summary>
        /// Verifica si existe la cedula ya registrada en la tabla
        /// Retorna FALSE en el caso de que no este registrada
        ///         TRUE en el caso de que este registrada
        /// </summary>
        /// <param name="_cedula"></param>
        /// <returns></returns>
        public bool VerificarExistenciaCedula(string _cedula)
        {
            try
            {
                string _sql_select = "SELECT COUNT([cedula]) FROM [dbo].[emp_empleado] WHERE [cedula] = @cedula";

                SqlParameter parametro = new SqlParameter("@cedula", SqlDbType.VarChar, 10);
                parametro.Value = _cedula;

                return Convert.ToInt32(SqlHelper.ExecuteScalar(_con, CommandType.Text, _sql_select, parametro)) == 0 ? false : true;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
