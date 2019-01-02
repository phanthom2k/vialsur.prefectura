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
                                            "VALUES(@cedula,@cargo_id,@pwd,@activo,"+
                                            "@fecha_activacion,@fecha_desactivacion,@per_persona_cedula_activacion,"+
                                            "@tipo_usuario,@observaciones_activacion,@observaciones_desactivacion)";

                    //{"Invalid column name '@cedula'.\r\nInvalid column name '@cargo_id'.
                    //\r\nInvalid column name '@pwd'.\r\nInvalid column name '@activo'.
                    //\r\nInvalid column name '@fecha_activacion'.\r\nInvalid column name '@fecha_desactivacion'.\r\n
                    //Invalid column name '@per_persona_cedula_activacion'.\r\nInvalid column name '@tipo_usuario'.\r\n
                    //Invalid column name '@observaciones_activacion'.\r\nInvalid column name '@observaciones_desactivacion'."}

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

        public entidades.vialsur.prefectura.emp_empleado ConsultarEmpEmpleado(string cedula)
        {
            try
            {
                string consulta =   "SELECT[id],[cedula],[cargo_id],[pwd],[activo],[fecha_activacion],[fecha_desactivacion],[per_persona_cedula_activacion]," +
                                    "[tipo_usuario],[observaciones_activacion],[observaciones_desactivacion],[tipo_mantenimiento_asignado] " +
                                    "FROM [dbo].[emp_empleado] WHERE[cedula] = @cedula";

                SqlParameter parametro = new SqlParameter("@cedula", SqlDbType.VarChar);
                parametro.Value = cedula;

                entidades.vialsur.prefectura.emp_empleado obj_emp_empleado = new entidades.vialsur.prefectura.emp_empleado();

                SqlDataReader dr_datos = SqlHelper.ExecuteReader(_con, CommandType.Text, consulta, parametro);

                while (dr_datos.Read())
                {
                    obj_emp_empleado.id = Convert.ToInt32(dr_datos["id"]);
                    obj_emp_empleado.cedula = dr_datos["cedula"].ToString();
                    obj_emp_empleado.cargo_id = Convert.ToInt32(dr_datos["cargo_id"]);
                    obj_emp_empleado.pwd = dr_datos["pwd"].ToString();
                    obj_emp_empleado.activo = Convert.ToBoolean(dr_datos["activo"]);
                    obj_emp_empleado.fecha_activacion = Convert.ToDateTime(dr_datos["fecha_activacion"]);
                    obj_emp_empleado.fecha_desactivacion = Convert.ToDateTime(dr_datos["fecha_desactivacion"]);
                    obj_emp_empleado.per_persona_cedula_activacion = dr_datos["per_persona_cedula_activacion"].ToString();
                    obj_emp_empleado.tipo_usuario = Convert.ToInt32(dr_datos["tipo_usuario"]);
                    obj_emp_empleado.observaciones_activacion = dr_datos["observaciones_activacion"].ToString();
                    obj_emp_empleado.observaciones_desactivacion = dr_datos["observaciones_desactivacion"].ToString();
                    obj_emp_empleado.tipo_mantenimiento_asignado = Convert.ToInt32(dr_datos["tipo_mantenimiento_asignado"]);
                }
                dr_datos.Close();
                return obj_emp_empleado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar los datos de la persona: " + ex.Message);
            }
        }

        public bool ActalizarPer_persona(entidades.vialsur.prefectura.emp_empleado _emp_empleado)
        {
            bool k = false;
            try
            {
                if (VerificarExistenciaCedula(_emp_empleado.cedula))
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

                    SqlParameter _tipo_mantenimiento_asignado = new SqlParameter("@tipo_mantenimiento_asignado", SqlDbType.Int);
                    _tipo_mantenimiento_asignado.Value = _emp_empleado.tipo_mantenimiento_asignado;
                    parameters.Add(_tipo_mantenimiento_asignado);

                    
                    #endregion

                    string _sql_update =    "UPDATE[dbo].[emp_empleado] " +
                                            "SET[cargo_id] = @cargo_id, [pwd] = @pwd, [activo] = @activo,[fecha_activacion] = @fecha_activacion, [fecha_desactivacion] = @fecha_desactivacion, " +
                                            "[per_persona_cedula_activacion] = @per_persona_cedula_activacion, [tipo_usuario] = @tipo_usuario,[observaciones_activacion] = @observaciones_activacion," +
                                            "[observaciones_desactivacion] = @observaciones_desactivacion , [tipo_mantenimiento_asignado] = @tipo_mantenimiento_asignado " +
                                            "WHERE[cedula] = @cedula ";

                    int customerId = SqlHelper.ExecuteNonQuery(_con, CommandType.Text, _sql_update, parameters.ToArray());

                    k = customerId > 0 ? true : false;
                }
                else
                    throw new Exception("Cédula no registrada");
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo registrar los datos de la persona", ex);
            }
            return k;
        }

        /// <summary>
        /// Actualiza la clave
        /// </summary>
        /// <param name="_emp_empleado"></param>
        /// <returns></returns>
        public bool ActalizarPer_persona_Clave(entidades.vialsur.prefectura.emp_empleado _emp_empleado)
        {
            bool k = false;
            try
            {
                if (VerificarExistenciaCedula(_emp_empleado.cedula))
                {
                    List<SqlParameter> parameters = new List<SqlParameter>();

                    #region parametros

                    SqlParameter _cedula = new SqlParameter("@cedula", SqlDbType.VarChar, 10);
                    _cedula.Value = _emp_empleado.cedula;
                    parameters.Add(_cedula);

                    //SqlParameter _cargo_id = new SqlParameter("@cargo_id", SqlDbType.Int);
                    //_cargo_id.Value = _emp_empleado.cargo_id;
                    //parameters.Add(_cargo_id);

                    SqlParameter _pwd = new SqlParameter("@pwd", SqlDbType.Text);
                    _pwd.Value = _emp_empleado.pwd;
                    parameters.Add(_pwd);

                    //SqlParameter _activo = new SqlParameter("@activo", SqlDbType.Bit);
                    //_activo.Value = _emp_empleado.activo;
                    //parameters.Add(_activo);

                    //SqlParameter _fecha_activacion = new SqlParameter("@fecha_activacion", SqlDbType.DateTime);
                    //_fecha_activacion.Value = _emp_empleado.fecha_activacion;
                    //parameters.Add(_fecha_activacion);


                    //SqlParameter _fecha_desactivacion = new SqlParameter("@fecha_desactivacion", SqlDbType.DateTime);
                    //_fecha_desactivacion.Value = _emp_empleado.fecha_activacion;
                    //parameters.Add(_fecha_desactivacion);


                    //SqlParameter _per_persona_cedula_activacion = new SqlParameter("@per_persona_cedula_activacion", SqlDbType.VarChar, 10);
                    //_per_persona_cedula_activacion.Value = _emp_empleado.per_persona_cedula_activacion;
                    //parameters.Add(_per_persona_cedula_activacion);

                    //SqlParameter _tipo_usuario = new SqlParameter("@tipo_usuario", SqlDbType.Int);
                    //_tipo_usuario.Value = _emp_empleado.tipo_usuario;
                    //parameters.Add(_tipo_usuario);

                    //SqlParameter _observaciones_activacion = new SqlParameter("@observaciones_activacion", SqlDbType.Text);
                    //_observaciones_activacion.Value = _emp_empleado.observaciones_activacion;
                    //parameters.Add(_observaciones_activacion);

                    //SqlParameter _observaciones_desactivacion = new SqlParameter("@observaciones_desactivacion", SqlDbType.Text);
                    //_observaciones_desactivacion.Value = _emp_empleado.observaciones_desactivacion;
                    //parameters.Add(_observaciones_desactivacion);

                    #endregion

                    string _sql_update = "UPDATE[dbo].[emp_empleado] " +
                                            "SET  [pwd] = @pwd " +
                                            "WHERE[cedula] = @cedula ";

                    int customerId = SqlHelper.ExecuteNonQuery(_con, CommandType.Text, _sql_update, parameters.ToArray());

                    k = customerId > 0 ? true : false;
                }
                else
                    throw new Exception("Cédula no registrada");
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


        /// <summary>
        /// Lista los empleados que estan registrados para usar en la grilla principal, se incluye el nombre del CARGO y TIPO DE USUARIO ademas del ID
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="cedula"></param>
        /// <returns></returns>
        public DataTable ListarPersonas_UX(int a, int b, string cedula="")
        {
            try
            {
                //string _sql_consulta = "SELECT per_persona.cedula, per_persona.nombres, per_persona.apellidos, emp_empleado.id, emp_empleado.activo,emp_empleado.fecha_activacion, emp_empleado.tipo_usuario, emp_empleado.cargo_id " +
                //                        "FROM per_persona INNER JOIN emp_empleado ON per_persona.cedula = emp_empleado.cedula   ";


                string _sql_consulta = "SELECT p.cedula, p.nombres, p.apellidos, e.id, e.activo,e.fecha_activacion, " +
                                        "e.tipo_usuario, (select etu.nombre from emp_empleado_tipo_usuario etu where etu.id = e.tipo_usuario  ) as tipousuario, " +
                                        "e.cargo_id , (select emp_carg.nombre from emp_empleado_cargo as emp_carg where emp_carg.id = e.cargo_id) as cargoid " +
                                        "FROM per_persona p INNER JOIN emp_empleado e ON p.cedula = e.cedula ";

                List<SqlParameter> parameters = new List<SqlParameter>();
                if (cedula =="")  //para buscar minimo y maximo
                {
                    //_sql_consulta += "WHERE emp_empleado.id >= @ID1 AND emp_empleado.id <= @ID2 ";
                    _sql_consulta += "WHERE E.id >= @ID1 AND E.id <= @ID2   ORDER BY apellidos,nombres ";

                    SqlParameter _id1 = new SqlParameter("@ID1", SqlDbType.Int );
                    _id1.Value = a;
                    parameters.Add(_id1);

                    SqlParameter _id2 = new SqlParameter("@ID2", SqlDbType.Int);
                    _id2.Value = b;
                    parameters.Add(_id2);
                }
                else  //para buscar por el numero de cedula
                {
                    _sql_consulta += "WHERE E.cedula = @cedula   ; ";

                    SqlParameter _cedula = new SqlParameter("@cedula", SqlDbType.VarChar);
                    _cedula.Value = cedula;
                    parameters.Add(_cedula);
                }

                DataTable dt = new DataTable();

                dt.Load(SqlHelper.ExecuteReader(_con, CommandType.Text, _sql_consulta, parameters.ToArray() ), LoadOption.PreserveChanges);

                return dt;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Lista los usuarios registrados en el sistema, concatenado el apellido y nombre con el numero de cedula
        /// </summary>
        /// <param name="tu"></param>
        /// <param name="activo"></param>
        /// <returns></returns>
        public DataTable ListarPersonasPorTipoUsuario_UX(entidades.vialsur.prefectura.TipoUsuario tu, bool activo = true,
             entidades.vialsur.prefectura.Tipo_Mantenimiento_Asignado _Tipo_Mantenimiento_Asignado = entidades.vialsur.prefectura.Tipo_Mantenimiento_Asignado.NO_DEFINIDO)
        {
            try
            {
                string _sql_consulta = "SELECT CONCAT(per_persona.apellidos,' ', per_persona.nombres) nombre, per_persona.cedula, emp_empleado.id emp_empleado_id  " +
                                        "FROM per_persona INNER JOIN emp_empleado ON per_persona.cedula = emp_empleado.cedula " +
                                        "WHERE emp_empleado.activo = @activo " +
                                        "AND emp_empleado.tipo_usuario = @tipo_usuario ";
                if (_Tipo_Mantenimiento_Asignado != entidades.vialsur.prefectura.Tipo_Mantenimiento_Asignado.NO_DEFINIDO)
                    _sql_consulta += "AND tipo_mantenimiento_asignado= " + (int) _Tipo_Mantenimiento_Asignado;
                //_sql_consulta += "AND tipo_mantenimiento_asignado= " + (entidades.vialsur.prefectura.Tipo_Mantenimiento_Asignado)_Tipo_Mantenimiento_Asignado;


                List<SqlParameter> parameters = new List<SqlParameter>();
                SqlParameter _activo = new SqlParameter("@activo", SqlDbType.Bit);
                _activo.Value = activo;
                parameters.Add(_activo);

                SqlParameter _tipo_usuario = new SqlParameter("@tipo_usuario", SqlDbType.Int);
                _tipo_usuario.Value = tu;
                parameters.Add(_tipo_usuario);

                DataTable dt = new DataTable();

                dt.Load(SqlHelper.ExecuteReader(_con, CommandType.Text, _sql_consulta, parameters.ToArray()), LoadOption.PreserveChanges);

                return dt;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        /// <summary>
        /// Consulta el numero de empleados registrados
        /// </summary>
        /// <returns></returns>
        public int ConsultarNumeroEmpleados()
        {
            try
            {
                string _sql_consulta = "SELECT count([cedula]) as [cedula] FROM [dbo].[emp_empleado]";

                return Convert.ToInt32(SqlHelper.ExecuteScalar(_con, CommandType.Text, _sql_consulta));

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
