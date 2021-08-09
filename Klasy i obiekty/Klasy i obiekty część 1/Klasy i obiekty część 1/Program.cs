using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_i_obiekty_część_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Czlowiek daw = new Czlowiek();
            Console.WriteLine(daw.name);
            daw.name = "Jacek";
            Console.WriteLine(daw.name);

            daw.PrzedstawSie();
            Console.ReadKey();
        }
    }

    // Możemy utworzyć klasę i przepisać to tam 
    class Czlowiek
    {
        public string name = "Dawid";
        public string surname = "Kocik";

        public void PrzedstawSie()
        {
            Console.WriteLine("Mam na imię " + name);
        }
    }
}
