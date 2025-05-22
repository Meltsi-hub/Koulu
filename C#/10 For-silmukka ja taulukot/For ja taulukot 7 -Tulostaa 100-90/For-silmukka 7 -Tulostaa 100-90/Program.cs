using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_silmukka_7__Tulostaa_100_90
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 10.7. Kirjoita ohjelma, joka tulostaa luvut 100–>90. */

            Console.WriteLine("ohjelma tulostaa luvut 100–>90:\n");

            for (int i = 100; i >= 90; --i)  // i alustetaan, ehto tarkistetaan ja kasvatetaan yhdellä
            {

                Console.WriteLine($"Luku {i}"); //tulostaa luvut
            }
        }
    }
}
