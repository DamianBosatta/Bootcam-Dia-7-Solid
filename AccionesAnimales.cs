using System;
using System.Collections.Generic;
using System.Text;

namespace Solid
{
    class AccionesAnimales : INada, ICorre
    {
        public void Corre()
        {
            Console.WriteLine(" El animal Corre ");

        }

        public void Nada()
        {
            Console.WriteLine(" El Animal Esta nadando ");
        }
    }
}
