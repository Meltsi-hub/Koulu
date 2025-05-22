using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaattorit_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 5.1 Kirjoita ohjelma, joka pyytää käyttäjältä kahta kokonaislukua. Laske ja tulosta näiden lukujen:

            summa (+),  erotus (-),  tulo (*),  osamäärä (/),   jakojäännös (%).    Tulostuksesta pitää näkyä, mitä on laskettu. */


            // Kysytään käyttäjältä kahta kokonaislukua
            Console.WriteLine("Anna kaksi kokonaislukua:");

            // Tarkistetaan, että syöte on kelvollinen int ja kirjoitetaan luvut muuttujiin
            bool validInput1 = int.TryParse(Console.ReadLine(), out int Luku1);
            bool validInput2 = int.TryParse(Console.ReadLine(), out int Luku2);


            // Tarkistaa onko kelvollinen
            if (validInput1 && validInput2)
            {
                // Lasketaan ja tulostetaan lukujen summa
                Console.WriteLine($"Lukujen {Luku1} ja {Luku2} summa on {Luku1 + Luku2}");
                // Lasketaan ja tulostetaan lukujen erotus
                Console.WriteLine($"Lukujen {Luku1} ja {Luku2} erotus on {Luku1 - Luku2}");
                // Lasketaan ja tulostetaan lukujen tulo
                Console.WriteLine($"Lukujen {Luku1} ja {Luku2} tulo on {Luku1 * Luku2}");
                // Lasketaan ja tulostetaan lukujen osamäärä
                Console.WriteLine($"Lukujen {Luku1} ja {Luku2} osamäärä on {Luku1 / Luku2}");
                // Lasketaan ja tulostetaan lukujen jakojäännös
                Console.WriteLine($"Lukujen {Luku1} ja {Luku2} jakojäännös on {Luku1 % Luku2}");

                //Console.WriteLine("suorakulmion pinta-ala on " + (Leveys * Korkeus) + " metriä");

            }
            else
            {
                // Jos syöte ei ollut kelvollinen luku
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }
        }
    }
}
