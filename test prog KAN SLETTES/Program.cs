﻿using System;
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
            




            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

    }
    public class Terning
    {
        
        public int C
        {
            get;
            set;
        }

        public int D { get; private set; } = 1;



    }
}