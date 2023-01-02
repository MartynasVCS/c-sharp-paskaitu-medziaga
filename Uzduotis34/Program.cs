using System;

namespace Uzduotis34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Įvesti du skaičius iš konsolės
             * 
             * Paklausti vartotojo kokį veiksmą 
             * su tais skaičiais nori atlikti: 
             *      Daugybą ar dalybą
             * 
             * Parašyti po atskirą metodą kiekvienam veiksmui
             *      daugybai naudoti int tipą
             *      dalybai - double
             * 
             * Su if patikrinti kokį veiksmą atlikti 
             * ir išsikviesti atitinkamą metodą, 
             * jei tokio veiksmo nėra – informuoti vartotoją, 
             * jog tokio veiksmo nėra.
             */

            Console.Write("Įveskite pirmą skaičių: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Įveskite antrą skaičių: ");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kokį veiksmą norite atlikti su skaičiais? (daugyba, dalyba): ");
            string veiksmas = Console.ReadLine();

            if (veiksmas == "daugyba")
            {
                int sandauga = Daugyba(skaicius1, skaicius2);
                Console.WriteLine($"{skaicius1} * {skaicius2} = {sandauga}");
            }
            else if (veiksmas == "dalyba")
            {
                double dalmuo = Dalyba(skaicius1, skaicius2);
                Console.WriteLine($"{skaicius1} / {skaicius2} = {dalmuo}");
            }
            else Console.WriteLine($"Įvedėte negalimą pasirinkimą ({veiksmas}), darbas baigiamas");
        }

        private static double Dalyba(int skaicius1, int skaicius2)
        {
            return (double)skaicius1 / skaicius2;
        }

        private static int Daugyba(int skaicius1, int skaicius2)
        {
            return skaicius1 * skaicius2;
        }
    }
}
