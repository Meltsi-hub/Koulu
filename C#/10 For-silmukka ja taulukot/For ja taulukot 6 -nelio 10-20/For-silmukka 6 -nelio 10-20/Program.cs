using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_silmukka_6__nelio_10_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 10.6.  Kirjoita ohjelma, joka tulostaa jokaisen luvun ja sen neliön välillä 10–20. */

            Console.WriteLine("ohjelma tulostaa jokaisen luvun ja sen neliön välillä 10–20:\n");

            for (int i = 10; i <= 20; ++i)  // i alustetaan, ehto tarkistetaan ja kasvatetaan yhdellä
            {
                int nelio = i * i; // Laskee neliön
                Console.WriteLine($"Luku {i} ja sen neliö {nelio}\n"); //tulostaa luvut
            }
        }
    }
}
