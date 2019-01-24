using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabler2_STRING
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                string fornavn = "Michael";
                string efternavn = "Danielsen";

                string fulde_navn = fornavn + " " + efternavn;
                Console.WriteLine(fulde_navn);

                string navnStort = fulde_navn.ToUpper();
                Console.WriteLine(navnStort);

                string navnlille = fulde_navn.ToLower();
                Console.WriteLine(navnlille);

                string udtræk = fulde_navn.Substring(8, 4);  //Fra og hvor langt angives i parantesen
                Console.WriteLine(udtræk);
            }




            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}
