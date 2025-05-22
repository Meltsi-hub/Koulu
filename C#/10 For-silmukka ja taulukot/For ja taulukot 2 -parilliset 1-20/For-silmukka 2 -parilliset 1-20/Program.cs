using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_silmukka_2__parilliset_1_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 10.2. Kirjoita ohjelma, joka tulostaa kaikki parilliset luvut väliltä 1–20 pelkästään for-silmukkaa käyttäen (ei %-operaattoria). */

            Console.WriteLine("ohjelma tulostaa luvut väliltä 1–20 pelkästään for-silmukkaa käyttäen (ei %-operaattoria):");


            for (int i = 2; i <= 20; i += 2)  // i alustetaan, ehto tarkistetaan ja kasvatetaan kahdella
            {
                Console.WriteLine($"Luku: {i}");
            }
        }
    }
}
