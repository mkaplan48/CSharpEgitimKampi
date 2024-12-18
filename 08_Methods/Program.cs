using System;
using System.Collections.Generic;
using System.Linq;
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
              void WriteMethod(string customerName)
            {
                Console.WriteLine(customerName);

            }
            WriteMethod("Mehmet Yılmaz");
            void customerCard(string name,string surname)
            {
                Console.WriteLine("Müşteri:"+name+" "+surname);
            }
            customerCard("Ali","Deniz");
            customerCard("Muhammet", "Kaplan");
            #endregion

            Console.ReadLine();
           





        }
    }
}
