using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeandroHospital
{
    public class Medico : Persona
    {

        private int _Matricula;
        public int Matricula { get => _Matricula; set => _Matricula = value; }


        public Medico(string pNombre, string pApellido, int pMatricula) : base(pNombre, pApellido)
        {
            Matricula = pMatricula;
        }

        public override string ToString()
        {
            return "Médico: "+base.ToString()+" - Matricula: "+Matricula;
            
        }
    }
}
