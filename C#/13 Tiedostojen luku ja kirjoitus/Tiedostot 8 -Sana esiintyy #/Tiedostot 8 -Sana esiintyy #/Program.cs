using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiedostot_8__Sana_esiintyy__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 13.8. Kirjoita ohjelma, joka:    Lukee tiedoston ja laskee, kuinka monta kertaa tietty sana esiintyy tiedostossa.    Tulostaa esiintymien määrän käyttäjälle.
                     Vinkki: Käytä string.IndexOf ja silmukkaa laskemiseen. */

            string filePath2 = "example_stream.txt";
            string filePath1 = "example_stream2.txt";
            int k = 1;

            using (StreamWriter writer = new StreamWriter(filePath2))
            {
                writer.WriteLine("Ensimmäinen rivi.");
                writer.WriteLine("Toinen rivi.");
                writer.WriteLine("Kolmas rivi.");
                writer.WriteLine("Ensimmäinen rivi.");
                writer.WriteLine("Toinen rivi.");
                writer.WriteLine("Kolmas rivi.");
                writer.WriteLine("Ensimmäinen rivi.");
                writer.WriteLine("Toinen rivi.");
                writer.WriteLine("Kolmas rivi.");
            }

            Console.WriteLine(File.ReadAllText(filePath2));

            if (File.Exists(filePath2))
            {

                using (StreamReader reader = new StreamReader(filePath2))
                {
                    string line;
                    Console.WriteLine("Tiedoston sisältö rivit kerrallaan:");


                    
                        while ((line = reader.ReadLine()) != null)
                        {

                            for (int i = 0; i < line.; i++)
                            {
                                writer.WriteLine($"{k} Tämä on: {line}");

                            }
                            k++;
                        }
                       
                }
            }
            else
            {
                Console.WriteLine($"Tiedostoa {filePath2} ei löytynyt.");
            }
            Console.WriteLine("");
            Console.WriteLine(File.ReadAllText(filePath1));
        }
    }
}
