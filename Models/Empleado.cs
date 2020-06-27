using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaMediMan.Models
{
    public class Empleado
    {
		private int _id;
		private string _rut;
		private string _nombre;
		private string _apellidoP;
		private string _apellidoM;
		private string _telefono;
		private string _rol;
		private string _user;
		private string _password;

		private string Rut { get; set; }
		private string Nombre { get; set; }
		private string ApellidoP { get; set; }
		private string ApellidoM { get; set; }
		private string Telefono { get; set; }
		private string Rol { get; set; }
		private string User { get; set; }
		private string Pass { get; set; }
		public Empleado()
        {
			this.Init();
        }

		public void Init()
        {
			Rut = string.Empty;
			Nombre = string.Empty;
			ApellidoP = string.Empty;
			ApellidoM = string.Empty;
			Telefono = string.Empty;
			Rol = string.Empty;
			User = string.Empty;
			Pass = string.Empty;
        }

		public Empleado(int id, string rut, string nombre, string apellidoP, string apellidoM, string telefono, string rol, string user, string password)
        {
			this._id = id;
			this._rut = rut;
			this._nombre = nombre;
			this._apellidoP = apellidoP;
			this._apellidoM = apellidoM;
			this._telefono = telefono;
			this._rol = rol;
			this._user = user;
			this._password = password;
        }

		
	}
}