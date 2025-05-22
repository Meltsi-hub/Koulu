using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_4__etsi_nimi_listasta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 11.4. Etsi nimi listasta     Kirjoita ohjelma, joka:     Luo List<string>-listan, jossa on muutama nimi, esim. "Anna", "Matti", "Liisa", "Pekka".
             * Pyytää käyttäjältä nimeä.        Tarkistaa, onko nimi listassa, ja tulostaa vastaavan viestin. */

            List<string> nimet = new List<string>() { "Anna", "Matti", "Liisa", "Pekka" };  //Luodaan lista arvoilla "Anna", "Matti", "Liisa", "Pekka"

            Console.WriteLine("Ohjelma Luo string-listan, jossa on nimet Anna, Matti, Liisa ja Pekka. Pyytää käyttäjältä nimeä ja tarkistaa, onko nimi listassa, ja tulostaa vastaavan viestin:");

            Console.WriteLine($"\nAnna haettava nimi\n");  // Kysytään listaan talletettavaa nimeä

            string haeNimi = Console.ReadLine(); //Käyttäjä antaa haettavan nimen

            bool vertaa = nimet.Contains(haeNimi);

            Console.WriteLine((vertaa == true) ? $"\n{haeNimi} löytyi\n" : "\nNimeä ei löytynyt\n");
        }
    }
}
