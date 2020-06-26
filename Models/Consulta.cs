using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mediMan.Models
{
    public class Consulta
    {
        private int _id;
        private DateTime _hora;
        private DateTime _fecha;
        private int _box;
        private int _sesion;
        private Paciente _paciente;
        private Empleado _empleado;

        private int Id { get; set; }
        private DateTime Hora { get; set; }
        private DateTime Fecha { get; set; }
        private int Box { get; set; }
        private int Sesion { get; set; }
        private Paciente Paciente_id { get; set; }
        private Empleado Empleado_id { get; set; }

        private Consulta()
        {
            this.Init();
        }
        private void Init()
        {
            Hora = new DateTime(1900,1,1,00,00,00);
            Fecha= new DateTime(1900, 1, 1);
            Box = 0;
            Sesion = 0;
            Paciente_id = Paciente_id;
            Empleado_id = Empleado_id;

        }

        public Consulta(int id, DateTime hora, DateTime fecha, int box, int sesion, Paciente paciente, Empleado empleado)
        {
            this._id = id;
            this._hora = hora;
            this._fecha = fecha;
            this._box = box;
            this._sesion = sesion;
            this._paciente = paciente;
            this._empleado = empleado;
        }


    }
}