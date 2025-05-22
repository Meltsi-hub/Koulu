using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace For_ja_taulukot_14__etsi_luku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 10.14.extra. Kirjoita ohjelma, joka tarkistaa, löytyykö tietty luku taulukosta. Extrana luo random taulukon luvut ja indexien määrän */

        reroll:
            Random rand = new Random();
            int Indexer = rand.Next(50, 101);   // taulukon koon random arvo
            int[] numerot = new int[Indexer]; ; //luodaan taulukkoon 50-100 indeksiä
            Random rand2 = new Random();
            bool Found = false;

            Console.WriteLine("Ohjelma luo taulukon, jonka koko ja luvut on randomisoitu, ja tarkistaa löytyykö käyttäjän antama luku taulukosta:\n");

            for (int j = 0; j < numerot.Length; j++) // j alustetaan, ehto tarkistetaan ja kasvatetaan yhdellä, sekä luodaan taulukko käyttäjän arvoilla
            {
                
                int Luku = rand2.Next(1, 101);  // Taulukkoon talletettavan luvun random arvo
                numerot[j] = Luku;              // Talletetaan luku taulukkoon
            }
        gotoExpression:

            Console.WriteLine("Anna etsittävä kokonaisluku väliltä 1-100:"); // Kysytään käyttäjältä kokonaislukua
            //Console.WriteLine("Tai 101 arpoo taulukon arvot uudestaan"); 

            bool validInput1 = int.TryParse(Console.ReadLine(), out int Luku1); // Tarkistetaan, että syöte on kelvollinen int ja kirjoitetaan annettu luku muuttujaan
            Console.WriteLine($"");

            if ( Luku1 == 101)    // Jos tosi 101 arpoo uudet arvot
            {
                goto reroll;    // Hyppää ohjelman alkuun
            }

            if (validInput1)    // Tarkistaa onko kelvollinen
            {
                if (Luku1 <= 0 || Luku1 >= 102)    // Jos annettu luku on alle 1 tai yli 102 suorita
                {
                    Console.WriteLine("Arvaus ulkona arvaus alueelta\n");
                    goto gotoExpression;    // Hyppää luvun kyselyyn
                }
                for (int i = 0; i < numerot.Length; ++i)  // i alustetaan, ehto tarkistetaan ja kasvatetaan yhdellä
                {
                    if (Luku1 == numerot[i])    // Verrataan käyttäjän lukua taulukon lukuun
                    {
                        int Index = i;
                        Console.WriteLine($"Antamasi luku {Luku1} löytyi indexistä {Index}\n"); //tulostaa löydetyn luvun ja taulukon indeksin
                        Found = true;   // Totta, jos luku/lukuja löytyi
                    }
                }
                if (Found == false)    // Totta, jos ei löytynyt
                {
                    Console.WriteLine($"Antamaasi lukua {Luku1} ei löytynyt\n"); //tulostaa tiedon ettei lukua löytynyt
                    Console.WriteLine($"Yritä uudelleen\n"); //tulostaa tiedon ettei lukua löytynyt
                    goto gotoExpression;    // Hyppää luvun kyselyyn
                }
                
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.\n");    // Jos syöte ei ollut kelvollinen luku
                goto gotoExpression;    // Hyppää luvun kyselyyn
            }
        }
    }
}
