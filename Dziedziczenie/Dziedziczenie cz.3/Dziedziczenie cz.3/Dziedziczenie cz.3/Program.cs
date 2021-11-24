using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie_cz._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Mag p1 = new Mag("Venom", 1000, 350);
            Console.WriteLine(p1.nick + " " + p1.punktyHP + " " + p1.mana);

            p1.Ruch();

            Console.ReadKey();
        }



        class Postac
        {
            public string nick;
            public int punktyHP;
            public Postac(string nick, int punktyHP)
            {
                this.nick = nick;
                this.punktyHP = punktyHP;

            }
            public Postac()
            {

            }
            public virtual void Ruch()
            {
                Console.WriteLine("Ruch postaci ");
            }

        }

        class Mag : Postac
        {
            public Mag(string nick, int punktyHP, int mana) : base("Venom", 1000)
            {
                this.mana = mana;
                
            }
            public int mana;

            public override void Ruch()
            {
                base.Ruch();
                Console.WriteLine("Misja wykonana");

            }
        }

    }
}
