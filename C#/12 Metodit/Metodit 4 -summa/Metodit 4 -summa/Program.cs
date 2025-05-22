using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodit_4__summa
{
    internal class Program
    {
        static int Sum(int luku, int luku2)
        {
            luku = luku + luku2;

            return luku;
        }
        static void Main(string[] args)
        {
            /* 12.4. Kirjoita metodi Sum, joka ottaa kaksi kokonaislukua ja palauttaa niiden summan. */

            do
            {
                Console.WriteLine("Ohjelma ottaa kaksi kokonaislukua ja palauttaa niiden summan. Anna (0) poistuaksesi:\n");

                Console.WriteLine("Anna kokonaisluku\n");

                bool validInput1 = int.TryParse(Console.ReadLine(), out int luku);

                if (luku == 0) { break; }

                Console.WriteLine("Anna toinen kokonaisluku\n");

                bool validInput2 = int.TryParse(Console.ReadLine(), out int luku2);

                if (luku2 == 0) { break; }

                int summa = Sum(luku, luku2);   // Kutsuu metodia

                if (validInput1 && validInput2)
                {
                    Console.WriteLine($"\nAntamasi lukujen {luku} ja {luku2} summa on {summa}\n");
                }
                else
                {
                    Console.WriteLine("\nVirheellinen syöte. Anna kelvollinen luku.\n");
                }
            }
            while (true);
        }
    }
}
