using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mediMan.Models
{
    public class Paciente
    {
		private int _id;
		private string _rut;
		private string _nombre;
		private string _apellidoP;
		private string _apellidoM;
		private DateTime _fdenac;
		private int _edad;
		private string _telefono;
		private string _prevision;
		private string _calle;
		private int _numCalle;
		private string _comuna;
		private Actividad _actividad;
		private Deporte _deporte;

		private int Id { get; set; }
		private string Rut { get; set; }
		private string Nombre { get; set; }
		private string ApellidoP { get; set; }
		private string ApellidoM { get; set; }
		private DateTime Fdenac { get; set; }
		private int Edad { get; set; }
		private string Telefono { get; set; }
		private string Prevision { get; set; }
		private string Calle { get; set; }
		private int Num { get; set; }
		private string Comuna { get; set; }
		private Actividad Act_id { get; set; }
		private Deporte Dep_id { get; set; }

		public Paciente()
		{
			this.Init();
		}

		private void Init()
		{
			Rut = string.Empty;
			Nombre = string.Empty;
			ApellidoP = string.Empty;
			ApellidoM = string.Empty;
			Fdenac = new DateTime(1900, 1, 1);
			Telefono = string.Empty;
			Prevision = string.Empty;
			Calle = string.Empty;
			Num = 0;
			Act_id = Act_id;
			Dep_id = Dep_id;
		}

		public Paciente(int id, string rut, string nombre, string apellidoP, string apellidoM, DateTime fdenac, string telefono, string prevision, string calle, int numCalle, string comuna, Actividad actividad, Deporte deporte)
        {
			this._id = id;
			this._rut = rut;
			this._nombre = nombre;
			this._apellidoP = apellidoP;
			this._apellidoM = apellidoM;
			this._fdenac = fdenac;
			this._telefono = telefono;
			this._prevision = prevision;
			this._calle = calle;
			this._numCalle = numCalle;
			this._comuna = comuna;
			this._actividad = actividad;
			this._deporte = deporte;
        }
	}
}