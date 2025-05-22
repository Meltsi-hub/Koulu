using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_silmukka_8__korko_korolle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 10.8. Kirjoita ohjelma, joka laskee säästetyn summan arvon korkoa korolle laskettuna 10 vuoden ajan, jos korkoprosentti on 5%. */

            Console.WriteLine("ohjelma laskee säästetyn summan arvon korkoa korolle laskettuna 10 vuoden ajan, jos korkoprosentti on 5%:\n");

            const double KORKO = 0.05;
            double summa = 1000;
            double arvo = summa;

            for (int i = 1; i <= 10; ++i)  // i alustetaan, ehto tarkistetaan ja kasvatetaan yhdellä
            {
                arvo = arvo + (arvo * KORKO); // Laskee vuosittaisen lisäyksen

                Console.WriteLine($"Vuosi {i} korotettu summa {String.Format("{0:F2}", arvo)}\n"); //tulostaa säästetty summa vuosittain
            }
            Console.WriteLine($"Voittoa kymmenen vuoden jälkeen {String.Format("{0:F2}", arvo - summa)}\n"); //tulostaa paljonko voittoa sait kymmenessä vuodessa
        }
    }
}
