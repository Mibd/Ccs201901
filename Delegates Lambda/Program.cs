using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 5, 1, 3, 51, 7, 1, 56, 36, 5 };
            
            Console.WriteLine(a.FindIndex(FindVærdi));

            Console.WriteLine();
            a.ForEach(ListVærdi);


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
        static bool FindVærdi(int i)
        {
        return i == 51;
        }



        static void ListVærdi(int i)
        {
        Console.WriteLine(i);
        }
    }
}
