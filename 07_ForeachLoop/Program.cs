﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Foreach Döngüsü
            /*
            foreach(1;2;3;4)
            
            1: değişken türü
            2:değişken adı
            3:In
            4:liste,koleksıyon:dizi

             */

            /*
            string[] cities =
            {
                "milano","roma","budapeste","ankara","istanbul","varşova"
            };


            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }
            */

            /*
            int[] numbers = {45,78,985,635,74,11,22,33,41,205,6578,10394 };


            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            */

            /*
            int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };


            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }
            
             */

            /*
            int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            int total = 0;

            foreach (int i in numbers)
            {
                total += i;
            }
            Console.WriteLine(total);
            */


            /*
            List<int> numbers = new List<int>()
            {
                1, 2, 3, 4, 5, 8
            };

           // Console.WriteLine(numbers);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            */




            #endregion

            #region Örnek sınav sistemi uygulaması


            Console.WriteLine("**** C# Eğitim Kampı Sınav Uygulaması ****");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("----------------------------------------");

            Console.Write("Sınıfınızda Kaç Öğrenci Var : ");
            int studentCount = int.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];


            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}.öğrencinin ismini giriniz : ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz : ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;

                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("----------------------------------------");

                Console.WriteLine($"{studentNames[i]} adlı öğrencının ortalaması : {studentExamAvg[i]}");

                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                }
                else {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi kaldı");

                }

                Console.WriteLine("----------------------------------------");
                Console.WriteLine();

            }








            #endregion




            Console.Read();

        }
    }
}