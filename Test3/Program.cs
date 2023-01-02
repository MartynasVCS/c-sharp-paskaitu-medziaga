using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atsisveikinti();
        }

        static public void Pasisveikinti()
        {
            Console.WriteLine("Labas");
        }

        static public void Atsisveikinti()
        {
            Console.WriteLine("Iki");
        }

        static public bool ArLyginis(int skaicius)
        {
            if (skaicius % 2 == 0) return true;
            else return false;
        }
    }
}
