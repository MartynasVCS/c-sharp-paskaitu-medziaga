using System;

namespace Klases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zmogus zmogus1 = new Zmogus();
            zmogus1.vardas = "Petras";
            Zmogus zmogus2 = new Zmogus();
            zmogus2.vardas = "Antanas";

            Zmogus zmogus3 = new Zmogus("Saulius");
            Zmogus zmogus4 = new Zmogus("Ignas", "Ignatavičius");

            Console.WriteLine(zmogus2.pavarde);
            Console.WriteLine(zmogus3.pavarde);
            Console.WriteLine(zmogus4.pavarde);
        }
    }

    internal class Zmogus
    {
        public string vardas { get; set; }
        public string pavarde { get; set; }

        public Zmogus(string vardas, string pavarde)
        {
            this.vardas = vardas;
            this.pavarde = pavarde;
        }

        public Zmogus(string vardas)
        {
            this.vardas = vardas;
        }

        public Zmogus()
        {

        }
    }
}
