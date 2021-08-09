using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parzyste_i_nieparzyste
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;

            for(int i=0; i<11; i++)
            {
                if(i % 2 == 0)
                    //Może być if(i % 2 == 0)- jako parzysta z resztą 0, 
                    //Jeśli damy 1 to mamy resztę 1 czyli liczbę nieparzystą
                    Console.WriteLine(i);

            }
            
            Console.ReadKey();
        }
    }
}
