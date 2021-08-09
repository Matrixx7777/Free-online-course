using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("Audi", 2009);
            Auto auto2 = new Auto("Audi", 2009);
            Console.WriteLine(auto1.Equals(auto2));

            // Sama ta metoda odwołuje się do obiektu auto1 i auto2. One nie są indetyczne dlatego false
            // Jeśli odwołamy się do właściwości obiektu auta1 i 2 to odczytane dane ich będą takie same

            Console.ReadKey();
        }
    }

    class Auto
    {
        public string Marka { get; set; }
        public int Rocznik { get; set; }
        public Auto (string Marka, int Rocznik)
        {
            this.Marka = Marka;
            this.Rocznik = Rocznik;
        }

        // Odwołujemy się do danych auto1 i auto2

        public bool Equals(Auto auto)
        {
            return auto.Marka == this.Marka && auto.Rocznik == this.Rocznik;
        }
        // Ta metoda z Equals wraca do auta i sprawdza dane Marki i Rocznika czy są takie same.
        // Jeśli jej nie będzie to porgram sprawdzi czy obiekty są takie same, a nie dane ich.
    }
}
