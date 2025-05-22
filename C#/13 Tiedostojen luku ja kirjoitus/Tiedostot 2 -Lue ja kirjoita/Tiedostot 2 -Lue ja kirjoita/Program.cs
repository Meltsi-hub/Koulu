using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiedostot_2__Lue_ja_kirjoita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 13.2. Kirjoita ohjelma, joka:    Lukee tiedoston sisällön.   Kirjoittaa saman sisällön uuteen tiedostoon nimeltä kopio.txt.  Vinkki: Käytä File.ReadAllText ja File.WriteAllText. */

            string filePath = "example.txt";
            string filePath2 = "kopio.txt";

            string content = "tämä teksti on example.txt tiedostossa";
            string content2;

            File.WriteAllText(filePath, content);

            if (File.Exists(filePath))
            {
                content = File.ReadAllText(filePath);
                Console.WriteLine("Tiedoston sisältö:");
                Console.WriteLine($"{content}\n");

                File.WriteAllText(filePath2, content);
                content2 = File.ReadAllText(filePath2);

                Console.WriteLine($"Teksti on kirjoitettu tiedostoon {filePath2}\n");
                Console.WriteLine($"{filePath2} tiedostossa on nyt {content2}\n");
            }
            else
            {
                Console.WriteLine($"Tiedostoa {filePath} ei löytynyt.");
            }
        }
    }
}
