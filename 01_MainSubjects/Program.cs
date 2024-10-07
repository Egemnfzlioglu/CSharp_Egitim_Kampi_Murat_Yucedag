using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region YazdırmaKomutları

            /*
            Console.WriteLine("Merhaba Dünya");

            Console.WriteLine("*** Yemek Kategorileri ***");
            Console.WriteLine();
            Console.WriteLine("1-Çorbalar");
            Console.WriteLine("2-Ana Yemekler");
            Console.WriteLine("3-Soğuk Başlangıçlar");
            Console.WriteLine("4-Salatalar");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("6-İçeçekler");
            Console.WriteLine();
            */

            #endregion



            #region String Değişkenler
            /*
            string name;
            name = "egemen";
            Console.WriteLine(name);
            */
            /*
            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail,district,city;

            customerName = "ali";
            customerSurname = "çınar";
            customerPhone = "+90 500 400 30 20";
            customerEmail = "deneme@gmail.com";
            district = "kadiköy";
            city = "istanbul";

            Console.WriteLine();

            Console.WriteLine("*** Rezervasyon Kartı ***");

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(
                "Müşteri = " +
                customerName.Substring(0, 1).ToUpper() +
                customerName.Substring(1).ToLower() +
                " " +
                customerSurname.ToUpper());
            Console.WriteLine("İletişim = " + customerPhone);
            Console.WriteLine("Email = " + customerEmail);
            Console.WriteLine("Adres = " + district + "/" + city);
            Console.WriteLine("-------------------------------------------");




            customerName = "aysegul";
            customerSurname = "kaya";
            customerPhone = "+90 500 400 50 05";
            customerEmail = "deneme2@gmail.com";
            district = "sapanca";
            city = "sakarya";





            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine(
                "Müşteri = " +
                customerName.Substring(0, 1).ToUpper() +
                customerName.Substring(1).ToLower() +
                " " +
                customerSurname.ToUpper());
            Console.WriteLine("İletişim = " + customerPhone);
            Console.WriteLine("Email = " + customerEmail);
            Console.WriteLine("Adres = " + district + "/" + city);
            Console.WriteLine("-------------------------------------------");
            */
            #endregion





            #region Int Değişkenler
            /*
            int number = 24;
            Console.WriteLine(number);
            */

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;


            Console.WriteLine("*** restoran Menu ***");
            Console.WriteLine();
            Console.WriteLine("---hamburger : " + hamburgerPrice + " TL");
            Console.WriteLine("---pizza : " + pizzaPrice + " TL");
            Console.WriteLine("---kola : " + cokePrice + " TL");
            Console.WriteLine("---limonata : " + lemonadePrice + " TL");
            Console.WriteLine("---kızartma : " + friesPrice + " TL");
            Console.WriteLine("---su : " + waterPrice + " TL");


            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemoadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;



            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemoadeCount = 0;


            totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            totalCokePrice = cokePrice * cokeCount;
            totalWaterPrice = waterPrice * waterCount;
            totalFriesPrice = friesPrice * friesCount;
            totalPizzaPrice = pizzaPrice * pizzaCount;
            totalLemonadePrice = lemonadePrice * lemoadeCount;



            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Hamburger Tutarı : " + totalHamburgerPrice + " TL");
            Console.WriteLine("Pizza Tutarı : " + totalPizzaPrice + " TL");
            Console.WriteLine("Kızartma Tutarı : " + totalFriesPrice + " TL");
            Console.WriteLine("Kola Tutarı : " + totalCokePrice + " TL");
            Console.WriteLine("limonata Tutarı : " + totalLemonadePrice + " TL");
            Console.WriteLine("Su Tutarı : " + totalWaterPrice + " TL");


            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalPizzaPrice + totalFriesPrice + totalCokePrice + totalLemonadePrice + totalWaterPrice;

            Console.WriteLine("Toplam Ödenecek Tutar : " + totalPrice + " TL");


            #endregion



            Console.Read();

        }
    }
}




// Yazdırma Programları
