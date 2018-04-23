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

    public class cls_data_catalogo_parte_secundiaria
    {
        private string _con = String.Empty;
        public cls_data_catalogo_parte_secundiaria()
        {
            this._con = ConfigurationManager.ConnectionStrings["db_mantenimiento"].ConnectionString;
        }
        ~cls_data_catalogo_parte_secundiaria()
        {
            this._con = String.Empty;
        }

        //public DataTable ListarPersonas_UX(int a, int b, string cedula = "")
        //{
        //    try
        //    {
        //        string _sql_consulta = "SELECT per_persona.cedula, per_persona.nombres, per_persona.apellidos, emp_empleado.id, emp_empleado.activo,emp_empleado.fecha_activacion, emp_empleado.tipo_usuario " +
        //                                "FROM per_persona INNER JOIN emp_empleado ON per_persona.cedula = emp_empleado.cedula   ";



        //        List<SqlParameter> parameters = new List<SqlParameter>();
        //        if (cedula == "")  //para buscar minimo y maximo
        //        {
        //            _sql_consulta += "WHERE emp_empleado.id >= @ID1 AND emp_empleado.id <= @ID2 ";

        //            SqlParameter _id1 = new SqlParameter("@ID1", SqlDbType.Int);
        //            _id1.Value = a;
        //            parameters.Add(_id1);

        //            SqlParameter _id2 = new SqlParameter("@ID2", SqlDbType.Int);
        //            _id2.Value = b;
        //            parameters.Add(_id2);
        //        }
        //        else  //para buscar por el numero de cedula
        //        {
        //            _sql_consulta += "WHERE emp_empleado.cedula = @cedula; ";

        //            SqlParameter _cedula = new SqlParameter("@cedula", SqlDbType.VarChar);
        //            _cedula.Value = cedula;
        //            parameters.Add(_cedula);
        //        }

        //        DataTable dt = new DataTable();

        //        dt.Load(SqlHelper.ExecuteReader(_con, CommandType.Text, _sql_consulta, parameters.ToArray()), LoadOption.PreserveChanges);

        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}


    }
}
