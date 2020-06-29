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
        public DateTime FechaHora { get; set; }
        public int Box { get; set; }
        public int Sesion { get; set; }
        public int Paciente_id { get; set; }
        public int Empleado_id { get; set; }
    }
}