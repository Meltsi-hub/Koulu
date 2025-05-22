using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_6__käänteinen_järjestys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 11.6.Listan käänteinen järjestys     Kirjoita ohjelma, joka: Luo List<int> -listan, johon lisätään lukuja 1–10.   Kääntää listan järjestyksen.   Tulostaa listan sekä ennen että jälkeen käännön. */

            Random rand = new Random();

            List<int> numerot = new List<int>();

            Console.WriteLine("Ohjelma luo listan, johon lisätään 10 randomisoitua lukua väliltä 1-10 ja Kääntää listan järjestyksen. Tulostaa listan sekä ennen että jälkeen käännön:\n");

            for (int j = 0; j < 10; j++) // j alustetaan, ehto tarkistetaan ja kasvatetaan yhdellä, sekä luodaan taulukko käyttäjän arvoilla
            {
                int luku = rand.Next(1, 11);  // Taulukkoon talletettavan luvun random arvo

                // Elementtien lisääminen
                numerot.Add(luku);            // Talletetaan luku taulukkoon
            }
            foreach (int numero in numerot) //käyttää foreach listan tulostukseen
            {
                Console.Write($"{numero}, ");
            }
            Console.WriteLine("\n");

            numerot.Reverse();// Käännetään lista

            foreach (int numero in numerot) //käyttää foreach listan käännetyn listan tulostukseen
            {

                Console.Write($"{numero}, ");

            }
            Console.WriteLine($"\n");
        }
    }
}
