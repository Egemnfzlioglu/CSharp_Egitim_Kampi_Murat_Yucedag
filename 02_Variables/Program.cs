using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            /*
            double number;

            number = 4.85;

            Console.WriteLine(number);
            */



            /*
            Console.WriteLine("*** Fiyat Listesi ***");
            Console.WriteLine();
            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            applePrice = 14.85;
            orangePrice = 20.95;
            strawberryPrice = 45;
            potatoPrice = 9.74;
            tomatoPrice = 6.88;

            Console.WriteLine("--- Elma Fiyatı : " + applePrice + " TL");
            Console.WriteLine("--- Portakal Fiyatı : " + orangePrice + " TL");
            Console.WriteLine("--- Çilek Fiyatı : " + strawberryPrice + " TL");
            Console.WriteLine("--- Patates Fiyatı : " + potatoPrice + " TL");
            Console.WriteLine("--- Domates Fiyatı : " + tomatoPrice + " TL");


            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            appleGram = 1.245;
            orangeGram = 2.650;
            strawberryGram = 0.750;
            potatoGram = 4.859;
            tomatoGram = 3.745;

            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalPrice = orangeGram * orangePrice;
            double strawberryTotalPrice = strawberryGram * strawberryPrice;
            double potatoTotalPrice = potatoGram * potatoPrice;
            double tomatoTotalPrice = tomatoGram * tomatoPrice;




            Console.WriteLine();
            Console.WriteLine("Alınan Ürün : Elma     - " + "Birim Fiyat : " + applePrice + " - Gramaj : " + appleGram + " - Toplam Tutar : " + appleTotalPrice);
            Console.WriteLine("Alınan Ürün : Portakal - " + "Birim Fiyat : " + orangePrice + " - Gramaj : " + orangeGram + " - Toplam Tutar : " + orangeTotalPrice);
            Console.WriteLine("Alınan Ürün : Çilek    - " + "Birim Fiyat : " + strawberryPrice + " - Gramaj : " + strawberryGram + " - Toplam Tutar : " + strawberryTotalPrice);
            Console.WriteLine("Alınan Ürün : Patates  - " + "Birim Fiyat : " + potatoPrice + " - Gramaj : " + potatoGram + " - Toplam Tutar : " + potatoTotalPrice);
            Console.WriteLine("Alınan Ürün : Domates  - " + "Birim Fiyat : " + tomatoPrice + " - Gramaj : " + tomatoGram + " - Toplam Tutar : " + tomatoTotalPrice);



            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;

            Console.WriteLine();

            Console.WriteLine("ALIŞVERİŞ TOPLAM TUTAR : " + shoppingTotalPrice + " TL");

            */

            #endregion


            #region Char Değişkenler
            /*
            char symbol;

            symbol = 'a';

            Console.WriteLine(symbol);

            */

            #endregion


            #region Klavyeden_Veri_Girişleri_String_Değişkenleri

            /*
            Console.WriteLine("*** CSharp Hava Yolları Yolcu Bilgisi *** ");
            Console.WriteLine();

            string passangerName, passangerSurname, passangerDistrict, passangerCity, passangerAge, passangerIdentityNumber;


            Console.Write("Yolcu Adı : ");
            passangerName = Console.ReadLine();

            Console.Write("Yolcu Soyadı : ");
            passangerSurname = Console.ReadLine();

            Console.Write("Yolcu Yaş : ");
            passangerAge = Console.ReadLine();

            Console.Write("Yolcu TC Kimlik No : ");
            passangerIdentityNumber = Console.ReadLine();

            Console.Write("ilçe : ");
            passangerDistrict = Console.ReadLine();

            Console.Write("Şehir : ");
            passangerCity = Console.ReadLine();





            Console.WriteLine("-------------------------------");


            Console.WriteLine("Yolcu : " + passangerName + " " + passangerSurname);
            Console.WriteLine("        " + passangerDistrict + "/" + passangerCity);
            Console.WriteLine("        " + passangerIdentityNumber);
            Console.WriteLine("        " + passangerAge);

            */
            #endregion


            #region Klavyeden_Tam_Sayı_Girişleri_ve_Dönüşümler
            /*

            int shoePrice, computerPrice, chairPrice, televisionPrice;

            shoePrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            televisionPrice = 12000;



            int shoeCount, computerCount, chairCount, televisionCount;

            Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz : ");
            shoeCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz : ");
            computerCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz : ");
            chairCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen Aldığınız Televizyon Sayısını Giriniz : ");
            televisionCount = int.Parse(Console.ReadLine());


            int totalPrice = shoeCount * shoePrice + computerCount * computerPrice + televisionCount * televisionPrice + chairCount * chairPrice;


            Console.WriteLine();
            Console.WriteLine("Toplam Ödemeniz Gereken Tutar : " + totalPrice);

            */


            #endregion


            #region Klavyeden_Ondalıklı_Sayı_İşlemleri
            /*
            double exam1, exam2, exam3, result;

            Console.Write("Lütfen 1. Sınav Notunu Giriniz : ");
            exam1 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 2. Sınav Notunu Giriniz : ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 3. Sınav Notunu Giriniz : ");
            exam3 = double.Parse(Console.ReadLine());


            result = (exam1 + exam2 + exam3) / 3;

            Console.WriteLine();

            Console.WriteLine("Sınav Ortalamanız : " + result);

            */
            #endregion



            #region Klavyeden_Karakter_Girişleri

            char gender;

            Console.Write("Lütfen Cinsiyet Seçiniz : ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz cinsiyet : " + gender);



            #endregion



            Console.ReadLine();


        }
    }
}
