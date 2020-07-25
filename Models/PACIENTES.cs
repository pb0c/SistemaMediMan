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
    
    public partial class PACIENTES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PACIENTES()
        {
            this.CONSULTAS = new HashSet<CONSULTAS>();
            this.FICHAS = new HashSet<FICHAS>();
        }
    
        public int ID { get; set; }
        public int DEP_ID { get; set; }
        public int ACT_ID { get; set; }
        public string RUT { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDOP { get; set; }
        public string APELLIDOM { get; set; }
        public System.DateTime FDENAC { get; set; }
        public int EDAD { get; set; }
        public bool SEXO { get; set; }
        public string TELEFONOP { get; set; }
        public string PREVISION { get; set; }
        public string CALLE { get; set; }
        public int NUMCALLE { get; set; }
        public string DPTO { get; set; }
        public string COMUNA { get; set; }
    
        public virtual ACTIVIDADES ACTIVIDADES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONSULTAS> CONSULTAS { get; set; }
        public virtual DEPORTES DEPORTES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FICHAS> FICHAS { get; set; }
    }
}
