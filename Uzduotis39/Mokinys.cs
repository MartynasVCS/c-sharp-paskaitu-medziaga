using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis39
{
    internal class Mokinys
    {
        internal string vardas;
        internal string pavarde;
        internal List<PamokosPazymiai> pazymiai;

        internal Mokinys(string vardas, string pavarde)
        {
            this.vardas = vardas;
            this.pavarde = pavarde;
            pazymiai = new List<PamokosPazymiai>(); 
        }
    }
}
