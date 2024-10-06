using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Değişkenler

            ////double number;
            ////number = 0.5;

            ////Console.WriteLine(number);

            //Console.WriteLine("*****Fiyat Listesi*****");
            //Console.WriteLine();

            //double applePrice, tomatoPrice, orangePrice, strawberryPrice, patatoPrice;

            //applePrice = 35.50;
            //tomatoPrice = 28.95;
            //orangePrice = 42.75;
            //strawberryPrice =59.99;
            //patatoPrice = 24.25;

            //Console.WriteLine("-Elma Kilogram Fiyatı: " + applePrice + "TL");
            //Console.WriteLine("-Domates Kilogram Fiyatı: " + tomatoPrice + "TL");
            //Console.WriteLine("-Portakal Kilogram Fiyatı: " + orangePrice + "TL");
            //Console.WriteLine("-Çilek Kilogram Fiyatı: " + strawberryPrice + "TL");
            //Console.WriteLine("-Patates Kilogram Fiyatı: " + patatoPrice + "TL");

            ////alınan kg tanımlama
            //double appleGram, tomatoGram, orangeGram, patatoGram, strawberryGram;

            //appleGram = 1.4;
            //tomatoGram = 2.5;
            //orangeGram = 3.0;
            //patatoGram = 4.8;
            //strawberryGram = 0.9;

            //double appleTotalPrice = applePrice + appleGram;
            //double tomatoTotalPrice = tomatoPrice + tomatoGram;
            //double orangeTotalPrice = orangePrice + orangeGram;
            //double patatoTotalPrice = patatoPrice + patatoGram;
            //double strawberryTotalPrice =  strawberryPrice + strawberryGram;

            //Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine("Alınan Ürün: Elma -" + "Birim Fiyatı: " + applePrice + "Alınan Kg: " + appleGram + "Toplam Tutar: " +appleTotalPrice + "TL");
            //Console.WriteLine("Alınan Ürün: Portakal -" + "Birim Fiyatı: " + orangePrice + "Alınan Kg: " + orangeGram + "Toplam Tutar: " +orangeTotalPrice + "TL");
            //Console.WriteLine("Alınan Ürün: Domates -" + "Birim Fiyatı: " + tomatoPrice + "Alınan Kg: " + tomatoGram + "Toplam Tutar: " +tomatoTotalPrice + "TL");
            //Console.WriteLine("Alınan Ürün: Patates -" + "Birim Fiyatı: " + patatoPrice + "Alınan Kg: " + patatoGram + "Toplam Tutar: " +patatoTotalPrice + "TL");
            //Console.WriteLine("Alınan Ürün: Çilek -" + "Birim Fiyatı: " + strawberryPrice + "Alınan Kg: " + strawberryGram + "Toplam Tutar: " +strawberryTotalPrice + "TL");
            //Console.WriteLine();

            //double totalPrice=appleTotalPrice + orangeTotalPrice + tomatoTotalPrice + patatoTotalPrice + strawberryTotalPrice;

            //Console.WriteLine("Toplam Alışveriş Tutarı: " +totalPrice + "TL");

            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişi

            //Console.WriteLine("*** Yolcu Bilgisi ***");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerId ;

            //Console.Write("Yolcu adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yolcu yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu kimlik bilgisi: ");
            //passengerId = Console.ReadLine();

            //Console.Write("İl: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("İlçe: ");
            //passengerDistrict = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("----------------------------------");

            //Console.WriteLine("Yolcu Bilgileri");
            //Console.WriteLine("Ad:" + passengerName);
            //Console.WriteLine("Soyad:" + passengerSurname);
            //Console.WriteLine("Id:" + passengerId);
            //Console.WriteLine("Yaş:" + passengerAge);
            //Console.WriteLine("il:" + passengerCity +"  " + "İlçe: " + passengerDistrict);

            //Console.WriteLine("----------------------------------");


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümleri

            //Dönüşümler

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1500;
            //computerPrice = 24000;
            //chairPrice = 560;
            //tvPrice = 85000;

            //int shoeCount, computerCount, chairCount, tvCount;

            //Console.Write("lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoeCount = int.Parse(Console.ReadLine());

            //Console.Write("lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("lütfen aldığınız tv sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice= (shoePrice*shoeCount)+(computerPrice*computerCount)+(chairPrice*chairCount)+(tvPrice*tvCount);

            //Console.WriteLine();
            //Console.WriteLine("Toplam tutar: " + totalPrice + "TL");


            #endregion

            #region Klavyeden Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("1.Sınav Notu: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sınav Notu: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("3.Sınav Notu: ");
            //exam3 = int.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine() ;
            //Console.WriteLine("Ortalamananız: " + result );


            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz E/K : ");
            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz cinsiyet: " +gender);

            #endregion

            Console.Read();

        }
    }
}
