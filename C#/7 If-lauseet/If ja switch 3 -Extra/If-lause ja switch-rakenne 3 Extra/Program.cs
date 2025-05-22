using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_lause_ja_switch_rakenne_3_Extra
{
    internal class Program
    {
        static void Main(string[] args)
        {
        /* 7.3. Kirjoita ohjelma, joka pyytää käyttäjältä kolme lukua ja kertoo, mikä niistä on suurin. */

        done:

            Console.WriteLine("ohjelma pyytää käyttäjältä kolme lukua ja kertoo, mikä niistä on suurin:\n");

            // Kysytään käyttäjältä ensimmäistä lukua
            Console.WriteLine("Syötä ensimmäinen luku:");

            // Tarkistetaan, että syöte on kelvollinen double ja kirjoitetaan luvut muuttujiin
            bool validInput1 = int.TryParse(Console.ReadLine(), out int Luku1);

            // Kysytään käyttäjältä toista lukua
            Console.WriteLine("Syötä toinen luku:");

            // Tarkistetaan, että syöte on kelvollinen double ja kirjoitetaan luvut muuttujiin
            bool validInput2 = int.TryParse(Console.ReadLine(), out int Luku2);

            // Kysytään käyttäjältä kolmatta lukua
            Console.WriteLine("Syötä kolmas luku:");

            // Tarkistetaan, että syöte on kelvollinen double ja kirjoitetaan luvut muuttujiin
            bool validInput3 = int.TryParse(Console.ReadLine(), out int Luku3);


            // Tarkistaa onko kelvollinen
            if (validInput1 && validInput2 && validInput3)
            {
                if (Luku1 == Luku2 && Luku2 == Luku3)
                {
                    // Verrataan onko Luku1, Luku2 ja Luku3 yhtäsuuria? ja tulostetaan jos se on:
                    Console.WriteLine($"Ensimmäinen, Toinen ja kolmas luku {Luku1} ovat yhtäsuuria");
                }
                // Verrataan onko Luku1 ja Luku2 yhtäsuuria
                else if (Luku1 == Luku2)
                {
                    // Verrataan onko Luku1 ja Luku2 suurempia kuin Luku3? ja tulostetaan ne jos on:
                    if (Luku2 > Luku3)
                    {
                        Console.WriteLine($"Ensimmäinen ja toinen luku {Luku1} ovat yhtäsuuria ja suurempia kuin kolmas");
                    }
                    else
                    {
                        // Jäljelle jää Luku3? ja tulostetaan se:
                        Console.WriteLine($"Kolmas luku {Luku3} on suurin");
                    }
                }
                // Verrataan onko Luku2 ja Luku3 yhtäsuuria
                else if (Luku2 == Luku3)
                {
                    // Verrataan onko Luku2 ja Luku3 suurempia kuin Luku1? ja tulostetaan ne jos on:
                    if (Luku3 > Luku1)
                    {
                        Console.WriteLine($"Toinen ja kolmas luku {Luku2} ovat yhtäsuuria ja suurempia kuin ensimmäinen");
                    }
                    else
                    {
                        // Jäljelle jää Luku1? ja tulostetaan se:
                        Console.WriteLine($"Ensimmäinen luku {Luku1} on suurin");
                    }
                }
                // Verrataan onko Luku3 ja Luku1 yhtäsuuria
                else if (Luku3 == Luku1)
                {
                    // Verrataan onko Luku3 ja Luku1 suurempia kuin Luku2? ja tulostetaan ne jos on:
                    if (Luku1 > Luku2)
                    {
                        Console.WriteLine($"Ensimmäinen ja kolmas luku {Luku1} ovat yhtäsuuria ja suurempia kuin toinen");
                    }
                    else
                    {
                        // Jäljelle jää Luku2? ja tulostetaan se:
                        Console.WriteLine($"Toinen luku {Luku2} on suurin");
                    }
                }
                else if (Luku1 >= Luku2 && Luku1 >= Luku3)
                {
                    // Verrataan onko Luku1 suurempi kuin Luku2 ja Luku3? ja tulostetaan jos se on:
                    Console.WriteLine($"Ensimmäinen luku {Luku1} on suurin");
                }
                else if (Luku2 >= Luku3)
                {
                    // Verrataan onko Luku2 suurempi kuin Luku3? ja tulostetaan jos se on:
                    Console.WriteLine($"Toinen luku {Luku2} on suurin");
                }
                else
                {
                    // Jäljelle jää Luku3? ja tulostetaan se:
                    Console.WriteLine($"Kolmas luku {Luku3} on suurin");
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

