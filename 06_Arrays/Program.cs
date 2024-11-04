using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {



            #region Temel_Dizi_Örnekleri

            /*

            string[] colors = new string[4];


            colors[0] = "kırmızı";
            colors[1] = "sarı";
            colors[2] = "beyaz";
            colors[3] = "mavi";

            Console.WriteLine(colors[2]);


            string[] cities = new string[5];

            cities[0] = "milano";
            cities[1] = "budapeste";
            cities[2] = "lyon";
            cities[3] = "kahire";
            cities[4] = "üsküp";

            Console.WriteLine(cities[4]);
          



            int[] numbers = new int[10];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[7] = 4;

            Console.WriteLine(numbers[7]);


            */











            #endregion

            #region dizideki tüm elemanları listeleme
            /*
            string[] colors =
            {
                "sarı",
                "kırmızı",
                "beyaz",
                "mavi",
                "yeşil",
                "turuncu",
                "pembe"
            };


            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine(colors[i]);
            }
           */




            /*
            string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };

            Console.WriteLine(persons.Length);
            */


            /*
            int[] numbers = { 1123, 2123, 312123, 31234, 41235, 11236, 237 };

            Array.Sort(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            */

            /*
            int[] numbers = { 1123, 2123, 312123, 31234, 41235, 11236, 237 };

            Array.Reverse(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            */


            #endregion

            #region dizi metodları
            /*
            string[] customers =
            {
                "ali",
                "buse",
                "aysegül",
                "çınar",
                "merve",
                "kaya",

            };

            int index = Array.IndexOf(customers, "merve");

            Console.WriteLine(index);
            */
            /*

            int[] numbers = { 1123, 2123, 312123, 31234, 41235, 11236, 237 };
            Console.WriteLine("dizinin en büyük elemanı : " + numbers.Max());
            Console.WriteLine("dizinin en küçük elemanı : " + numbers.Min());

            */


            #endregion

            #region kullanıcıdan değer alma
            /*
            string[] cities = new string[5];

            for (int i = 0; i < cities.Length; i++)
            {
                Console.Write($"lütfen {i + 1}. şehri giriniz : ");
                cities[i] = Console.ReadLine();
            }


            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < cities.Length; i++) {
                Console.WriteLine(cities[i]);
            }
            */




            #endregion





            Console.Read();
        }
    }
}
