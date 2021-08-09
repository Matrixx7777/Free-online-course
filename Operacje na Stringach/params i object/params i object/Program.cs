using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace params_i_object
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Mam na imię Dawid i mam 21 lat");
            //Console.ReadKey();
            // To zupełnie tak samo ma wyświetlać jak powyżej tylko innym sposobem

            Console.WriteLine(GenerujTekst("Mam na imię #0 i mam #1 lat", "Dawid", 21));
            Console.ReadKey();
        }

        public static string GenerujTekst(string tekst, params object[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                tekst = tekst.Replace("#" + i, args[i].ToString());
                
            }
            return tekst;
        }
    }
}
