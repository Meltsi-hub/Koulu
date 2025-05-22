using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_10__kopioi_lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 11.10. Kopioi lista      Kirjoita ohjelma, joka:     Luo List<int>-listan, jossa on 10 lukua.        Kopioi listan uuteen listaan.
             *        Muokkaa alkuperäistä listaa lisäämällä siihen lukuja.   Tulostaa molemmat listat ja osoittaa, että ne ovat eri kopioita. */

            Random rand = new Random();

            List<int> numerot = new List<int>();
            List<int> numerot2 = new List<int>();

            Console.WriteLine("Ohjelma luo kaksi listan, johon lisätään 10 randomisoitua lukua väliltä 1-20, sitten kopioi listan uuteen listaan.\n" +
                "Muokkaa alkuperäistä listaa lisäämällä siihen lukuja.   Tulostaa molemmat listat ja osoittaa, että ne ovat eri kopioita:\n");

            for (int j = 0; j < 10; j++) // j alustetaan, ehto tarkistetaan ja kasvatetaan yhdellä, sekä luodaan taulukko käyttäjän arvoilla
            {
                int luku = rand.Next(1, 21);  // Taulukkoon talletettavan luvun random arvo

                // Elementtien lisääminen
                numerot.Add(luku);            // Talletetaan luku taulukkoon
            }

            numerot.ForEach(x => numerot2.Add(x));  //Lisää arvot uuteen listaan
            numerot.Add(12);
            numerot.Add(45);

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
        }
    }
}
