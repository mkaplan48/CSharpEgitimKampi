using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnekleri
            //2,4,6,8,
            //sarı,kırmızı,mavi,yeşil
            //adana,ankara,istanbul,bursa
            //DeğişkenTürü[]DiziAdı=new DeğişkenTürü[ElamanSayısı]

            //string[] colors = new string[4];
            //colors[0] = "beyaz";
            //colors[1] = "mavi";
            //colors[2] = "kırmızı";
            //colors[3] = "siyah";

            //Console.WriteLine(colors[1]);
            //string[] cities = new string[5];
            //cities[0] = "Muğla";
            //cities[1] = "Balıkesir";
            //cities[2] = "Trabzon";
            //cities[3] = "Van";
            //cities[4] = "Ankara";

            //Console.WriteLine(cities[4]);
            //int[] number=new int[10];
            //number[0] = 2;
            //number[1] = 10;
            //number[2] = 222;
            //number[3] = 378;
            //number[4] = 18;
            //number[5] = 90;//diziye değer ataması yapmazsam default olarak 0 değeri atanır.
            //number[7] = 88;

            //Console.WriteLine(number[6]);

            // string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };

            //Console.WriteLine(cities[2]);
            #endregion
            #region Dizideki Tüm Elamanları Listeleme
            //string[] colors = { "Sarı", "Kırmızı", "Mavi", "Yeşil", "Turuncu","Pembe", "Siyah","Beyaz" }; 
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //ORNEK
            //int[] numbers = { 10, 23, 30, 45, 51, 60, 1200, 900, 543, 36, 12, 90, 100, 6754 };
            //for (int i = 0; i < numbers.Length; i++) 
            // {
            //    if (numbers[i] % 3 == 0) 
            //    { 
            //        Console.WriteLine(numbers[i]);
            //    }

            //}
            //
            #region Örnek:Dizideki Büyük değeri bulma 

            //int[] myArray = { 100, 43, 94589, 35, 9328, 66, 87 };
            //int MaxNumber = myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > MaxNumber)
            //    {
            //        MaxNumber = myArray[i];
            //    }
            //}
            //    Console.WriteLine(MaxNumber);

            #endregion
            #region Örnek Dizi Uzunluğu bulucu
            //string[] myArray2 = { "Ali", "Muhammet", "İlay", "Deniz", "Kaplan" };
            //Console.WriteLine(myArray2.Length);
            #endregion
            #region Örnek Sort Metoduyla Sıralama
            //int[] numbers = { 12, 34, 87, 99, 123, 07, 45, 77, 53, 276 };
            //Array.Sort(numbers); //Küçükten büyüğe sıraladı
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion
            #region Örnek Reverse Metoduyla Diziyi Komple Tersten Sıralama

            //int[] numbers = { 12, 34, 87, 99, 123, 7, 45, 77, 53, 276 };
            //Array.Reverse(numbers); //Küçükten büyüğe sıraladı
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion
            #region Index Of ile dizide arama yapma
            //string[] customers = { "Buse", "Ali", "İlay", "Deniz", "Şevkinaz" };
            //int index = Array.IndexOf(customers, "İlay");
            //Console.WriteLine(index);
            #endregion
            #region Dizilerde Max Min Komutları
            //int[] myArray = { 1, 2, 3, 4, 6, 7, 88, 90, 45, 677 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: "+myArray.Max()+" "+"Dizinin En Küçük Elemanı: "+myArray.Min());

            #endregion
            #region  Kullanıcıdan Dizi Değeri Girmesini İsteme
            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();


            //}
            //Console.WriteLine("---------------------------------");
            //for (int j = 0; j < cities.Length; j++) 
            //{
            //    Console.WriteLine(cities[j]);
            //}
            #endregion
            #region Dizideki tam sayıları toplayıp yazdırma
            //int[] Array = { 10, 22, 32, 54, 77, 89, 12, 43, 67, 888, 9 };
            //int plus = 0;
            //for (int i=0 ; i<Array.Length; i++)
            //{
            //    plus = plus + Array[i];
            //}
            //Console.WriteLine(plus);
            #endregion
            #region Dizideki tek ve çift sayıları ayrı ayrı listeleme
            int[] numbers = { 11, 22, 33, 444, 55,76, 67, 81, 93, 140, 141, 612, 413, 214 };
            Console.WriteLine("Çift Sayılar: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.WriteLine("Tek Sayılar: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] %2!=  0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            #endregion
            #endregion
            Console.ReadLine();
            }
        }
    }

