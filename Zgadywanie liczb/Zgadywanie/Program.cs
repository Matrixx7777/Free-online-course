            
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zgadywanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int los = rnd.Next(1, 11);

            int mojaliczba;
            int ileRazy = 0;

            Console.WriteLine("Odgadnij moją liczbę od 1 do 10");

            do
            {
                
                Console.Write("Podaj liczbę ");
                mojaliczba = int.Parse(Console.ReadLine());

                if (mojaliczba < 1 || mojaliczba > 10)
                {
                    Console.WriteLine("Liczba z poza zakresu");
                }

                else
                {
                    ileRazy++;
                    if (mojaliczba > los)
                    {
                        Console.WriteLine("Liczba jest za duża");

                    }


                    else if (mojaliczba < los)
                    {
                        Console.WriteLine("Liczba jest za mała");
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Brawo odgadłeś moją liczbę !!! Za {0} razem", ileRazy++);
                    }
                }
                } while (los != mojaliczba) ;
            
            Console.ReadKey();
        }
    }
}
