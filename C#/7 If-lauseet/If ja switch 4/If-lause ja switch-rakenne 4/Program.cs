using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_lause_ja_switch_rakenne_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 7.4. Kirjoita ohjelma, joka tarkistaa käyttäjän iän ja kertoo, mihin ikäryhmään hän kuuluu. */

            Console.WriteLine("Ohjelma tarkistaa, käyttäjän iän perusteella, mihin ikäryhmään hän kuuluu:\r\n");
        done:
            // Kysytään käyttäjältä ikää
            Console.WriteLine("Anna ikäsi vuosina:");

            // Tarkistetaan, että syöte on kelvollinen double ja kirjoitetaan luku muuttujaan
            bool validInput1 = int.TryParse(Console.ReadLine(), out int Luku1);



            // Tarkistaa onko kelvollinen
            if (validInput1)
            {
                switch (Luku1)
                {
                    case 0:
                        Console.WriteLine("Vauva");
                        break;
                    case "two":
                        Console.WriteLine("Lapsi");
                        break;
                    case "one":
                        Console.WriteLine("Teini");
                        break;
                    case "two":
                        Console.WriteLine("Aikuinen");
                        break;
                    case "one":
                        Console.WriteLine("Eläkeläinen");
                        break;
                    case "two":
                        Console.WriteLine("Lapsi");
                        break;
                    default:
                        Console.WriteLine("Nuori");
                        break;
                }
            }
            else
            {
                // Jos syöte ei ollut kelvollinen luku
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.\n");
                goto done;
            }
        }
    }
}
        }
    }
}
