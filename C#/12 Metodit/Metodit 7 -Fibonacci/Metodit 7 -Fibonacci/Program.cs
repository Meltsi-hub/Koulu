using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodit_7__Fibonacci
{
    internal class Program
    {
        static int Fibonacci(int n)
        {
            int i = 0;
            int uusi = 1;
            int vanha = 0;
            int vara = 0;
            int fibo = 0;

            while (i <= n)  // Ehto: silmukka jatkuu niin kauan kuin i on enintään 10
            {
                
                fibo = vanha;
                vara = uusi;
                uusi = uusi + vanha;
                vanha = vara;

                i++;
            }
            return fibo;
        }
        static int[] FiboArray(int n)
        {
            int[] numerot = new int[Math.Abs(n) + 1]; //luodaan taulukkoon n indeksiä
            int i = 0;
            int uusi = 1;
            int vanha = 0;
            int vara;

            while (i <= Math.Abs(n))  // Ehto: silmukka jatkuu niin kauan kuin i on enintään 10
            {

                numerot[i] = vanha;
                vara = uusi;
                uusi = uusi + vanha;
                vanha = vara;

                i++;
            }
            return numerot;
        }
            static void PrintArray(int[] numerot)
        {
            Console.WriteLine($"");
            for (int j = 0; j < numerot.Length; j++) // j alustetaan, ehto tarkistetaan ja kasvatetaan yhdellä, sekä luodaan taulukko käyttäjän arvoilla
            {
                Console.Write($"{numerot[j]}, ");  // Taulukkoon talletettavan luvun random arvo

            }
            Console.WriteLine($"\n");
        }
        static void Main(string[] args)
        {
            /* 12.7. Kirjoita metodi Fibonacci, joka palauttaa Fibonacci-sarjan n:nnen luvun. */

            do
            {
                Console.WriteLine("Ohjelma palauttaa Fibonacci-sarjan n:nnen luvun. Anna (0) poistuaksesi:\n");

                Console.WriteLine("Anna n kerroin\n");

                bool validInput1 = int.TryParse(Console.ReadLine(), out int n);

                if (n == 0) { break; }

                if (n > 0) { int fibo = Fibonacci(n); Console.WriteLine($"\n{n}. fibonacci luku on {fibo}\n"); }

                if (n < 0) { int[] numerot = FiboArray(n); PrintArray(numerot);}
            }
            while (true);
        }
    }
}
