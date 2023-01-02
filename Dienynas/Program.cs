using System;
using System.Collections.Generic;

namespace Dienynas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Mokinys> mokiniai = new List<Mokinys>
            {
                new Mokinys("Paulius", "Petrauskas"),
                new Mokinys("Antanas", "Antanavičius")
            };

            Dienynas dienynas = new Dienynas(mokiniai);

            List<double> pazymiai = new List<double> { 10, 9, 8 };
            
            dienynas.IvestiPazymius("lietuvių", mokiniai[0], pazymiai);
            dienynas.IvestiPazymius("lietuvių", mokiniai[1], pazymiai);
            dienynas.IvestiPazymius("lietuvių", mokiniai[0], pazymiai);
            dienynas.IvestiPazymius("anglų", mokiniai[0], pazymiai);
            dienynas.IvestiPazymius("anglų", mokiniai[0], pazymiai);
        }
    }
}
