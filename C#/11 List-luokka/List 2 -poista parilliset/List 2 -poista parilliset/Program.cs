using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_2__poista_parilliset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*11.2. Poista parilliset      luvut Kirjoita ohjelma, joka:     Luo List<int>-listan, jossa on lukuja 1–20.     Poistaa kaikki parilliset luvut listasta.       Tulostaa jäljelle jääneet luvut. */

            Random rand = new Random();

            List<int> numerot = new List<int>();

            Console.WriteLine("Ohjelma luo listan, johon lisätään 20 randomisoitua lukua väliltä 1-20 ,sitten poistaa kaikki parilliset luvut listasta ja tulostaa jäljelle jääneet luvut:\n");

            for (int j = 0; j < 20; j++) // j alustetaan, ehto tarkistetaan ja kasvatetaan yhdellä, sekä luodaan taulukko käyttäjän arvoilla
            {
                int luku = rand.Next(1, 21);  // Taulukkoon talletettavan luvun random arvo

                // Elementtien lisääminen
                numerot.Add(luku);            // Talletetaan luku taulukkoon
            }

            foreach (int numero in numerot) //käyttää foreach listan tulostukseen
            {
                Console.Write($"{numero} ");
            }
            Console.WriteLine("\n");

            numerot.RemoveAll(x => x % 2 == 0); //tapa 1

            /*for (int i = numerot.Count - 1; i >= 0; i--) //tapa2
            {
                if (numerot[i] % 2 == 0)
                {
                    numerot.RemoveAt(i);
                }
            }*/

            foreach (int numero in numerot) //käyttää foreach listan tulostukseen
            {
                Console.Write($"{numero} ");
            }
            numerot.RemoveAll(x => x % 2 == 0);
        }
    }
}
