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
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Clase Actividad. Contiene todos los atributos que corresponden a la clase actividad
    /// También se incluyen sus llaves foráneas.
    /// </summary>

    public partial class ACTIVIDADES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACTIVIDADES()
        {
            this.PACIENTES = new HashSet<PACIENTES>();
        }
    
        public int ID { get; set; }
        [Required]
        [DisplayName("Actividad")]
        [RegularExpression("[a-zA-ZñÑáéíóúÁÉÍÓÚ]+", ErrorMessage = "Este campo solo admite letras")]
        public string ACTIVIDAD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PACIENTES> PACIENTES { get; set; }
    }
}
