using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funckcje_część_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine("Przed " + a);
            Test (a);
            Console.WriteLine("Po " + a);
            Console.ReadKey();
        }

        static void Test (int a)
        {
            a += 5;
            Console.WriteLine("W funckji " + a);
        }
    }
}
