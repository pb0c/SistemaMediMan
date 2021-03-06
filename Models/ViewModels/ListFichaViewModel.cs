﻿using SistemaMediMan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaMediMan.Models.ViewModels
{
    public class ListFichaViewModel
    {
        public int Id { get; set; }
        public string Medico { get; set; }
        public string Tratamiento { get; set; }
        public string Diagnostico { get; set; }
        public string Medicamento { get; set; }
        public string AntMorbido { get; set; }
        public int Paciente_id { get; set; }
    }
}