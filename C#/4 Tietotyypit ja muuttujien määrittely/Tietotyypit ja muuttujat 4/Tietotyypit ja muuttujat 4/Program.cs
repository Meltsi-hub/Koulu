using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tietotyypit_ja_muuttujat_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 3.4 Määrittele vakiona .Pyydä käyttäjältä tuotteen hinta ilman veroa ja laske kokonaishinta.

            Kaava: kokonaishinta = hinta ilman veroa × (1 + vero)*/

            // Lisätään erikois merkkejä (Esim. €) printtaukseen
            Console.OutputEncoding = Encoding.UTF8;

            // Määritellään arvonlisävero(25,5%) vakio
            const double ARVONLISA = 0.255;

            // Kysytään käyttäjältä tuotteen hintaa ilman veroa
            Console.WriteLine("Anna tuotteen hinta ilman veroa:");

            // Tarkistetaan, että syöte on kelvollinen ja kirjoitetaan veroton hinta muuttujaan Veroton
            bool validInput1 = double.TryParse(Console.ReadLine(), out double Veroton);


            // Tarkistaa onko kelvollinen
            if (validInput1)
            {
                // Tulostetaan kokonaishinta kahdella tavalla
                Console.WriteLine($"Kokonaishinta on {Veroton * (1 + ARVONLISA)}€");
                Console.WriteLine("Kokonaishinta on " + (Veroton * (1 + ARVONLISA)) + "€");

            }
            else
            {
                // Jos syöte ei ollut kelvollinen luku
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }


        }
    }
}
