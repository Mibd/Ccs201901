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
                String fornavn = "Michael";
                String efternavn = "Danielsen";

                String samletnavn = fornavn +' '+ efternavn;
                Console.WriteLine(samletnavn);

                var navnSTORT = samletnavn.ToUpper();
                Console.WriteLine(navnSTORT);

                var navnLille = samletnavn.ToLower();
                Console.WriteLine(navnLille);
            }




            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}
