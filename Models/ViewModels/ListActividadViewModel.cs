using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlTypes;
using System.Web;
using SistemaMediMan.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SistemaMediMan.Models.ViewModels
{
    public class ListActividadViewModel
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Deporte")]
        [RegularExpression("[a-zA-ZñÑáéíóúÁÉÍÓÚ]+", ErrorMessage = "Este campo solo admite letras")]
        public string Nombre { get; set; }

    }
}