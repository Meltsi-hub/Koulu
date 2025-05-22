using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_11__Kauppa_lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 11.11. Simuloi kauppalista   Kirjoita ohjelma, joka:     Luo List<string>-listan, johon käyttäjä voi lisätä tuotteita (kauppalista).
                      Mahdollistaa tuotteiden lisäämisen, poistamisen ja listan tulostamisen.     Lopettaa toiminnan, kun käyttäjä valitsee "poistu"-vaihtoehdon. */

            List<string> kauppalista = new List<string>();  //Luodaan tyhjä lista 
            bool poistu = false;

            Console.Write("Voit lisätä, poistaa tuotteita ja tulostaa kauppalistan käskyillä:\n");

            while (poistu == false)
            {
                Console.Write("\n(lisää)(poista)(tulosta) tai poistua (poistu)\n");

                Console.WriteLine($"\nAnna komento");  // Annetaan listasta haettava nimi

                string arvo = Console.ReadLine(); //Käyttäjä antaa Käskyn

                switch (arvo)
                {
                    case "lisää":
                        Console.WriteLine($"\nAnna lisättävän tuotteen nimi:");  // Annetaan listasta haettava nimi

                        string lisaa = Console.ReadLine(); //Käyttäjä antaa korvattavan nimen
                        kauppalista.Add(lisaa);  //Lisää uuden nimentulosta
                        break;

                    case "poista":

                        Console.WriteLine($"\nAnna poistettavan tuotteen nimi:");  // Annetaan listasta haettava nimi

                        string poisto = Console.ReadLine(); //Käyttäjä antaa korvattavan nimen

                        int index = -1;
                        index = kauppalista.FindIndex(x => x == poisto);    //Etsitään haettavan nimen indexi

                        if (index < 0)  //Totta jos nimeä ei löydy ja indexi on silloin -1
                        {
                            Console.WriteLine($"\nAntamaasi nimeä {arvo} ei ole listassa\n");  // Nimeä ei löytynyt
                        }
                        else
                        {

                            kauppalista.RemoveAt(index);  //Poistaa vanhan nimen
                        }
                        Console.WriteLine($"");
                        break;

                    case "tulosta":
                        Console.WriteLine($"");
                        foreach (string nimi in kauppalista) //käyttää foreach listan tulostukseen
                        {
                            Console.WriteLine($"{nimi}");
                        }
                        break;
                    case "poistu":
                        poistu = true;
                        Console.WriteLine($"");
                        break;
                    default:
                        Console.WriteLine($"\nAntamaasi komento on väärin\n");  // Nimeä ei löytynyt
                        break;
                }
            }
        }
    }
}
