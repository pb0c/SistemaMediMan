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
        public string Nombre { get; set; }

    }
}