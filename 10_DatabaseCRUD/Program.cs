using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");

            #region kategori ekleme işlemi
            /*
            Console.Write("Eklemek İstediğiniz Kategori Adı : ");
           
            string categoryName = Console.ReadLine();

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-V4SQU10;initial Catalog=EgitimKampiDb;integrated Security=true");

            connection.Open();

            SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);

            command.Parameters.AddWithValue("@p1", categoryName);

            // kosulsuz sekılde sorguyu calıstır
            command.ExecuteNonQuery();

            connection.Close();


            Console.WriteLine("kategori başarıyla eklendı");
            */
            #endregion

            #region ürün ekleme işlemi
            /*
            string productName;
            decimal productPrice;
            // bool productStatus;

            Console.Write("ürün adı : ");
            productName = Console.ReadLine();

            Console.Write("ürün fiyatı : ");
            productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-V4SQU10;initial Catalog=EgitimKampiDb;integrated Security=true");

            connection.Open();

            SqlCommand command = new SqlCommand(
                "insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)",
                connection);

            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productStatus", true);

            command.ExecuteNonQuery();

            connection.Close();

            Console.WriteLine("ürün eklemesi başarılı");





            */

            #endregion

            #region  ürün listeleme işlemi
            /*
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-V4SQU10;initial Catalog=EgitimKampiDb;integrated Security=true");

            connection.Open();

            SqlCommand command = new SqlCommand("select * from TblProduct", connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString()+ "-");
                   // Console.Write("-");
                }
                Console.WriteLine();
            }

            connection.Close();
            */
            #endregion

            #region ürün silme işlemi

            /*
            Console.Write("silinecek ürün ID : ");
            int productId = int.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-V4SQU10;initial Catalog=EgitimKampiDb;integrated Security=true");

            connection.Open();

            SqlCommand command = new SqlCommand("delete from TblProduct where ProductId=@productId",connection);

            command.Parameters.AddWithValue("@productId", productId);

            command.ExecuteNonQuery();
            
            connection.Close();

            Console.WriteLine("Silme işlemi yapıldı");
            */
            #endregion


            #region ürün güncelleme işlemi


            Console.Write("güncellenecek ürün Id : ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("güncellenecek ürün adı : ");
            string productName = Console.ReadLine();

            Console.Write("güncellenecek ürün fiyatı : ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-V4SQU10;initial Catalog=EgitimKampiDb;integrated Security=true");
            connection.Open();

            SqlCommand command = new SqlCommand("update TblProduct set ProductName=@productName,ProductPrice=@productPrice where ProductId=@productId",connection);

            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);

            command.ExecuteNonQuery();



            connection.Close();

            Console.WriteLine("güncelleme başarılı");
            #endregion


            Console.Read();

        }
    }
}
