using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode_Simple
{
    class Program
    {
        static void Main(string[] args)
        {

            int res = LægSammen(7, 5); // Bruger metoden LægSammen til at add de to tal

            Console.WriteLine(res); // Her vises resultatet

            double res2 = BeregnAreal(5); //Bruger metoden Beregn areal til at mul det angivede tal med 3,14

            Console.WriteLine(res2); // Viser reultatet på konsollen

            Udskriv("Michael");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

               
        }
        
        
        private static double BeregnAreal(double v)
        {
            return v * v * 3.14;
        }

        private static int LægSammen(int v1, int v2)
        {
            return v1 + v2;
        }

        static void Udskriv(string text)
        {
            Console.WriteLine(text);
        }


    }
}
