using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_i_obiekty_część_2
{
    class Czlowiek
    {
    
        //Jeśli dopiszemy to. Nie wyświetli nam tego poniżej.
        public Czlowiek(string imiekonstruktora, string nazwiskokonstruktora)
        {
            imie = imiekonstruktora;
            nazwisko = nazwiskokonstruktora;
        }
            
       
        public string imie = "Dawid ";
        public string nazwisko = "Kocik";
        public string text = "W przyszłości osiągniesz sukces tylko nigdy się nie poddawaj. Stawiaj czoła !";

        public void PrzedstawSie()
        {
            Console.WriteLine("Mam na imię " + imie + nazwisko) ;
        }
    }
              




            
        
    
    
}
