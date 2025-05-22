using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Metodit_3__Nelio
{
    internal class Program
    {
        static int Square(int luku)
        {
            luku = luku * luku;

            return luku;
        }
        static void Main(string[] args)
        {
            /* 12.3. Kirjoita metodi Square, joka ottaa kokonaisluvun parametrina ja palauttaa sen neliön. */

            do
            {
                Console.WriteLine("Ohjelma ottaa kokonaisluvun parametrina ja palauttaa sen neliön. Anna (0) poistuaksesi:\n");

                Console.WriteLine("Anna kokonaisluku\n");

                bool validInput1 = int.TryParse(Console.ReadLine(), out int luku);

                if (luku == 0) {break;}

                int nelio = Square(luku);

                if (validInput1)
                {
                    Console.WriteLine($"\nAntamasi luvun {luku} neliö on {nelio}\n");
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
