using System;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {

            Hombre Damian = new Hombre("Damian",34);

            Damian.Corre();
            Damian.EstaNadando();

            Leon Zimba = new Leon(" Zimba");

            Zimba.Corre();

            Delfin Flipper = new Delfin("flipper");

            Flipper.Nada();
        }
    }
}
