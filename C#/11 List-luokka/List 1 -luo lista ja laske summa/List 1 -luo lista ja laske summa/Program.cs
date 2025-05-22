using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_1__luo_lista_ja_laske_summa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 11.1. Luo lista ja laske summa   Kirjoita ohjelma, joka:     Luo List<int>-tyyppisen listan.     Lisää listaan 10 lukua (1–10).      Laskee ja tulostaa listan lukujen summan. */

            Random rand = new Random();

            List<int> numerot = new List<int>();

            int summa = 0;

            Console.WriteLine("Ohjelma luo listan, johon lisätään 10 randomisoitua lukua väliltä 1-10 ja laskee sekä tulostaa listan lukujen summan:\n");

            for (int j = 0; j < 10; j++) // j alustetaan, ehto tarkistetaan ja kasvatetaan yhdellä, sekä luodaan taulukko käyttäjän arvoilla
            {
                int luku = rand.Next(1, 11);  // Taulukkoon talletettavan luvun random arvo

                // Elementtien lisääminen
                numerot.Add(luku);            // Talletetaan luku taulukkoon
            }
            foreach (int numero in numerot) //käyttää foreach listan tulostukseen
            {
                Console.Write($"{numero} ");
            }
            Console.WriteLine("\n");
            foreach (int numero in numerot) //tapa2 vaatii numerot2 muuttujan, ja käyttää foreach tulostukseen
            {
                  
                summa = summa + numero;  // Summaa listan luvut yhteen

            }
            Console.WriteLine($"Listan luvut laskettuna yhteen {summa}\n");
        }
    }
}
