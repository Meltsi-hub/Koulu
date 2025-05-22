using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_silmukka_5__tulostaa_Fibonacci_sarjan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 8.5. Kirjoita ohjelma, joka tulostaa Fibonacci - sarjan ensimmäiset 10 lukua: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34. */

            Console.WriteLine("Ohjelma tulostaa Fibonacci - sarjan ensimmäiset 10 lukua:\n");

            int i = 1;
            int uusi = 1;
            int vanha = 0;
            int vara = 0;

            while (i <= 10)  // Ehto: silmukka jatkuu niin kauan kuin i on enintään 10
            {
                Console.Write($"{vanha}, "); //Tulostetaan vanha

                vara = uusi;
                uusi = uusi + vanha;
                vanha = vara;

                i++;

            }
        }
    }
}
