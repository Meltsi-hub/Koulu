using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaattorit_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 5.2 Kirjoita ohjelma, joka pyytää käyttäjältä kahta lukua ja tarkistaa, ovatko ne:

            yhtä suuria(==),    erisuuria(!=),  ensimmäinen suurempi kuin toinen(>),    ensimmäinen pienempi kuin toinen(<).
            Esim:   Syötä ensimmäinen luku: 5   Syötä toinen luku: 10   Onko luvut yhtä suuria? Ei  Onko ensimmäinen suurempi? Ei   Onko ensimmäinen pienempi? Kyllä */


            // Kysytään käyttäjältä ensimmäistä lukua
            Console.WriteLine("Syötä ensimmäinen luku:");

            // Tarkistetaan, että syöte on kelvollinen double ja kirjoitetaan luvut muuttujiin
            bool validInput1 = double.TryParse(Console.ReadLine(), out double Luku1);

            // Kysytään käyttäjältä toista lukua
            Console.WriteLine("Syötä ensimmäinen luku:");

            // Tarkistetaan, että syöte on kelvollinen double ja kirjoitetaan luvut muuttujiin
            bool validInput2 = double.TryParse(Console.ReadLine(), out double Luku2);


            // Tarkistaa onko kelvollinen
            if (validInput1 && validInput2)
            {
                // Verrataan ja tulostetaan Onko luvut yhtä suuria?
                Console.WriteLine($"Onko luvut yhtä suuria? {(Luku1 == Luku2 ? "Kyllä" : "Ei")}");

                // Verrataan ja tulostetaan Onko luvut erisuuria?
                Console.WriteLine($"Onko luvut erisuuria? {(Luku1 != Luku2 ? "Kyllä" : "Ei")}");

                // Verrataan ja tulostetaan Onko ensimmäinen luku suurempi?
                Console.WriteLine($"Onko ensimmäinen suurempi? {(Luku1 > Luku2 ? "Kyllä" : "Ei")}");

                // Verrataan ja tulostetaan Onko ensimmäinen luku pienempi?
                Console.WriteLine($"Onko ensimmäinen pienempi? {(Luku1 < Luku2 ? "Kyllä" : "Ei")}");
            }
            else
            {
                // Jos syöte ei ollut kelvollinen luku
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }
        }
    }
}
