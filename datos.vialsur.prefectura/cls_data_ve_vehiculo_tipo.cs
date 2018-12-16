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

    public class cls_data_ve_vehiculo_tipo
    {
        private string _con = String.Empty;
        public cls_data_ve_vehiculo_tipo()
        {
            this._con =  ConfigurationManager.ConnectionStrings["db_mantenimiento"].ConnectionString;
        }
        ~cls_data_ve_vehiculo_tipo()
        {
            this._con = String.Empty;
        }

       // private string sql_Consulta = "select id, codigo, nombre_especifico, nombre_comun from ve_vehiculo_color order by nombre_especifico;";

        //public void Insertar()
        //{
        //    try
        //    {

        //    }
        //    catch (Exception ex)
        //    {
                
        //    }
        //    finally
        //    {

        //    }

        //}
        //public bool Actualizar()
        //{
        //    return true;
        //}
        //public SqlDataReader Consultar()
        //{            
        //    try
        //    {
        //        return SqlHelper.ExecuteReader(_con, CommandType.Text, sql_Consulta);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("cls_data_ve_vehiculo_color:" + ex.Message, ex);
        //    }
        //    finally
        //    {

        //    }
        //}

        /// <summary>
        /// Consulta todos los tipos de vehiculos
        /// </summary>
        /// <returns></returns>
        public DataTable Consultar()
        {
            DataTable dt = new DataTable();
            try
            {
                string _consulta = "SELECT[id] ,[tipo] FROM[dbo].[ve_vehiculo_tipo]";
                dt.Load(SqlHelper.ExecuteReader(_con, CommandType.Text, _consulta), LoadOption.PreserveChanges);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("cls_data_ve_vehiculo_color:" + ex.Message, ex);
            }
            finally
            {
                dt.Dispose();
            }
        }

        /*
        public entidades.vialsur.prefectura.ve_vehiculo_color Consultar_Color(int id)
        {
            try
            {

                string consulta = "SELECT[id],[codigo],[nombre_especifico],[nombre_comun] FROM [ve_vehiculo_color] where id=@id";

                SqlParameter parametro = new SqlParameter("@id", SqlDbType.Int);
                parametro.Value = id;

                entidades.vialsur.prefectura.ve_vehiculo_color obj_color = new entidades.vialsur.prefectura.ve_vehiculo_color();

                SqlDataReader dr_datos = SqlHelper.ExecuteReader(_con, CommandType.Text, consulta, parametro);
                while (dr_datos.Read())
                {
                     obj_color.id = (int)dr_datos["id"];
                    obj_color.codigo = dr_datos["codigo"].ToString();
                    obj_color.nombre_especifico =  dr_datos["nombre_especifico"].ToString();
                    obj_color.nombre_comun = dr_datos["nombre_comun"].ToString();
                }
                dr_datos.Close();
                return obj_color;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        */
    }
}
