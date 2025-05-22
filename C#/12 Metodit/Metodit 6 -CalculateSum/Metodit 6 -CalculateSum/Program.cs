using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodit_6__CalculateSum
{
    internal class Program
    {
        static int CalculateSum(int[] numerot)
        {
            int summa = 0;
            for (int j = 0; j < numerot.Length; j++) // j alustetaan, ehto tarkistetaan ja kasvatetaan yhdellä, sekä luodaan taulukko käyttäjän arvoilla
            {
                summa = summa + numerot[j];  // Taulukkoon talletettavan luvun random arvo
            }
            return summa;
        }
        static void PrintArray(int[] numerot)
        {
            for (int j = 0; j < numerot.Length; j++) // j alustetaan, ehto tarkistetaan ja kasvatetaan yhdellä, sekä luodaan taulukko käyttäjän arvoilla
            {
                Console.Write($"{numerot[j]}, ");  // Taulukkoon talletettavan luvun random arvo
                
            }
            Console.WriteLine($"");
        }
        static int[] MakeArray(int[] numerot)
        {
            Random rand2 = new Random();
            for (int j = 0; j < numerot.Length; j++) // j alustetaan, ehto tarkistetaan ja kasvatetaan yhdellä, sekä luodaan taulukko käyttäjän arvoilla
            {
                int Luku = rand2.Next(1, 101);  // Taulukkoon talletettavan luvun random arvo
                numerot[j] = Luku;              // Talletetaan luku taulukkoon
            }
            return numerot;
        }
        static void Main(string[] args)
        {
            /* 12.6. Kirjoita metodi CalculateSum, joka saa parametrina kokonaislukutaulukon ja palauttaa sen summan. */

            Random rand = new Random();
            int Indexer = rand.Next(10, 21);   // taulukon koon random arvo
            int[] numerot = new int[Indexer]; ; //luodaan taulukkoon 50-100 indeksiä

            numerot = MakeArray(numerot);
           
            Console.WriteLine("Ohjelma saa parametrina kokonaislukutaulukon ja palauttaa sen summan.\n");

            PrintArray(numerot);

            int summa = CalculateSum(numerot);

            Console.WriteLine($"\nKokonaislukutaulukon lukujen summa {summa}\n");
        }
    }
}
