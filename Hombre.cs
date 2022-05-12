using System;
using System.Collections.Generic;
using System.Text;

namespace Solid
{
    class Hombre :Persona, ISerVivo
    {
       
       
        public Hombre(string n, int e)
        {
            this.Nombre = n;
            this.Edad = e;

        }


    
    }


}
