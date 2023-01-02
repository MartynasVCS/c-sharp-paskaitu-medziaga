using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 23;
            //int b = 10;

            //int c = 10 / 15;
            //var d = (double)10 / 15;
            //double e = 10 / 15.0;
            //double f = Convert.ToDouble(a) / b;

            //Console.WriteLine(a / b);
            //Console.WriteLine(b / a);

            //Console.WriteLine(a % b);
            //Console.WriteLine(b % a);

            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.WriteLine(e);
            //Console.WriteLine(f);

            //Console.WriteLine(7 % 7);
            //Console.WriteLine(8 % 7);
            //Console.WriteLine(6 % 7);
            //Console.WriteLine(5 % 7);
            //Console.WriteLine(4 % 7);

            //var skaiciusNusakantisKazkas = 5;
            //var kazkoksKitoksSkaicius = 10;
            //Console.WriteLine(skaiciusNusakantisKazkas);

            //skaiciusNusakantisKazkas = skaiciusNusakantisKazkas + kazkoksKitoksSkaicius;

            //Console.WriteLine(skaiciusNusakantisKazkas);

            //skaiciusNusakantisKazkas += kazkoksKitoksSkaicius;

            //Console.WriteLine(skaiciusNusakantisKazkas);

            //var skaicius = 5;

            //Console.WriteLine(--skaicius);
            //Console.WriteLine(skaicius);


            //Console.WriteLine("Labas");
            //string skaicius = Console.ReadLine();
            //var sk = Convert.ToDouble("02.45dsfhhtsd646");
            //var simbolis = Convert.ToChar(Console.Read());
            //Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("simbolis " + simbolis);
            //var kitasSimbolis = Convert.ToChar(Console.Read());
            //Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("kitas simbolis " + kitasSimbolis);
            //var treciasSimbolis = Convert.ToChar(Console.Read());
            //Console.WriteLine();
            //Console.WriteLine("kitas simbolis " + treciasSimbolis);


            //bool nuolatinis = false;

            //if (!nuolatinis)
            //{
            //    Console.WriteLine("Labas");
            //}

            //var skaicius = -6;

            //if (skaicius > 0)
            //{
            //    if (skaicius % 2 == 0)
            //    {
            //        Console.WriteLine("Lyginis teigiamas");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Nelyginis teigiamas");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Neigiamas");
            //}

            //int aa = 1;
            //int bb = 2;
            //int cc = 3;

            //Console.WriteLine(Math.Max(Math.Max(aa, bb), cc));

            //int[] sarasas = { aa, bb, cc };
            //Console.WriteLine(sarasas.Max());

            //int a = 5;
            //int b = a;
            //Console.WriteLine($"{a} {b}");
            //a = 10;
            //Console.WriteLine($"{a} {b}");




            // < tipas >[] < pavadinimas > = { < duomenys > };
            // < tipas >[] < pavadinimas > = new < tipas >[< dydis >];

            //double[] masyvoPavadinimas = { 1, 1.1, '1' };

            ////masyvoPavadinimas[0] = 1;
            //masyvoPavadinimas[0] = 2.2;
            ////Console.WriteLine(masyvoPavadinimas[0]);
            ////Console.WriteLine(masyvoPavadinimas[1]);
            ////Console.WriteLine(masyvoPavadinimas[2]);

            //string[] tekstoMasyvas = 
            //{ 
            //    "tekstas", 
            //    "labas", 
            //    "ate" 
            //};

            //// Tuscias masyvas su 5 vietom skaitinems reiksmems
            //char[] skaiciuMasyvas = new char[5];

            //// Tuscias masyvas be vietu kur galetu ideti reiksmes
            //int[] skaiciuMasyvasBeDydzio = { };

            //skaiciuMasyvas[0] = '0';
            //skaiciuMasyvas[1] = '1';
            //skaiciuMasyvas[4] = '*';

            //Console.WriteLine(skaiciuMasyvas[0]);
            //Console.WriteLine(skaiciuMasyvas[1]);
            //Console.WriteLine(skaiciuMasyvas[2]);
            //Console.WriteLine(skaiciuMasyvas[3]);
            //Console.WriteLine(skaiciuMasyvas[4]);

            //Console.WriteLine();
            //Console.WriteLine(skaiciuMasyvasBeDydzio.Length);
            //skaiciuMasyvasBeDydzio[0] = 1;

            //int[] skaiciuMasyvas = { 5, 4, 7, 3 };

            //int suma = 0;
            //// For
            //for (int i = 0; i < skaiciuMasyvas.Length; i++)
            //{
            //    suma += skaiciuMasyvas[i];
            //}
            //Console.WriteLine(suma);

            //suma = 0;
            //// Foreach
            //foreach (int skaicius in skaiciuMasyvas)
            //{
            //    suma += skaicius;
            //}
            //Console.WriteLine(suma);
            //Console.WriteLine(skaiciuMasyvas.Sum());

            //int min = Int32.MaxValue;
            //for (int i = 0; i < skaiciuMasyvas.Length; i++)
            //{
            //    if (skaiciuMasyvas[i] < min)
            //    {
            //        min = skaiciuMasyvas[i];
            //    }
            //}
            //Console.WriteLine(min);
            //Console.WriteLine(skaiciuMasyvas.Min());

            //int max = Int32.MinValue;
            //for (int i = 0; i < skaiciuMasyvas.Length; i++)
            //{
            //    if (skaiciuMasyvas[i] > max)
            //    {
            //        max = skaiciuMasyvas[i];
            //    }
            //}
            //Console.WriteLine(max);
            //Console.WriteLine(skaiciuMasyvas.Max());

            //string[] tekstoMasyvas = { "labas", "ilgasZodis", "tr", "ilgiausiasZodis" };
            //Console.WriteLine(tekstoMasyvas.Max());

            //int ilgis = Int32.MaxValue;
            //int indeksas = -1;

            //for (int i = 0; i < tekstoMasyvas.Length; i++)
            //{
            //    if (tekstoMasyvas[i].Length > ilgis)
            //    {
            //        indeksas = i;
            //    }
            //}
            //Console.WriteLine($"Ilgiausias elementas indeksu '{indeksas}', jo reiksme '{tekstoMasyvas[indeksas]}'");


            //int[] skaiciuMasyvas = { 1, 5, 7, 234 };
            //List<int> skaiciuSarasas = new List<int> { 1, 5, 7, 234 };

            //Console.WriteLine(skaiciuMasyvas.Length);
            //Console.WriteLine(skaiciuSarasas.Count);

            //var randomGeneratorius = new Random();

            //for (int i = 0; i < 1000000; i++)
            //{
            //    Console.WriteLine(randomGeneratorius.Next());
            //}

            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine(randomGeneratorius.Next(1, 20));
            //}
            //Console.WriteLine();

            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine(new Random().Next(1, 20));
            //}

            //string zodis = "kazkoksZodis";
            //Console.WriteLine(zodis.Length);


            //int[] skaiciuMasyvas = { 1, 5, 7, 234 };
            //List<int> skaiciuSarasas = new List<int> { 1, 5, 7, 234 };

            //// Kaip nuskaityti elementą
            //Console.WriteLine(skaiciuMasyvas[2]);
            //Console.WriteLine(skaiciuSarasas.ElementAt(2));

            //int a = 5;
            //int b = 10;

            //int laikinas = a;
            //a = b;
            //b = laikinas;

            int skaicius1 = 1;
            Console.WriteLine(skaicius1);
            Keisti(ref skaicius1);
            Console.WriteLine(skaicius1);
        }

        static public void Keisti(ref int a)
        {
            a = a + 1;
        }
    }
}
