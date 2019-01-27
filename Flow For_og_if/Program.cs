using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow_For_og_if
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int xx = 1; xx < 11; xx++)
            {
                for (int yy = 1; yy < 11; yy++)
                {
                    string tal = (xx * yy).ToString();
                    //if ((xx * yy) > 50)
                    //    Console.ForegroundColor = ConsoleColor.Yellow;
                    //else
                    //    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(tal.PadLeft(4));
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;
            }




            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}
