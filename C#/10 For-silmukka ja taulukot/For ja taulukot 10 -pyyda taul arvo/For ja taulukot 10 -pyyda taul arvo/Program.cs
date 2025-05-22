using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_ja_taulukot_10__pyyda_taul_arvo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 10.10. Kirjoita ohjelma, joka pyytää käyttäjältä viisi kokonaislukua ja tallentaa ne taulukkoon. Lopuksi ohjelma tulostaa arvot. */

            int[] numerot = new int[5]; ; //luodaan taulukko

            Console.WriteLine("Ohjelma syöttää käyttäjän antamat arvot taulukkoon ja tulostaa ne:");

            for (int j = 0; j < numerot.Length; j++) //// j alustetaan, ehto tarkistetaan ja kasvatetaan yhdellä, sekä luodaan taulukko käyttäjän arvoilla
            {
                // Kysytään käyttäjältä kokonaislukua
                Console.WriteLine("\nAnna kokonaisluku:");

                // Tarkistetaan, että syöte on kelvollinen int ja kirjoitetaan luku muuttujaan
                bool validInput1 = int.TryParse(Console.ReadLine(), out int Luku1);



                // Tarkistaa onko kelvollinen
                if (validInput1)
                {
                    numerot[j] = Luku1;
                }
                else
                {
                    // Jos syöte ei ollut kelvollinen luku
                    Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
                }
            }
            Console.WriteLine("");
            for (int i = 0; i < numerot.Length; ++i)  // i alustetaan, ehto tarkistetaan ja kasvatetaan yhdellä
            {
                Console.Write($"{numerot[i]} "); //tulostaa käyttäjän taulukkoon antamat arvot
            }
            Console.WriteLine($"");
        }
    }
}
