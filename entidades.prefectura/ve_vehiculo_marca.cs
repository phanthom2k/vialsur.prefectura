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
    
    public partial class ve_vehiculo_marca
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ve_vehiculo_marca()
        {
            this.ve_vehiculo_modelo = new HashSet<ve_vehiculo_modelo>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public string obserbacion { get; set; }
        public Nullable<bool> activo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ve_vehiculo_modelo> ve_vehiculo_modelo { get; set; }
    }
}