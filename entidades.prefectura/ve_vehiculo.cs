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
    
    public partial class ve_vehiculo
    {
        public int id { get; set; }
        public int ve_vehiculo_marca_id { get; set; }
        //public string ve_vehiculo_marca { get; set; }
        public int ve_vehiculo_modelo_id { get; set; }        
        public int ve_vehiculo_color_id { get; set; }        
        public Nullable<int> anio_fabricacion { get; set; }
        public int anio_compra { get; set; }
        public string cilindraje { get; set; }
        public string codigo { get; set; }
        public string codigo_anterior { get; set; }
        public string color { get; set; }
        public Nullable<decimal> costo { get; set; }
        public Nullable<bool> estado { get; set; }
        public string PaisCodigo { get; set; }
        public string placa { get; set; }
        public string placa_provisional { get; set; }
        public string serie_chasis { get; set; }
        public string serie_motor { get; set; }
    
        public virtual ve_vehiculo_color ve_vehiculo_color { get; set; }
        public virtual ve_vehiculo_modelo ve_vehiculo_modelo { get; set; }
    }
}
