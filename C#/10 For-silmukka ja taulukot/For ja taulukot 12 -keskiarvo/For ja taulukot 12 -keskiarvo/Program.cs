using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_ja_taulukot_12__keskiarvo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 10.12. Kirjoita ohjelma, joka laskee taulukon lukujen keskiarvon. */

            int[] numerot = new int[5]; ; //luodaan taulukko

            Console.WriteLine("Ohjelma syöttää käyttäjän antamat arvot taulukkoon ja laskee taulukon lukujen keskiarvon:");

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
            double Summa = 0;
            for (int i = 0; i < numerot.Length; ++i)  // i alustetaan, ehto tarkistetaan ja kasvatetaan yhdellä
            {
                Summa += numerot[i]; // Summaa taulokon luvut yhteen
                Console.Write($"{numerot[i]} "); //tulostaa käyttäjän taulukkoon antamat arvot
            }
            Console.Write($"\nTaulukon lukujen keskiarvo on {String.Format("{0:F2}", Summa / numerot.Length)}\n"); //tulostaa käyttäjän luoman taulukon lukujen keskiarvon
        }
    }
}
