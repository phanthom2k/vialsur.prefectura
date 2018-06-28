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
    
    public partial class per_persona
    {
        /// <summary>
        /// Retorna los apellidos y nombres completos
        /// </summary>
        public string GetFullName
        {
            get
            {
                string r = string.Empty;
                if (string.IsNullOrEmpty(apellidos) | string.IsNullOrEmpty(nombres))
                    r = "---";
                else
                    r=  apellidos + ", " + nombres;
                return r;
            }
        }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public per_persona()
        {
            this.emp_empleado = new HashSet<emp_empleado>();
        }
    
        public string cedula { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public Nullable<System.DateTime> fecha_nacimiento { get; set; }
    
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<emp_empleado> emp_empleado { get; set; }

        /// <summary>
        /// Retorna una cadena con los apellidos y nombres de la persona
        /// </summary>
        public string ApellidosNombres
        {
            get
            {
                return apellidos + " " + nombres;
            }
        }
    }
}
