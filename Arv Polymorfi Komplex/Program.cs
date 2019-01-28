using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Polymorfi_Komplex
{
    class Program
    {
        static void Main(string[] args)
        {
            // Til at starte med er det traditionelle instancer af klasserne
            Hund d1 = new Hund();
            d1.Navn = "Fiddo";
            d1.SigNoget();
            Console.WriteLine("Jeg er et dyr og hedder " + d1.Navn);

            Kat d2 = new Kat();
            d2.Navn = "Lucky";
            d2.SigNoget();
            Console.WriteLine("Jeg er et dyr og hedder " + d2.Navn);

            Console.WriteLine();
            // Her laver jeg en liste til mange instancer

            List<Dyr> zoo = new List<Dyr>();   
            zoo.Add(new Kat() { Navn = "Misser" });
            zoo.Add(new Hund() { Navn = "Balder" });
            zoo.Add(new Kat() { Navn = "Garfild" });
            zoo.Add(new Hund() { Navn = "Ozzy" });

            foreach (Dyr dyr in zoo)
            {
                dyr.SigNoget();             //Her printes en liste med alle lydene 
            }
                


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }


    }

    public class Dyr    //Moder klassen

    {
        static System.Random rnd = new Random();

        public string Navn { get; set; }

        public virtual void SigNoget()

        {
            Console.WriteLine("Jeg er et dyr og hedder " + Navn);
        }

    }
    public class Hund: Dyr   //Indeholder moderobjektet
    {
        public override void SigNoget()
        {
            Console.WriteLine("vov");
        }

    }
    public class Kat : Dyr //Indeholder moderobjektet
    {
        public override void SigNoget()
        {
            Console.WriteLine("Miav");
        }

    }
}