//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace entidades.vialsur.prefectura
{
    using System;
    using System.Collections.Generic;

    public enum Estado_catalogo_parte_secundiaria
    {
        INACTIVO = 0,
        ACTIVO = 1
    }

    public enum TipoSubParte__catalogo_parte_secundiaria
    {
        LIVIANOS = 1,
        PESADOS = 2,
        MIXTO = 3
    }

    public partial class catalogo_parte_secundaria
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public Nullable<int> catalogo_parte_principal_id { get; set; }
        public Nullable<int> estado { get; set; }
        public Nullable<int> tipo_sub_parte { get; set; }
    
        public virtual catalogo_parte_principal catalogo_parte_principal { get; set; }
    }
}
