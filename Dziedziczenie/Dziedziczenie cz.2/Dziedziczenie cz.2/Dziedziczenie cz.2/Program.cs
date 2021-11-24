using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie_cz._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mag p1 = new Mag("Venom", 1000, 350);
            Console.WriteLine(p1.nick + " " + p1.punktyHP + " " + p1.mana);
            Console.ReadKey();
        }

        
       
        class Postac
        {
            public string nick;
            public int punktyHP;
            public  Postac(string nick, int punktyHP)
            {
                this.nick = nick;
                this.punktyHP = punktyHP;

            }
            public Postac()
            {

            }

        }

         class Mag : Postac
        {
            public Mag (string nick, int punktyHP, int mana)
            {
                this.mana = mana;
                this.nick = nick;
                this.punktyHP = punktyHP;
            }

            public int mana;
        }
            
    }
}
