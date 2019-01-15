using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabler2
{
    class Program
    {
        static void Main(string[] args)
        {// Date and Time variabler
            DateTime d1;


            d1 = DateTime.Now;
            {
                d1 = d1.AddDays(10);
                Console.WriteLine($"Dato +10 dage {d1}");
            }
            {
                d1 = d1.AddMinutes(20);
                Console.WriteLine($"Dato +20 min {d1}");


            }

            {
                d1 = d1.AddMonths(-1);
                Console.WriteLine($"Dato - 1 mnd {d1}");

            }
            {
                    DateTime d2 = new DateTime(2018, 1, 1);
                    DateTime d3 = new DateTime(2018, 5, 1);
                    TimeSpan t1 = d3.Subtract(d2);
                    Console.WriteLine(t1.Days);
             }

            {
                TimeSpan t2 = new TimeSpan(16, 0, 0);
                Console.WriteLine(t2);
                TimeSpan t3 = new TimeSpan(0, 30, 0);
                Console.WriteLine(t3);
                TimeSpan t4 = t2 - t3;
                Console.WriteLine(t4);

            }





            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
