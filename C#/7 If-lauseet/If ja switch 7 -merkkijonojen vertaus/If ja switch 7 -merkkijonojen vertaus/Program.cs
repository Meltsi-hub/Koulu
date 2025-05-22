using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace If_ja_switch_7__merkkijonojen_vertaus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 7.7. Kirjoita ohjelma, joka tarkistaa, ovatko kaksi käyttäjän syöttämää merkkijonoa samoja. */

            Console.WriteLine("Ohjelma tarkistaa, ovatko kaksi käyttäjän syöttämää tekstiä samoja (kirjain koolla ei ole väliä):\n");

            Console.WriteLine($"Anna teksti\n");  // Kysytään tekstiä

            string teksti = Console.ReadLine(); //Käyttäjä antaa tekstiä

            Console.WriteLine($"\nAnna verrattava teksti\n");  // Kysytään tekstiä uudestaan

            string vertaa = Console.ReadLine(); //Käyttäjä antaa tekstin uudestaan

            Console.WriteLine(teksti.Equals(vertaa, StringComparison.OrdinalIgnoreCase) ? $"\nSyöttämäsi tekstit ovat samoja\n" : "\nSyöttämäsi tekstit eivät ole samoja\n");
        }
    }
}
