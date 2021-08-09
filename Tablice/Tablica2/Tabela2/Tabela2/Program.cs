using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabela2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] tab = new int [2][];
            tab[0] = new int[4];
            tab[1] = new int[3];
            tab[0][0] = 1;
            tab[0][1] = 1;
            tab[0][2] = 1;
            tab[0][3] = 1;

            tab[1][0] = 2;
            tab[1][1] = 2;
            tab[1][2] = 2;

            for (int i = 0; i < tab.Length; i++)
            {
                for (int j=0; j < tab[i].Length; j++)
                {
                    Console.Write(tab[i][j] + "");

                }
                Console.WriteLine();
            }       

            Console.ReadKey();
        }
    }
}
