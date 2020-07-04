using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using SistemaMediMan.Models;

namespace SistemaMediMan.Models.ViewModels
{
	public class ListEmpleadoViewModel
	{

		public int Id { get; set; }
		[Display(Name = "Rut")]
		[Required]
		public string Rut { get; set; }
		[Display(Name = "Nombre")]
		[Required]
		public string Nombre { get; set; }
		[DisplayName("Apellido")]
		[Required]
		public string ApellidoP { get; set; }
		[Display(Name = "Apellido")]
		[Required]
		public string ApellidoM { get; set; }
		[Display(Name = "Teléfono")]
		[Required]
		public string Telefono { get; set; }
		[Display(Name = "Rol")]
		[Required]
		public string Rol { get; set; }
		[Display(Name = "Usuario")]
		[Required]
		public string User { get; set; }
		[Display(Name = "Contraseña")]
		[Required]
		public string Pass { get; set; }
	}
}