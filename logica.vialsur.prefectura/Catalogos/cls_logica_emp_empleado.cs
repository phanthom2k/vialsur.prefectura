using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.vialsur.prefectura.Catalogos
{
    using entidades.vialsur.prefectura;

    public class cls_logica_emp_empleado
    {


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

                return new datos.vialsur.prefectura.cls_data_emp_empleado().ListarPersonas_UX(pivoteBase, pivoteProyectado, cedula);
                

                
            }
            catch (Exception ex)
            {
                throw;
            }
        }


    }
}
