using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_silmukka_ja_taulukot_5__tupla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 10.5. Kirjoita ohjelma, joka tulostaa seuraavanlaisen taulukon käyttäen for-silmukkaa:

            1 2 3 4 5
            2 4 6 8 10
            3 6 9 12 15
            4 8 12 16 20
            5 10 15 20 25 */

            int[] numerot = { 1, 2, 3, 4, 5 };
            int[] numerot2 = new int[5];

            Console.WriteLine("ohjelma tulostaa seuraavanlaisen taulukon käyttäen for-silmukkaa:\n");

            for (int i = 1; i <= 5; ++i)  // i alustetaan, ehto tarkistetaan ja kasvatetaan yhdellä
            {
                Console.WriteLine($"{numerot[0] * i} {numerot[1] * i} {numerot[2] * i} {numerot[3] * i} {numerot[4] * i}"); //tapa1 toimii suoraan

                //laskutoimitus tapaa 2 ja 3 varten
                numerot2[0] = numerot[0] * i;
                numerot2[1] = numerot[1] * i;
                numerot2[2] = numerot[2] * i;
                numerot2[3] = numerot[3] * i;
                numerot2[4] = numerot[4] * i;

                foreach (int numero in numerot2) //tapa2 vaatii numerot2 muuttujan, ja käyttää foreach tulostukseen
                {
                    Console.Write($"{numero} ");
                }
                Console.WriteLine($"\n{numerot2[0]} {numerot2[1]} {numerot2[2]} {numerot2[3]} {numerot2[4]}"); //Tapa3 vaatii numerot2 muuttujan
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write($"{j * i} "); //Tapa4 kahdella for-lausekkeella
                }
                Console.WriteLine($"\n");
            }
        }
    }
}
