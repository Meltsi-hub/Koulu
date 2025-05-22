using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_ja_taulukot_16__2d_taulukko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 10.16. Kirjoita ohjelma, joka tallentaa kaksiulotteiseen taulukkoon seuraavat rivit ja tulostaa ne:
                    1  2  3
                    4  5  6
                    7  8  9 */

            int[,] matriisi = new int[3, 3];  // 3 riviä, 3 saraketta
            int k = 1;

            // Arvojen asettaminen
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriisi[i, j] = k;
                    k++;
                }
            }
            // Matriisin läpikäyminen
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Matriisi[{i},{j}] = {matriisi[i, j]}");
                }
            }
            Console.WriteLine($"");
            //Muotoilu
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{matriisi[i, j]} ");
                }
                Console.WriteLine($"");
            }
            Console.WriteLine($"");
        }
    }
}
