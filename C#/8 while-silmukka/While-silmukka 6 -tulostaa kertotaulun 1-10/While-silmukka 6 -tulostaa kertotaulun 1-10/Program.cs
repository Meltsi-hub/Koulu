using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_silmukka_6__tulostaa_kertotaulun_1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 8.6. Kirjoita ohjelma, joka tulostaa käyttäjän syöttämän luvun kertotaulun väliltä 1–10. */

            Console.WriteLine("Tulostaa käyttäjän syöttämän luvun kertotaulun väliltä 1–10:\n");

            Console.WriteLine("Syötä luku:");

            // Tarkistetaan, että syöte on kelvollinen int ja kirjoitetaan luku muuttujaan
            bool validInput1 = int.TryParse(Console.ReadLine(), out int luku);

            // Tarkistaa onko kelvollinen
            if (validInput1)
            {
                int i = 1;
                while (i <= 10)  // Ehto: silmukka jatkuu niin kauan kuin i on enintään 10
                {
                    int tulo = luku * i;

                    Console.WriteLine($"\nAntamasi luku {luku} kerrottuna {i} on {tulo}");//Tulostetaan 10 kertaa

                    i++;
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
