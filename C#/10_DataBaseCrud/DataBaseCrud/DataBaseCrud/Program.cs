using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Menü Şipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("---------------------------------------");
            #region Kategori ekleme işlemi 
            //Console.Write("eklmek istediğiniz kategoriyi giriniz : ");
            //string categoryName = Console.ReadLine();
            // SqlConnection connection = new SqlConnection("Data Source=LAPTOP-L2Q5OFLE\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true ");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory (categoryName) values (@p1)",connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();


            //Console.WriteLine("kategory başarıyla eklendi");
            #endregion

            #region Ürün eklem İşlemi

            //string productName;
            //decimal productPrice;
            //// bool productStatus;

            //Console.Write("ürün adı :");
            //productName = Console.ReadLine();

            //Console.Write("ürün fiyatı : ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-L2Q5OFLE\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true ");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@p1,@p2,@p3)",connection );
            //command.Parameters.AddWithValue("@p1",productName);
            //command.Parameters.AddWithValue("@p2",productPrice);
            //command.Parameters.AddWithValue("@p3",true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("ürün eklemesi başarılı ");

            #endregion

            #region Ürün listeleme işlemi

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-L2Q5OFLE\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true ");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);


            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();

            //}

            //    connection.Close();



            #endregion

            #region ürün silme işlemi
            Console.Write("silinecek ürünün ıd sini giriniz :");
            int productId = int.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-L2Q5OFLE\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true ");
            connection.Open();
            SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=productId", connection);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();




            connection.Close();
            Console.WriteLine("silme işlemi başarılı ");

            #endregion
            Console.Read();
        }
    }
}
