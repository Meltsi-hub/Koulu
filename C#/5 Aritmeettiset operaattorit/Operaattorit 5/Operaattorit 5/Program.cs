using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaattorit_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 5.5 Kirjoita ohjelma, joka pyytää käyttäjältä kokonaislukua.Tarkista, onko luku:

            parillinen vai pariton(%),  jaollinen 3:lla(%).
            Esim:       Syötä luku: 15      Onko luku parillinen? Ei        Onko luku jaollinen 3:lla? Kyllä */


            const int JAKAJA2 = 2;
            const int JAKAJA3 = 3;

            // Kysytään käyttäjältä kokonaislukua
            Console.WriteLine("Anna kokonaislukua:");

            // Tarkistetaan, että syöte on kelvollinen int ja kirjoitetaan luku muuttujaan
            bool validInput1 = int.TryParse(Console.ReadLine(), out int Luku1);



            // Tarkistaa onko kelvollinen
            if (validInput1)
            {
                // Tarkastetaan, onko luku: parillinen vai pariton(%) ja onko se jaollinen 3:lla(%) ja tulostetaan
                Console.WriteLine($"Onko luku parillinen? {(0 == (Luku1 % JAKAJA2) ? "Kyllä" : "Ei")}\nOnko luku jaollinen 3:lla? {((Luku1 % JAKAJA3) == 0 ? ((Luku1) != 0 ? "Kyllä" : "Ei") : "Ei")}");
            }
            else
            {
                // Jos syöte ei ollut kelvollinen luku
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }
        }
    }
}
