using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_lause_ja_switch_rakenne_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 7.2. Kirjoita ohjelma, joka tarkistaa, onko käyttäjän syöttämä luku positiivinen, negatiivinen vai nolla. */


            Console.WriteLine("Ohjelma tarkistaa, onko käyttäjän syöttämä luku positiivinen, negatiivinen vai nolla.:\r\n");
        done:
            // Kysytään käyttäjältä kokonaislukua
            Console.WriteLine("Anna luku:");

            // Tarkistetaan, että syöte on kelvollinen double ja kirjoitetaan luku muuttujaan
            bool validInput1 = double.TryParse(Console.ReadLine(), out double Luku1);



            // Tarkistaa onko kelvollinen
            if (validInput1)
            {
                // Tarkastetaan, onko luku nolla
                if (0 == Luku1)
                {
                    // Jos tosi, tulostetaan, että se on nolla
                    Console.WriteLine($"Luku on nolla");
                }
                else if (0 < Luku1)
                {
                    // Muussa tapauksessa, tulostetaan, että ei ole
                    Console.WriteLine($"Luku on positiivinen");
                }
                else
                {
                    // Muussa tapauksessa, tulostetaan, että luku on negatiivinen
                    Console.WriteLine($"Luku on negatiivinen");
                }
            }
            else
            {
                // Jos syöte ei ollut kelvollinen luku
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.\n");
                goto done;
            }
        }
    }
}
