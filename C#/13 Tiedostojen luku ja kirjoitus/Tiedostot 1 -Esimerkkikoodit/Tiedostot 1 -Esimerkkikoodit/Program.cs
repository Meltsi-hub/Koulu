using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiedostot_1__Esimerkkikoodit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 13.1. Testaa kappaleen esimerkkikoodit */

            /*1.Kirjoita teksti tiedostoon
                Kirjoita tekstiä tiedostoon käyttämällä File.WriteAllText - metodia. */

                string filePath = "example.txt";
                string content = "Tämä on esimerkki tiedoston kirjoittamisesta.";

            File.WriteAllText(filePath, content);

                Console.WriteLine($"Teksti on kirjoitettu tiedostoon {filePath}\n");

            /* 2. Lue teksti tiedostosta
                  Lue tekstiä tiedostosta käyttämällä File.ReadAllText-metodia.*/


            //string filePath = "example.txt";
            if (File.Exists(filePath))
            {
                string content2 = File.ReadAllText(filePath);
                Console.WriteLine("Tiedoston sisältö:");
                Console.WriteLine($"{content2}\n");
            }
            else
            {
                Console.WriteLine($"Tiedostoa {filePath} ei löytynyt.");
            }

            /* 3. Lisää tekstiä tiedostoon
                  Lisää olemassa olevaan tiedostoon sisältöä File.AppendAllText-metodilla. */


            //string filePath = "example.txt";
            string additionalContent = "\nTämä teksti lisättiin tiedostoon.";

            File.AppendAllText(filePath, additionalContent);

            Console.WriteLine($"Teksti on lisätty tiedostoon {filePath}\n");
 
            /* 4. Lue tiedoston rivit
                  Lue tiedosto rivi kerrallaan käyttäen File.ReadAllLines-metodia. */

            //string filePath = "example.txt";

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                Console.WriteLine("Tiedoston rivit:");

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine($"Tiedostoa {filePath} ei löytynyt.");
            }
            Console.WriteLine("");

            /* 5. Kirjoita tiedostoon käyttäen StreamWriter
                  StreamWriter antaa enemmän kontrollia tiedoston kirjoittamiseen. */

            string filePath2 = "example_stream.txt";

            using (StreamWriter writer = new StreamWriter(filePath2))
            {
                writer.WriteLine("Ensimmäinen rivi.");
                writer.WriteLine("Toinen rivi.");
                writer.WriteLine("Kolmas rivi.");
            }

            Console.WriteLine($"Tiedosto {filePath2} on kirjoitettu.\n");

            /* 6. Lue tiedosto StreamReaderilla
                  StreamReader on hyödyllinen, kun haluat lukea tiedoston rivi kerrallaan. */


            if (File.Exists(filePath2))
            {
                using (StreamReader reader = new StreamReader(filePath2))
                {
                    string line;
                    Console.WriteLine("Tiedoston sisältö rivit kerrallaan:");


                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            else
            {
                Console.WriteLine($"Tiedostoa {filePath2} ei löytynyt.");
            }
            Console.WriteLine("");


            /*7. Kopioi ja poista tiedosto
                 Voit kopioida ja poistaa tiedoston helposti käyttämällä File.Copy ja File.Delete-metodeja.*/


            string sourcePath = "example.txt";
            string destinationPath = "example_copy.txt";

            // Kopioi tiedosto
            if (File.Exists(sourcePath))
            {
                File.Copy(sourcePath, destinationPath, true);
                Console.WriteLine($"Tiedosto kopioitu: {destinationPath}");
            }
            else
            {
                Console.WriteLine($"Lähdetiedostoa {sourcePath} ei löytynyt.");
            }

            // Poista kopioitu tiedosto
            if (File.Exists(destinationPath))
            {
                File.Delete(destinationPath);
                Console.WriteLine($"Tiedosto {destinationPath} poistettu.\n");
            }
        }
    }
}
