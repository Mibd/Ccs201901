using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egenskaber_Fuld
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare vare1 = new Vare();
                        vare1.Navn = "vare #1";
                        vare1.Pris = 100;
            Console.WriteLine(vare1.Navn);
            Console.WriteLine(vare1.PrisMedMoms());

            Vare vare2 = new Vare("vare #2", 200);
            Console.WriteLine(vare2.Navn);
            Console.WriteLine(vare2.PrisMedMoms());



            // Hold console åben ved debug

            if (System.Diagnostics.Debugger.IsAttached)

            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
    public class Vare
        {
        public Vare()
        {

        }
        public Vare(string navn, double pris)
        {
            this.Pris = pris;
            this.Navn = navn;

        }
        private string navn;
        public string Navn
        {
            get
            {
                Console.WriteLine("nu aflæses navn");
                return navn;
            }

            set
            {
                Console.WriteLine("Nu tildeles navn");
                navn = value;
            }

        }
            private double pris;

        public double Pris

        {

            get
            {
                Console.WriteLine("Nu aflæses pris");
                return pris;
                 }

            set
            {
                Console.WriteLine("Nu tildeles pris");
                pris = value;
                }
        }
        public double PrisMedMoms()
            {
            return this.pris * 1.25;
            }
    }

        



}




