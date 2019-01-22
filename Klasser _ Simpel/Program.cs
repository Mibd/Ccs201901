using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser___Simpel
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Fornavn = "Peter";
            p1.Efternavn = "Madsen";
            p1.Fødselsår = 1966;

            Person p2 = new Person();
            p2.Fornavn = "Anders";
            p2.Efternavn = "And";
            p2.Fødselsår = 1999;

            Person p3 = new Person();
            p3.Fornavn = "Putte";
            p3.Efternavn = "Grethe";
            p3.Fødselsår = 2001;

            Person p4 = new Person() {Fornavn = "Birger", Efternavn = "Hansen",Fødselsår = 2011};

            Console.WriteLine(p1.Fuldtnavn() + " " + p1.Alder());
            Console.WriteLine(p2.Fuldtnavn() + " " + p2.Alder());
            Console.WriteLine(p3.Fuldtnavn() + " " + p3.Alder());
            Console.WriteLine(p4.Fuldtnavn() + " " + p4.Alder());


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
    class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;

       public string Fuldtnavn()
        {
            return $"{Fornavn} {Efternavn}";

        }

        public int Alder()
        {
            int år = DateTime.Now.Year;
            return år - this.Fødselsår;
        }



        // default constructor

        public Person()

        {

            this.Fornavn = "";
            this.Efternavn = "";

        }
    }
}
