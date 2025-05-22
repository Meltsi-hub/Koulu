using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Tietotyypit_ja_muuttujat_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 3. Määrittele muuttujat suorakulmion leveyden ja korkeuden tallentamiseen.Pyydä käyttäjältä arvot näihin metreinä ja laske suorakulmion pinta - ala.*/

            // Kysytään käyttäjältä suorakulmion leveys ja korkeus metreinä
            Console.WriteLine("Anna suorakulmion leveys ja korkeus metreinä:");

            // Tarkistetaan, että syöte on kelvollinen double ja kirjoitetaan putoamisaika muuttujaan
            bool validInput1 = double.TryParse(Console.ReadLine(), out double Leveys);
            bool validInput2 = double.TryParse(Console.ReadLine(), out double Korkeus);


            // Tarkistaa onko kelvollinen
            if (validInput1 && validInput2)
            {
                // Lasketaan ja tulostetaan suorakulmion pinta - ala kahdella tavalla
                Console.WriteLine($"suorakulmion pinta-ala on {Leveys * Korkeus} metriä");
                Console.WriteLine("suorakulmion pinta-ala on " + (Leveys * Korkeus) + " metriä");

            }
            else
            {
                // Jos syöte ei ollut kelvollinen luku
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }

        }
    }
}
