using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_taulukot_13___kaanto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 10.13. Kirjoita ohjelma, joka kääntää taulukon arvot toiseen järjestykseen.

            Array.Reverse(luvut);\\luvut-taulukko */

            int[] numerot = new int[5]; ; //luodaan taulukko

            Console.WriteLine("Ohjelma syöttää käyttäjän antamat arvot taulukkoon ja kääntää taulukon arvot käänteiseen järjestykseen:");

            for (int j = 0; j < numerot.Length; j++) // j alustetaan, ehto tarkistetaan ja kasvatetaan yhdellä, sekä luodaan taulukko käyttäjän arvoilla
            {
                Console.WriteLine("\nAnna kokonaisluku:"); // Kysytään käyttäjältä kokonaislukua

                bool validInput1 = int.TryParse(Console.ReadLine(), out int Luku1); // Tarkistetaan, että syöte on kelvollinen int ja kirjoitetaan luku muuttujaan
                
                if (validInput1)    // Tarkistaa onko kelvollinen
                {
                    numerot[j] = Luku1;
                }
                else
                {
                    Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");    // Jos syöte ei ollut kelvollinen luku
                }
            }

            Array.Reverse(numerot);    //numerot -taulukko käännetään

            Console.Write($"\nKäännetty taulukko:\n");

            for (int i = 0; i < numerot.Length; ++i)  // i alustetaan, ehto tarkistetaan ja kasvatetaan yhdellä
            {
                Console.Write($"{numerot[i]} "); //tulostaa käyttäjän taulukkoon antamat arvot
            }
            Console.Write($"\n"); //tulostaa käyttäjän luoman taulukon lukujen keskiarvon
        }
    }
}
