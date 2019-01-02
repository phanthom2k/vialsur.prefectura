using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.vialsur.prefectura.log
{
    using entidades.vialsur.prefectura;

    public class cls_log_empleados
    {

        /// <summary>
        /// Verifica si la clave y usuario es correcta
        /// </summary>
        /// <param name="cedula"></param>
        /// <param name="pwd"></param>
        /// <param name="EsValido"></param>
        /// <returns></returns>
        public entidades.vialsur.prefectura.emp_empleado Verificar(string cedula, string pwd, out bool EsValido )
        {
            try
            {
                emp_empleado obj_emp = new datos.vialsur.prefectura.cls_data_emp_empleado().ConsultarEmpEmpleado(cedula);
                if(obj_emp.cedula == null && obj_emp.pwd == null )
                    throw new Exception("Usuario y/o clave invalida");               

                if (obj_emp.cedula.Equals(cedula) && obj_emp.pwd.Equals(pwd))
                    EsValido = true;
                else
                {
                    EsValido = false;
                    throw new Exception("Usuario y/o clave invalida");
                }
                if ((bool)obj_emp.activo != true)
                    throw new Exception("Usuario inactivo.\nConsulte con el administrador del sistema.");

                return obj_emp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
