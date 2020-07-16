using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using SistemaMediMan.Models;

namespace SistemaMediMan.Models.ViewModels
{
    public class ListPacienteViewModel
    {
		public int Id { get; set; }
		[Required]
		[Display(Name = "Rut")]
		public string Rut { get; set; }
		[Required]
		[Display(Name = "Nombre")]
		[RegularExpression("^[a-zA-z]+$",ErrorMessage ="Solo debe contener letras")]
		public string Nombre { get; set; }
		[Required]
		[Display(Name ="ApellidoPaterno")]
		[RegularExpression("^[a-zA-z]+$", ErrorMessage = "Solo debe contener letras")]
		public string ApellidoP { get; set; }
		
		[Display(Name = "ApellidoMaterno")]
		[RegularExpression("^[a-zA-z]+$", ErrorMessage = "Solo debe contener letras")]
		public string ApellidoM { get; set; }
		[Required]
		[DataType(DataType.Date)]
		[Display(Name = "FechadeNacimiento")]
		public DateTime Fdenac { get; set; }
		[Required]
		[Display(Name = "Edad")]
		public int Edad { get; set; }
		[Required]
		[Display(Name = "Sexo")]
		public bool Sexo { get; set; }
		[Required]
		[Display(Name = "Telefono")]
		[DataType(DataType.PhoneNumber)]
		public string Telefono { get; set; }
		[Required]
		[Display(Name = "Previsión")]
		public string Prevision { get; set; }
		[Required]
		[Display(Name = "NombreCalle")]
		public string Calle { get; set; }
		[Required]
		[Display(Name = "NúmeroCalle")]
		public int Numero { get; set; }
		public string Dpto { get; set; }
		[Required]
		[Display(Name = "Communa")]
		public string Comuna { get; set; }
		[Display(Name = "Actividad")]
		public int Actividad_id { get; set; }
		[Display(Name = "Deporte")]
		public int Deporte_id { get; set; }
	}

}