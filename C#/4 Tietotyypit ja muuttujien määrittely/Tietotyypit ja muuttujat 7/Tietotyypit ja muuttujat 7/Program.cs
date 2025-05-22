using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tietotyypit_ja_muuttujat_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 4.7 Pyydä käyttäjältä sekuntien määrä ja laske, kuinka monta tuntia, minuuttia ja sekuntia tämä vastaa.*/


            // Määritellään Tuntien ja minuuttien jakajat vakioksi
            const int TUNNIT = 3600;
            const int MINUUTIT = 60;


            // Kysytään käyttäjältä sekunteina aika, jonka haluat muuntaa tunneiksi, minuuteiksi ja sekunneiksi
            Console.WriteLine("Ohjelma muuntaa antamasi sekunnit muotoon: tunnit, minuutit ja sekunnit \nAnna aika sekunteina:");

            // Tarkistetaan, että syöte on kelvollinen double ja kirjoitetaan putoamisaika muuttujaan
            bool validInput1 = double.TryParse(Console.ReadLine(), out double Input);


            // Tarkistaa onko kelvollinen
            if (validInput1)
            {
                // Selvitetään tuntien määrä
                int Tunnit = (int)(Input / TUNNIT);

                // Otetaan jakojäännös tunneista ja talletetaan se uutena Inputtina
                Input = Input % TUNNIT;

                // Selvitetään minuuttien määrä jakojäännöksestä
                int Minuutit = (int)(Input / MINUUTIT);

                // Otetaan jakojäännös Minuuteista ja talletetaan se uutena Inputtina
                Input = Input % MINUUTIT;

                // Jäljelle jää sekunttien määrä
                int Sekunnit = (int)Input;

                // Tulostetaan muunnos tunteina, minuutteina ja sekuntteina kolmella tavalla
                Console.WriteLine($"{Tunnit} Tuntia, {Minuutit} Minuuttia ja {Sekunnit} Sekunttia");
                Console.WriteLine((Tunnit) + " Tuntia, " + (Minuutit) + " Minuuttia ja " + (Sekunnit) + " Sekunttia");
                Console.WriteLine(string.Format("{0} Tuntia, {1} Minuuttia ja {2} Sekunttia", Tunnit, Minuutit, Sekunnit));

            }
            else
            {
                // Jos syöte ei ollut kelvollinen luku
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }

        }
    }
}
