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
            Terning t1 = new Terning();
            Console.WriteLine(t1.Værdi);
            t1.Ryst();
            Console.WriteLine(t1.Værdi);

            Terning t2 = new Terning(6);
            Console.WriteLine(t2.Værdi);
            t2.Ryst();
            Console.WriteLine(t2.Værdi);

            Terning t3 = new Terning();
            EventHandler f = (s, e) => Console.WriteLine("Juuubiii");
            t3.ErSekser += f;
            t3.Ryst();
            Console.WriteLine(t3.Værdi);
            t3.ErSekser -= f;


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