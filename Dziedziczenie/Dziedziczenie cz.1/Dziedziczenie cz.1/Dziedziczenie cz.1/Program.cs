using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie_cz._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Planety planety = new Planety();
            planety.merkury();
            planety.wenus();
            planety.ziemia();

            Console.ReadKey();

        }
    }
}
