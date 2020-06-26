using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using mediMan.Models;

namespace SistemaMediMan.Models.ViewModels
{
    public class ListPacienteViewModel
    {
		public int Id { get; set; }
		public string Rut { get; set; }
		public string Nombre { get; set; }
		public string ApellidoP { get; set; }
		public string ApellidoM { get; set; }
		public DateTime Fdenac { get; set; }
		public int Edad { get; set; }
		public bool Sexo { get; set; }
		public string Telefono { get; set; }
		public string Prevision { get; set; }
		public string Calle { get; set; }
		public int Numero { get; set; }
		public string Dpto { get; set; }
		public string Comuna { get; set; }
		public Actividad Act { get; set; }
		public Deporte Dep { get; set; }
	}
}