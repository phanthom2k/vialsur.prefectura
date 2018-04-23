﻿using System;
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

    //public enum Estado_catalogo_parte_secundiaria
    //{
    //    INACTIVO =0,
    //    ACTIVO=1
    //}
    
    //public enum TipoSubParte__catalogo_parte_secundiaria
    //{
    //    PESADOS = 1,
    //    LIVIANOS = 2,
    //    MIXTO = 3
    //}


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



        /// <summary>
        /// Consulta que retorna los datos del catalogo de partes secundarias
        /// bajo criterios como los agrupados en el catalogo principal, el tipo de sub parte
        /// </summary>
        /// <param name="catalogo_parte_principal_id"></param>
        /// <param name="tipo_sub_parte">Especificar si es vehiculo liviano o pesado</param>
        /// <param name="estado">Si esta activo o inactivo</param>
        /// <returns></returns>
        public DataTable Listar_Catalogo_Partes_Secundarias_UX(int catalogo_parte_principal_id, 
                                                               entidades.vialsur.prefectura.TipoSubParte__catalogo_parte_secundiaria tipo_sub_parte ,
                                                               entidades.vialsur.prefectura.Estado_catalogo_parte_secundiaria  estado)
        {
            try
            {
                string _sql_consulta =    "SELECT [id] ,[nombre] ,[catalogo_parte_principal_id] ,[estado] ,[tipo_sub_parte] " +
                                          "FROM [catalogo_parte_secundaria] " +
                                          "WHERE [catalogo_parte_principal_id] = @catalogo_parte_principal_id " +
                                          "AND [tipo_sub_parte] = @tipo_sub_parte " +
                                          "AND [estado] = @estado " +
                                          "ORDER BY[nombre] ASC ";

                List<SqlParameter> parameters = new List<SqlParameter>();

                SqlParameter _catalogo_parte_principal_id = new SqlParameter("@catalogo_parte_principal_id", SqlDbType.Int);
                _catalogo_parte_principal_id.Value = catalogo_parte_principal_id;
                parameters.Add(_catalogo_parte_principal_id);

                SqlParameter _tipo_sub_parte = new SqlParameter("@tipo_sub_parte", SqlDbType.Int);
                _tipo_sub_parte.Value = tipo_sub_parte;
                parameters.Add(_tipo_sub_parte);

                SqlParameter _estado = new SqlParameter("@estado", SqlDbType.Int);
                _estado.Value = estado;
                parameters.Add(_estado);

                DataTable dt = new DataTable();

                dt.Load(SqlHelper.ExecuteReader(_con, CommandType.Text, _sql_consulta, parameters.ToArray()), LoadOption.PreserveChanges);

                return dt;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


    }
}