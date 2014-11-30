using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ADONETDemo1
{
    public class Program
    {
        public static void Main()
        {
            //APIs for SQL Server are in System.Data.SqlClient namespace
            var sw = new StreamWriter("products.csv");
            var connection =
                new SqlConnection("Data Source = (local); user id=sa;password=magesh;initial catalog=Northwind");
            connection.Open();
            var selectProductsCommand = new SqlCommand("Select * from products", connection);
            var reader = selectProductsCommand.ExecuteReader();
            while (reader.Read())
            {
                var data = string.Format("{0},{1},{2}", reader[0], reader[1], reader[2]);
                sw.WriteLine(data);
                Console.WriteLine("Id = {0}, Name = {1}, UnitPrice = {2}", reader[0], reader[1], reader[2]);
            }
            sw.Close();
            reader.Close();
            connection.Close();
            Console.WriteLine("Done");
            Console.ReadLine();

        }
    }
}
