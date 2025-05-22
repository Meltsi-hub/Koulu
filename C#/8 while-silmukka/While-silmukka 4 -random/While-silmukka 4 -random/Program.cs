using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_silmukka_4__random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 8.4. Kirjoita ohjelma, joka pyytää käyttäjää arvaamaan salaisen luvun (1–100).
             * Ohjelma antaa vihjeitä ("liian suuri" tai "liian pieni"), kunnes arvaus on oikein.

             * Random rand = new Random();         int secretNumber = rand.Next(1, 101); */

            Random rand = new Random();
            int secretNumber = rand.Next(1, 101);

        done:
            Console.WriteLine("Yritä arvata salainen luku (1–100).\nSaat vihjeitä (liian suuri tai pieni), kunnes arvaat oikein:\n");
            int Arvaus = 0;
            while (secretNumber != Arvaus)  // Ehto: silmukka jatkuu niin kauan kuin i on enintään 100
            {
                Console.WriteLine("Arvaa luku:\n");

                // Tarkistetaan, että syöte on kelvollinen int ja kirjoitetaan luku muuttujaan
                bool validInput1 = int.TryParse(Console.ReadLine(), out int Arvaus2);

                Arvaus = Arvaus2;
                
                // Tarkistaa onko kelvollinen
                if (validInput1)
                {
                    if (Arvaus <= 0 || Arvaus >= 101)
                    {
                        Console.WriteLine("Arvaus ulkona arvaus alueelta\n");
                        goto done;
                    }

                    if (secretNumber < Arvaus)
                    {
                        Console.WriteLine($"{Arvaus} on liian suuri\n");//Tulostetaan kun totta

                    }
                    else if (secretNumber > Arvaus)
                    {
                        Console.WriteLine($"{Arvaus} on liian pieni\n");//Tulostetaan kun totta
                    }

                }
                else
                {
                    // Jos syöte ei ollut kelvollinen luku
                    Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.\n");
                    goto done;
                }
            }
            Console.WriteLine($"Onneksi olkoon voitit!!! Vastaus oli {Arvaus}\n");
        }
    }
}
