using System;

namespace Uzduotis3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Išveskite į ekraną 
             * norimo dydžio tuščiavidurį kvadratą iš žvaigždučių.
             * Pvz:
             * ****
             * *  *
             * *  *
             * ****
             */

            Console.WriteLine("********");
            Console.WriteLine("*      *");
            Console.WriteLine("*      *");
            Console.WriteLine("*      *");
            Console.WriteLine("*      *");
            Console.WriteLine("*      *");
            Console.WriteLine("*      *");
            Console.WriteLine("********");
            Console.WriteLine();

            string s = "x";
            Console.WriteLine(s + s + s + s + s);
            Console.WriteLine(s + "   " + s);
            Console.WriteLine(s + "   " + s);
            Console.WriteLine(s + "   " + s);
            Console.WriteLine(s + s + s + s + s);
            Console.WriteLine();
            
            string blokas = "****\n*  *\n*  *\n****";
            Console.WriteLine(blokas);
        }
    }
}
