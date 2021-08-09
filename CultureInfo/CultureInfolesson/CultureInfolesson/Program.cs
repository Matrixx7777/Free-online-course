using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CultureInfolesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = CultureInfo.GetCultures(CultureTypes.AllCultures);
            foreach (var item in c)
            {
                Console.Write(item.Name);
                Console.WriteLine(item.NumberFormat.NumberDecimalSeparator);
                //Wyświetliło nam wszystkie kultury 
            }

            int a = -5;
            double b = 3.14;
            Console.Write($"{a}\n{b}");
            Console.ReadKey();
            
        }
    }
}
