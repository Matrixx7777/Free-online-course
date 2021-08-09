using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funckje_część_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Dodaj(5, 4));

            Console.ReadKey();
        }

        static string Dodaj(int a, int b)
        {
            int wynik = a + b;
            if (wynik >= 10)
            {
                return "Wynik większy od 10";

            }

            else 
            {
                return "Wynik mniejszy od 10";
               
            }

           
        }
    }
}
