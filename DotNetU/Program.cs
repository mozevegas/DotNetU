using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetU
{
    class Program
    {
        static void Main(string[] args)
        {
            // WHere is the Database
            const string connectionString =
                @"Server=localhost\SQLEXPRESS;Database=DotNetU;Trusted_Connection=True;";
            // Open with using something
            using (var connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("Connected!");
                var sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection;
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.CommandText = @"SELECT * FROM[DotNetU].[dbo].[InstructorTable]";
                connection.Open();

                var instructors = new List<Instructor>();

                var reader = sqlCommand.ExecuteReader();


                while (reader.Read())
                {
                    var teacher = new Instructor(reader);
                    instructors.Add(teacher);
                }
                foreach (var item in instructors)
                {
                    Console.WriteLine(item.Name);
                }


                connection.Close();
            }



        }
    }
}
