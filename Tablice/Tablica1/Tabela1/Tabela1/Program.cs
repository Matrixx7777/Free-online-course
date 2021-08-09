using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabela1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tab = new int[2,4];
            tab[0,0] = 1;
            tab[0,1] = 1;
            tab[0,2] = 1;
            tab[0,3] = 1;
            tab[1,0] = 2;
            tab[1,1] = 2;
            tab[1,2] = 2;
            tab[1,3] = 2;
            

            for (int i = 0; i < tab.GetLength(0);  i++)
            {

                for (int j = 0; j < tab.GetLength(1); j++)
                {

                    
                  
                        Console.Write(tab[i,j] + "");
                    


                    
                }

                Console.WriteLine();
            }

            Console.ReadKey();


        }
    }
}
