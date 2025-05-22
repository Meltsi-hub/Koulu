using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_1__salasana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 9.1. Kirjoita ohjelma, joka kysyy käyttäjältä salasanaa, kunnes käyttäjä syöttää oikean salasanan. */

            Console.WriteLine("Kysyy käyttäjältä salasanaa, kunnes käyttäjä syöttää oikean salasanan:");

            string salasana = "Kullervo";
            string sana;

            do
            {
                Console.Write("\nAnna salasana: ");
                sana = Console.ReadLine();
            }
            while (salasana != sana);  // Jatketaan, jos syöte ei ole kelvollinen

            Console.WriteLine($"\nSalasana oikein\n");
        }
    }
}
