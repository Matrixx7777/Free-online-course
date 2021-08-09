using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funckje_część_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dodaj(2, 2, 3);
            Dodaj(2, 4, d:4) ;
            Dodaj(1, 6,1,1);

                Console.ReadKey();
        }

        static void Dodaj(int a, int b, int c = 2, int d = 2)
        {
            int wynik = a + b + c + d;
            Console.WriteLine(wynik + " Bardzo dobrze policzone !");

        }
    }
}
