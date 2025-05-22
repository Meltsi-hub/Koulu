using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace List_5__Järjestä_nimet_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 11.5.Järjestä nimet aakkosjärjestykseen      Kirjoita ohjelma, joka:     Luo List<string> -listan, jossa on vähintään 5 nimeä.
             * Lajittelee nimet aakkosjärjestykseen.        Tulostaa nimet järjestyksessä. */

            List<string> nimet = new List<string>() { "Keijo", "Pekka", "Riikka", "Liisa", "Anna", "Matti" };  //Luodaan lista arvoilla "Anna", "Matti", "Liisa", "Pekka"

            Console.WriteLine("Ohjelma luo string-listan, jossa on nimet Keijo, Pekka, Riikka, Liisa, Anna, Matti.\nLajittelee nimet aakkosjärjestykseen ja tulostaa ne:\n");

            foreach (string nimi in nimet) //käyttää foreach listan tulostukseen
            {
                Console.Write($"{nimi} ");
            }

            nimet.Sort();

            Console.WriteLine("\n");

            foreach (string nimi in nimet) //käyttää foreach listan tulostukseen
            {
                Console.Write($"{nimi} ");
            }
            Console.WriteLine("\n");
        }
    }
}
