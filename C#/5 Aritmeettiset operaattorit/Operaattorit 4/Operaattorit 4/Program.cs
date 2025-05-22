using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaattorit_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 5.3  Kirjoita ohjelma, joka pyytää käyttäjältä aloitusarvon ja kasvattaa sitä seuraavilla tavoilla:

            Lisää siihen luku 5 (+=), Kertoo sen luvulla 2 (*=) ja Jakaa sen luvulla 3 (/=). */

            const int SUMMAIN = 5;
            const int KERROIN = 2;
            const int JAKAJA = 3;

            // Kysytään käyttäjältä aloitusarvon
            Console.WriteLine("Anna aloitus arvo:");

            // Tarkistetaan, että syöte on kelvollinen int ja kirjoitetaan luvut muuttujiin
            bool validInput1 = double.TryParse(Console.ReadLine(), out double Luku1);
            


            // Tarkistaa onko kelvollinen
            if (validInput1)
            {
                // Lasketaan ja tulostetaan lukujen summa
                Console.WriteLine($"Arvo summauksen jälkeen {Luku1 += SUMMAIN}\nArvo tulon jälkeen {Luku1 *= KERROIN}\nArvo jaon jälkeen {Luku1 /= JAKAJA}");
            }
            else
            {
                // Jos syöte ei ollut kelvollinen luku
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }
        }
    }
}
