using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.vialsur.prefectura.Catalogos
{
    using entidades.vialsur.prefectura;
    using System.Data;


    public class cls_logica_emp_empleado_tipo_mantenimiento_asignado
    {
        /// <summary>
        /// Consulta el catalogo de TIPOS DE MANTENIMIENTO
        /// </summary>
        /// <returns></returns>
        public DataTable Consultar()
        {
            try
            {
                return new datos.vialsur.prefectura.cls_data_emp_empleado_tipo_mantenimiento_asignado().Consultar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /*
        public bool Nuevo_Emp_Empleado(emp_empleado empleado)
        {
            try
            {
                return new datos.vialsur.prefectura.cls_data_emp_empleado().InsertarNuevaPer_persona(empleado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public emp_empleado Consultar_Emp_Empleado(string cedula)
        {
            try
            {
                return new datos.vialsur.prefectura.cls_data_emp_empleado().ConsultarEmpEmpleado(cedula);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Actualizar_Emp_Empleado(emp_empleado empleado)
        {
            try
            {
                return new datos.vialsur.prefectura.cls_data_emp_empleado().ActalizarPer_persona(empleado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Actualizar_Emp_Empleado_PWD(emp_empleado empleado)
        {
            try
            {
                return new datos.vialsur.prefectura.cls_data_emp_empleado().ActalizarPer_persona_Clave(empleado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ExisteCedula(string cedula)
        {
            try
            {
                return new datos.vialsur.prefectura.cls_data_emp_empleado().VerificarExistenciaCedula(cedula);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public System.Data.DataTable ListarPersonas_UX(ref int pivoteBase, bool busquedaFrontal=true,  string cedula = "")
        {
            try
            {
                int pivoteProyectado = 0;
                //es para generar el conjunto de busqueda bassado en el id bajo y alto
                if (cedula=="")
                {
                    if (busquedaFrontal)
                        pivoteProyectado = pivoteBase + 25;
                    else

                    {
                        pivoteBase -= 25;
                        pivoteProyectado = pivoteBase + 25;
                    }
                }
                if (pivoteBase < 0)
                {
                    pivoteBase = 0;
                    pivoteProyectado = 25;
                }
                System.Data.DataTable dt = new datos.vialsur.prefectura.cls_data_emp_empleado().ListarPersonas_UX(pivoteBase, pivoteProyectado, cedula);
                System.Data.DataTable dt_clonada = dt.Clone();
                dt_clonada.Columns["tipo_usuario"].DataType = typeof(string);

                foreach(System.Data.DataRow dr in dt.Rows)
                {
                    dt_clonada.LoadDataRow(dr.ItemArray, false);
                }

                for (int i = 0; i < dt_clonada.Rows.Count; i++)
                {

                    dt_clonada.Rows[i]["tipo_usuario"] = ((TipoUsuario)int.Parse(dt_clonada.Rows[i]["tipo_usuario"].ToString())).ToString();
                }

                return dt_clonada;               
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retorna concatenado apellido con nombres, cedula y emp_empleado.id
        /// </summary>
        /// <param name="tu"></param>
        /// <param name="activo"></param>
        /// <returns></returns>
        public System.Data.DataTable ListarPersonasPorTipoUsuario_UX(entidades.vialsur.prefectura.TipoUsuario tu, bool activo = true)
        {
            try
            {

                //return new datos.vialsur.prefectura.cls_data_emp_empleado().ListarPersonasPorTipoUsuario_UX(tu, activo);
                System.Data.DataTable dt_empleados = new System.Data.DataTable("emp_empleado");
                dt_empleados  = new datos.vialsur.prefectura.cls_data_emp_empleado().ListarPersonasPorTipoUsuario_UX(tu, activo);
                              
                System.Data.DataRow  dr0 = dt_empleados.NewRow();
                dr0["cedula"] = 0;
                dr0["nombre"] = "Seleccione";
                dr0["emp_empleado_id"] = 0;
                dt_empleados.Rows.InsertAt(dr0, 0);
                return dt_empleados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        */
    }
}
