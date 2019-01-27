using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder_rekursiv
{
    class Program
    {
        static void Main(string[] args)
        {

            LøkkeMetode(1, 10);

            void LøkkeMetode(int start, int stop)
            {
                Console.WriteLine(start);
                if (start == stop)
                    return;
                start++;
                LøkkeMetode(start, stop);
            }



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }


    }
}
