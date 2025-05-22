using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaattorit_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 5.9 Kirjoita ohjelma, joka tarkistaa, onko käyttäjän syöttämä piste suorakulmion sisällä. Käytä vertailuoperaattoreita.

            Suorakulmio määritellään vakioilla:        vasenX = 0, oikeaX = 10, yläY = 10, alaY = 0        Pyydä käyttäjältä pisteen koordinaatit x ja y.

            Esim:   Syötä pisteen x: 5      Syötä pisteen y: 8      Piste on suorakulmion sisällä: Kyllä */

            const int VASEN_X = 0;
            const int OIKEA_X = 10;
            const int YLA_Y = 10;
            const int ALA_Y = 0;

            Console.WriteLine("Ohjelma tarkistaa, onko käyttäjän syöttämä piste suorakulmion sisällä\n");

            // Kysytään käyttäjältä x:n arvo
            Console.WriteLine("Syötä x:n kordinaatti:");

            // Tarkistetaan, että syöte on kelvollinen double ja kirjoitetaan totuusarvo muuttujaan
            bool validInput1 = double.TryParse(Console.ReadLine(), out double X);

            // Kysytään käyttäjältä y:n arvo
            Console.WriteLine("Syötä y:n koordinaatti:");

            // Tarkistetaan, että syöte on kelvollinen bool ja kirjoitetaan totuusarvoa muuttujaan
            bool validInput2 = double.TryParse(Console.ReadLine(), out double Y);


            // Tarkistaa onko kelvollinen
            if (validInput1 && validInput2)
            {
                // Tulostaa ja antaa true vain jos molempien totuusarvojen tila on true, muuten false
                Console.WriteLine($"Piste on suorakulmion sisällä: {(VASEN_X <= X && X <= OIKEA_X ? (ALA_Y <= Y && Y <= YLA_Y ? "Kyllä" : "Ei") : "Ei")}");

            }
            else
            {
                // Jos syöte ei ollut kelvollinen luku
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }
        }
    }
}
