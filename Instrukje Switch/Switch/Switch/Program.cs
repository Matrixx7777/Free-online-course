using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba;
            liczba = int.Parse(Console.ReadLine());

            switch(liczba)
            {
                case 1:
                    Console.WriteLine("One");
                    break;

                case 2:
                    Console.WriteLine("Two");
                    break;

                case 3:
                    Console.WriteLine("Tree");
                    break;

                default:
                    Console.WriteLine("Inna wartość");
                    break;


            }

            Console.WriteLine("Koniec");
            Console.ReadKey();
        }
    }
}
