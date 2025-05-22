using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_ja_switch_10__laskin_switch_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 7.10. Kirjoita ohjelma, joka pyytää käyttäjältä kaksi lukua ja laskutoimituksen (+, -, *, /) sekä suorittaa valitun laskutoimituksen. */

            bool poistu = false;
            do
            {
                Console.WriteLine("\nAnna ensimmäinen luku:");

                bool validInput1 = int.TryParse(Console.ReadLine(), out int luku1);   // Tarkistetaan, että syöte on kelvollinen int ja kirjoitetaan luku muuttujaan

                if (validInput1)    // Tarkistaa onko kelvollinen
                {

                    Console.WriteLine("\nValitse toiminto:");
                    Console.Write("(+) Plus  ");
                    Console.Write("(-) Miinus   ");
                    Console.Write("(*) Kerto    ");
                    Console.Write("(/) Jako     ");
                    Console.WriteLine("(q) Poistu   \n");


                    Console.Write("Syötä valinta: ");
                    string choice = Console.ReadLine();


                    switch (choice)
                    {
                        case "+":
                            Console.WriteLine("\nAnna toinen luku:");

                            bool validInput2 = int.TryParse(Console.ReadLine(), out int luku2);   // Tarkistetaan, että syöte on kelvollinen int ja kirjoitetaan luku muuttujaan
                            if (validInput2)    // Tarkistaa onko kelvollinen
                            {
                                double summa = luku1 + luku2;

                                Console.WriteLine($"\nLukujen {luku1} ja {luku2} summa on {summa}:");
                            }
                            else
                            {
                                Console.WriteLine("\nVirheellinen syöte. Anna kelvollinen luku.");  // Jos syöte ei ollut kelvollinen luku
                            }
                            break;

                        case "-":
                            Console.WriteLine("\nAnna toinen luku:");

                            bool validInput3 = int.TryParse(Console.ReadLine(), out int luku3);   // Tarkistetaan, että syöte on kelvollinen int ja kirjoitetaan luku muuttujaan
                            if (validInput3)    // Tarkistaa onko kelvollinen
                            {
                                double erotus = luku1 + luku3;

                                Console.WriteLine($"\nLukujen {luku1} ja {luku3} erotus on {erotus}:");
                            }
                            else
                            {
                                Console.WriteLine("\nVirheellinen syöte. Anna kelvollinen luku.");  // Jos syöte ei ollut kelvollinen luku
                            }
                            break;

                        case "*":
                            Console.WriteLine("\nAnna toinen luku:");

                            bool validInput4 = int.TryParse(Console.ReadLine(), out int luku4);   // Tarkistetaan, että syöte on kelvollinen int ja kirjoitetaan luku muuttujaan
                            if (validInput4)    // Tarkistaa onko kelvollinen
                            {
                                double tulo = luku1 * luku4;

                                Console.WriteLine($"\nLukujen {luku1} ja {luku4} tulo on {tulo}:");
                            }
                            else
                            {
                                Console.WriteLine("\nVirheellinen syöte. Anna kelvollinen luku.");  // Jos syöte ei ollut kelvollinen luku
                            }
                            break;

                        case "/":
                            Console.WriteLine("\nAnna toinen luku:");

                            bool validInput5 = int.TryParse(Console.ReadLine(), out int luku5);   // Tarkistetaan, että syöte on kelvollinen int ja kirjoitetaan luku muuttujaan
                            if (validInput5)    // Tarkistaa onko kelvollinen
                            {
                                double osamaara = luku1 + luku5;

                                Console.WriteLine($"\nLukujen {luku1} ja {luku5} osamäärä on {osamaara}:");
                            }
                            else
                            {
                                Console.WriteLine("\nVirheellinen syöte. Anna kelvollinen luku.");  // Jos syöte ei ollut kelvollinen luku
                            }
                            break;

                        case "q":
                            poistu = true;
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
