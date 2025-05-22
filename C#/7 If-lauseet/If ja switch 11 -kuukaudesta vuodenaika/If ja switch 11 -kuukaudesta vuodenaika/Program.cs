using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_ja_switch_11__kuukaudesta_vuodenaika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 7.11. Kirjoita ohjelma, joka pyytää kuukauden numeron ja tulostaa siihen liittyvän vuodenajan. */

            bool poistu = false;

            Console.WriteLine("Ohjelma pyytää kuukauden numeron ja tulostaa siihen liittyvän vuodenajan:  syötä (0) kun haluat poistua:\n");

            do
            {

                Console.Write("Syötä luku:");

                bool validInput1 = int.TryParse(Console.ReadLine(), out int luku);   // Tarkistetaan, että syöte on kelvollinen int ja kirjoitetaan luku muuttujaan

                if (luku == 0)
                {
                    poistu = true;
                    break;
                }

                if (validInput1)    // Tarkistaa onko kelvollinen
                {
                    switch (luku)
                    {
                        case int n when (n == 1 || n == 2 || n == 12):
                            Console.WriteLine("\nTalvi\n");
                            break;

                        case int n when (n >= 3 && n <= 5):
                            Console.WriteLine("\nKevät\n");
                            break;

                        case int n when (n >= 6 && n <= 8):
                            Console.WriteLine("\nKesä\n");
                            break;

                        case int n when n >= 9 && n <= 11:
                            Console.WriteLine("\nSyksy\n");
                            break;

                        default:
                            Console.WriteLine("\nVirheellinen valinta.\n");
                            break;
                    }
                    //Tapa 2
                    switch (luku)
                    {
                        case 12:
                        case 1:
                        case 2:
                            Console.WriteLine("\nTalvi\n");
                            break;

                        case 3:
                        case 4:
                        case 5:
                            Console.WriteLine("\nKevät\n");
                            break;

                        case 6:
                        case 7:
                        case 8:
                            Console.WriteLine("\nKesä\n");
                            break;

                        case 9:
                        case 10:
                        case 11:
                            Console.WriteLine("\nSyksy\n");
                            break;

                        default:
                            Console.WriteLine("\nVirheellinen valinta.\n");
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
