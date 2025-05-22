using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tietotyypit_ja_muuttujat_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 4.6 Pyydä käyttäjältä lämpötila Celsius-asteina ja laske se Fahrenheit-asteiksi.

            Kaava:  F = C × 9 / 5 + 32 */


            // Määritellään lopuksi plussattava luku vakioksi
            const double VAKIO = 32;


            // Kysytään käyttäjältä lämpötila Celsius-asteina
            Console.WriteLine("Anna lämpötila Celsius-asteina:");

            // Tarkistetaan, että syöte on kelvollinen double ja kirjoitetaan lämpötila muuttujaan Celsius-asteina
            bool validInput1 = double.TryParse(Console.ReadLine(), out double Celsius);


            // Tarkistaa onko kelvollinen
            if (validInput1)
            {
                // Muutetaan ja tulostetaan Fahrenheit-asteiksi kahdella tavalla
                Console.WriteLine($"Antamasin lämpötila on {(Celsius * 9 / 5) + VAKIO} Fahrenheit-astetta");
                Console.WriteLine("Antamasin lämpötila on " + ((Celsius * 9 / 5) + VAKIO) + " Fahrenheit-astetta");

            }
            else
            {
                // Jos syöte ei ollut kelvollinen luku
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }
        }
    }
}
