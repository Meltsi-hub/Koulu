using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merkkijonot_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Merkkijonot

        Merkkijonojen käsittely on keskeinen osa C#-ohjelmointia.

        Merkkijonon luominen
        Merkkijonot luodaan käyttäen " " - lainausmerkkejä. */

            string greeting = "Hello, World!";
            Console.WriteLine(greeting);


            /* Merkkijonojen yhdistäminen

        Merkkijonoja voi yhdistää(concatenate) käyttämällä + -operaattoria tai string.Concat() - metodia. */

            string firstName = "John";
            string lastName = "Doe";
            string fullName = $"{firstName} {lastName}";
            Console.WriteLine(fullName);

            string str0 = "Ice";
            string str1 = " cream";

            // concatenates str0 and str1
            string result1 = String.Concat(str0 ,"  ", str1);
            Console.WriteLine(result1);


            /*Merkkijonon pituus
        Merkkijonon pituuden saa Length-ominaisuudella. */

            string text = "Hello, World!";

            Console.WriteLine(text.Length);
            string part = text.Substring(7, 5);  // "World"
            Console.WriteLine(part);



            /* Merkkijonon muokkaaminen
        C#:ssa on useita metodeja merkkijonon muokkaamiseen:

        Muuttaminen pieniksi ja isoiksi kirjaimiksi: */

            string text1 = "Hello";
            Console.WriteLine(text1.ToUpper());  // "HELLO"
            Console.WriteLine(text1.ToLower());  // "hello"
            Console.WriteLine($"{text1}");


            //trimmaaminen(poistetaan välilyönnit alusta ja lopusta):

            string text2 = "   Hello, World!   ";
            Console.WriteLine(text2.Trim());  // "Hello, World!"

                /*Merkkijonon etsiminen ja korvaaminen
            Etsiminen: */
            string text3 = "Hello, World!";
            
            // mitä tarkastetaan, Mistä indexistä aloitetaan, ja kuinka monta indexiä käydään läpi
            int index = text3.IndexOf("o", 1, 4);  // 4

            int index2 = text3.LastIndexOf("o");  // 8
            Console.WriteLine(index);
            Console.WriteLine(index2);
            
            //Korvaaminen:
            string text4 = "I like apples";
            string newText = text4.Replace("apples", "oranges");
            Console.WriteLine(newText);  // "I like oranges"



                /*Merkkijonojen jakaminen(Split) ja yhdistäminen(Join) */

            Console.Write("Syötä sanat yhdellä rivillä (esim. 'kissa koira hevonen'): ");
            //string input = "Syötä sanat yhdellä rivillä (esim. 'kissa koira hevonen'): ";

            string input = Console.ReadLine();
            //String.Concat(input, " ", input2);

            string[] words = input.Split(' ');
            //Console.WriteLine($"{words}");

            string result = string.Join(" ", words); // Yhdistä sanat välilyönnillä
            Console.WriteLine($"Yhdistetty merkkijono: {result}");

                /* Interpolointi
            Interpolointi(string interpolation) on moderni tapa luoda merkkijonoja.Se on luettava ja helppo ymmärtää.*/

            string name = "John";
            int age = 25;


            string message = $"My name is {name} and I am {age} years old.";
            Console.WriteLine(message);



                /*Escape - merkit
            Jos haluat käyttää erikoismerkkejä, kuten rivinvaihtoa(\n), käytä escape-merkkejä:*/

            string text5 = "First line\nSecond line";
            Console.WriteLine(text5);



                /* Merkkijonojen käsittely ilman muotoiluja(verbatim strings)
            Verbatim - merkkijonot(@) mahdollistavat moniriviset ja erityismerkkien helpomman käytön: */

            string path = @"C:\Users\Public\Documents";
            Console.WriteLine(path);



                /* Merkkijonot ja muuttumattomuus(immutability)
            C#:ssa merkkijonot ovat muuttumattomia. Kaikki muokkaustoiminnot luovat uuden merkkijonon. Tätä varten kannattaa käyttää StringBuilder-luokkaa, jos tehdään paljon muokkauksia.

            StringBuilder - luokka C#:ssa on erityisen hyödyllinen, kun halutaan käsitellä suuria määriä merkkijonoja tehokkaasti.
            Toisin kuin tavalliset merkkijonot, StringBuilder-objektit ovat muokattavissa, mikä tarkoittaa, että ne eivät luo uusia olioita jokaisen muutoksen yhteydessä.
            Tämä tekee StringBuilder-luokasta suorituskykyisemmän suurten tekstimanipulaatioiden yhteydessä.

            Voit käyttää Append, Insert ja Replace -metodeja tekstin lisäämiseen ja muokkaamiseen. */

            //using System.Text;

            StringBuilder sb = new StringBuilder("Hei maailma!");


            // Lisää tekstiä loppuun
            sb.Append(" Kuinka voit?");

            // Lisää tekstiä tiettyyn kohtaan
            sb.Insert(4, "kaunis ");


            // Korvaa tekstiä
            sb.Replace("Hei", "Terve");


            Console.WriteLine(sb.ToString());


            // Voit poistaa osia tekstistä Remove - metodilla.
            // StringBuilder sb = new StringBuilder("Terve maailma!");

            sb.Remove(6, 7); // Poistaa "maailma!" (alkaa indeksistä 6, 7 merkkiä)

            Console.WriteLine(sb.ToString());
        }
    }
}
