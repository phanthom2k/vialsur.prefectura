using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.vialsur.prefectura.Catalogos
{
    using entidades.vialsur.prefectura;
    public class cls_logica_catalogo_parte_principal
    {
        /// <summary>
        /// Consulta el catalogo de partes principales
        /// </summary>
        /// <returns></returns>
        public System.Data.DataTable ListarCatalogoPartesPrincipal()
        {
            try
            {
                return new datos.vialsur.prefectura.cls_data_catalogo_parte_principal().ListarPartePrincipal();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un problema al realizar la busqueda", ex);
            }
        }


    }
}
