using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operacje_na_Plikach__.txt_
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\C#\operacje na Plikach (.txt)";
            StreamWriter sw;

            if(!File.Exists(path))
            {
                sw = File.CreateText(path);
                Console.WriteLine("Plik utworzony");
            }
            else
            {
                sw = new StreamWriter(path, true);
                Console.WriteLine("Plik utworzony");
            }
            Console.WriteLine("Podaj imie:");
            string text = Console.ReadLine();
            sw.WriteLine(text);
            sw.Close();

            StreamReader sr = File.OpenText(path);
            string s = "";
            int i = 1;
            Console.WriteLine("\nZawartość pliku:");
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(i++ + "" + s);
            }
            sr.Close();
            Console.ReadKey();
        }
    }
}
