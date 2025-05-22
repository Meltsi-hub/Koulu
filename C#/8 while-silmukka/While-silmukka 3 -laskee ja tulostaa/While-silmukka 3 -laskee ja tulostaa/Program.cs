using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace While_silmukka_3__laskee_ja_tulostaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 8.3. Kirjoita ohjelma, joka laskee ja tulostaa lukujen summan, kunnes käyttäjä syöttää negatiivisen luvun. */

            Console.WriteLine("ohjelma laskee ja tulostaa lukujen summan, kunnes käyttäjä syöttää negatiivisen luvun.:");

        done:
        loop:
            Console.WriteLine("Syötä luku:");

            // Tarkistetaan, että syöte on kelvollinen int ja kirjoitetaan luku muuttujaan
            bool validInput1 = double.TryParse(Console.ReadLine(), out double Luku1);

            // Tarkistaa onko kelvollinen
            if (validInput1)
            {
                while (0 < Luku1)  // Ehto: silmukka jatkuu niin kauan kuin i on enintään 100
                {
                    Luku1 += Luku1;

                    Console.WriteLine($"Lukujen summa on {Luku1}");//Tulostetaan kun totta
                    goto loop;
                }
            }
            else
            {
                // Jos syöte ei ollut kelvollinen luku
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
                goto done;
            }
        }
    }
}
