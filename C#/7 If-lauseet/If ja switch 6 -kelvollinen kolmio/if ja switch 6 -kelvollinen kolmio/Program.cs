using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_ja_switch_6__kelvollinen_kolmio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*7.6. Kirjoita ohjelma, joka tarkistaa, muodostavatko kolme käyttäjän syöttämää sivun pituutta kelvollisen kolmion.
                   Kahden sivun yhteinen pituus pitää olla suurempi kuin kolmannen sivun pituus. */

            Console.WriteLine("tarkistaa, muodostavatko kolme käyttäjän syöttämää sivun pituutta kelvollisen kolmion:");
            Console.WriteLine("\nKahden sivun yhteinen pituus pitää olla suurempi kuin kolmannen sivun pituus:\n");

            Console.WriteLine("\nAnna kolmion ensimmäinen sivu:");

            bool validInput1 = int.TryParse(Console.ReadLine(), out int sivu1);   // Tarkistetaan, että syöte on kelvollinen int ja kirjoitetaan luku muuttujaan
            Console.WriteLine("\nAnna kolmion toinen sivu:");

            bool validInput2 = int.TryParse(Console.ReadLine(), out int sivu2);   // Tarkistetaan, että syöte on kelvollinen int ja kirjoitetaan luku muuttujaan
            Console.WriteLine("\nAnna kolmion kolmas sivu:");

            bool validInput3 = int.TryParse(Console.ReadLine(), out int sivu3);   // Tarkistetaan, että syöte on kelvollinen int ja kirjoitetaan luku muuttujaan

            if (validInput1 || validInput2 || validInput3)    // Tarkistaa onko kelvollinen
            {
                if (sivu1 > 0 && sivu2 > 0 && sivu3 > 0)    // Tarkastaa ettei sivun pituus ole nolla tai miinus merkkinen
                {
                    if (sivu3 < (sivu1 + sivu2) && sivu2 < (sivu1 + sivu3) && sivu1 < (sivu3 + sivu2))  // Tarkastaa, että kahden sivun yhteinen pituus on suurempi kuin kolmannen sivun pituus
                    {
                        Console.WriteLine($"\nAnnoit kelvollisen kolmion mitat\n");
                    }
                    else
                    {
                        Console.WriteLine($"\nAntamasi sivut eivät luo kelvollista kolmiota\n");
                    }
                }
                else
                {
                    Console.WriteLine($"\nSivun pituus ei voi olla nolla tai pienempi\n");
                }
            }
            else
            {
                Console.WriteLine("\nVirheellinen syöte. Anna kelvollinen luku.");  // Jos syöte ei ollut kelvollinen luku
            }
        }
    }
}
