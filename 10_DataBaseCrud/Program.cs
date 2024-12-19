using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
            Console.WriteLine("Eklemek İstediğiniz Kategori Adı:");
            string categoryName = Console.ReadLine();

            SqlConnection connection = new SqlConnection("Data Source=TIGER;initial catalog=EgitimKampiDb;integrated security=true");
            connection.Open();
            SqlCommand command= new SqlCommand("insert into TblCategory(CategoryName) values (@p1)",connection); 
            command.Parameters.AddWithValue("@p1",categoryName); 
            command.ExecuteNonQuery();  
            connection.Close();
            Console.WriteLine("Kategori Başarı ile Eklendi!");
            Console.Read();


        }
    }
}
