using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaMediMan.Models
{
    public class Deporte
    {
        private int _id;
        private string _nombre;

        private string Nombre { get; set; }

        public Deporte()
        {
            this.Init();
        }

        private void Init()
        {
            Nombre = string.Empty;
        }
    }
}