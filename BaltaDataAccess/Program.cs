using System;
using Microsoft.Data.SqlClient;

namespace BaltaDataAccess
{
    class Program
    {

        static void Main(string[] args)
        {
            const string connectionString = "Server = LOCALHOST; Database = balta; Trusted_Connection = True";
            
            using(var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // INSERT
                // UPDATE
                connection.Close();
            }

            Console.WriteLine("Hello, world!");
        }
    }
}