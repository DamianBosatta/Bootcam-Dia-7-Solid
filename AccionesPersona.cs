using System;
using System.Collections.Generic;
using System.Text;

namespace Solid
{
    class AccionesPersona : INada,ICorre
    {



        public void EstaNadando()
        {
            Console.WriteLine(" Esta nadando");

        }
        public void Corre()
        {
            Console.WriteLine("Esta corriendo");

        }
    }
}