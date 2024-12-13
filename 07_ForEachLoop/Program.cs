using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForEachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü 
            //Döngüyü yazıp geçiyoruz o bizim yerimize başlangıç ve bitişi ayarlıyor
            //Foreach(1;2;3;4)
            //1:Değişken türü
            //2:Değişken adı
            //3:In
            //4:Liste,Koleksiyon,Dizi
            //string[] cities = { "Roma", "Milano", "Ankara", "Madrid", "Burdur", "Şırnak" };

            //foreach(string a in cities)
            //{

            //    Console.WriteLine(a);
            //}
            //int[] numbers = { 123, 34, 54656, 34, 56, 87, 23, 66 };
            //foreach(int i in numbers)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //int[] numbers = { 123, 34, 54656, 34, 56, 87, 23, 66 };
            //int total = 0;
            //foreach(int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);
            //List<int> numbers = new List<int>() {
            //    1,2,3,4,5,6,7,8,9,0
            //};
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}
            //string word = "Merhaba";
            //foreach (char i in word) 
            //{ 
            //    Console.WriteLine(i);
            //}
            #region Örnek Sınav Sistemi Uygulaması
            Console.WriteLine("********** Sınav Uygulaması *********");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("----------------------------------");//Sınıftaki Öğrenci Sayısını Kullanıcıdan Alma
            Console.Write("Sınıfınızda Kaç Öğrenci Var? ");
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------");

            //Öğrenci İsimlerini ve Ortalamalarını Student Count sayısına göre saklayan dizilerin kodu:
            string[] studentNames = new string[studentCount];
            double[]studentAvg=new double[studentCount];
            for (int  i= 0;  i< studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();
                double totalExamResult = 0;

                //Her öğrenci için 3 sınav notu girişi
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin " + $"{j + 1}. Notunu Giriniz: ");
                    double value=double.Parse(Console.ReadLine());
                    totalExamResult += value;// 3 sınav notunu toplar
                  
                }
                studentAvg[i] = totalExamResult / 3;
                Console.WriteLine();
            }
            //Sınav Ortalamaları
            for (int k = 0; k < studentCount; k++)
                {
                    Console.WriteLine($"{studentNames[k]} adlı öğrencinin ortalaması: {studentAvg[k]}");
                //Öğrencilerin Geçip Kalma Durumları
                if (studentAvg[k]>=50)
                {
                    Console.WriteLine($"{studentAvg[k]} adlı öğrenci dersi geçiştir.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[k]} adlı öğrenci dersten kalmıştır.");
                }
                Console.WriteLine("-----------------------------------------------");
            }


           
           





            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("********** Sınav Uygulaması *********");
            #endregion

            #endregion
            Console.Read();
        }
    }
}
