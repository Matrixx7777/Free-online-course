using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            PoryRoku poraroku = PoryRoku.Wiosna;    //lub można (PoryRoku)1
            Console.WriteLine(poraroku);        // (1)poraroku)
                                                // Wyświetli nam liczbę

            PoryRoku poraroku2 = PoryRoku.Lato;    
            Console.WriteLine(poraroku2);
            
            PoryRoku poraroku3 = PoryRoku.Jesień;    
            Console.WriteLine(poraroku3);

            PoryRoku poraroku4 = PoryRoku.Zima;    
            Console.WriteLine(poraroku4);

            Console.ReadKey();
        }

        enum PoryRoku
        {
            Wiosna = 1, Lato = 2, Jesień = 3, Zima= 4
        }
    }
}
