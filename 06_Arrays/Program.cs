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
            int[] numbers = { 10, 23, 30, 45, 51, 60, 1200, 900, 543, 36, 12, 90, 100, 6754 };
            for (int i = 0; i < numbers.Length; i++) 
             {
                if (numbers[i] % 3 == 0) 
                { 
                    Console.WriteLine(numbers[i]);
                }
            
            }



            #endregion
            Console.ReadLine();
        }
    }
}
