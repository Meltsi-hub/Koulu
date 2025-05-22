using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tietotyypit_ja_muuttujat_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 4.8 Määrittele vakiona ilman tiheys ρ=1.225 kg/m^3 ja painovoiman kiihtyvyys g=9.81 m/s^2. Pyydä käyttäjältä korkeuden muutos Δh ja laske paineen muutos kaavalla: ΔP=ρ×g×Δh */

            // EXTRA tein myös muutoksen vedessä arvolla ρ=1020 kg/m^3

            // Määritellään ilman tiheys ρ=1.225 kg/m^3 ja painovoiman kiihtyvyys g=9.81 m/s^2 vakioiksi
            const double g = 9.81;
            const double I_TIHEYS = 1.225;
            const double V_TIHEYS = 1020;

            // Kysytään käyttäjältä Korkeuden muutos Δh
            Console.WriteLine("Ohjelma laske paineen muutoksen \nAnna korkeus ero metreinä:");

            // Tarkistetaan, että syöte on kelvollinen double ja kirjoitetaan Korkeuden muutos muuttujaan
            bool validInput1 = int.TryParse(Console.ReadLine(), out int h);


            // Tarkistaa onko kelvollinen
            if (validInput1)
            {
                // Tulostetaan Paineen muutos ilmassa ΔP kahdella tavalla
                Console.WriteLine($"Paineen muutos ilmassa on {(int)(I_TIHEYS * g * h)} pascals (N/m²)");
                Console.WriteLine("Paineen muutos ilmassa on " + (int)(I_TIHEYS * g * h) + " pascals (N/m²)");
                // EXTRA
                // Laskee paineen muutos vedessä ΔP
                int Paine = (int)(V_TIHEYS * g * h);
                // Bar:eina tai ATM
                int Paine_ATM = (int)(V_TIHEYS * g * h / 100000);
                
                // Tulostetaan Paineen muutoksen vedessä ΔP
                Console.WriteLine(string.Format("Paineen muutos vedessä on {0} pascals (N/m²) tai {1} Bar", Paine, Paine_ATM));

            }
            else
            {
                // Jos syöte ei ollut kelvollinen luku
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }

        }
    }
}
