using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_simpel
{
    class Program
    {
        static void Main(string[] args)
        {


            Instruktør i1 = new Instruktør();
            i1.Fornavn = "Ole";
            i1.Efternavn = "Olesen";
            i1.NøgleId = 21;

            Console.WriteLine(i1.FuldtNavn());

            Elev e1 = new Elev();
            e1.Fornavn = "Jens";
            e1.Efternavn = "Jensen";
            e1.klasselokale = 23;

            Console.WriteLine(e1.FuldtNavn());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

    }
    class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public string FuldtNavn()

        {

            return $"{Fornavn} {Efternavn}";

        }

    }
    class Elev: Person
    {
        public int klasselokale { get; set; }

    }
    class Instruktør: Person
    {
        public int NøgleId { get; set; }

    }

}
