using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace While_silmukka_7__vuosikorko
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            /* 8.7.  Kirjoita ohjelma, joka laskee säästetyn summan ja koron vuosittain, kunnes säästö ylittää tavoitesumman. */

            Console.OutputEncoding = Encoding.Default;

            Console.WriteLine("Laskee säästetyn summan ja koron vuosittain, kunnes säästö ylittää tavoitesumman:\n");

            Console.WriteLine("\nAnna alkupääoma:\n");

            // Tarkistetaan, että syöte on kelvollinen double ja kirjoitetaan luku muuttujaan
            bool validInput1 = double.TryParse(Console.ReadLine(), out double pOma);

            Console.WriteLine("\nAnna korko prosentteina:\n");

            // Tarkistetaan, että syöte on kelvollinen double ja kirjoitetaan luku muuttujaan
            bool validInput2 = double.TryParse(Console.ReadLine(), out double korko);
            Console.WriteLine("\nAnna tavoitesumma:\n");

            // Tarkistetaan, että syöte on kelvollinen double ja kirjoitetaan luku muuttujaan
            bool validInput3 = double.TryParse(Console.ReadLine(), out double tSumma);

            Console.WriteLine("");

            korko = korko / 100;

            int vuosi = 0;
            // Tarkistaa onko kelvollinen
            if (validInput1 && validInput2 && validInput3)
            {
                if (pOma <= tSumma)
                {
                    while (pOma <= tSumma)  // Ehto: silmukka jatkuu niin kauan kuin korotettu pääoma on pienempi kuin tavoite summa
                    {
                        vuosi = vuosi + 1;
                        double korkoSumma = pOma * korko;
                        pOma = pOma + korkoSumma;
                        Console.WriteLine($"{vuosi} vuoden jälkeen pääomaan lisätään {String.Format("{0:F2}", korkoSumma)}€ ja uusi pääoma on {String.Format("{0:F2}", pOma)}€\n");//Tulostetaan vuosittaiset tulokset
                    }
                }
                else
                {

                }
            }
            else
            {
                // Jos syöte ei ollut kelvollinen luku
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.\n");
            }
            Console.WriteLine($"Tavoitesumman {String.Format("{0:F2}", tSumma)}€ saavuttamiseen meni {NumberToWords(vuosi)} vuotta, ja lopullinen pääoma on {String.Format("{0:F2}", pOma)}€\n");//Tulostetaan lopullinen tulos
        }
        public static string NumberToWords(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "nolla", "yksi", "kaksi", "kolme", "neljä", "viisi", "kuusi", "seitsemän", "kahdeksan", "yhdeksän", "kymmenen", "yksitoista", "kaksitoista", "kolmetoista", "neljätoista", "viisitoista", "kuusitoista", "seitsemäntoista", "kahdeksantoista", "yhdeksäntoista" };
                var tensMap = new[] { "nolla", "kymmenen", "kaksikymmentä", "kolmekymmentä", "neljäkymmentä", "viisikymmentä", "kuusikymmentä", "seitsemänkymmentä", "kahdeksankymmentä", "yhdeksänkymmentä" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "" + unitsMap[number % 10];
                }
            }

            return words;
        }
    }
}
