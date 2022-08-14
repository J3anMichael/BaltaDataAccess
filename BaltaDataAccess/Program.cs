using System;
using Microsoft.Data.SqlClient;
using Dapper;
using BaltaDataAccess.Model;

namespace BaltaDataAccess
{
    class Program
    {

        static void Main(string[] args)
        {
            const string connectionString = "Server = LOCALHOST; Database = balta; Trusted_Connection = True";
            
            var list = new List<Category>();

            using(var connection = new SqlConnection(connectionString))
            {
                //connection.Open();

                var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [Category]");

                foreach(var category in categories)
                {
                    Console.WriteLine($"{category.Id} - {category.Title}");
                }





                //using (var command = new SqlCommand())
                //{
                //    command.Connection = connection;
                //    command.CommandType = System.Data.CommandType.Text;
                //    command.CommandText = "SELECT [Id], [Title] FROM [Category]";

                //    var reader = new command.ExecuteReader();
                //    while (reader.Read())
                //    {
                //        Console.WriteLine($"{reader.GetGuid(0)} - {reader.GetString(1)}");
                //    }
                //}
                connection.Close();
            }

            Console.WriteLine("Hello, world!");
        }
    }
}