using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.vialsur.prefectura.Catalogos
{
    using entidades.vialsur.prefectura;

    public class cls_logica_catalogo_parte_secundaria
    {

        /// <summary>
        /// Lista las sub partes de determinada parte principal acorde si es vehiculo liviano o pesado
        /// </summary>
        /// <param name="catalogo_parte_principal_id"></param>
        /// <param name="tipo_sub_parte"></param>
        /// <param name="estado"></param>
        /// <returns></returns>
        public System.Data.DataTable ListarCatalogoPartesSecundario(int catalogo_parte_principal_id,
                                                               entidades.vialsur.prefectura.TipoSubParte__catalogo_parte_secundiaria tipo_sub_parte,
                                                               entidades.vialsur.prefectura.Estado_catalogo_parte_secundiaria estado)
        {
            try
            {
                return new datos.vialsur.prefectura.cls_data_catalogo_parte_secundiaria().Listar_Catalogo_Partes_Secundarias_UX(catalogo_parte_principal_id, tipo_sub_parte, estado);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un problema al realizar la busqueda", ex);
            }
        }

        /// <summary>
        /// Consulta la parte secundaria segun su id
        /// </summary>
        /// <param name="ById"></param>
        /// <returns></returns>
        public entidades.vialsur.prefectura.catalogo_parte_secundaria Parte_Secundaria_Get(int ById)
        {
            try
            {
                return new datos.vialsur.prefectura.cls_data_catalogo_parte_secundiaria().Parte_Secundaria_Get(ById);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un problema al realizar la busqueda", ex);
            }
        }


    }
}
