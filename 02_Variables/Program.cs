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
            //Console.WriteLine("-----Fiyat Listesi-----");
            //Console.WriteLine();
            //double applePrice, orangePrice, strawberryPrice, tomatoPrice, potatoPrice;
            //applePrice =19.75;
            //orangePrice = 12.45;
            //strawberryPrice = 40.50;
            //tomatoPrice = 21.30;
            //potatoPrice = 14.50;

            //Console.WriteLine("Elma Birim Fiyatı: " + applePrice + "TL.");
            //Console.WriteLine("Portakal Birim Fiyatı: " + orangePrice + "TL.");
            //Console.WriteLine("Çilek Birim Fiyatı: " + strawberryPrice + "TL.");
            //Console.WriteLine("Domates Birim Fiyatı: " + tomatoPrice + "TL.");
            //Console.WriteLine("Patates Birim Fiyatı: " + potatoPrice + "TL.");
            //Console.WriteLine("-----------------------");
            //Console.WriteLine();
            //Console.WriteLine();
            //double appleGram, orangeGram, strawberryGram, tomatoGram, potatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //tomatoGram = 3.745;
            //potatoGram = 4.859;
            //double appleTotalPrice, orangeTotalPrice, strawberryTotalPrice, tomatoTotalPrice, potatoTotalPrice;


            //appleTotalPrice = applePrice * appleGram;
            //orangeTotalPrice = orangePrice * orangeGram;
            //strawberryTotalPrice = strawberryPrice * strawberryGram;
            //tomatoTotalPrice = tomatoPrice * tomatoGram;
            //potatoTotalPrice = potatoPrice * potatoGram;
            //Console.WriteLine("-----Total Fiyatlar----");
            //Console.WriteLine("Alınan Ürün Elma:  " + "Birim Fiyatı: " + applePrice + " Gramaj: " + appleGram + " Ödenecek Tutar: " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün Portakal:  " + "Birim Fiyatı: " + orangePrice + " Gramaj: " + orangePrice + " Ödenecek Tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün Çilek:  " + "Birim Fiyatı: " + strawberryPrice + " Gramaj: " + strawberryGram + " Ödenecek Tutar: "+strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün Domates:  " + "Birim Fiyatı: " + tomatoPrice + " Gramaj: " + tomatoGram + " Ödenecek Tutar: "+tomatoTotalPrice);
            //Console.WriteLine("Alınan Ürün Patates:  " + "Birim Fiyatı: " + potatoPrice + " Gramaj: " + potatoGram + " Ödenecek Tutar: "+potatoTotalPrice);
            //double shopiingTotalPrice;
            //shopiingTotalPrice = appleTotalPrice + orangePrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("TOPLAM ALIŞVERİŞ TUTARI:"+shopiingTotalPrice+" ₺");



            #endregion

            #region Char değişkenler
            ////ABCDEFGH SEZAR ŞİFRELEME
            ////DEF...
            ////TOPLANTI SAAT 20:00'DE
            ////CHAR DEĞİŞKENLER ' İLE TANIMLANIR
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);
            #endregion

            #region Klavyeden Veri Girişleri
            //Console.WriteLine("***MUHAMMET HAVA YOLLARI YOLCU BİLGİLERİ***");
            //Console.WriteLine();
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIDNumber;
            //Console.Write("Yolcu Adı: ");
            //passengerName=Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname=Console.ReadLine();
            //Console.Write("İlçe: ");
            //passengerDistrict=Console.ReadLine();
            //Console.Write("İl: ");
            //passengerCity=Console.ReadLine();
            //Console.Write("Yas: ");
            //passengerAge=Console.ReadLine();
            //Console.Write("Yolcu ID: ");
            //passengerIDNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Yolcu: " + passengerName + " " + passengerSurname+" Yaş: "+passengerAge+" İlçe: "+passengerDistrict+" İl: "+passengerCity+" ID No : "+passengerIDNumber);

            #endregion

            #region Klavyeden Tam Sayı Girişi ve Dönüşümler
            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;
            //int shoeCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen Aldığınız Ayakkabı Saysını Giriniz:");
            //shoeCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Girdiğiniz Tv Sayısını Giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());
            //int totalPrice;
            //totalPrice = shoeCount * shoePrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;
            //Console.WriteLine();
            //Console.WriteLine(totalPrice);
            #endregion
            #region Klavyeden Ondalık Sayı Girişleri
            //double exam1, exam2, exam3, result;
            //Console.Write("1. Sınav Notunu Giriniz: ");
            //exam1=double.Parse(Console.ReadLine());
            //Console.Write("2. Sınav Notunu Giriniz: ");
            //exam2=double.Parse(Console.ReadLine());
            //Console.Write("3. Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());
            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Ortalama:" + result);
            #endregion

            #region Klavyeden Karakter Girişleri
            char gender;
            Console.Write("Cinsiyet Seçiniz: ");//Tek Karakter Uzunluğu Kabul Eder
            gender = char.Parse(Console.ReadLine());

            Console.Write("Seçtiğiniz Cinsiyet= "+gender);






            #endregion


            Console.Read();
        }
    }
}
