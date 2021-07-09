using Microsoft.Data.SqlClient;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string name = "devops";
            if (name == "devops")
                          Console.WriteLine("devops  World!");
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = @"Select * from Logins where User_na='' OR User_na LIKE '%'--pass_wrd= 'xxx'";
            }
        }
    }
}
