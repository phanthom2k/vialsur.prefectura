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

  

    public partial class detalle_pedidos_aceite
    {
        public int id { get; set; }
        public int pedidos_aceite_id { get; set; }
        public int cantidad { get; set; }
        public string detalle { get; set; }        
            
        public virtual pedidos_aceite pedidos_aceite { get; set; }
    }
}
