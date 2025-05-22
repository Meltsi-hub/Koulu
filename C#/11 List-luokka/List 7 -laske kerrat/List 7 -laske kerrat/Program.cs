using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_7__laske_kerrat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 11.7. Laske, montako kertaa arvo esiintyy        Kirjoita ohjelma, joka:     Luo List<int>-listan, johon lisätään satunnaisia lukuja (esim. 10–20 lukua väliltä 1–5).
                     Pyytää käyttäjää syöttämään luvun.         Laskee ja tulostaa, montako kertaa käyttäjän antama luku esiintyy listassa. */

            Random rand = new Random();

            List<int> numerot = new List<int>();
            bool found = false;
            int index = 0;

            Console.WriteLine("Ohjelma luo listan, johon lisätään 20 randomisoitua lukua väliltä 1-5 ja Laskee ja tulostaa, montako kertaa käyttäjän antama luku esiintyy listassa:\n");

            for (int j = 0; j < 20; j++) // j alustetaan, ehto tarkistetaan ja kasvatetaan yhdellä, sekä luodaan taulukko käyttäjän arvoilla
            {
                int luku = rand.Next(1, 6);  // Taulukkoon talletettavan luvun random arvo

                // Elementtien lisääminen
                numerot.Add(luku);            // Talletetaan luku taulukkoon
            }
        ask:
            Console.WriteLine("Anna etsittävä kokonaisluku väliltä 1-5:"); // Kysytään käyttäjältä kokonaislukua

            bool validInput1 = int.TryParse(Console.ReadLine(), out int luku2); // Tarkistetaan, että syöte on kelvollinen int ja kirjoitetaan annettu luku muuttujaan
            Console.WriteLine($"");

            if (validInput1)    // Tarkistaa onko kelvollinen
            {
                foreach (int numero in numerot) //käyttää foreach listan tulostukseen
                {
                    if (luku2 == numero)    // Verrataan käyttäjän lukua taulukon lukuun
                    {
                        index++;
                        found = true;   // Totta, jos luku/lukuja löytyi
                    }
                }
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.\n");    // Jos syöte ei ollut kelvollinen luku
                goto ask;
            }

            if (found == true)    // Totta, jos löytyi
            {
                Console.WriteLine($"Antamaasi lukua löytyi {index} kappaletta\n"); //tulostaa löydetyn määrän
            }
            else
            {
                Console.WriteLine($"Antamaasi lukua {luku2} ei löytynyt yhtään kappaletta\n"); //tulostaa tiedon ettei lukua löytynyt
            }
        }
    }
}
