using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_i_as
{
    class Program
    {
        static void Main(string[] args)
        {
            Zwierze zwierze = new Zwierze(); // Jeśli dodamy "new Kot" i w if(zwierze is Kot) to kot będzie zwierzęciem
            Kot kot = new Kot();


            Kot kot2 = zwierze as Kot;

            //if(zwierze is Kot)

            if(kot2==null)   // if(!(kot2==null)) jest różne od pustego
            {
                kot.DajGlos();
                
                Console.WriteLine("Kot jest zwierzęciem");
                kot.PijMleko();
            }
            else
            {
                Console.WriteLine("Kot jest robotem :O !");
            }
            Console.ReadKey();
        }

        class Zwierze
        {
            public void DajGlos()
            {
                Console.WriteLine("Niegrzeczny");
            }
        }

        class Kot : Zwierze
        {
            public void PijMleko()
            {
                Console.WriteLine("Pije kawe z mlekiem");
            }
        }
    }
}
