using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_8__korvaa_arvo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 11.8. Päivitä tietty arvo        Kirjoita ohjelma, joka:     Luo List<string>-listan, jossa on muutama nimi.     Pyytää käyttäjältä nimeä ja uutta nimeä.
                     Korvaa listassa käyttäjän antaman nimen uudella nimellä, jos se löytyy listasta.       Tulostaa päivitetyn listan. */

            List<string> nimet = new List<string>() { "Keijo", "Pekka", "Riikka", "Liisa", "Anna", "Matti" };  //Luodaan lista arvoilla "Anna", "Matti", "Liisa", "Pekka"
            int index = -1;

            Console.Write("Ohjelma pyytää käyttäjältä nimeä listasta ja uutta nimeä ja korvaa listassa käyttäjän antaman nimen uudella nimellä, jos se löytyy tulostaa päivitetyn listan:\n");

            Console.Write("\nListalla olevat nimet: ");
            foreach (string nimi in nimet) //käyttää foreach listan tulostukseen
            {
                Console.Write($"{nimi}, ");
            }


            Console.WriteLine($"\n\nAnna muutettava nimi");  // Annetaan listasta haettava nimi

            string arvo = Console.ReadLine(); //Käyttäjä antaa korvattavan nimen

            index = nimet.FindIndex(x => x == arvo);    //Etsitään haettavan nimen indexi

            if (index < 0)  //Totta jos nimeä ei löydy ja indexi on silloin -1
            {
                Console.WriteLine($"\nAntamaasi nimeä {arvo} ei ole listassa\n");  // Nimeä ei löytynyt
            }
            else
            {
                Console.WriteLine($"\nAnna uusi nimi");  // Annetaan listaan talletettavan luvun arvo

                string uusiArvo = Console.ReadLine(); //Käyttäjä antaa uuden nimen

                nimet.RemoveAt(index);  //Poistaa vanhan nimen
                nimet.Insert(index, uusiArvo);  //Lisää uuden nimen

                Console.WriteLine("");

                foreach (string nimi in nimet) //käyttää foreach listan tulostukseen
                {
                    Console.Write($"{nimi} ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
