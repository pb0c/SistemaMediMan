using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaMediMan.Models.ViewModels
{
    public class ListEmpleadoViewModel
    {
		private int Id { get; set; }
		private string Rut { get; set; }
		private string Nombre { get; set; }
		private string ApellidoP { get; set; }
		private string ApellidoM { get; set; }
		private string Telefono { get; set; }
		private string Rol { get; set; }
		private string User { get; set; }
		private string Pass { get; set; }
	}
}