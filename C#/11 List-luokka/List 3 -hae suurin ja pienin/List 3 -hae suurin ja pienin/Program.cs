using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_3__hae_suurin_ja_pienin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 11.3. Hae suurin ja pienin luku      Kirjoita ohjelma, joka:     Luo List<int>-tyyppisen listan, johon käyttäjä voi syöttää 5 lukua.     Tulostaa listan suurimman ja pienimmän luvun. */

            List<int> numerot = new List<int>();

            Console.WriteLine("Ohjelma luo listan, johon käyttäjä voi syöttää 5 lukua ja hakee suurimman ja pienimmän luvun:");

            for (int j = 0; j < 5; j++) // j alustetaan, ehto tarkistetaan ja kasvatetaan yhdellä, sekä luodaan taulukko käyttäjän arvoilla
            {
                Console.WriteLine($"\nAnna luku");  // Annetaan listaan talletettavan luvun arvo

                int.TryParse(Console.ReadLine(), out int luku); //Käyttäjä antaa luvun

                numerot.Add(luku);            // Talletetaan luku listaan
            }
            Console.WriteLine($"\nSuurin luku {numerot.Max()}\n");

            Console.WriteLine($"Pienin luku {numerot.Min()}\n");
        }
    }
}
