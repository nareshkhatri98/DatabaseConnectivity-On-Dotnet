using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace DatabaseConnectivity
{
    internal class DisplayOperations
    {
        public void display()
        {
            try
            {

                string cs = "Data Source =LAPTOP-8KI500RH\\SQLEXPRESS;Initial Catalog = db_swsc; Integrated Security = true;";
                SqlConnection sc = new SqlConnection(cs);

                if (sc.State == ConnectionState.Open)
                {
                    Console.WriteLine("server connected");
                }
                sc.Open();
                string disQuery = "select *from tbl_reg";
                SqlCommand cmd = new SqlCommand(disQuery, sc);
                // for display executeReader should be used to fetch data
                // it return SqlDataReader.
                SqlDataReader row = cmd.ExecuteReader();
                while (row.Read())
                {
                    Console.WriteLine("id is " + row["id"]);
                    Console.WriteLine("username is " + row["username"]);
                    Console.WriteLine("password is " + row["password"]);
                    Console.WriteLine("repassword is " + row["repassword"]);
                    Console.WriteLine("gender is " + row["gender"]);
                    Console.WriteLine("course is " + row["course"]);
                    Console.WriteLine("country is " + row["country"]);
                    Console.WriteLine("------------------------------------");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
