using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mediMan.Models
{
    public class Ficha
    {
        private int _id;
        private string _medico;
        private string _tratamiento;
        private string _diagnostico;
        private string _medicamento;
        private string _antMorbido;
        private Paciente _paciente;

        private int Id { get; set; }
        private string Medico { get; set; }
        private string Tratamiento { get; set; }
        private string Diagnostico { get; set; }
        private string Medicamento { get; set; }
        private string AntMorbido { get; set; }
        private Paciente Paciente_id { get; set; }
        public Ficha()
        {
            this.Init();
        }

        private void Init()
        {
            Medico = string.Empty;
            Tratamiento = string.Empty;
            Diagnostico = string.Empty;
            Medicamento = string.Empty;
            AntMorbido = string.Empty;
            Paciente_id = Paciente_id;

        }

        public Ficha(string medico, string tratamiento, string diagnostico, string medicamento, string antMorbido, Paciente paciente)
        {
            this._medico = medico;
            this._tratamiento = tratamiento;
            this._diagnostico = diagnostico;
            this._medicamento = medicamento;
            this._antMorbido = antMorbido;
            this._paciente = paciente;
        }

    }
}