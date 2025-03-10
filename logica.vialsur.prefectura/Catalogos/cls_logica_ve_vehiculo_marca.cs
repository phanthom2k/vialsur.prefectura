﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.vialsur.prefectura.Catalogos
{
    using datos.vialsur.prefectura;
    using System.Data.SqlClient;
    using System.Data;

    public    class cls_logica_ve_vehiculo_marca
    {
        public DataTable UX_Consulta_Todos_Registros()
        {
            try
            {
                SqlDataReader datos_para_control = new cls_data_ve_vehiculo_marca().Consultar();

                DataTable dt_datos = new DataTable("ve_vehiculo_marca");
                dt_datos.Load(datos_para_control);                
                DataRow dr0 = dt_datos.NewRow();
                dr0["id"] = 0;
                dr0["nombre"] = "Seleccione";
                dt_datos.Rows.InsertAt(dr0, 0);
                return dt_datos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lista todos las Marcas Registradas
        /// </summary>
        /// <returns></returns>
        public DataTable Consulta_Todas_Marcas()
        {
            try
            {
                SqlDataReader datos_para_control = new cls_data_ve_vehiculo_marca().ConsultarTodasMarcas();

                DataTable dt_datos = new DataTable("ve_vehiculo_marca");
                dt_datos.Load(datos_para_control);               
                return dt_datos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retorna los datos de determinada marca segun el ID
        /// </summary>
        /// <returns></returns>
        public entidades.vialsur.prefectura.ve_vehiculo_marca InformacionMarca(int IdMarca)
        {
            try
            {
                return new cls_data_ve_vehiculo_marca().Consultar_Marca(IdMarca);                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Inserta un nuevo registro de una nueva marca
        /// </summary>
        /// <param name="marca"></param>
        public void InsertarMarca(entidades.vialsur.prefectura.ve_vehiculo_marca marca)
        {
            try
            {
                 new cls_data_ve_vehiculo_marca().Insertar(marca);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ActualizarMarca(entidades.vialsur.prefectura.ve_vehiculo_marca marca)
        {
            try
            {
                return new cls_data_ve_vehiculo_marca().Actualizar(marca);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
