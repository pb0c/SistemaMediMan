using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
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
		[Display(Name ="Apellido Paterno")]
		[RegularExpression("^[a-zA-z]+$", ErrorMessage = "Solo debe contener letras")]
		public string ApellidoP { get; set; }
		
		[Display(Name = "Apellido Materno")]
		[RegularExpression("^[a-zA-z]+$", ErrorMessage = "Solo debe contener letras")]
		public string ApellidoM { get; set; }
		[Required]
		[DataType(DataType.Date)]
		[Display(Name = "Fecha de Nacimiento")]
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
		//[RegularExpression(@"^\(? ([0 - 9]{1})\)?[-. ]? ([0 - 9]{8})$",ErrorMessage ="Número de teléfono no válido")]
		public string Telefono { get; set; }
		[Required]
		[Display(Name = "Previsión")]
		public string Prevision { get; set; }
		[Required]
		[Display(Name = "Nombre Calle")]
		public string Calle { get; set; }
		[Required]
		[Display(Name = "Número Calle")]
		public int Numero { get; set; }
		public string Dpto { get; set; }
		[Required]
		[Display(Name = "Communa")]
		public string Comuna { get; set; }
		[Display(Name = "Actividad")]
		public Actividad Act { get; set; }
		[Display(Name = "Deporte")]
		public Deporte Dep { get; set; }
	}
}