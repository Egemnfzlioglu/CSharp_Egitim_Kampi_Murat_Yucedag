using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For_Döngüsü

            /*
            int i;

            for (i= 1; i < 5; i++)
            {
                Console.WriteLine("C# Egitim Kampı");
            }

            */

            /*
              for (int i = 3; i < 50; i += 3)
              {
                  Console.WriteLine(i);
              }

              */

            /*
            Console.Write("Ekrana yazılmasını istediğiniz adedi giriniz : ");

            int finishValue = int.Parse(Console.ReadLine());
            for (int i = 0; i <= finishValue; i++)
            {
                Console.WriteLine("Yaşasın Cumhuriyet");
            }
            */



            #endregion


            #region For_Döngüsüyle_Karar_Yapıları
            /*
            for (int i = 0; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            */
            /*
            int bacterium = 1;

            for (int i = 0; i < 24; i++)
            {
                bacterium *= 2;
                Console.WriteLine(i + ". Saat Sonunda : " + bacterium);
            }
            */
            #endregion


            #region While_Döngüsü
            /*
            int i = 1;

            while (i <= 10)
            {
                Console.WriteLine("Merhaba Döngüler");
                i++;
            }

            */
            #endregion


            #region Örnek_Sınav_Sorusu

            Console.Write("Sayıyı Giriniz : ");
            int number = int.Parse(Console.ReadLine());

            int ones, tens, hundreds;
            int sum;

            ones = number % 10;
            hundreds = number / 100;

            tens = (number % 100) / 10;

            Console.WriteLine(ones + " + " + tens + " + " + hundreds);

            sum = ones + tens + hundreds;

            Console.WriteLine("= " + sum);
            #endregion


            Console.Read();
        }
    }
}
