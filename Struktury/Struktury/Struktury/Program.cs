using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struktury
{
    class Program
    {
        static void Main(string[] args)
        {
            Dane2D dane;
            dane.x = 10;
            dane.y = 40;
            dane.c = dane.x + dane.y ;

            Console.WriteLine(dane.x);
            Console.WriteLine(dane.y);
            Console.WriteLine(dane.OdlegloscOdSrodka());
            Console.WriteLine("Wynik dodawania:");
            Console.WriteLine(dane.c);

            Console.ReadKey();
        }
    }

    struct Dane2D
    {
        public Dane2D(int x, int y, int c)
        {
            this.x = x;
            this.y = y;
            this.c = c;
        }

        public int x;
        public int y;
        public int c;
        public double OdlegloscOdSrodka()
        {
            return Math.Round(Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2)),1);
        }
    }
}
