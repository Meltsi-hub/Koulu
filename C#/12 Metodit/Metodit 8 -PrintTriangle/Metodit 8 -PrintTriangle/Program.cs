using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodit_8__PrintTriangle
{
    internal class Program
    {
        static void PrintTriangle(int n)
        {
            string tahti = "*";
            string summa = "";
            Console.WriteLine("\nTulostaa kolmion käyttäen tähtiä:");

            for (int i = 1; i <= n; ++i)  // i alustetaan, ehto tarkistetaan ja kasvatetaan yhdellä
            {
                summa += tahti;
                Console.WriteLine($"{summa}");
            }
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            /* 12.8. Kirjoita metodi PrintTriangle, joka saa parametrina kokonaisluvun n ja tulostaa kolmion, jossa on n riviä tähtiä. */

            do
            {
                Console.WriteLine("Ohjelma saa parametrina kokonaisluvun n ja tulostaa kolmion, jossa on n riviä tähtiä. Anna (0 tai pienempi) poistuaksesi:\n");

                Console.WriteLine("Anna kerrat kokonaisluku\n");

                int.TryParse(Console.ReadLine(), out int n);

                if (n <= 0) { break; }

                PrintTriangle(n);
            }
            while (true);
        }
    }
}
