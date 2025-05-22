using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_silmukka_2__2__ja_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
        /* 8.2. Kirjoita ohjelma, joka tulostaa kaikki parilliset tai kolmella jaolliset luvut väliltä 1–100. */

            const int JAKAJA2 = 2;
            const int JAKAJA3 = 3;
            const int SKIP = 10;
            const int NOLLA = 0;
            const int MAX = 100;

            Console.WriteLine("ohjelma tulostaa kaikki parilliset tai kolmella jaolliset luvut väliltä 1–100:");

            int i = 1;  // Aloitusarvo
            while (i <= MAX)  // Ehto: silmukka jatkuu niin kauan kuin i on enintään 100
            {
                if (NOLLA == (i % JAKAJA2) || (i % JAKAJA3) == NOLLA) // Tarkastetaan, onko luku: parillinen vai pariton(%) ja onko se jaollinen 3:lla(%)
                {
                    if (NOLLA == (i % SKIP))
                    {
                        Console.Write($"\n");
                    }
                    Console.Write($"{i}, ");//Tulostetaan kun totta
                }
                i++;  // Kasvatetaan i:tä yhdellä joka kierroksella
            }
        }
    }
}
