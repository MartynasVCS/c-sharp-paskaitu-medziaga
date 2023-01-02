using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dienynas
{
    internal class PamokosPazymiai
    {
        public string pamoka { get; set; }
        public List<double> pazymiai { get; set; }
        
        public PamokosPazymiai(string pamoka, List<double> pazymiai)
        {
            this.pamoka = pamoka;
            this.pazymiai = pazymiai.ToList();
        }

        public double GautiVidurki()
        {
            return pazymiai.Average();
        }
    }
}
