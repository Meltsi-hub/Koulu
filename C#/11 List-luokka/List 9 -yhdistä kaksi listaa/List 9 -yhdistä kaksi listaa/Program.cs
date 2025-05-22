using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_9__yhdistä_kaksi_listaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 11.9. Yhdistä kaksi listaa       Kirjoita ohjelma, joka:     Luo kaksi erillistä List<int>-listaa, joissa on lukuja.
                     Yhdistää listat yhdeksi listaksi.      Tulostaa yhdistetyn listan ilman duplikaatteja. */

            Random rand = new Random();

            List<int> numerot = new List<int>();
            List<int> numerot2 = new List<int>();

            Console.WriteLine("Ohjelma luo kaksi listan, johon lisätään 20 randomisoitua lukua väliltä 1-20 ja yhdistää listat yhdeksi listaksi, sekä tulostaa yhdistetyn listan ilman duplikaatteja.:\n");

            for (int j = 0; j < 20; j++) // j alustetaan, ehto tarkistetaan ja kasvatetaan yhdellä, sekä luodaan taulukko käyttäjän arvoilla
            {
                int luku = rand.Next(1, 21);  // Taulukkoon talletettavan luvun random arvo

                // Elementtien lisääminen
                numerot.Add(luku);            // Talletetaan luku taulukkoon
            }
            for (int j = 0; j < 20; j++) // j alustetaan, ehto tarkistetaan ja kasvatetaan yhdellä, sekä luodaan taulukko käyttäjän arvoilla
            {
                int luku = rand.Next(1, 21);  // Taulukkoon talletettavan luvun random arvo

                // Elementtien lisääminen
                numerot2.Add(luku);            // Talletetaan luku taulukkoon
            }

            foreach (int numero in numerot) //käyttää foreach listan listan tulostukseen
            {

                Console.Write($"{numero}, ");

            }
            Console.WriteLine($"\n");

            foreach (int numero in numerot2) //käyttää foreach listan käännetyn listan tulostukseen
            {

                Console.Write($"{numero}, ");

            }
            Console.WriteLine($"\n");
            numerot.AddRange(numerot2);

            foreach (int numero in numerot) //Yhdistetty koko lista
            {

                Console.Write($"{numero}, ");

            }
            List<int> numerot3 = numerot.Distinct().ToList();   //Poistetaan duplikaatit ja tehdään uusi lista tulostusta varten

            Console.WriteLine($"\n");


            foreach (int numero in numerot3) //käyttää foreach listan käännetyn listan tulostukseen
            {

                Console.Write($"{numero}, ");

            }
            Console.WriteLine($"\n");
        }
    }
}
