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

  

    public partial class fondo_detalle_pedido
    {
        public int id { get; set; }
        public int fondo_pedido_id { get; set; }
        public int cantidad { get; set; }
        public string detalle { get; set; }        
            
        public virtual fondo_pedido fondo_pedido { get; set; }
    }
}
