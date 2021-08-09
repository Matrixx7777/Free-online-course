using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_i_obiekty_część_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Czlowiek czlowiek = new Czlowiek();


            Console.WriteLine("Nazywam się " + czlowiek.name + czlowiek.surname  );
            Console.WriteLine("Urodziłem się w roku " + RokUrodzenia.liczba);
            Console.ReadKey();
        }
    }
}
