using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SistemaMediMan.Models;

namespace SistemaMediMan.Models.ViewModels
{
    public class ListEmpleadoViewModel
    {
		public int Id { get; set; }
		public string Rut { get; set; }
		public string Nombre { get; set; }
		public string ApellidoP { get; set; }
		public string ApellidoM { get; set; }
		public string Telefono { get; set; }
		public string Rol { get; set; }
		public string User { get; set; }
		public string Pass { get; set; }
	}
}