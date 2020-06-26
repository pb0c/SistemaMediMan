using mediMan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaMediMan.Models.ViewModels
{
    public class ListConsultaViewModel
    {
        private int Id { get; set; }
        private DateTime Hora { get; set; }
        private DateTime Fecha { get; set; }
        private int Box { get; set; }
        private int Sesion { get; set; }
        private Paciente Paciente_id { get; set; }
        private Empleado Empleado_id { get; set; }
    }
}