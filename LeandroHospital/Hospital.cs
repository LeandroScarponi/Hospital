using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeandroHospital
{
    public class Hospital
    {

        public List<Persona> ListaGeneralPersonas = new List<Persona>();


        public Hospital()
        {

            Medico medico1 = new Medico("Carlos", "Perez", 1234);
            Medico medico2 = new Medico("Juan", "Sanchez", 2345);
            Medico medico3 = new Medico("Pedro", "Ansio", 4231);
            Paciente paciente1 = new Paciente("Lionel", "Messi", 4235672);
            Paciente paciente2 = new Paciente("Luis", "Suarez", 4231252);

            ListaGeneralPersonas.Add(medico1);
            ListaGeneralPersonas.Add(medico2);
            ListaGeneralPersonas.Add(medico3);
            ListaGeneralPersonas.Add(paciente1);
            ListaGeneralPersonas.Add(paciente2);

        }
    }
}
