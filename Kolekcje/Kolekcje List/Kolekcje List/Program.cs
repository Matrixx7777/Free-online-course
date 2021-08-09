using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz numer samochodu");
            List<Auto> list = new List<Auto>();
            list.Add(new Auto("1.BMW"));
            list.Add(new Auto("2.Mercedes"));
            list.Add(new Auto("3.Opel"));
            list.Add(new Auto("4.Śkoda"));
            list.Add(new Auto("5.Citroen"));
            list.Add(new Auto("6.Toyota"));
            list.Add(new Auto("7.Pegueot"));
            list.Add(new Auto("8.Clio"));
            list.Add(new Auto("9.Fiat"));

            foreach (Auto item in list)
            {
                Console.WriteLine(item.Nazwa);
            }
            Console.ReadKey();
        }

        class Auto
        {
            public string Nazwa { get; set; }
            public Auto(string marka)
            {
                Nazwa = marka;
            }
        }
    
    }
}
