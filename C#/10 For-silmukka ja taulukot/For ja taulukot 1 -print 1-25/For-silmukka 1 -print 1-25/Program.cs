using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_silmukka_1__print_1_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 10.1. Kirjoita ohjelma, joka tulostaa luvut 1–25 käyttäen for-silmukkaa. */

            Console.WriteLine("ohjelma tulostaa luvut 1–25 käyttäen for-silmukkaa:");


            for (int i = 1; i <= 25; i++)  // i alustetaan, ehto tarkistetaan ja kasvatetaan
            {
                Console.WriteLine($"Luku: {i}");
            }


        }
    }
}
