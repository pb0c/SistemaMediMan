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
    
    public partial class CONSULTAS
    {
        public int ID { get; set; }
        public int EMP_ID { get; set; }
        public int PAC_ID { get; set; }
        public System.TimeSpan HORA { get; set; }
        public System.DateTime FECHA { get; set; }
        public int BOX { get; set; }
        public int SESION { get; set; }
    
        public virtual EMPLEADOS EMPLEADOS { get; set; }
        public virtual PACIENTES PACIENTES { get; set; }
    }
}
