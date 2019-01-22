using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Simpel
{
    class Program
    {
        static void Main(string[] args)
        {
           

            int[] månedsløn = { 11111, 2222, 33333, 44, 55555 };

            double sum = 0;

            for (int i =0; i < månedsløn.Length; i++)

            {
                sum += månedsløn[i];
                Console.WriteLine(månedsløn[i]);
            }

            Console.WriteLine();

            int antal = månedsløn.Length;

            Console.WriteLine(antal);

            Console.WriteLine();

            int min = månedsløn.Min();

            Console.WriteLine(min);


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }



    }
}
