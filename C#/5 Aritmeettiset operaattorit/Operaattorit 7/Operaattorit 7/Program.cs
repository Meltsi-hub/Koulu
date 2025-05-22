using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaattorit_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 5.7 Kirjoita ohjelma, joka pyytää käyttäjältä lukua ja tarkistaa ehdollisella operaattorilla, onko luku positiivinen, negatiivinen vai nolla.

            Esim:   Syötä luku: -5      Tuloste: Luku on negatiivinen. */

            // Kysytään käyttäjältä lukua
            Console.WriteLine("Syötä luku:");

            // Tarkistetaan, että syöte on kelvollinen int ja kirjoitetaan luku muuttujaan
            bool validInput1 = double.TryParse(Console.ReadLine(), out double Luku1);

            // Tarkistaa onko kelvollinen
            if (validInput1)
            {
                // Tarkastetaan onko annettu luku positiivinen, negatiivinen vai nolla ja tulostetaan vastaus
                Console.WriteLine((Luku1 > 0) ? "luku positiivinen" : Luku1 < 0 ? "Luku on negatiivinen" : "Luku on nolla");

            }
            else
            {
                // Jos syöte ei ollut kelvollinen luku
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }
        }
    }
}
