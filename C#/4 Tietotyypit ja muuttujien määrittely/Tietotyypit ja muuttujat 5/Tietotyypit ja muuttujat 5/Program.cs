using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tietotyypit_ja_muuttujat_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 4.5 Määrittele vakiona valonnopeus c = 299792458 m / s.Pyydä käyttäjältä aika sekunteina ja laske, kuinka pitkän matkan valo kulkee siinä ajassa kilometreina. */

            // Määritellään valonnopeus c = 299792458 m / s vakio
            const double c = 299792458;


            // Kysytään käyttäjältä valon kulkema aika sekunteina
            Console.WriteLine("Anna valon kulkema aika sekunteina:");

            // Tarkistetaan, että syöte on kelvollinen double ja kirjoitetaan valonkulkema aika muuttujaan sekunteina
            bool validInput1 = double.TryParse(Console.ReadLine(), out double v_aika);


            // Tarkistaa onko kelvollinen
            if (validInput1)
            {
                // Lasketaan ja tulostetaan putoamismatka kahdella tavalla
                Console.WriteLine($"Valo kulkee {(c / v_aika) / 1000} kilometriä, antamassasi ajassa");
                Console.WriteLine("Valo kulkee " + ((c / v_aika) / 1000) + " kilometriä, antamassasi ajassa");

            }
            else
            {
                // Jos syöte ei ollut kelvollinen luku
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }
        }
    }
}
