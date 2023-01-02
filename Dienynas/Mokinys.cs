using System;
using System.Collections.Generic;

namespace Dienynas
{
    internal class Mokinys
    {
        public string vardas { get; set; }
        public string pavarde { get; set; }
        public List<PamokosPazymiai> pazymiai { get; set; }

        public Mokinys(string vardas, string pavarde)
        {
            this.vardas = vardas;
            this.pavarde = pavarde;
            pazymiai = new List<PamokosPazymiai>();
        }
    }
}
