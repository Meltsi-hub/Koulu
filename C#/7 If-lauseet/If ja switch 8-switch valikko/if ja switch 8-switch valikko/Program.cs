using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_ja_switch_8_switch_valikko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 7.8. Kirjoita ohjelma, joka näyttää yksinkertaisen valikon ja suorittaa valitun toiminnon.
                    Esim:               Console.WriteLine("Valitse toiminto:");
                                        Console.WriteLine("1. Matematiikka");
                                        Console.WriteLine("2. Ohjelmointi");
                                        Console.WriteLine("3. Poistu"); */

            Console.WriteLine("Valitse toiminto:");
            Console.WriteLine("1. Matematiikka");
            Console.WriteLine("2. Ohjelmointi");
            Console.WriteLine("3. Poistu");

            Console.Write("Syötä valinta: ");
            int choice = int.Parse(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    Console.WriteLine("Matematiikan koe");
                    break;
                case 2:
                    Console.WriteLine("Ohjelmoinnin koe");
                    break;
                case 3:
                    Console.WriteLine("Ohjelma suljetaan.");
                    break;
                default:
                    Console.WriteLine("Virheellinen valinta.");
                    break;
            }
        }
    }
}
