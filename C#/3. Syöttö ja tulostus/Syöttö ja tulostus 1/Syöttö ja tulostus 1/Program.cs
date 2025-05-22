using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syöttö_ja_tulostus_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.1 Testaa kappaleen koodit. Tee niihin pieniä muutoksia. Lisää muuttujia ja tulostuksia. 

            // Syötteen lukeminen
            Console.WriteLine("Syötä nimesi:");
                // Syötteen kirjoitus
                string name = Console.ReadLine();

            Console.WriteLine("Syötä ikäsi:");
                int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Syötä pituutesi sentteinä:");
                double height = double.Parse(Console.ReadLine());

            // Tulostetaan kaikki syötetyt tiedot
            Console.WriteLine(string.Format("Hei {0}!",name));
            Console.WriteLine($"Ikäsi on {age} vuotta.");
            Console.WriteLine("Pituutesi on " + height/100 + " metriä.");
        }
    }
}
