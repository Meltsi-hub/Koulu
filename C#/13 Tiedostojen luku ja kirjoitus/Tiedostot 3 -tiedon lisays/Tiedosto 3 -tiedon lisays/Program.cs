using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Tiedosto_3__tiedon_lisays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*13.3. Kirjoita ohjelma, joka:    Lukee tiedoston rivit.    Lisää jokaisen rivin alkuun rivin numeron (esim. "1: Tämä on ensimmäinen rivi").    Kirjoittaa muutetut rivit uuteen tiedostoon.
                    Vinkki: Käytä StreamReader ja StreamWriter.*/

            string filePath2 = "example_stream.txt";
            string filePath1 = "example_stream2.txt";
            int k = 1;

            using (StreamWriter writer = new StreamWriter(filePath2))
            {
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


                    using (StreamWriter writer = new StreamWriter(filePath1))
                    {
                        while ((line = reader.ReadLine()) != null)
                        {
                            
                            for (int i = 0; i < 1; i++)
                            {
                                writer.WriteLine($"{k} Tämä on: {line}");
                               
                            }
                            k++;
                        }
                        writer.Close();
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
