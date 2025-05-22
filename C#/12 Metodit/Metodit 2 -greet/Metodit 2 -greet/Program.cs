using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodit_2__greet
{
    internal class Program
    {
        static void Greet(string nimi)
        {
            Console.WriteLine($"Hei, {nimi}!");
        }
        static void Main(string[] args)
        {
            /* 12.2. Kirjoita metodi Greet, joka ottaa vastaan käyttäjän nimen ja tulostaa tervehdyksen. */

            Console.WriteLine("Anna nimesi");

            Greet(Console.ReadLine());
        }
    }
}
