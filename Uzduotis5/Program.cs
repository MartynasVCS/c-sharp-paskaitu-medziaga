using System;

namespace Uzduotis5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Išveskite į ekraną dviejų skaičių 
             * sumą, skirtumą, sandaugą ir dalmenį,
             * kiekvieną kartą nurodant atliekamą veiksmą 
             * ir šių skaičių reikšmes. 
             * Pvz.: 
             * 4 + 5 = 9
             * 4 - 5 = -1
             * …
             */

            int pirmas = 4;
            int antras = 9;
            int suma = pirmas + antras;
            int skirtumas = pirmas - antras;
            int sandauga = pirmas * antras;
            double dalyba = (double)pirmas / antras;

            Console.WriteLine("Veiksmai su skaiciais '{0}' ir '{1}':", pirmas, antras);
            Console.WriteLine("Suma: {0} + {1} = {2}", pirmas, antras, suma);
            Console.WriteLine("Skirtumas: {0} - {1} = {2}", pirmas, antras, skirtumas);
            Console.WriteLine("Sandauga: {0} * {1} = {2}", pirmas, antras, sandauga);
            Console.WriteLine("Dalyba: {0} / {1} = {2}", pirmas, antras, dalyba);
            Console.WriteLine();

            /*
             * Išveskite į ekraną pasirinktą skaičių, 
             * jo kvadratą ir jį pakeltą trečiuoju laipsniu.
             */

            int skaicius = 5;
            Console.WriteLine("Veiksmai su skaiciumi '{0}':", skaicius);

            // Kelimas kvadratu
            Console.WriteLine("Skaicius kvadratu: {0}^2 = {1}", skaicius, skaicius * skaicius);
            //Console.WriteLine(Math.Pow(skaicius, 2));

            // Kelimas kubu
            Console.WriteLine("Skaicius kvadratu: {0}^3 = {1}", skaicius, skaicius * skaicius * skaicius);
            //Console.WriteLine(Math.Pow(skaicius, 3));
            Console.WriteLine();

            /*
             * Išveskite į ekraną trijų skaičių sandaugą.
             */

            int skaicius1 = 5;
            int skaicius2 = 6;
            int skaicius3 = 7;

            Console.WriteLine("Skaiciu '{0}', '{1}' ir '{2}' sandauga:", skaicius1, skaicius2, skaicius3);
            Console.WriteLine("{0} * {1} * {2} = {3}", skaicius1, skaicius2, skaicius3, skaicius1 * skaicius2 * skaicius3);
            Console.WriteLine();
        }
    }
}
