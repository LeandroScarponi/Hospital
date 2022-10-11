using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeandroHospital
{
    public class Paciente : Persona
    {
        private int _HistoriaClinica;
        public int HistoriaClinica { get => _HistoriaClinica; set => _HistoriaClinica = value; }
        public Paciente (string pNombre, string pApellido, int pHistoriaClinica) : base(pNombre, pApellido)
        {
            HistoriaClinica = pHistoriaClinica;
        }

        public override string ToString()
        {
            return "Paciente: "+ base.ToString() + " - Historia Clinica "+HistoriaClinica;
        }

    }
}
