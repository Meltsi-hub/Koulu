using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_ja_taulukot_15__Kopioi_taulukko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 10.15. Kirjoita ohjelma, joka yhdistää kahden taulukon arvot yhdeksi.

            Array.Copy(... */

            Random rand = new Random();
            int Indexer = rand.Next(50, 101);   // taulukon koon random arvo
            int[] numerot = new int[Indexer]; ; //luodaan taulukkoon 50-100 indeksiä
            Random rand2 = new Random();

            int[] numerot2 = new int[Indexer]; ; //luodaan taulukkoon 50-100 indeksiä

            Console.WriteLine("Ohjelma luo taulukon, jonka koko ja luvut on randomisoitu, ja yhdistää kahden taulukon arvot yhdeksi:\n");

            for (int j = 0; j < numerot.Length; j++) // j alustetaan, ehto tarkistetaan ja kasvatetaan yhdellä, sekä luodaan taulukko käyttäjän arvoilla
            {
                int luku1 = rand2.Next(1, 101);  // Taulukkoon talletettavan luvun random arvo
                numerot[j] = luku1;              // Talletetaan luku taulukkoon
            }

            Array.Copy(numerot, numerot2, numerot.Length);

            foreach (int numero in numerot) //tapa2 vaatii numerot2 muuttujan, ja käyttää foreach tulostukseen
            {
                Console.Write($"{numero} ");
            }
            Console.WriteLine("\n");
            foreach (int numero2 in numerot2) //tapa2 vaatii numerot2 muuttujan, ja käyttää foreach tulostukseen
            {
                Console.Write($"{numero2} ");
            }
            Console.WriteLine("\n");
        }
    }
}
