//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaMediMan.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EMPLEADOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMPLEADOS()
        {
            this.CONSULTAS = new HashSet<CONSULTAS>();
        }
    
        public int ID { get; set; }
        public string RUT { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDOP { get; set; }
        public string APELLIDOM { get; set; }
        public string ROL { get; set; }
        public string TELEFONO { get; set; }
        public string PASS { get; set; }
        public string USER { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONSULTAS> CONSULTAS { get; set; }
    }
}
