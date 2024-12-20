﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _10_DataBaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud=Create-Read-Update-Delete
            Console.WriteLine("Menü Sipariş Paneli");
            Console.WriteLine();

            Console.WriteLine("-------------------");
            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek İstediğiniz Kategori Adı:");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=TIGER;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command= new SqlCommand("insert into TblCategory(CategoryName) values (@p1)",connection); 
            //command.Parameters.AddWithValue("@p1",categoryName); 
            //command.ExecuteNonQuery();  
            //connection.Close();
            //Console.WriteLine("Kategori Başarı ile Eklendi!");
            #endregion
            #region Ürün Ekleme İşlemi
            //string eklenecekUrunAdi;
            //decimal eklenecekUrunUcreti;
            ////bool eklenecekUrunDurumu;
            //Console.Write("Eklemek İstediğiniz Yemek Adı:");
            //eklenecekUrunAdi = Console.ReadLine();
            //Console.Write("Eklenecek Ürün Ücreti: ");
            //eklenecekUrunUcreti=decimal.Parse(Console.ReadLine());
            ////Console.Write("Eklenecek Ürünün Stok Durumu: ");
            //// eklenecekUrunDurumu=bool.Parse(Console.ReadLine());
            //SqlConnection baglanti = new SqlConnection("Data source=TIGER;initial catalog=EgitimKampiDb;integrated security=true");
            //baglanti.Open();
            //SqlCommand sqlkomutu = new SqlCommand("insert into TblProduct(ProductName,ProductPrice,ProductStatus) values (@eklenecekUrunAdi,@eklenecekUrunUcreti,@eklenecekUrunDurumu)", baglanti);
            //sqlkomutu.Parameters.AddWithValue("@eklenecekUrunAdi", eklenecekUrunAdi);
            //sqlkomutu.Parameters.AddWithValue("@eklenecekUrunUcreti", eklenecekUrunUcreti);
            //sqlkomutu.Parameters.AddWithValue("@eklenecekUrunDurumu",true);
            //sqlkomutu.ExecuteNonQuery();
            //Console.WriteLine("Ürün Başarıyla Eklendi!");
            //baglanti.Close();






            #endregion
            #region  Ürün Listeleme İşlemi
            //SqlConnection baglanti = new SqlConnection("Data Source=TIGER;initial Catalog=EgitimKampiDb;integrated security=true");
            //baglanti.Open();

            //SqlCommand sqlKomutu = new SqlCommand("Select * From TblProduct",baglanti);

            //SqlDataAdapter sqlAdapteEt=new SqlDataAdapter(sqlKomutu);//SQL den veriler c# çekecek köprü görevi görür
            //DataTable sqlCekilenVeriTablosu = new DataTable();
            //sqlAdapteEt.Fill(sqlCekilenVeriTablosu);

            //foreach(DataRow row in sqlCekilenVeriTablosu.Rows)
            //{
            //    foreach(var dr in row.ItemArray)
            //    {
            //        Console.Write(dr.ToString()+" ");
            //    }
            //    Console.WriteLine() ;
            //}





            //baglanti.Close();




            #endregion
            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün ID:");
            //int silinecekUrunId=int.Parse(Console.ReadLine());

            //SqlConnection baglanti = new SqlConnection("Data Source=TIGER;initial Catalog=EgitimKampiDb;integrated security=true");
            //baglanti.Open();
            //SqlCommand sqlKomutu = new SqlCommand("Delete From TblProduct Where ProductId=@silinecekUrunId",baglanti);
            //sqlKomutu.Parameters.AddWithValue("@silinecekUrunId",silinecekUrunId);
            //sqlKomutu.ExecuteNonQuery();        

            //baglanti.Close();

            //Console.WriteLine("Ürün Silme İşlemi Başarılı!");
            #endregion
            #region Ürün Güncelleme
            Console.Write("Güncellenecek Ürün ID:");
            int urunId=int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek Ürün Adı:");
            string urunAdi=Console.ReadLine();

            Console.Write("Güncellenecek Ürün Fiyatı:");
            decimal urunFiyati=decimal.Parse(Console.ReadLine());   

            SqlConnection baglanti = new SqlConnection("Data Source=TIGER;initial Catalog=EgitimKampiDb;integrated security=true");
            baglanti.Open();
            SqlCommand sqlKomutu=new SqlCommand("Update TblProduct set ProductName=@urunAdi,ProductPrice=@urunFiyati where ProductId=@urunId",baglanti);
            sqlKomutu.Parameters.AddWithValue ("@urunAdi",urunAdi);
            sqlKomutu.Parameters.AddWithValue("@urunFiyati", urunFiyati);
            sqlKomutu.Parameters.AddWithValue("@urunId", urunId);
            sqlKomutu.ExecuteNonQuery();




            baglanti.Close();
            Console.WriteLine("Güncelleme Başarılı!");


            #endregion
            Console.Read();


        }
    }
}
