using mediMan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaMediMan.Models.ViewModels
{
    public class ListFichaViewModel
    {
        private int Id { get; set; }
        private string Medico { get; set; }
        private string Tratamiento { get; set; }
        private string Diagnostico { get; set; }
        private string Medicamento { get; set; }
        private string AntMorbido { get; set; }
        private Paciente Paciente_id { get; set; }
    }
}