using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_silmukka_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 8.1.Kirjoita ohjelma, joka tulostaa luvut 1–10 käyttäen. */

            Console.WriteLine("Ohjelma tulostaa luvut 1–10:");

            int i = 0;  // Aloitusarvo
            while (i <= 10)  // Ehto: silmukka jatkuu niin kauan kuin i on enintään 10
            {
                Console.WriteLine($"Luku: {i}");
                i++;  // Kasvatetaan i:tä yhdellä joka kierroksella
            }
        }
    }
}