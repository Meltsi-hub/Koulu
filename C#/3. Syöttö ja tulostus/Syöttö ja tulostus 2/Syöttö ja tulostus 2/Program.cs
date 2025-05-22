using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Syöttö_ja_tulostus_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.2 Kirjoita ohjelma, joka kysyy kahta kokonaislukua ja tulostaa niiden summan, erotuksen ja tulon. Tee tarkistus, että luvut ovat valideja liukulukuja.

            Console.WriteLine("Syötä kaksi kokonaislukua:");


            // Yritetään lukea luku ja tarkistetaan, että syöte on kelvollinen
            bool validInput1 = int.TryParse(Console.ReadLine(), out int luku1);
            bool validInput2 = int.TryParse(Console.ReadLine(), out int luku2);
            
            // Tulostetaan kaikki syötetyt tiedot
            if (validInput1 && validInput2)
            {
                Console.WriteLine($"lukujen summa on {luku1 + luku2}, Erotus on {luku1 - luku2} ja tulo on {luku1 * luku2}");
                Console.WriteLine("lukujen summa on " + (luku1 + luku2) + ", Erotus on " + (luku1 - luku2) + " ja tulo on " + (luku1 * luku2));
                
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }
        }
    }
}
