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


    }
}
