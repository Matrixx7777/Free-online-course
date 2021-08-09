using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("BMW", 2007);
            Auto auto2 = new Auto("Audi", 2010);
            Auto auto3 = new Auto("Toyota", 2011);
            Auto auto4 = new Auto("Peuegot", 2007);
            Auto auto5 = new Auto("Opel", 2013);
            Auto auto6 = new Auto("Ferrari", 2020);

            List<Auto> list = new List<Auto>();
            list.Add(auto1);
            list.Add(auto2);
            list.Add(auto3);
            list.Add(auto4);
            list.Add(auto5);
            list.Add(auto6);

            list.Sort(new AutoComparer());

            foreach (var item in list)
            {
                Console.WriteLine(item.Marka + " - " + item.Rocznik);
            }

            Console.ReadKey();
        }
    }

    // Ta klasa Auto jest wpisana jako lista do klasy AutoComparer, dlatego AutoComparer dominuje w ustawieniach
    // Jeśli ją wyrzucimy to musimy usunąć new AutoComparer w liscie sortowania wtedy zadziała klasa Auto
    class AutoComparer : IComparer<Auto>
    {
        public int Compare(Auto x, Auto y)
        {
            if (x.Rocznik < y.Rocznik)
                return 1;

            else if (x.Rocznik == y.Rocznik)
                return 0;

            else
                return -1;
        }

    }

    class Auto : IComparable
    {
        public string Marka { get; set; }
        public int Rocznik { get; set; }
        public Auto(string Marka, int Rocznik)
        {
            this.Marka = Marka;
            this.Rocznik = Rocznik;
        }

        public int CompareTo(object obj)
        {
            var arg =(Auto) obj;

            if (Rocznik < arg.Rocznik)
                return 1;

            else if (Rocznik == arg.Rocznik)
                return 0;

            else
                return -1;
        }
        
    }
}
