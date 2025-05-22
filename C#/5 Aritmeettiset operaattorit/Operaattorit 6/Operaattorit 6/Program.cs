using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaattorit_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 5.6 Kirjoita ohjelma, joka pyytää käyttäjältä kahta kokonaislukua ja näyttää niiden:

            AND (&),    OR (|),    XOR (^),    vasemman siirron (<<),    oikean siirron (>>).
            Esim:   Syötä ensimmäinen luku: 6   Syötä toinen luku: 3    AND: 2  OR: 7   XOR: 5  Vasemman siirto (6 << 1): 12    Oikean siirto (6 >> 1): 3 */

            const int BIT = 1;
            // Kysytään käyttäjältä ensimmäistä kokonaisluku
            Console.WriteLine("Syötä ensimmäinen luku:");

            // Tarkistetaan, että syöte on kelvollinen int ja kirjoitetaan ensimmäinen luku muuttujaan
            bool validInput1 = int.TryParse(Console.ReadLine(), out int Luku1);

            // Kysytään käyttäjältä toinen kokonaisluku
            Console.WriteLine("Syötä toinen luku:");

            // Tarkistetaan, että syöte on kelvollinen int ja kirjoitetaan toinen luku muuttujaan
            bool validInput2 = int.TryParse(Console.ReadLine(), out int Luku2);

            // Tarkistaa onko kelvollinen
            if (validInput1 && validInput2)
            {
                // Lasketaan ja tulostetaan lukujen BitWise AND
                Console.WriteLine($"Lukujen {Luku1} ja {Luku2} AND on {Luku1 & Luku2}");
                // Lasketaan ja tulostetaan lukujen BitWise OR
                Console.WriteLine($"Lukujen {Luku1} ja {Luku2} OR on {Luku1 | Luku2}");
                // Lasketaan ja tulostetaan lukujen BitWise XOR
                Console.WriteLine($"Lukujen {Luku1} ja {Luku2} XOR on {Luku1 ^ Luku2}");
                // Lasketaan ja tulostetaan ensimmäisen luvun yhden bitin siirto vasemmalle
                Console.WriteLine($"Luvun {Luku1} bitin siirto vasemmalle {(Luku1) << (BIT)}");
                // Lasketaan ja tulostetaan ensimmäisen luvun yhden bitin siirto oikealle
                Console.WriteLine($"Luvun {Luku1} bitin siirto oikealle {(Luku1) >> (BIT)}");

            }
            else
            {
                // Jos syöte ei ollut kelvollinen luku
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }
        }
    }
}
