using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaMediMan.Models
{
    public class ConsultCE
    {
        [Required]
        [DisplayName("Empleado")]
        public int EMP_ID { get; set; }
        [Required]
        [DisplayName("Paciente")]
        public int PAC_ID { get; set; }
        [Required]
        [DisplayName("Hora")]
        [DataType(DataType.Time)]
        public TimeSpan HORA { get; set; }
        [Required]
        [DisplayName("Fecha")]
        [DataType(DataType.Date)]
        public DateTime FECHA { get; set; }
        [Required]
        [DisplayName("Box")]
        public int BOX { get; set; }
        [Required]
        [DisplayName("Sesion")]
        public int SESION { get; set; }
    }

    [MetadataType(typeof(ConsultCE))]

    public partial class CONSULTAS
    {
    }
}