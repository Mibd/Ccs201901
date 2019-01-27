using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow_break_og_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                if (i % 3 != 0)  //Denne er fra eksemplet. Jeg frostår den ikke helt
                    continue;

                Console.WriteLine(i);
                if (i == 15)
                    break;
            }


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }


        }
    }
}
