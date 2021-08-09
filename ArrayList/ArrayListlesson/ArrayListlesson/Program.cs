using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListlesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // Auto auto = new Auto();
            // auto.Id = 1;
            // auto.marka = "BMW";
            // auto.owner = "Dawid Kocik";
            // Console.WriteLine($"{auto.Id}\n{auto.marka}\n {auto.owner}" );
            // Console.ReadKey();
            // To jest mój sposób na zabawę, teraz sprawdziwy sposób inny, bardziej zaawansowany.

            ArrayList list = new ArrayList();
            list.Add(2);
            list.Add("Bartek");
            list.Add("BMW");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            // Cieszę się że zrozumiałem podstawowe budowanie obiektu.
            // Widzę że to moja pasja, chciałbym więcej się nauczyć.
            // Jako introwertyk mógłbym przysiadywać całymi dniami na bezludnej wyspie przed kopem
        }
    }
}
