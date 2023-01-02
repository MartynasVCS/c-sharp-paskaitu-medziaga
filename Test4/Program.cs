using System;

namespace Test4
{
    public class Program
    {
        static public void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string vardas = "Petras";
            Pasisveikinimas();
            Pasisveikinimas(vardas, 18);
            Pasisveikinimas("Saulius", 20);
            AtsisveikinimasSuVardu("Saulius");

            Console.Write("Įveskite savo amžių: ");
            int amzius = Convert.ToInt32(Console.ReadLine());
            if (ArPilnametis(amzius)) Console.WriteLine("Esi pilnametis!!!");
            else Console.WriteLine("Tau dar nėra 18 metų :(");

            Console.WriteLine(KvadratineSaknis(5));
            Console.WriteLine(KvadratineSaknis(8));
            Console.WriteLine(KvadratineSaknis(25));
            Console.WriteLine(KvadratineSaknis(115));
            Console.WriteLine(KvadratineSaknis(7));
            Console.WriteLine(KvadratineSaknis(2));

            int pazymys = SkaiciausIvedimasVartotojui("Įvesk pažymį");
            Atspausdink("Tavo įvestas pažymys", pazymys.ToString());

            int temperatura = SkaiciausIvedimasVartotojui("Įvesk temperatūrą");
            Atspausdink("Temperatūra kurią tu pats ką tik įvedei", temperatura.ToString());
        }

        static public int SkaiciausIvedimasVartotojui(string zinute)
        {
            Console.Write($"{zinute}: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static public void Atspausdink(string zinute, string reiksme)
        {
            Console.WriteLine($"{zinute}: {reiksme}");
        }

        static public double KvadratineSaknis(int skaicius)
        {
            return Math.Sqrt(skaicius);
        }

        static public bool ArPilnametis(int amzius)
        {
            if (amzius >= 18) return true;
            else return false;
        }

        static public void Pasisveikinimas(string vardas, int amzius)
        {
            Console.WriteLine($"Labas, {vardas}, kuriam yra {amzius} metų");
        }

        static public void Pasisveikinimas()
        {
            Console.WriteLine($"Labas!");
        }

        static public void AtsisveikinimasSuVardu(string vardas)
        {
            Console.WriteLine($"Ate, {vardas}");
        }
    }
}
