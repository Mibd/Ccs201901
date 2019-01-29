using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_helt_grundlæggende
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> f1 = MinSkrivTilConsole;  //Dette er også en delegate, men den kræver ikke definition (Action er en Void)

            f1.Invoke("test1");
            f1 -= MinSkrivTilConsole;

            MinDelegate1 f2 = new MinDelegate1(MinSkrivTilConsole);  //Løsning med Delegate kræver at delegate defineres i namespace

            f2("test2");
            f2 -= MinSkrivTilConsole;

            Func<int> f3 = metode1;  //Dette er en delegate, der retunere en værdi
            f3();

            int metode1()
            {
                Console.WriteLine("**** Test3 ****");
                return 0;
            }

            Action f4 = () => Console.WriteLine("**** Test4 ****");  //Her bruges Lamda metoden. Det er en meget komprimeret metode
            f4();


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }

        static void MinSkrivTilConsole(string txt)
        {
            Console.WriteLine("**** " + txt + " ****");
        }


        public delegate void MinDelegate1(string txt);
        
    }
}