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
    
    public partial class FICHAS
    {
        public int ID { get; set; }
        public int PAC_ID { get; set; }
        public string MEDICO { get; set; }
        public string TRATAMIENTO { get; set; }
        public string MEDICAMENTO { get; set; }
        public string DIAGNOSTICO { get; set; }
        public string ANTMORBIDO { get; set; }
    
        public virtual PACIENTES PACIENTES { get; set; }
    }
}
