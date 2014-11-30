using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ADONETDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection =
                new SqlConnection("Data Source=(local); user id=sa; password=magesh; initial catalog=northwind");
            connection.Open();
            var command = new SqlCommand("Insert into designations(title, minSalary) values(@title, @minSalary)", connection);
            command.Parameters.AddWithValue("@title", "Country Manager");
            command.Parameters.AddWithValue("@minSalary", 300000);

            
            var rowsAffected = command.ExecuteNonQuery();
            Console.WriteLine("Rows Affected = {0}", rowsAffected);
            connection.Close();
            Console.ReadLine();
        }
    }
}
