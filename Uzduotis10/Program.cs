using System;

namespace Uzduotis10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Liepkite įvesti skaičių.
             * Jei skaičius lyginis, 
             *      tuomet išveskite šį skaičių bei jo penktą laipsnį.
             * Jei skaičius nesidalina iš 4, 
             *      tuomet liepkite įvesti antrąjį skaičių. 
             *      Išveskite abiejų skaičių sumą ir sandaugą.
             */

            Console.WriteLine("Įveskite pirmą sveikąjį skaičių:");
            string ivedimas = Console.ReadLine();
            int skaicius1 = Convert.ToInt32(ivedimas);

            if (skaicius1 % 2 == 0 )
            {
                Console.WriteLine("Skaičius: '{0}'. Pakeltas penktuoju laipsniu: '{1}'", skaicius1, Math.Pow(skaicius1, 5));
            }

            if (skaicius1 % 4 != 0 )
            {
                Console.WriteLine("Įveskite antrą sveikąjį skaičių:");
                ivedimas = Console.ReadLine();
                int skaicius2 = Convert.ToInt32(ivedimas);

                Console.WriteLine("Įvesti skaičiai: '{0}' ir '{1}'", skaicius1, skaicius2);
                Console.WriteLine("Skaičių suma: '{0}', sandauga: '{1}'", skaicius1 + skaicius2, skaicius1 * skaicius2);
            }
        }
    }
}
