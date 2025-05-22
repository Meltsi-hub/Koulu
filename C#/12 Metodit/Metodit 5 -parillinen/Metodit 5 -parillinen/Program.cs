using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodit_5__parillinen
{
    internal class Program
    {
        static bool IsEven(int luku)
        {
            const int JAKAJA2 = 2;
            const int NOLLA = 0;
            bool pari;

            if ((luku % JAKAJA2) == NOLLA) // Tarkastetaan, onko luku: parillinen vai pariton(%)
            {

                pari = true;
            }
            else
            {
                pari = false;
            }

            return pari;
        }
        static void Main(string[] args)
        {
            /* 12.5. Kirjoita metodi IsEven, joka ottaa kokonaisluvun ja palauttaa true, jos luku on parillinen, ja false, jos se ei ole. */

            Console.WriteLine("Ohjelma ottaa kokonaisluvun ja palauttaa true, jos luku on parillinen, ja false, jos se ei ole:\n");

            Console.WriteLine("Anna kokonaisluku\n");

            bool validInput1 = int.TryParse(Console.ReadLine(), out int luku);

            if (validInput1)
            {
                bool paril = IsEven(luku);

                Console.WriteLine((paril == true) ? $"\nAntamasi luku {luku} on parillinen\n" : $"\nAntamasi luku {luku} on pariton\n");
            }
            else
            {
                // Jos syöte ei ollut kelvollinen luku
                Console.WriteLine("\nVirheellinen syöte. Anna kelvollinen luku.\n");
            }
        }
    }
}
