using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.vialsur.prefectura.Catalogos
{
    using entidades.vialsur.prefectura;

    public class cls_logica_per_persona
    {
        public bool Nueva_Per_Persona(per_persona persona)
        {
            try
            {
                return new datos.vialsur.prefectura.cls_data_per_persona().InsertarNuevaPer_persona(persona);
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
                return new datos.vialsur.prefectura.cls_data_per_persona().VerificarExistenciaCedula(cedula);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
