using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            //Console.Write("Şifreyi Giriniz:");
            //string password;
            //password =Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}
            //string capital, country;
            //Console.Write("Ülkeyi Giriniz:");
            //country= Console.ReadLine();
            //Console.Write("Başkenti Giriniz:");
            //capital=Console.ReadLine();
            //if (country == "türkiye" & capital == "ankara")
            //{
            //    Console.WriteLine("Veriler Doğrulandı");
            //}
            //else
            //{ Console.WriteLine("Veriler Doğrulanamadı");
            //}
            //int number;
            //number = 5;
            //Console.Write("Sayıyı Giriniz: ");
            //number=int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Doğru Değil!");
            //}
            //int exam1, exam2, exam3 , average;
            //string result;
            //Console.Write("1.Sınav: ");
            //exam1=int.Parse(Console.ReadLine());
            //Console.Write("2.Sınav: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("3.Sınav: ");
            //exam3 = int.Parse(Console.ReadLine());
            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Ortalama: " + average);
            //    if (average > 0 & average < 45)
            //    {
            //        Console.WriteLine("Ortalamanız: " + average + "Notunuz: 1");
            //    }
            //    if (average >= 45 & average < 55)
            //    {
            //        Console.WriteLine("Ortalamanız: "+average+"Notunuz: 2");
            //    }
            //    if (average >= 55 & average < 70)
            //    { 
            //    Console.WriteLine("Ortalamanız: "+average+"Notunuz: 3");
            //    }
            //    if (average >= 70 & average < 85)
            //    {
            //        Console.WriteLine("Ortalamanız: " + average + "Notunuz: 4");
            //    }
            //    if (average >= 85 & average <= 100)
            //    {
            //        Console.WriteLine("Ortalama: " + average + "Notunuz: 5");
            //    }
            //    if (average <1 || average>100)
            //{
            //    Console.WriteLine("Belirtilen Not Aralığı Dışındasınız");
            //}
            //string city;
            //Console.Write("Şehir Giriniz: ");
            //city = Console.ReadLine();
            //if (city == "ankara" || city == "bursa" || city == "trabzon")
            //{
            //    Console.WriteLine("Şehriniz Listede Mevcut!");
            //}
            //else
            //    { 
            //Console.WriteLine("Şehriniz listede yok");
            //}
            //string username;
            //Console.Write("Kullanıcı Adınızı Giriniz: ");
            //username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Kullanıcı Adı Yanlış!");
            //}
            //else
            //{
            //    Console.WriteLine("Kullanıcı Adı Doğru!");
            //}
            #endregion
            #region Mod
            //int number, result;
            //number = 26;
            //result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("1. Sayıyı Giriniz: ");
            //int number1=int.Parse(Console.ReadLine());
            //Console.Write("2. Sayıyı Giriniz: ");
            //int number2=int.Parse(Console.ReadLine());
            //Console.Write("Birinci Sayının İkinci Sayıya Modu: "+number1 % number2);

            //Console.Write("Sayıyı Giriniz: "); //Tek Çift Sayı
            //int number=int.Parse(Console.ReadLine());
            //if (number%2==0)
            //{
            //    Console.WriteLine("Sayı Çift Sayıdır!");

            //}
            //else
            //{
            //       Console.WriteLine("Sayı Tek Sayıdır!");
            //}
            //char team;
            //Console.Write("Klavyeden Girdiğiniz Harfe Göre Takımlar Karşınıza Gelecektir,Harfi Giriniz: ");
            //team=char.Parse(Console.ReadLine());
            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Girilen Takım: Fenerbahçedir");
            //}
            //if (team == 'b' | team == 'B')
            //{ 
            //Console.WriteLine("Girilen Takım:Beşiktaş");
            //}
            //if (team == 'g' | team == 'G')
            //{ 
            //Console.WriteLine("Seçilen Takım Galatasaray");
            //}
            //else
            //{
            //    Console.WriteLine("Girilen Takım Kayıtlı Değil");
            //}

            #endregion
            #region If Else Ornek
            //Console.WriteLine("****** C# EĞİTİM KAMPI RESTORAN *****");
            //Console.WriteLine("---------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("---------------------");
            //Console.WriteLine();
            //int cookChose;
            //Console.Write("Detayını Görmek İstediğiniz Menüyü Seçin: ");
            //cookChose = int.Parse(Console.ReadLine());
            //if (cookChose == 1)
            //{
            //    Console.WriteLine("---------------------");
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Kuru Fasulye-Pilav");
            //    Console.WriteLine("4-Balık");
            //    Console.WriteLine("Musakka");
            //    Console.WriteLine("---------------------");
            //    Console.WriteLine();
            //}
            //if (cookChose == 2)
            //{
            //    Console.WriteLine("---------------------");
            //    Console.WriteLine("1-Ezogelin");
            //    Console.WriteLine("2-Tavuk Suyu");
            //    Console.WriteLine("3-Tarhana");
            //    Console.WriteLine("4-Mercimek");
            //    Console.WriteLine("5-Yayla");
            //    Console.WriteLine("---------------------");
            //    Console.WriteLine();
            //}
            //if (cookChose == 3)
            //{
            //    Console.WriteLine("---------------------");
            //    Console.WriteLine("1-Margarita");
            //    Console.WriteLine("2-Tavuklu");
            //    Console.WriteLine("3-Sosisli");
            //    Console.WriteLine("4-Peynirli");
            //    Console.WriteLine("Sucuklu");
            //    Console.WriteLine("---------------------");
            //    Console.WriteLine();
            //}
            //if (cookChose == 4)
            //{
            //    Console.WriteLine("---------------------");
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Su");
            //    Console.WriteLine("3-Fanta");
            //    Console.WriteLine("4-Ayran");
            //    Console.WriteLine("5-Erik Suyu");
            //    Console.WriteLine("---------------------");
            //    Console.WriteLine();
            //}
            //if (cookChose == 5)
            //{
            //    Console.WriteLine("---------------------");
            //    Console.WriteLine("1-Trileçe");
            //    Console.WriteLine("2-CheeseCake");
            //    Console.WriteLine("3-Pasta");
            //    Console.WriteLine("4-Sütlaç");
            //    Console.WriteLine("5-Baklava");
            //    Console.WriteLine("---------------------");
            //    Console.WriteLine();
            //}
            //else if (cookChose<1 ||  cookChose>5)

            //{
            //    Console.WriteLine("Doğru Seçim Yapmadınız!");
            //}

            #endregion
            #region Switch Case
            //Console.Write("Ay Girişi Yapınız: ");
            //int mountNumber=int.Parse(Console.ReadLine());
            //switch(mountNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2:Console.Write("Şubat");break;
            //    case 3:Console.Write("Mart");break;
            //    case 4:Console.Write("Nisan"); break;
            //    case 5:Console.Write("Mayıs");break;
            //    case 6:Console.Write("Haziran"); break;
            //    case 7:Console.Write("Temmuz");break;
            //    case 8:Console.Write("Ağustos");break;
            //    case 9:Console.Write("Eylül");break;
            //    case 10:Console.Write("Ekim");break;
            //    case 11:Console.Write("Kasım");break;
            //    case 12:Console.Write("Aralık"); break;
            //    default:Console.Write("Hatalı Değer Girdin!"); break;


            //}

            #endregion
            #region Switch Case Hesap Makinesi
            Console.Write("1.Sayıyı Giriniz: ");
            int number1=int.Parse(Console.ReadLine());
            Console.Write("2.Sayıyı Giriniz: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.Write("Yapmak İstediğiniz İşlemin Karakterini Giriniz:");
            char symbol=char.Parse(Console.ReadLine());
            int result;
            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Toplam:"+result);
                break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Eksi: " + result);
                break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpım: "+result);
                break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Bölüm: " + result);
                break;

            }
            #endregion

            Console.Read();
        }
    }
}


