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

    public class cls_data_per_persona
    {
        private string _con = String.Empty;
        public cls_data_per_persona()
        {
            this._con = ConfigurationManager.ConnectionStrings["db_mantenimiento"].ConnectionString;
        }
        ~cls_data_per_persona()
        {
            this._con = String.Empty;
        }

        /// <summary>
        /// Inserta datos de nueva persona
        /// </summary>
        /// <param name="_per_persona"></param>
        /// <returns></returns>
        public bool InsertarNuevaPer_persona(entidades.vialsur.prefectura.per_persona _per_persona)
        {
            bool k = false;
            try
            {
                if (!VerificarExistenciaCedula(_per_persona.cedula))
                {
                    List<SqlParameter> parameters = new List<SqlParameter>();

                    #region parametros

                    SqlParameter _cedula = new SqlParameter("@cedula", SqlDbType.VarChar, 10);
                    _cedula.Value = _per_persona.cedula;
                    parameters.Add(_cedula);

                    SqlParameter _nombres = new SqlParameter("@nombres", SqlDbType.VarChar, 150);
                    _nombres.Value = _per_persona.nombres;
                    parameters.Add(_nombres);

                    SqlParameter _apellidos = new SqlParameter("@apellidos", SqlDbType.VarChar, 150);
                    _apellidos.Value = _per_persona.apellidos;
                    parameters.Add(_apellidos);

                    SqlParameter _fecha_nacimiento = new SqlParameter("@fecha_nacimiento", SqlDbType.DateTime);
                    _fecha_nacimiento.Value = _per_persona.fecha_nacimiento;
                    parameters.Add(_fecha_nacimiento);

                    #endregion

                    string _sql_insert = "INSERT INTO [dbo].[per_persona] " +
                                            "([cedula],[nombres],[apellidos],[fecha_nacimiento]) " +
                                            "VALUES(@cedula, @nombres, @apellidos, @fecha_nacimiento)";

                    int customerId = SqlHelper.ExecuteNonQuery(_con, CommandType.Text, _sql_insert, parameters.ToArray());

                    k = customerId > 0 ? true : false;
                }
                else
                    throw new Exception("Cédula ya registrada");
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo registrar los datos de la persona",ex);
            }            
            return k;
        }

        /// <summary>
        /// Consulta los registros de una persona segun su cedula retornano un Objeto tipo Per_Persona
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns></returns>
        public entidades.vialsur.prefectura.per_persona ConsultarPerPersona(string cedula)
        {
            try
            {
                string consulta = "SELECT [cedula],[nombres],[apellidos],[fecha_nacimiento] " +
                                    "FROM[dbo].[per_persona] where[cedula] = @cedula";

                SqlParameter parametro = new SqlParameter("@cedula", SqlDbType.VarChar );
                parametro.Value = cedula;

                entidades.vialsur.prefectura.per_persona obj_per_persona = new entidades.vialsur.prefectura.per_persona();

                SqlDataReader dr_datos = SqlHelper.ExecuteReader(_con, CommandType.Text, consulta, parametro);

                while(dr_datos.Read())
                {
                    obj_per_persona.cedula = dr_datos["cedula"].ToString();
                    obj_per_persona.nombres = dr_datos["nombres"].ToString();
                    obj_per_persona.apellidos = dr_datos["apellidos"].ToString();
                    obj_per_persona.fecha_nacimiento = Convert.ToDateTime(dr_datos["fecha_nacimiento"]);
                }
                dr_datos.Close();
                return obj_per_persona;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar los datos de la persona: " + ex.Message);
            }
        }

        /// <summary>
        /// Actualiza los datos de una persona segun la cedula, cedula no se actualiza
        /// </summary>
        /// <param name="_per_persona"></param>
        /// <returns></returns>
        public bool ActualizarPerPersona(entidades.vialsur.prefectura.per_persona _per_persona)
        {
            bool k = false;
            try
            {
                if (VerificarExistenciaCedula(_per_persona.cedula))
                {
                    List<SqlParameter> parameters = new List<SqlParameter>();

                    #region parametros

                    SqlParameter _cedula = new SqlParameter("@cedula", SqlDbType.VarChar, 10);
                    _cedula.Value = _per_persona.cedula;
                    parameters.Add(_cedula);

                    SqlParameter _nombres = new SqlParameter("@nombres", SqlDbType.VarChar, 150);
                    _nombres.Value = _per_persona.nombres;
                    parameters.Add(_nombres);

                    SqlParameter _apellidos = new SqlParameter("@apellidos", SqlDbType.VarChar, 150);
                    _apellidos.Value = _per_persona.apellidos;
                    parameters.Add(_apellidos);

                    SqlParameter _fecha_nacimiento = new SqlParameter("@fecha_nacimiento", SqlDbType.DateTime);
                    _fecha_nacimiento.Value = _per_persona.fecha_nacimiento;
                    parameters.Add(_fecha_nacimiento);

                    #endregion

                    string _sql_update =    "UPDATE[dbo].[per_persona] " +
                                            "SET[nombres] = @nombres, [apellidos] = @apellidos, [fecha_nacimiento] = @fecha_nacimiento " +
                                            "WHERE cedula = @cedula ";                                            

                    int customerId = SqlHelper.ExecuteNonQuery(_con, CommandType.Text, _sql_update , parameters.ToArray());

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
        /// Verifica si existe registrada la cedula
        /// Retorna FALSE en el caso de que no este registrada y TRUE en el casi de que si
        /// </summary>
        /// <param name="_cedula">FALSE indica que no</param>
        /// <returns></returns>
        public bool VerificarExistenciaCedula(string _cedula)
        {
            try
            {
                string _sql_select = "SELECT COUNT(cedula) cedula FROM [dbo].[per_persona] WHERE cedula =@cedula";

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
