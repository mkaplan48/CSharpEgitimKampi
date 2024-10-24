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
            #region Donguler For
            //for(x;y;z)
            //x=başlangıç
            //y=bitiş
            //z=artış-azalış
            //int i;
            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("Muhammet KAPLAN");

            //}
            //for (int i = 3; i <= 50; i+=3)
            //{ 
            //Console.WriteLine(i);
            //}
            //Console.Write("Kaç Defa Yazırmak İstiyorsunuz?: ");
            //int finishValue=int.Parse(Console.ReadLine());
            //for (int i = 0; i < finishValue; i++)
            //{
            //    Console.WriteLine("Türkiye");
            //}
            #endregion
            #region Döngülerde Karar Yapıları
            //Ör:5e ölünebilen sayılar
            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 5 == 0)
            //    { 
            //    Console.WriteLine(i);
            //    }
            //}
            //Ör:1 ile 10 arası sayıların toplamı
            //Console.Write("Ardışık Toplanmasını istediğiniz Son Sayıyı Giriniz: ");
            //int lastNumber=int.Parse(Console.ReadLine());
            //int total = 0;
            //for (int i = 0; i <= lastNumber; i = i + 1) {
            //    total+=i;          
            //}
            //Console.WriteLine(total);
            //Girilen sayıya kadar çift sayıların toplamı
            //int total = 0;
            //Console.Write("Son Sayıyı Giriniz:");
            //int lastNumber=int.Parse(Console.ReadLine());
            //for (int i = 0; i < lastNumber; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        total += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("***************");
            //Console.WriteLine(total);

            //Ör:Girilen Sayıların içinde kaç tane girilen sayı tam bölünüyor yazdırma
            //Console.Write("Bölünen Sayı: ");
            //int bolunenSayi=int.Parse(Console.ReadLine());
            //Console.Write("Bölen Sayı: ");
            //int bolenSayi = int.Parse(Console.ReadLine());
            //int total = 0;
            //for (int i = 1; i <= bolunenSayi; i++)
            //{
            //    if (i % bolenSayi == 0)
            //    {
            //        total++;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("Toplam: " + total + " kere.");

            //Her saat 2 ye bölünerek üreyen bakterilerin 24 saat sonraki sayısı kaçtır.

            //int bakteri = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bakteri *= 2;
            //    Console.WriteLine(i + ".Saat: " + bakteri);
            //}
            #endregion;
            #region While Döngüsü
            //While(Şart) işlem sağlandığı sürece while döngüsü devam eder.
            //{
            //işlemler
            //}
            //int i = 1;
            //while (i <= 10)
            //{    
            //Console.WriteLine(i);
            //    i++;
            //}

            //Ör: Klavyeden Girilen Sayıların birbirine Bölümünü veren Porgram
            //Console.Write("Bölünecek Sayıyı Girin:");
            //int bolunecekSayi=int.Parse(Console.ReadLine());
            //Console.Write("Bölen Sayıyı Girin:");
            //int bolenSayi = int.Parse(Console.ReadLine());
            //int i = 1;
            //int total = 0;
            //while (i <= bolunecekSayi)
            //{
            //    if (i % bolenSayi == 0)
            //    {
            //        total++;
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}
            //Console.WriteLine(bolunecekSayi + " İçinde " + bolenSayi +" "+","+ total + " kere bulunur.");

            //Klavyeden girilen 3 basamaklı sayının rakamları toplamını veren program
            Console.Write("Basamaklarını Toplamak İstediğiniz 3 Basamaklı Sayıyı Giriniz:");
            int sayi=int.Parse(Console.ReadLine());
            int i = 1;
            int basamak1;
            int basamak2;
            int basamak3;
            int toplam;
            basamak1 = sayi / 100;
            basamak3 = sayi % 10;
            basamak2=((sayi%100)-(basamak3))/10;
            Console.WriteLine(basamak1);
            Console.WriteLine(basamak2);
            Console.WriteLine(basamak3);
            toplam = basamak1 + basamak2 + basamak3;
            Console.WriteLine(toplam);
            #endregion
            Console.Read();
        }
    }
}
