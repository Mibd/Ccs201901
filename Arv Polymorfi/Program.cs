using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Polymorfi
{
    class Program
    {
        static void Main(string[] args)
        {
            Faktura f1 = new Faktura() { Nr = 1, Kunde = "Hansen", Dato = DateTime.Now.Date };
            

            Console.WriteLine(f1);



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }


    }

    public class Faktura
    {
        public int Nr { get; set; }
        public string Kunde { get; set; }
        public DateTime Dato { get; set; }

        public override string ToString()
        {
            return $"Faktura nr {Nr} til {Kunde} fra {Dato:D}.";
        }
    }
}
