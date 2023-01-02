using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string auto1marke = "Audi";
            string auto1modelis = "A4";
            string auto2marke = "Ford";
            string auto2modelis = "Sierra";

            Console.WriteLine(auto1marke);
            Console.WriteLine(auto1modelis);

            Automobilis manoAutomobilis = new Automobilis("Audi", "A4", 1999, 455712);
            Automobilis sesesAutomobilis = new Automobilis("Ford", "Sierra", 1985, 677456);

            Console.WriteLine(manoAutomobilis.marke);
            Console.WriteLine(manoAutomobilis.modelis);
            Console.WriteLine(manoAutomobilis.pagaminimoMetai);
            Console.WriteLine(manoAutomobilis.rida);

            Console.WriteLine(sesesAutomobilis.marke);
            Console.WriteLine(sesesAutomobilis.modelis);
            Console.WriteLine(sesesAutomobilis.pagaminimoMetai);
            Console.WriteLine(sesesAutomobilis.rida);
            manoAutomobilis.Garsas();
        }
    }

    class Automobilis
    {
        public string marke;
        public string modelis;
        public int pagaminimoMetai;
        public int rida;

        public Automobilis(string marke, string modelis, int metai, int rida) 
        {
            this.marke = marke;
            this.modelis = modelis;
            this.pagaminimoMetai = metai;
            this.rida = rida;
        }

        public void Garsas()
        {
            Console.WriteLine(this.rida);
        }
    }
}
