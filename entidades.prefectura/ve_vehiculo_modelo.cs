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
    
    public enum TipoCombustible
    {
        NO_DEFINIDO = 0,
        GASOLINA =1,
        DIESEL = 2
    }
    /// <summary>
    /// Define LIVIANO, PESADO Y NO_DEFINIDO
    /// </summary>
    public enum ClaseVehiculo
    {
        NO_DEFINIDO = 0,
        LIVIANO = 1,
        PESADO = 2
        //,NO_DEFINIDO = 3
    }

    public partial class ve_vehiculo_modelo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ve_vehiculo_modelo()
        {
            this.ve_vehiculo = new HashSet<ve_vehiculo>();
        }
    
        public int id { get; set; }
        public string modelo { get; set; }
        public string observacion { get; set; }
        public Nullable<int> ve_vehiculo_marca_id { get; set; }
        public Nullable<int> tipo_combustible { get; set; }
        public Nullable<bool> traccion { get; set; }
        public byte[] imagen { get; set; }
        public Nullable<int> tipo_motor { get; set; }
        public Nullable<int> ve_vehiculo_tipo_id { get; set; }
        public Nullable<int> clase_vehiculo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ve_vehiculo> ve_vehiculo { get; set; }
        public virtual ve_vehiculo_marca ve_vehiculo_marca { get; set; }
        public virtual ve_vehiculo_tipo ve_vehiculo_tipo { get; set; }
    }
}
