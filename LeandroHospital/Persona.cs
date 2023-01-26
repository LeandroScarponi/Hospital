using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeandroHospital
{
    public class Persona
    {
        private string _Nombre;
        private string _Apellido;

        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }

        public Persona(string pNombre, string pApellido)
        {
            Nombre = pNombre;
            Apellido = pApellido;
        }

        public override string ToString()
        {
            return Apellido +" "+Nombre;
        }

    }
}
