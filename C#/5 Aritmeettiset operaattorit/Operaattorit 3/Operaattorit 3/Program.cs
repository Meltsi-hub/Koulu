using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaattorit_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 5.3 Kirjoita ohjelma, joka pyytää käyttäjältä kahta totuusarvoa(true / false). Tulosta seuraavat loogisten operaattoreiden tulokset:

            AND(&&),    OR(||), NOT(!).
            Esim:   Syötä ensimmäinen totuusarvo(true / false): true    Syötä toinen totuusarvo(true / false): false    AND: false  OR: true    NOT(ensimmäinen): false */

            // Kysytään käyttäjältä ensimmäistä totuusarvoa
            Console.WriteLine("Syötä ensimmäinen totuusarvo(true / false):");

            // Tarkistetaan, että syöte on kelvollinen double ja kirjoitetaan totuusarvo muuttujaan
            bool validInput1 = bool.TryParse(Console.ReadLine(), out bool Arvo1);

            // Kysytään käyttäjältä toista totuusarvoa
            Console.WriteLine("Syötä toinen totuusarvo(true / false):");

            // Tarkistetaan, että syöte on kelvollinen bool ja kirjoitetaan totuusarvoa muuttujaan
            bool validInput2 = bool.TryParse(Console.ReadLine(), out bool Arvo2);


            // Tarkistaa onko kelvollinen
            if (validInput1 && validInput2)
            {
                // Tulostaa ja antaa true vain jos molempien totuusarvojen tila on true, muuten false
                Console.WriteLine($"AND: {Arvo1 && Arvo2}");

                // Tulostaa ja antaa true jos ensimmäisen tai toinen tai molempien totuusarvon tila on true, muuten false
                Console.WriteLine($"OR: {Arvo1 || Arvo2}");

                // Tulostaa ja muuttaa ensimmäisen totuusarvon tilaa (true jos false ja false jos true)
                Console.WriteLine($"NOT(ensimmäinen) {!Arvo1}");

                // Tulostaa ja muuttaa toisen totuusarvon tilaa (true jos false ja false jos true)
                Console.WriteLine($"NOT(toinen): {!Arvo2}");
            }
            else
            {
                // Jos syöte ei ollut kelvollinen luku
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }
        }
    }
}
