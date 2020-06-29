using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaMediMan.Models
{
    public class Actividad
    {
        private int _id;
        private string _nombre;

        private int Id { get; set; }
        private string Nombre { get; set; }

        public Actividad()
        {
            this.Init();
        }

        private void Init()
        {
            Id = 0;
            Nombre = string.Empty;
        }
    }

    
}