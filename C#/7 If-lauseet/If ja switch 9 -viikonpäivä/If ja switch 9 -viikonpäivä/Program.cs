using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_ja_switch_9__viikonpäivä
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 7.9. Kirjoita ohjelma, joka ottaa numeron 1–7 ja tulostaa vastaavan viikonpäivän. */

            bool poistu = false;

            Console.WriteLine("Ohjelma, joka ottaa numeron 1–7 ja tulostaa vastaavan viikonpäivän:  syötä (0) kun haluat poistua:\n");

            do
            {

                Console.Write("Syötä luku:");

                bool validInput1 = int.TryParse(Console.ReadLine(), out int luku);   // Tarkistetaan, että syöte on kelvollinen int ja kirjoitetaan luku muuttujaan

                if (validInput1)    // Tarkistaa onko kelvollinen
                {
                    switch (luku)
                    {
                        case 1:
                            Console.WriteLine("\nMaanantai\n");
                            break;

                        case 2:
                            Console.WriteLine("\nTiistai\n");
                            break;

                        case 3:
                            Console.WriteLine("\nKeskiviikko\n");
                            break;

                        case 4:
                            Console.WriteLine("\nTorstai\n");
                            break;

                        case 5:
                            Console.WriteLine("\nPerjantai\n");
                            break;

                        case 6:
                            Console.WriteLine("\nLauantai\n");
                            break;

                        case 7:
                            Console.WriteLine("\nSunnuntai\n");
                            break;

                        case 0:
                            poistu = true;
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
