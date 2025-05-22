using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_silmukka_2__2__ja_3__extra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 8.2.ekstra Kirjoita ohjelma, joka tulostaa kaikki parilliset tai kolmella jaolliset luvut väliltä 1–100. käyttää Array */

            const int JAKAJA2 = 2;
            const int JAKAJA3 = 3;
            const int SKIP = 10;
            const int NOLLA = 0;
            const int MAX = 100;
            int[] Array = new int[100];
            int j = 0;
            int k = 0;
            Console.WriteLine("ohjelma tulostaa kaikki parilliset tai kolmella jaolliset luvut väliltä 1–100:");

            int i = 1;  // Aloitusarvo
            while (i <= MAX)  // Ehto: silmukka jatkuu niin kauan kuin i on enintään 100
            {
                if (NOLLA == (i % JAKAJA2) || (i % JAKAJA3) == NOLLA) // Tarkastetaan, onko luku: parillinen vai pariton(%) ja onko se jaollinen 3:lla(%)
                {
                    Array[j] = i;
                    j++;
                }
                i++;  // Kasvatetaan i:tä yhdellä joka kierroksella
            }
            while (k <= Array.Length)
            {
                if (Array == null || Array[k] == 0) { break; }
                else
                {
                    if (NOLLA == (k % SKIP)) { Console.Write($"\n"); }

                    Console.Write($"{Array[k]}, ");//Tulostetaan kun totta

                    k++;
                }
            }
        }
    }
}
