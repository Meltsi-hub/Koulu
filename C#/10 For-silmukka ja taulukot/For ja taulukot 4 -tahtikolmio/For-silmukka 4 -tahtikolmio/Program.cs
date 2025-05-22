using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_silmukka_4__tahtikolmio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 10.4. Kirjoita ohjelma, joka tulostaa seuraavanlaisen kolmion käyttäen tähtiä:
            *
            **
            ***
            ****
            *****          */

            string tahti = "*";
            string summa = "";
            Console.WriteLine("ohjelma tulostaa kolmion käyttäen tähtiä:");

            for (int i = 1; i <= 5; ++i)  // i alustetaan, ehto tarkistetaan ja kasvatetaan yhdellä
            {
                summa += tahti;
                Console.WriteLine($"{summa}");
            }
        }
    }
}
