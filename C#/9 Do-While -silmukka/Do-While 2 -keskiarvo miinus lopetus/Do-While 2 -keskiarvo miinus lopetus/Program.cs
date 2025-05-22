using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_2__keskiarvo_miinus_lopetus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 9.2. Kirjoita ohjelma, joka laskee käyttäjän syöttämien positiivisten lukujen keskiarvon. Lopeta, kun käyttäjä syöttää negatiivisen luvun. */

            Console.WriteLine("Laskee käyttäjän syöttämien positiivisten lukujen keskiarvon:");
            Console.WriteLine("\nOhjelma tulostaa vastauksen, kun annat negatiivisen luvun:\n");

            double keskiarvo;
            double summa = 0;
            int arvo;
            int jako = 0;

            do
            {
                Console.WriteLine("\nAnna positiivinen luku:");

                bool validInput1 = int.TryParse(Console.ReadLine(), out int arvo1);   // Tarkistetaan, että syöte on kelvollinen int ja kirjoitetaan luku muuttujaan
                arvo = arvo1;

                if (validInput1)    // Tarkistaa onko kelvollinen
                {
                    if (arvo >= 0)
                    {
                        summa = summa + arvo;
                        jako++;
                    }
                }
                else
                {
                    Console.WriteLine("\nVirheellinen syöte. Anna kelvollinen luku.");  // Jos syöte ei ollut kelvollinen luku
                }
            }
            while (arvo >= 0);  // Jatketaan, jos syöte ei ole kelvollinen

            keskiarvo = summa / jako;   // Lasketaan keskiarvo
            Console.WriteLine($"\nAnnoit {jako} lukua, joiden keskiarvo on {keskiarvo}\n");
        }
    }
}
