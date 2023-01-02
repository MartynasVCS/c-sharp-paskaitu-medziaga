using System;
using System.Collections.Generic;
using System.Linq;

namespace Uzduotis36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * UŽDUOTIS 36
             * Sukurti klasę Mokinys su kintamaisiais: 
             *      vardas, 
             *      pavardė, 
             *      amžius, 
             *      klasė 
             *      pažymių sąrašą, kur saugosime 5 pažymius.
             *      
             * Sukurti konstruktorių, kad priskirtų reikšmes.
             * 
             * Klasės viduje sukurti metodą, 
             * kad išvestų visą informaciją apie mokinį.
             * 
             * Susikurti 3 objektus, 
             *      jiems priskirti reikšmes ir 
             *      naudojant sukurtą metodą  
             *      išvesti kiekvieno mokinio informaciją.
             */

            /*
             * UŽDUOTIS 37
             * Klasės viduje sukurti void tipo metodą, 
             * kuris išvestų į ekraną už, 
             * kiek metų mokinys baigs mokyklą, 
             *      jei atsakymas 0 – tuomet išvesti 
             *      „Mokinys mokyklą baigs šiais metais“. 
             * Iškviesti metodą Main‘o viduje visiems objektams.
             * 
             * Main‘o viduje 
             * naudojant Sąrašo komandas Max() ir Min() 
             * išvesti į ekraną kiekvieno mokinio geriausią ir blogiausią pažymį.
             * 
             * Sukurti int tipo metodą (pagrindinės klasės viduje), 
             * kuriam paduosim kintamąjį, 
             * kurio tipas yra Mokinys.  
             * Metodas turi apskaičiuoti, 
             * kiek yra mokinio pažymių, didesnių už 4. 
             * Išvesti šią informaciją apie kiekvieną mokinį.
             */

            Mokinys mokinysMartynas = new Mokinys("Martynas", "Martynauskas", 15, "5A", new List<int> { 10, 10, 9, 8, 10 });
            Mokinys mokinysPaulius = new Mokinys("Paulius", "Paulauskas", 16, "6B", new List<int> { 10, 9, 7, 10, 8 });
            Mokinys mokinysSaulius = new Mokinys("Saulius", "Saulauskas", 14, "7C", new List<int> { 8, 4 , 7, 6, 3 });

            mokinysMartynas.SpausdintiMokinioDuomenis();
            mokinysPaulius.SpausdintiMokinioDuomenis();
            mokinysSaulius.SpausdintiMokinioDuomenis();

            mokinysMartynas.KadaBaigsMokykla();
            mokinysPaulius.KadaBaigsMokykla();
            mokinysSaulius.KadaBaigsMokykla();

            Console.WriteLine();
            Console.WriteLine($"Mokinio {mokinysMartynas.vardas} geriausias pažymys: {mokinysMartynas.pazymiai.Max()}");
            Console.WriteLine($"Mokinio {mokinysMartynas.vardas} blogiausias pažymys: {mokinysMartynas.pazymiai.Min()}");
            Console.WriteLine($"Mokinio {mokinysPaulius.vardas} geriausias pažymys: {mokinysPaulius.pazymiai.Max()}");
            Console.WriteLine($"Mokinio {mokinysPaulius.vardas} blogiausias pažymys: {mokinysPaulius.pazymiai.Min()}");
            Console.WriteLine($"Mokinio {mokinysSaulius.vardas} geriausias pažymys: {mokinysSaulius.pazymiai.Max()}");
            Console.WriteLine($"Mokinio {mokinysSaulius.vardas} blogiausias pažymys: {mokinysSaulius.pazymiai.Min()}");

            Console.WriteLine();
            Console.WriteLine($"Mokinio {mokinysMartynas.vardas} teigiamų pažymių kiekis: {TeigiamuPazymiuKiekis(mokinysMartynas)}");
            Console.WriteLine($"Mokinio {mokinysPaulius.vardas} teigiamų pažymių kiekis: {TeigiamuPazymiuKiekis(mokinysPaulius)}");
            Console.WriteLine($"Mokinio {mokinysSaulius.vardas} teigiamų pažymių kiekis: {TeigiamuPazymiuKiekis(mokinysSaulius)}");
        }

        private static int TeigiamuPazymiuKiekis(Mokinys mokinys)
        {
            int kiekis = 0;

            foreach (int pazymys in mokinys.pazymiai)
            {
                if (pazymys > 4)
                {
                    kiekis++;
                }
            }

            return kiekis;
        }
    }

    public class Mokinys
    {
        static int mokyklosBaigimoAmzius = 19;
        internal string vardas;
        string pavarde;
        int amzius;
        string klase; // Pvz 5E, 2A
        internal List<int> pazymiai;

        internal Mokinys(string vardas, string pavarde, int amzius, string klase, List<int> pazymiai)
        {
            this.vardas = vardas;
            this.pavarde = pavarde;
            this.amzius = amzius;
            this.klase = klase;
            this.pazymiai = pazymiai;
        }

        internal void SpausdintiMokinioDuomenis()
        {
            // Spausdina informacija apie mokini.
            Console.WriteLine("Informacija apie mokinį:");
            Console.WriteLine($"   Vardas: {vardas}");
            Console.WriteLine($"   Pavardė: {pavarde}");
            Console.WriteLine($"   Amžius: {amzius}");
            Console.WriteLine($"   Klasė: {klase}");
            Console.Write($"   Pažymiai: ");
            for (int i = 0; i < pazymiai.Count; i++)
            {
                Console.Write(pazymiai[i]);

                if (i == pazymiai.Count - 1)
                {
                    // Nespausdinam kablelio
                } 
                else
                {
                    Console.Write(", ");
                }
                
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        internal void KadaBaigsMokykla()
        {
            int skirtumas = mokyklosBaigimoAmzius - amzius;

            if (skirtumas <= 0 )
            {
                Console.WriteLine("Mokinys mokyklą baigs šiais metais");
            }
            else
            {
                Console.WriteLine($"Mokinys {vardas} mokyklą baigs už {skirtumas} metų");
            }
        }
    }
}
