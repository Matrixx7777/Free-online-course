using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_i_obiekty_część_2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Czlowiek daw = new Czlowiek("Matrixx ", "7777");
            daw.PrzedstawSie();
            Console.WriteLine(daw.imie);
            Console.WriteLine(daw.nazwisko);
            Console.WriteLine(daw.text);

            Console.ReadKey();
        }
    }
}
