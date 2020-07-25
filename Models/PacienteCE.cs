using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace SistemaMediMan.Models
{
    public class PacienteCE
    {
		[Required]
		[Display(Name = "Rut")]
		public string RUT { get; set; }
		[Required]
		[Display(Name = "Nombre")]
		[RegularExpression("^[a-zA-z]+$", ErrorMessage = "Solo debe contener letras")]
		public string NOMBRE { get; set; }
		[Required]
		[Display(Name = "ApellidoPaterno")]
		[RegularExpression("^[a-zA-z]+$", ErrorMessage = "Solo debe contener letras")]
		public string APELLIDOP { get; set; }

		[Display(Name = "ApellidoMaterno")]
		[RegularExpression("^[a-zA-z]+$", ErrorMessage = "Solo debe contener letras")]
		public string APELLIDOM { get; set; }
		[Required]
		[DataType(DataType.Date)]
		[Display(Name = "FechadeNacimiento")]
		public DateTime FDENAC { get; set; }
		[Required]
		[Display(Name = "Edad")]
		public int EDAD { get; set; }
		[Required]
		[Display(Name = "Sexo")]
		public bool SEXO { get; set; }
		[Required]
		[Display(Name = "Telefono")]
		[DataType(DataType.PhoneNumber)]
		public string TELEFONOP { get; set; }
		[Required]
		[Display(Name = "Previsión")]
		public string PREVISION { get; set; }
		[Required]
		[Display(Name = "NombreCalle")]
		public string CALLE { get; set; }
		[Required]
		[Display(Name = "NúmeroCalle")]
		public int NUMCALLE { get; set; }
		public string DPTO { get; set; }
		[Required]
		[Display(Name = "Comuna")]
		public string COMUNA { get; set; }
		[Display(Name = "Actividad")]
		public int ACT_ID { get; set; }
		[Display(Name = "Deporte")]
		public int DEP_ID { get; set; }
	}
	
	[MetadataType(typeof(PacienteCE))]

    public partial class PACIENTES
    {
        public string nombreCompleto { get { return NOMBRE + " " + APELLIDOP + " " + APELLIDOM; } }
    }
}