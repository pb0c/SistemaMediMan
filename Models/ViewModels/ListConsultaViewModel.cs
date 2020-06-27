using SistemaMediMan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaMediMan.Models.ViewModels
{
    public class ListConsultaViewModel
    {
        public int Id { get; set; }
        public DateTime Hora { get; set; }
        public DateTime Fecha { get; set; }
        public int Box { get; set; }
        public int Sesion { get; set; }
        public Paciente Paciente_id { get; set; }
        public Empleado Empleado_id { get; set; }
    }
}