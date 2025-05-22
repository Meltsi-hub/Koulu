using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_ja_switch_14__pisteen_sijainti__x__y_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 7.14. Kirjoita ohjelma, joka tarkistaa, missä neljänneksessä (I, II, III, IV) käyttäjän antama piste (x, y) sijaitsee tasossa. */

            bool poistu = false;
            do
            {
                Console.WriteLine("Ohjelma tarkistaa, missä neljänneksessä (I, II, III, IV) käyttäjän antama piste (x, y) sijaitsee tasossa:\n");

                Console.WriteLine("\nAnna x:n arvo:");

                bool validInput1 = int.TryParse(Console.ReadLine(), out int x);   // Tarkistetaan, että syöte on kelvollinen int ja kirjoitetaan luku muuttujaan

                Console.WriteLine("\nAnna y:n arvo:");

                bool validInput2 = int.TryParse(Console.ReadLine(), out int y);   // Tarkistetaan, että syöte on kelvollinen int ja kirjoitetaan luku muuttujaan

                if (validInput1 && validInput2)    // Tarkistaa onko kelvollinen
                {

                    switch (x)
                    {
                        case 100:
                            poistu = true;
                            break;

                        case int n when (n == 0 && y == 0):
                            Console.WriteLine($"\nArvoilla x on {x} ja y on {y} piste on origossa:");
                            break;

                        case int n when (n >= 0 && y >= 0):
                            Console.WriteLine($"\nArvoilla x on {x} ja y on {y} piste on I neljänneksessä:");
                            break;

                        case int n when (n <= 0 && y >= 0):
                            Console.WriteLine($"\nArvoilla x on {x} ja y on {y} piste on II neljänneksessä:");
                            break;

                        case int n when (n <= 0 && y <= 0):
                            Console.WriteLine($"\nArvoilla x on {x} ja y on {y} piste on III neljänneksessä:");
                            break;

                        case int n when (n >= 0 && y <= 0):
                            Console.WriteLine($"\nArvoilla x on {x} ja y on {y} piste on IV neljänneksessä:");
                            break;

                        default:
                            Console.WriteLine("Virheellinen valinta.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nVirheellinen syöte. Anna kelvollinen luku.");  // Jos syöte ei ollut kelvollinen luku
                }
            }
            while (poistu == false);
        }
    }
}
