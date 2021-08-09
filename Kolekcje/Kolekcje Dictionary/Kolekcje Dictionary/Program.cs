using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Dawid");
            dictionary.Add(2, "Jacek");
            dictionary.Add(3, "To najlepsi kupmle");
            dictionary.Add(4, "Jestem zmęczony matematyką na studiach");
            dictionary.Add(5, "Daję z siebie wszystko, czasem nawet myślałem, żeby rzucić te studia lub się zabić");
            dictionary.Add(6, "Doszedłem do wniosku że jestem zmęczony i muszę odpocząć");

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }
            Console.ReadKey();
        }
    }
}
