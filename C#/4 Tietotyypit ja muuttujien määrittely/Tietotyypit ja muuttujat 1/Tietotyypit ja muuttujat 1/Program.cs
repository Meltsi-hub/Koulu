using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tietotyypit_ja_muuttujat_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 4.1 Määrittele vakioina laskemiseen tarvittava piin arvo. Laske ja tulosta ympyrän ympärysmitta.Halkaisijan pituus annetaan syötteenä.

            Vihje: Käytä vakiona const double PI = 3.14159;
                    Kaava: ympärysmitta = halkaisija×PI */

            // // Määritellään piin vakio
            const double PI = 3.14159;

            // Kysytään käyttäjältä ympyrän halkaisijaa
            Console.WriteLine("Anna ympyrän halkaisija:");

            // Tarkistetaan, että syöte on kelvollinen double
            bool validInput1 = double.TryParse(Console.ReadLine(), out double halkaisija);


            // Tarkistaa onko kelvollinen
            if (validInput1)
            {
                // Tulostetaan ympyrän ympäryysmitta kahdella tavalla
                Console.WriteLine($"Ympäryysmitta on {halkaisija * PI}");
                Console.WriteLine("Ympäryysmitta on " + (halkaisija * PI));

            }
            else
            {
                // Jos syöte ei ollut kelvollinen luku
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }
        }
    }
}
