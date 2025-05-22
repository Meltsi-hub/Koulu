using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_ja_switch_5__arvosana_0_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*7.5. Kirjoita ohjelma, joka tarkistaa käyttäjän antaman pistemäärän ja määrittää arvosanan asteikolla 0–100.
             * 0-40 = hylätty, 41-55 = 1, 56-70 = 2, 71-85 = 4, 86-100 = 5*/

            Console.WriteLine("Tarkistaa käyttäjän antaman pistemäärän 0-100 ja kertoo arvosanasi asteikolla hylätty–5:\n");

            Console.WriteLine("\nAnna saamasi pisteet väliltä 0-100:");

            bool validInput1 = int.TryParse(Console.ReadLine(), out int pisteet);   // Tarkistetaan, että syöte on kelvollinen int ja kirjoitetaan luku muuttujaan

            if (validInput1)    // Tarkistaa onko kelvollinen
            {
                if (pisteet >= 0 && pisteet <= 30)
                {
                    Console.WriteLine($"\nValitettavasti sait hylätyn\n");
                }
                else if (pisteet >= 31 && pisteet <= 45)  
                {
                    Console.WriteLine($"\nSaamasi arvosana on 1\n");
                }
                else if (pisteet >= 46 && pisteet <= 60)  
                {
                    Console.WriteLine($"\nSaamasi arvosana on 2\n");
                }
                else if (pisteet >= 61 && pisteet <= 75)
                {
                    Console.WriteLine($"\nSaamasi arvosana on 3\n");
                }
                else if (pisteet >= 76 && pisteet <= 90)
                {
                    Console.WriteLine($"\nSaamasi arvosana on 4\n");
                }
                else if (pisteet >= 91 && pisteet <= 100)
                {
                    Console.WriteLine($"\nSaamasi arvosana on 5\n");
                }
                else
                {
                    Console.WriteLine($"\nVirheellinen pistemäärä\n");
                }
                //toinentapa
                Console.WriteLine(
                      (pisteet >=  0 && pisteet <= 30) ? "\nValitettavasti sait hylätyn\n" 
                    : (pisteet >= 31 && pisteet <= 45) ? "\nSaamasi arvosana on 1\n" 
                    : (pisteet >= 46 && pisteet <= 60) ? "\nSaamasi arvosana on 2\n" 
                    : (pisteet >= 61 && pisteet <= 75) ? "\nSaamasi arvosana on 3\n" 
                    : (pisteet >= 76 && pisteet <= 90) ? "\nSaamasi arvosana on 4\n" 
                    : (pisteet >= 91 && pisteet <= 100) ? "\nSaamasi arvosana on 5\n" : "\nVirheellinen pistemäärä\n");
            }
            else
            {
                Console.WriteLine("\nVirheellinen syöte. Anna kelvollinen luku.");  // Jos syöte ei ollut kelvollinen luku
            }
        }
    }
}
