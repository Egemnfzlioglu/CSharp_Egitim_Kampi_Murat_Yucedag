using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If_ELse

            /*
            Console.Write("Lütfen Şifreyi Giriniz : ");

            string password;
            password = Console.ReadLine();
            if (password == "abcd")
            {
                Console.WriteLine("Şifre Doğru");

            }
            else
            {
                Console.WriteLine("Şifre Yanlış");
            }

            */


            /*
            string capital, country;
            Console.Write("Başkenti Girinin : ");
            capital = Console.ReadLine();

            Console.Write("Ülkeyi Giriniz : ");
            country = Console.ReadLine();

            if (capital=="ankara"&country=="türkiye")
            {
                Console.WriteLine("veriler doğrulandı");
            }
            else
            {
                Console.WriteLine("hatalı bilgi");
            }
            */

            /*
            int number;

            Console.Write("Sayıyı Giriniz : ");
            number = int.Parse(Console.ReadLine());


            if (number == 5)
            {
                Console.WriteLine("sayi dogru");

            }
            else
            {
                Console.WriteLine("sayı yanlış");
            }
            */

            /*
            int exam1, exam2, exam3, average;

            string result="hata";

            Console.Write("Sınav 1 : ");
            exam1 = int.Parse(Console.ReadLine());

            Console.Write("Sınav 2 : ");
            exam2 = int.Parse(Console.ReadLine());

            Console.Write("Sınav 3 : ");
            exam3 = int.Parse(Console.ReadLine());

            average = (exam1 + exam2 + exam3) / 3;

            Console.WriteLine("Sınavların Ortalaması : " + average);


            if (average > 0 & average <= 50)
            {
                result = "Sonuç Vasat !";
            }

            if (average > 50 & average <= 70)
            {
                result = "Sonuç Orta !";
            }

            if (average > 70 & average <= 84)
            {
                result = "Sonuç İyi !";
            }

            if (average > 84 & average <= 100)
            {
                result = "Sonuç Çok İyi !";
            }

            Console.WriteLine(result);

            */

            /*
            string city;

            Console.Write("Lütfen Şehir Girişi Yapınız : ");
            city = Console.ReadLine();

            if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            {
                Console.WriteLine("Şehir Mevcut");

            }
            else
            {
                Console.WriteLine("Şehir Mevcut Değil");
            }

            */



            /*
            Console.Write("Lütfen Kullanıcı Adını Giriniz : ");
            string username=Console.ReadLine();

            if (username!="admin")
            {
                Console.WriteLine("bu kullanıcı adı kabul edilemez");
            }
            else
            {
                Console.WriteLine("Hoşgeldiniz ! ");
            }

            */





            #endregion


            #region Mod_İşlemleri
            /*
            int number;
            number = 26;
            int result = number % 5;
            */

            /*
            Console.Write("Lütfen 1. Sayıyı Giriniz : ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen 2. Sayıyı Giriniz : ");
            int number2 = int.Parse(Console.ReadLine());


            int result = number1 % number2;

            Console.WriteLine("1. sayının 2. sayıya bölümden kalan : " + result);
            */

            /*
            Console.Write("lütfen sayıyı giriniz : ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("sayı çift");
            }
            else
            {
                Console.WriteLine("sayı tek");
            }

            */
            #endregion


            #region Char_Değişkenler_İle_Karar_Yapıları
            /*
            char team;
            Console.Write("lütfen takım sembolunu gırınız : ");

            team=char.Parse(Console.ReadLine());

            if(team == 'g' | team == 'G')
            {
                Console.Write("Galatasaray");
            }

            if (team == 'f' | team == 'F')
            {
                Console.Write("Fenerbahçe");
            }

            if (team == 'b' | team == 'B')
            {
                Console.Write("Beşiktaş");
            }

            */

            #endregion


            #region Örnek_Proje_Uygulaması

            /*
            Console.WriteLine("*** C# Egıtım Kampı Resoran *** ");
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1-Ana Yemekler");
            Console.WriteLine("2-Çorbalar");
            Console.WriteLine("3-Pizzalar");
            Console.WriteLine("4-İçeçekler");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("--------------------------------");
            Console.WriteLine();



            Console.Write("detayını gormek ıstedıgınız menuyu secınız : ");

            string menuItem;
            menuItem = Console.ReadLine();

            if (menuItem == "1")
            {
                Console.WriteLine();
                Console.Write("----------");
                Console.Write("Ana Yemekler");
                Console.Write("----------");
                Console.WriteLine();
                Console.WriteLine("1-köri soslu tavuk");
                Console.WriteLine("2-kızartma tabağı");
                Console.WriteLine("3-fasulye pilav");
                Console.WriteLine("4-fırında somon");
                Console.WriteLine("5-patlıcan musakka");

                Console.Write("----------");
                Console.Write("Ana Yemekler");
                Console.Write("----------");


            }

            if (menuItem == "2")
            {
                Console.WriteLine();
                Console.Write("----------");
                Console.Write("Çorbalar");
                Console.Write("----------");
                Console.WriteLine();
                Console.WriteLine("1-mercimek ");
                Console.WriteLine("2-ezogelin");

                Console.Write("----------");
                Console.Write("Çorbalar");
                Console.Write("----------");


            }

            if (menuItem == "3")
            {
                Console.WriteLine();
                Console.Write("----------");
                Console.Write("Pizzalar");
                Console.Write("----------");
                Console.WriteLine();
                Console.WriteLine("1-akdeniz pizza ");
                Console.WriteLine("2-margaritha");

                Console.Write("----------");
                Console.Write("Pizzalar");
                Console.Write("----------");


            }

            if (menuItem == "4")
            {
                Console.WriteLine();
                Console.Write("----------");
                Console.Write("İçeçekler");
                Console.Write("----------");
                Console.WriteLine();
                Console.WriteLine("1-kola ");
                Console.WriteLine("2-ayran");
                Console.WriteLine("3-su");

                Console.Write("----------");
                Console.Write("İçeçekler");
                Console.Write("----------");


            }
           
            if (menuItem == "5")
            {
                Console.WriteLine();
                Console.Write("----------");
                Console.Write("Tatlılar");
                Console.Write("----------");
                Console.WriteLine();
                Console.WriteLine("1-trilice ");
                Console.WriteLine("2-kazandibi");
                Console.WriteLine("3-sütlaç");

                Console.Write("----------");
                Console.Write("Tatlılar");
                Console.Write("----------");


            }
            */

            #endregion


            #region Switch_Case
            /*
            Console.Write("lütfen ay girişi yapınız : ");

            int monthNumber =int.Parse(Console.ReadLine());


            switch (monthNumber)
            {
                case 1:
                    Console.WriteLine("ocak");
                    break;
                case 2:
                    Console.WriteLine("şubat");
                    break;
                case 3:
                    Console.WriteLine("mart");
                    break;

                case 4:
                    Console.WriteLine("nisan");
                    break;

                case 5:
                    Console.WriteLine("mayıs");
                    break;

                case 6:
                    Console.WriteLine("haziran");
                    break;
                case 7:
                    Console.WriteLine("temmuz");
                    break;

                case 8:
                    Console.WriteLine("agustos");
                    break;
                case 9:
                    Console.WriteLine("eylül");
                    break;
                case 10:
                    Console.WriteLine("ekim");
                    break;

                case 11:
                    Console.WriteLine("kasım");
                    break;
                case 12:
                    Console.WriteLine("aralık");
                    break;


                default:
                    Console.WriteLine("hatalı veri girişi");
                    break;
            }

            */
            #endregion


            #region Switch_Case_Hesap_Makinesi



            int number1, number2, result;
            char symbol;

            Console.Write("1. sayıyı gırınız : ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("2. sayıyı gırınız : ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("işlemi gırınız : ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("sonuç : " + result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine("sonuç : " + result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("sonuç : " + result);
                    break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine("sonuç : " + result);
                    break;
                case '%':
                    result = number1 % number2;
                    Console.WriteLine("sonuç : " + result);
                    break;
                default:
                    break;
            }





            #endregion






            Console.Read();













        }
    }
}
