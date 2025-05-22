using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AarninFunk_1
{
    internal class Program
    {
        static char LastChar(string nimi)
        {
            return nimi[nimi.Length -1];
        }
        static double Positiivi(double luku)
        {
            return (luku < 0) ? -(luku) : luku; // tai return Math.Abs(luku);
        }
        static double Summa(double luku, double luku2)
        {
            return luku + luku2;
        }
        static void Hello(int luku)
        {
            for (int i = 0; i < luku; i++)
            {
                Console.WriteLine("Hello World!");
            }
        }
        static void Tervehdys(string nimi)
        {
            Console.WriteLine($"Terve {nimi}!");
        }
        static void Plus1(double luku)
        {
            Console.WriteLine(luku + 1);
        }
        static void KaksinKerroin(double luku)
        {
            Console.WriteLine(luku + luku);
        }
        static void Auts()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Auts!");
            }
        }
        static void Kutsu()
        { 
            Tervehdys();
        }
        static void Tervehdys()
        {
            Console.WriteLine("Terve maailma!");
        }
        static void Main(string[] args)
        {
            Kutsu();
            Auts();
            KaksinKerroin(3);
            Plus1(3);
            Tervehdys("Aarni");
            Hello(3);
            Console.WriteLine(Summa(5, 3));
            Console.WriteLine(Positiivi(-5));
            Console.WriteLine(LastChar("Aarni"));

        }
    }
}
