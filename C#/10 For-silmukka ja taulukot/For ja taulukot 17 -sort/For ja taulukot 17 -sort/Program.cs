using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_ja_taulukot_17__sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 10.17. Kirjoita ohjelma, joka järjestää taulukon luvut pienimmästä suurimpaan.       Array.Sort(... */

            int[,] matriisi = new int[3, 3];  // 3 riviä, 3 saraketta
            int k = 1;
            int h = 0;
            int[] luvut = new int[9];

            // Arvojen asettaminen
            for (int i = 2; i >= 0; i--)
            {
                for (int j = 2; j >= 0; j--)
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

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    luvut[h] = matriisi[i, j];  // Kirjoitetaan luvut matriisista taulukkoon
                    h++;
                }
            }
            Array.Sort(luvut);   // Järjestää taulukon luvut pienimmästä suurimpaan
            Console.WriteLine($"");

            k = 0; // Nollataan k
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriisi[i, j] = luvut[k];  // Kirjoitetaan luvut  taulukosta matriisiin
                    k++;
                }
            }

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
