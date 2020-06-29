using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlTypes;
using System.Web;
using SistemaMediMan.Models;
using System.ComponentModel.DataAnnotations;

namespace SistemaMediMan.Models.ViewModels
{
    public class ListActividadViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }

    }
}