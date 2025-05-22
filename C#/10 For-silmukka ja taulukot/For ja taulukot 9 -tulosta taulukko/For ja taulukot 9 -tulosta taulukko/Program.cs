using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_ja_taulukot_9__tulosta_taulukko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 10.9. Luo ohjelma, joka tulostaa taulukon arvot, jotka on alustettu etukäteen. */

            int[] numerot = { 1, 2, 3, 4, 5 }; //luodaan taulukko

            Console.WriteLine("ohjelma tulostaa taulukon arvot, jotka on alustettu etukäteen:\n");

            for (int i = 0; i <= 4; ++i)  // i alustetaan, ehto tarkistetaan ja kasvatetaan yhdellä
            {
                Console.Write($"{numerot[i]} "); //tulostaa taulukon arvot
            }
        }
    }
}
