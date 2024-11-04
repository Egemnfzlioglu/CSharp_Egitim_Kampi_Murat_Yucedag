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
            // ders linki
            // https://www.youtube.com/watch?v=T-uXK85d7Lc&list=PLKnjBHu2xXNPmFMvGKVHA_ijjrgUyNIXr&index=10&ab_channel=MuratY%C3%BCceda%C4%9F

            // Ado .Net

            #region  Ado .Net
            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();


            string tableNumber;


            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine();

            Console.Write("Lütfen Getirmek İstediğiniz Tablo Numarasını Giriniz : ");
            tableNumber = Console.ReadLine();

            Console.WriteLine("------------------------------------------------------------");


            // Sql Bağlantısı
            // Data Source = sql connection database engine yazan server name
            // initial Catalog = DB NAME
            // integrated Security = bağlantı güvenliği

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-V4SQU10;initial Catalog=EgitimKampiDb;integrated Security=true");

            // bağlantıyı aç
            connection.Open();

            // sql sorgusu yazmak için db ile iletişime geçiyor
            // yani sql de  new query gibi düşün
            SqlCommand command = new SqlCommand("select * from TblCategory", connection);

            // c# kodlarıyla sql arasında köprü görevi görüyor
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            // verileri ram(geçiçi) bellege almayı saglar
            DataTable dataTable = new DataTable();

            // 
            adapter.Fill(dataTable);


            connection.Close();


            //foreach (DataRow row in dataTable.Rows) { }
            /*
            foreach (var item in dataTable.Rows)
            {
                Console.WriteLine(item);
            }
            */

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());

                }
                Console.WriteLine();
            }

            #endregion





            Console.Read();
        }
    }
}
