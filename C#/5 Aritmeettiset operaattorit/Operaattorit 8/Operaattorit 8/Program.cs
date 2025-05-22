using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaattorit_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 5.8 Kirjoita ohjelma, joka pyytää käyttäjältä kolmea kokonaislukua. Tarkista seuraavilla ehdoin:

            Onko kaikki luvut kasvavassa järjestyksessä?    Onko kaikki luvut laskevassa järjestyksessä?    Ovatko kaikki luvut samoja?    Käytä loogisia ja vertailuoperaattoreita.

            Esim:   Syötä ensimmäinen luku: 3   Syötä toinen luku: 5    Syötä kolmas luku: 7    Kasvava järjestys: Kyllä    Laskeva järjestys: Ei   Kaikki samat: Ei */

            

            // Kysytään käyttäjältä ensimmäistä lukua
            Console.WriteLine("Syötä ensimmäinen luku:");

            // Tarkistetaan, että syöte on kelvollinen double ja kirjoitetaan luvut muuttujiin
            bool validInput1 = int.TryParse(Console.ReadLine(), out int Luku1);

            // Kysytään käyttäjältä toista lukua
            Console.WriteLine("Syötä toinen luku:");

            // Tarkistetaan, että syöte on kelvollinen double ja kirjoitetaan luvut muuttujiin
            bool validInput2 = int.TryParse(Console.ReadLine(), out int Luku2);

            // Kysytään käyttäjältä kolmatta lukua
            Console.WriteLine("Syötä kolmas luku:");

            // Tarkistetaan, että syöte on kelvollinen double ja kirjoitetaan luvut muuttujiin
            bool validInput3 = int.TryParse(Console.ReadLine(), out int Luku3);


            // Tarkistaa onko kelvollinen
            if (validInput1 && validInput2)
            {
                // Verrataan onko kaikki luvut yhtä suuria? ja tulostetaan
                Console.WriteLine($"Kaikki samoja: {(Luku1 == Luku2 ? (Luku1 == Luku3 ? "Kyllä" : "Ei") : "Ei")}");

                // Verrataan onko kaikki luvut kasvavassa järjestyksessä? ja tulostetaan
                Console.WriteLine($"Kasvava järjestys: {(Luku1 < Luku2 ? (Luku2 < Luku3 ? "Kyllä" : "Ei") : "Ei")}");

                // Verrataan onko kaikki luvut laskevassa järjestyksessä? ja tulostetaan
                Console.WriteLine($"Laskeva järjestys: {(Luku1 > Luku2 ? (Luku2 > Luku3 ? "Kyllä" : "Ei") : "Ei")}");

                /*// Verrataan ja tulostetaan Onko ensimmäinen luku pienempi?
                Console.WriteLine($"Onko ensimmäinen pienempi? {(Luku1 < Luku2 ? "Kyllä" : "Ei")}");

                // Verrataan ja tulostetaan Onko ensimmäinen luku pienempi?
                Console.WriteLine($"Onko ensimmäinen pienempi? {(Luku1 < Luku2 ? "Kyllä" : "Ei")}");

                // Verrataan ja tulostetaan Onko ensimmäinen luku pienempi?
                Console.WriteLine($"Onko ensimmäinen pienempi? {(Luku1 < Luku2 ? "Kyllä" : "Ei")}");*/
            }
            else
            {
                // Jos syöte ei ollut kelvollinen luku
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }
        }
    }
}
