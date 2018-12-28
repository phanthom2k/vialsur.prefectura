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

    /// <summary>
    /// Representa el estado de la orden de pedido de pieza
    /// </summary>
    public enum Orden_TipoEstadoPedido
    {        
        CREADO = 0,
        AUTORIZADO = 1     
    }

    public partial class pedidos
    {
        public int id { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string cedula { get; set; }
        public string observaciones { get; set; }
        public string orden_id { get; set; }
        public bool aprobada { get; set; }

        public virtual ICollection<detalle_pedidos> detalle_pedidos { get; set; }

    }
}
