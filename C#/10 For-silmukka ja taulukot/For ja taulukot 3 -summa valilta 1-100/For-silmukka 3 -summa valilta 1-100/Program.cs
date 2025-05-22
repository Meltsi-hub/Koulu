using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_silmukka_3__summa_valilta_1_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 10.3. Kirjoita ohjelma, joka laskee ja tulostaa lukujen summan välillä 1–100. */

            int summa = 0;
            Console.WriteLine("ohjelma laskee ja tulostaa lukujen summan välillä 1–100:");

            for (int i = 1; i <= 100; ++i)  // i alustetaan, ehto tarkistetaan ja kasvatetaan yhdellä
            {
                summa += i;
                Console.WriteLine($"kierroa {i} summa: {summa}");
               
            }
        }
    }
}
