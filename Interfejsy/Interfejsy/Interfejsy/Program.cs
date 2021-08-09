using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsy
{
    class Program
    {
        static void Main(string[] args)
        {
            Postac postac = new Postac("Spider-man", 790);
            Console.WriteLine(postac.nick, postac.punktyHP);
            Uderzenie uderzenie = (Uderzenie)postac;
            uderzenie.Uderzenie1(260);
            Obrona obrona = (Obrona)postac;
            obrona.Obrona1(190);
            Console.ReadKey();

        }
    }

    interface Uderzenie
    {
        void Uderzenie1(int uderzenie2);
    }
    interface Obrona
    {
        void Obrona1(int obrona2);
    }

    class Postac: Uderzenie, Obrona
    {
        public string nick;
        public int punktyHP;
        public Postac(string nick, int punktyHP)
        {
            this.nick = nick;
            this.punktyHP = punktyHP;

        }

        public void Uderzenie1(int damage)
        {
            Console.WriteLine("Atak: 260");
        }
        public void Obrona1(int defence)
        {
            Console.WriteLine("Obrona: 190");
        }
    }
}
