using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_lause_ja_switch_rakenne_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 7.1. Kirjoita ohjelma, joka tarkistaa, onko käyttäjän syöttämä luku parillinen vai pariton */

            const int JAKAJA2 = 2;

            Console.WriteLine("Ohjelma tarkistaa, onko käyttäjän syöttämä luku parillinen vai pariton:\r\n");

            // Kysytään käyttäjältä kokonaislukua
            Console.WriteLine("Anna kokonaislukua:");

            // Tarkistetaan, että syöte on kelvollinen int ja kirjoitetaan luku muuttujaan
            bool validInput1 = int.TryParse(Console.ReadLine(), out int Luku1);



            // Tarkistaa onko kelvollinen
            if (validInput1)
            {
                // Tarkastetaan, onko luku: parillinen vai pariton
                if (0 == (Luku1 % JAKAJA2))
                {

                    // Jos tosi, tulostetaan, että se on
                    Console.WriteLine($"Luku {Luku1} on parillinen");
                }
                else
                {
                    // Muussa tapauksessa, tulostetaan, että ei ole
                    Console.WriteLine($"Luku {Luku1} ei ole parillinen");
                }
            }
            else
            {
                // Jos syöte ei ollut kelvollinen luku
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }
        }
    }
}
