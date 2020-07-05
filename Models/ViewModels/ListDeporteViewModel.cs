using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using SistemaMediMan.Models;

namespace SistemaMediMan.Models.ViewModels
{
    public class ListDeporteViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Deporte")]
        [RegularExpression("[a-zA-ZñÑáéíóúÁÉÍÓÚ]+", ErrorMessage = "Este campo solo admite letras")]
        public string Nombre { get; set; }

    }
}