using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void Metotlar
            ////Metot olabilmesi için sonun () olması gerekir.
            ////Mor küre olarak gözükürse metottur.
            ////Geriye değer döndürmezler
            ////Customer -->Listele,ekle,sil,güncelle
            ////Void

            //void customerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Mehmet Sarı");
            //    Console.WriteLine("Ayşe Kırmızı");
            //    Console.WriteLine("Muhammet KAPLAN");

            //}
            //customerList();
            //customerList();
            //customerList();
            //customerList();

            //void Sum()

            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();
            #endregion
            #region Geriye Değer Döndürmeyen String Parametreleri Metodlar
            //  void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);

            //}
            //WriteMethod("Mehmet Yılmaz");
            //void customerCard(string name,string surname)
            //{
            //    Console.WriteLine("Müşteri:"+name+" "+surname);
            //}
            //customerCard("Ali","Deniz");
            //customerCard("Muhammet", "Kaplan");
            #endregion
            #region Geriye Değer Döndürmeyen int Parametreleri Metodlar
            //void sum(int number1,int number2,int number3)
            //    {
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);

            //}

            //sum(4, 5, 6);

            #endregion
            #region Geriye Değer Döndüren Metodlar
            //string customerName()
            //{
            //    return "Buse Yıldız";

            //}
            //customerName();
            //string studentCar()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";
            //    return name+ " " + surname; 
            //}
            //Console.WriteLine(studentCar());
            #endregion
            #region Geriye Değer Döndüren String Parametreli Metodlar
            //string countryCard(string countryName,string countryCapital,string counntryFlagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + "- Başkent: " + countryCapital + "-Bayrak Rengi: "  + counntryFlagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke Adı Giriniz:");
            //x = Console.ReadLine();
            //Console.Write("Başkenti Giriniz:");
            //y = Console.ReadLine();
            //Console.Write("Ülke Bayrak Rengini Giriniz:");
            //z = Console.ReadLine(); 
            //Console.WriteLine(countryCard(x, y, z));
            //Console.WriteLine(countryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));
            #endregion
            #region Geriye Değer Döndüren Int Parametreli Metodlar
            //int sum(int number1,int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(sum(10, 11));
            //Console.WriteLine(sum(20, 21));
            //Console.WriteLine(sum(30, 31));
            //Console.WriteLine(sum(40, 41));

            #endregion

            #region Örnek Uygulama
            string examResult(string studentName,string studentSurname,int exam1,int exam2,int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >=50)
                {
                    return studentName +"  " +studentSurname+" isimli öğrenci BAŞARILIDIR!";

                }
                else
                {
                    return studentName + "  " + studentSurname + " isimli öğrenci BAŞARISIZDIR!"; 
                }
            }
            Console.WriteLine(examResult("Muhammet", "Kaplan", 50, 50, 60));
            Console.WriteLine(examResult("Ayşe", "Kaplan", 10  , 10 , 60));
            #endregion



            Console.ReadLine();
           





        }
    }
}
