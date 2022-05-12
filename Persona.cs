using System;
using System.Collections.Generic;
using System.Text;

namespace Solid
{
    class Persona:AccionesPersona,ISerVivo
    {
        string nombre;
        int edad;
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }

    }
}
