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

    public enum Orde_Detalle_ACCION
    {
        NO_DEFINIDO = 0,
        CAMBIO = 1,
        LIMPIEZA = 2,
        REVISION = 3,
        OTRO = 4
    }



    public partial class orde_detalle
    {
        public string id { get; set; }
        public Nullable<int> catalogo_parte_principal_id { get; set; }
        public Nullable<int> catalogo_parte_secundaria_id { get; set; }
        public Nullable<int> accion_realizada { get; set; }
        public Nullable<decimal> cantidad { get; set; }
        public string observacion { get; set; }
        public Nullable<bool> estado { get; set; }
        public Nullable<int> accion_requerida { get; set; }
        public string orden_id { get; set; }
    
        public virtual orden orden { get; set; }
    }
}
