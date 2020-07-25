using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaMediMan.Models
{
    public class EmpleadoCE
    {
        public string RUT { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDOP { get; set; }
        public string APELLIDOM { get; set; }
        public string ROL { get; set; }
        public string TELEFONO { get; set; }
        public string PASS { get; set; }
        public string USER { get; set; }
    }

    [MetadataType(typeof(EmpleadoCE))]

    public partial class EMPLEADOS
    {
        public string nombreCompleto { get { return NOMBRE + " " + APELLIDOP + " " + APELLIDOM; } }
    }
}