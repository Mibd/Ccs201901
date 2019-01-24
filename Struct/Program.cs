using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare V1 = new Vare();
            V1.Id = 1;
            V1.Navn = "Vare nr1";
            V1.Beskrivelse = "beskrivelse v1";
            V1.Pris = 100.0;
            Console.WriteLine($"{ V1.Navn} Koster { V1.Pris:C2}");

            Vare V2 = new Vare();
            V2.Id = 2;
            V2.Navn = "Vare nr2";
            V2.Beskrivelse = "beskrivelse v2";
            V2.Pris = 125.10;
            Console.WriteLine($"{ V2.Navn} Koster { V2.Pris:C2}");

            Vare V3 = new Vare();
            V3.Id = 3;
            V3.Navn = "Vare nr3";
            V3.Beskrivelse = "beskrivelse v3";
            V3.Pris = 133.30;
            Console.WriteLine($"{ V3.Navn} Koster { V3.Pris:C2}");


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
        
            


        



    }


}
