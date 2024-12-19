using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ado.net
            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();
            string tableNumber;
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine("4-Lütfen Getirmek İstediğiniz Tablo Numarasını Giriniz:");
            tableNumber =Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------");


            //bu kodların amacı sorguyu ram bellek üzerinden kullancıya gösterebilmek
            SqlConnection connection = new SqlConnection("Data Source=TIGER;initial " +
                "Catalog=EgitimKampiDb;integrated security=true");// bağlantı oluşturdum
            connection.Open();//bağlantıyı açtım 
            SqlCommand command = new SqlCommand("Select * from TblCategory",connection);//bu tablonunu hangi veri tabanında oluduğunu bildirmek için yanına connection yazıldı
            SqlDataAdapter adapter = new SqlDataAdapter(command);//benim c# ile veri tabanımın köprü oluşturmasını sağlar
            DataTable dataTable=new DataTable(); 
            adapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows)  //birden fazla değişken kullanılacağında var tanımlaması kullanılır.
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                    Console.WriteLine();

            }
            connection.Close();
                                            







            Console.Read();
        }
    }
}
