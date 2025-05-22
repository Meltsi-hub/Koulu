using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_ja_switch_13__kolmion_muoto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 7.13. Kirjoita ohjelma, joka ottaa käyttäjältä kolmen sivun pituudet ja tarkistaa, onko kolmio tasakylkinen, tasasivuinen, suorakulmainen vai epäsäännöllinen. */

            bool poistu = false;
            do
            {
                Console.WriteLine("\nOhjelma ottaa käyttäjältä kolmen sivun pituudet ja tarkistaa, onko kolmio tasakylkinen, tasasivuinen, suorakulmainen vai epäsäännöllinen:\n");

                Console.WriteLine("\nAnna kolmion ensimmäisen sivun pituus:");

                bool validInput1 = int.TryParse(Console.ReadLine(), out int sivu1);   // Tarkistetaan, että syöte on kelvollinen int ja kirjoitetaan luku muuttujaan

                if (sivu1 == -1)
                {
                    break;
                }
                    
                Console.WriteLine("\nAnna kolmion toisen sivun pituus:");

                bool validInput2 = int.TryParse(Console.ReadLine(), out int sivu2);   // Tarkistetaan, että syöte on kelvollinen int ja kirjoitetaan luku muuttujaan

                Console.WriteLine("\nAnna kolmion kolmannen sivun pituus:");

                bool validInput3 = int.TryParse(Console.ReadLine(), out int sivu3);   // Tarkistetaan, että syöte on kelvollinen int ja kirjoitetaan luku muuttujaan

                if (validInput1 && validInput2 && validInput3)    // Tarkistaa onko kelvollinen
                {
                    if ((sivu1 + sivu2) <= sivu3 || (sivu2 + sivu3) <= sivu1 || (sivu1 + sivu3) <= sivu2 || sivu1 <= 0 || sivu2 <= 0 || sivu3 <= 0)
                    {
                        Console.WriteLine($"\nEi ole kolmio:");
                    }
                    else
                    {
                        switch (sivu1)
                        {
                            case int n when (n == sivu2 && sivu2 == sivu3):
                                Console.WriteLine($"\nTasasivuinen kolmio:");
                                break;

                            case int n when ((n ^ 2 + sivu2 ^ 2) == (sivu3 ^ 2) || (sivu2 ^ 2 + sivu3 ^ 2) == (n ^ 2) || ((n ^ 2) + (sivu3 ^ 2)) == (sivu2 ^ 2)):
                                Console.WriteLine($"\nSuorakulmainen kolmio:");
                                break;

                            case int n when (n == sivu2 || sivu2 == sivu3 || n == sivu3):
                                Console.WriteLine($"\nTasakylkinen kolmio:");
                                break;
                        }
                        if (sivu1 != sivu2 && sivu2 != sivu3 && sivu1 != sivu3)
                        {
                            Console.WriteLine($"\nEpäsäännöllinen kolmio:");
                        }
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
