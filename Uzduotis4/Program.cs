using System;

namespace Uzduotis4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Susikurkite reikiamus kintamuosius užduočiai atlikti. 
             * Į ekraną išveskite: 
             * Automobilio {markė} {modelis} ({metai} m.) rida - {rida} km.
             * Tarp {} nurodyti reikiami kintamieji, 
             * šiose vietose jų reikšmės turi būti įstatytos.
             */

            string marke = "Toyota";
            string modelis = "Corolla";
            int metai = 1997;
            int rida = 449567;

            Console.Write("Automobilio {0} {1} ", marke, modelis);
            Console.Write("({0} m.) rida - ", metai);
            Console.WriteLine("{0} km.", rida);
        }
    }
}
