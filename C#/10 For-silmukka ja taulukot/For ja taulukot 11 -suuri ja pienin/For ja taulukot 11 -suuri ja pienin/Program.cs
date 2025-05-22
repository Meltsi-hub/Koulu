using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_ja_taulukot_11__suuri_ja_pienin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 10.11. Kirjoita ohjelma, joka löytää suurimman ja pienimmän arvon taulukosta. */

            int[] numerot = new int[5]; ; //luodaan taulukko

            Console.WriteLine("ohjelma syöttää käyttäjän antamat arvot taulukkoon ja löytää suurimman ja pienimmän arvon taulukosta:");

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
            int Max = numerot.Max(); // Etsii suurimman
            int Min = numerot.Min(); // Etsii pienimmän
            Console.Write($"\nSuurin Luku {Max} ja pienin luku {Min}\n"); //tulostaa käyttäjän luoman taulukon suurimman ja pienimmän arvon
        
        }
    }
}
