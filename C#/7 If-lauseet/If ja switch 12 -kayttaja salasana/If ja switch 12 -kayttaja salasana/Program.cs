using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_ja_switch_12__kayttaja_salasana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 7.12. Kirjoita ohjelma, joka pyytää käyttäjältä käyttäjätunnusta ja salasanaa. Vain jos molemmat ovat oikein, tulostat "pääsy käyttäjätietoihin" .
             * Muussa tapauksessa ohjelma tulostaa "salasana tai käyttäjätunnus virheellinen" */

            string kTunnus = "admin";
            string salasana = "passu";

            Console.WriteLine("Ohjelma pyytää käyttäjältä käyttäjätunnusta ja salasanaa:\n");

            Console.WriteLine($"Anna käyttäjätunnus\n");  // Kysytään käyttäjätunnusta

            string teksti = Console.ReadLine(); //Käyttäjä antaa käyttäjätunnuksen

            Console.WriteLine($"\nAnna salasana\n");  // Kysytään salasanaa

            string vertaa = Console.ReadLine(); //Käyttäjä antaa salasanan

            Console.WriteLine(kTunnus.Equals(teksti, StringComparison.Ordinal) && salasana.Equals(vertaa, StringComparison.Ordinal)
                ? $"\npääsy käyttäjätietoihin\n" : "\nsalasana tai käyttäjätunnus virheellinen\n");
        }
    }
}
