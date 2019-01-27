using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DebugDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            F1();
            void F1()
            {
                Console.WriteLine("I F1()");
                F2();
            }
            void F2()
            {
                Console.WriteLine("I F2()");
                F3();
            }
            void F3()
            {
                Console.WriteLine("I F3()");
                F4();
            }
            void F4()
            {
                Console.WriteLine("I F4()");
                F5();
            }
            void F5()
            {
                Console.WriteLine("I F5()");
                // F1(); (puha - skaber rekursivt kald)
            }


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

    }
    public class Terning
    {
        // Felter
        private static Random rnd;
        private int _værdi;

        // Egenskab
        public int Værdi
        {
            get
            {
                return _værdi;
            }
            set
            {
                if (value < 1 || value > 6)
                    value = 1;
                if (value == 6)
                    ErSekser?.Invoke(this, new EventArgs());
                _værdi = value;
            }
        }

        // Metode
        public void Ryst()
        {
            Værdi = rnd.Next(1, 7);
        }

        // Hændelse
        public event EventHandler ErSekser;

        // Konstruktør
        public Terning()
        {
            rnd = new Random();
            Ryst();
        }

        // Konstruktør
        public Terning(int værdi) : base()
        {
            this.Værdi = værdi;
        }
    }
}