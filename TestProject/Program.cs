using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kintamuju sukurimas
            int a = 10;
            int b = 20;
            string pirmas = "";
            string antras = "";

            // Kintamuju isvedimas i konsole
            Console.WriteLine("a = " + a + ", b = " + b);
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine($"a = {a}, b = {b}");

            Console.WriteLine("" + a + "");
            Console.WriteLine(" {0} {1} {2}", "", pirmas, antras);
            Console.WriteLine("noriu atspausdinti kintamaji {0} \n ir dar antra kintamaji {1}", pirmas, antras);



            int lineWidth = 30;

            Console.Write("|");
            for (int i = 0; i < lineWidth; i++) 
            {
                Console.Write(" ");
            }
            Console.WriteLine("|");

            Console.WriteLine(7 / 3);
            Console.WriteLine(7 % 3);

            if (7 / 2 == 0 )
            {

            } else
            {

            }
        }
    }
}
