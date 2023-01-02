using System;
using System.Collections.Generic;

namespace Dienynas
{
    internal class Dienynas
    {
        public List<Mokinys> mokiniai { get; }

        public Dienynas(List<Mokinys> mokiniai)
        {
            this.mokiniai = mokiniai;
        }

        internal void IvestiPazymius(string pamoka, Mokinys mokinys, List<double> pazymiai)
        {
            int mokinioNr = -1;
            
            for (int i = 0; i < mokiniai.Count; i++)
            {
                if (mokiniai[i].vardas == mokinys.vardas && mokiniai[i].pavarde == mokinys.pavarde)
                {
                    mokinioNr = i;
                    break;
                }
            }

            if (mokinioNr == -1)
            {
                Console.WriteLine($"Mokinio {mokinys.vardas} {mokinys.pavarde} dienyne nėra");
                return;
            }
            else
            {
                int pamokosNr = -1;

                for (int i = 0; i < mokiniai[mokinioNr].pazymiai.Count; i++ )
                {
                    if (mokiniai[mokinioNr].pazymiai[i].pamoka == pamoka)
                    {
                        pamokosNr = i;
                        break;
                    }
                }

                if (pamokosNr == -1)
                {
                    Console.WriteLine($"Mokinys {mokinys.vardas} {mokinys.pavarde} neturi {pamoka} pamokos pažymių.");
                    Console.WriteLine("Irašomi nauji pažymiai");
                    mokiniai[mokinioNr].pazymiai.Add(new PamokosPazymiai(pamoka, pazymiai));
                }
                else
                {
                    Console.WriteLine("Pridedami nauji pažymiai");
                    foreach (double pazymys in pazymiai)
                    {
                        mokiniai[mokinioNr].pazymiai[pamokosNr].pazymiai.Add(pazymys);
                    }
                }
            }
        }
    }
}
