using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1
{
    class Program
    {
        static void Main(string[] args)
        {

            int res = LægSammen(7, 5); // Bruger metoden LægSammen til at add de to tal

            Console.WriteLine(res); // Her vises resultatet

            double res2 = BeregnAreal(5); //Bruger metoden Beregn areal til at mul det angivede tal med 3,14

            Console.WriteLine(res2); // Viser reultatet på konsollen

            Udskriv("Dette er min tekst"); // Bruger metoden Udskriv til at udskrive den angivede tekst

            double Beregn = Resultat(1.00, 2.00, 3.33);
            Console.WriteLine(Beregn);

            Person P = new Person();
            P.Alder = 53;
            P.Navn = "Michael";


        }

        struct Person
        {
            public string Navn;
            public int Alder;

            public void Udskriv()
            {
                Console.WriteLine($"Jeg hedder {this.Navn}");

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
        private static double Resultat(double x, double y, double z)
        {
            return x * y - z;

        }

    }
}
