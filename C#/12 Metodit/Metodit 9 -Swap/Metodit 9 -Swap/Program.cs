using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodit_9__Swap
{
    internal class Program
    {
        static void Swap(ref int x, ref int y)
        {
            (y, x) = (x, y);
        }
        static void Main(string[] args)
        {
            /* 12.9. Kirjoita metodi Swap, joka vaihtaa kahden muuttujan arvot.     Swap(ref int x, ref int y) // ref viittaus parametrina annettuihin muuttujiin */

            do
            {
                Console.WriteLine("Ohjelma vaihtaa kahden muuttujan arvot. Anna (-1) poistuaksesi:\n");

                Console.WriteLine("Anna kokonaisluku\n");

                bool validInput1 = int.TryParse(Console.ReadLine(), out int x);

                if (x == -1) { break; }

                Console.WriteLine("\nAnna toinen kokonaisluku\n");

                bool validInput2 = int.TryParse(Console.ReadLine(), out int y);

                if (y == -1) { break; }

                if (validInput1 && validInput2)
                {
                    Console.WriteLine($"\nAntamasi lukujen järjestys ennen   {x} ja {y}\n");
                }
                else
                {
                    Console.WriteLine("\nVirheellinen syöte. Anna kelvollinen luku.\n");
                }

                Swap(ref x, ref y);   // Kutsuu metodia

                if (validInput1 && validInput2)
                {
                    Console.WriteLine($"Antamasi lukujen järjestys jälkeen {x} ja {y}\n");
                }
                else
                {
                    Console.Write("");
                }
            }
            while (true);
        }
    }
}
