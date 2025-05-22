using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tietotyypit_ja_muuttujat_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 4.2 Määrittele vakio g = 9.81(m / s ^ 2), joka edustaa putoamiskiihtyvyyttä.Pyydä käyttäjältä putoamisajan arvo sekunteina, laske ja tulosta putoamismatka.

            Kaava: s = 1 / 2 × g × t ^ 2 */


            // Määritellään Maan vetovoiman vakio
            const double g = 9.81;
            

            // Kysytään käyttäjältä putoamisajan arvo sekunteina
            Console.WriteLine("Anna putoamisaika sekunteina:");

            // Tarkistetaan, että syöte on kelvollinen double ja kirjoitetaan putoamisaika muuttujaan
            bool validInput1 = double.TryParse(Console.ReadLine(), out double p_aika);


            // Tarkistaa onko kelvollinen
            if (validInput1)
            {
                // Lasketaan ja tulostetaan putoamismatka kahdella tavalla
                Console.WriteLine($"putoamismatka on {(g * (p_aika * p_aika)) / 2} metriä");
                Console.WriteLine("putoamismatka on " + ((g * (p_aika * p_aika)) / 2) + " metriä");

            }
            else
            {
                // Jos syöte ei ollut kelvollinen luku
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }

        }
    }
}
