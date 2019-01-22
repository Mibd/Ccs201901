using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egenskaber_Automatisk
{
    class Program
    {
        static void Main(string[] args)
        {

            Person P1 = new Person();
                P1.Fornavn = "Michael";
            P1.Efternavn = "Danielsen";

            Person P2 = new Person();
            P2.Fornavn = "Michael";
            P2.Efternavn = "Bo";  //Invalid, da det er under 3 karaktere


            Console.WriteLine(P1.Fuldtnavn());// Returnere hele navnet
            Console.WriteLine(P2.Fuldtnavn());  //Returnere kun fornavn, da efternavn er for kort


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
        




    }

    class Person
    {
        public string Fornavn { get; set; }
        private string efternavn;

        public string Efternavn
        {
            get { return efternavn; }
            set
            {
                if (value.Length <3 )
                {
                    efternavn = "";

                }
                else
                {
                    efternavn = value;
                }



            }

        }
        public string Fuldtnavn()

        {
            return Fornavn + " " + Efternavn;

        }

    }



}
