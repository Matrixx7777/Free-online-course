using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyjątki___Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Wynik = " + Dzielenie(5)); // W tym obiekcie dielenia możemy zmieniać liczbę, np. na 0

            }

            catch(DivideByZeroException b)
            {
                Console.WriteLine("Podałeś kurwa inną liczbę niż 5 ! " + b.Message);
            }

            catch (Exception b)
            {
                Console.WriteLine("Doprawdy ? " + b.Message);


            }

            finally
            {
                Console.WriteLine("Kończymy zabawę");
            }
            Console.ReadKey();
        }

        public static float Dzielenie (int a) 
        {
            if(a==5)
            {
                throw new Exception("Spierdalaj od tej 5 " + "Wynik = 2"); //Działa nawet Console.WriteLine();

            }
            return 10 / a;
        }
    }

}
