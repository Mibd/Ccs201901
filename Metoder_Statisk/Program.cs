using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder_Statisk
{
    class Program
    {
        static void Main(string[] args)
        {

            bool findes = System.IO.File.Exists(@"c:\temp\test.txt"); //leder efter filen. findes = True, hvis den er der

            Console.WriteLine($"{findes}"); //True eller false

            if (findes == true)
            {
                string indhold = System.IO.File.ReadAllText(@"c:\temp\test.txt"); //

                Console.WriteLine($"{indhold}");
            }




            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
