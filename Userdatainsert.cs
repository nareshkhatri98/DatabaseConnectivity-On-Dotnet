using System;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseConnectivity
{
    internal class Userdatainsert
    {
        public void DataInsert()
        {
            // Creating connection string
            string cs = "Data Source=LAPTOP-8KI500RH\\SQLEXPRESS;Initial Catalog=db_swsc;Integrated Security=true;";

            try
            {
                using (SqlConnection sc = new SqlConnection(cs))
                {
                    sc.Open();

                    Console.WriteLine("Enter teacher id:");
                    string tid = Console.ReadLine();
                    Console.WriteLine("Enter teacher name:");
                    string tname = Console.ReadLine();
                    Console.WriteLine("Enter the gender of teacher:");
                    string tgender = Console.ReadLine();
                    Console.WriteLine("Enter taddress:");
                    string taddress = Console.ReadLine();
                    Console.WriteLine("Enter tdepartment: ");
                    string tdepartment = Console.ReadLine();
                    Console.WriteLine("Enter the tSpecilization");
                    string tspecialization = Console.ReadLine();
                    Console.WriteLine("Enter the tsalary:");
                    string tsalary = Console.ReadLine();

                    // Insert Query
                    string insertQuery = "INSERT INTO tbl_teacher VALUES(@tid, @tname, @tgender, @taddress, @deprtment, @tspecialization, @tsalary)";
                    SqlCommand cmd = new SqlCommand(insertQuery, sc);
                    cmd.Parameters.AddWithValue("@tid", tid);
                    cmd.Parameters.AddWithValue("@tname", tname);
                    cmd.Parameters.AddWithValue("@tgender", tgender);
                    cmd.Parameters.AddWithValue("@taddress", taddress);
                    cmd.Parameters.AddWithValue("@deprtment", tdepartment);
                    cmd.Parameters.AddWithValue("@tspecialization", tspecialization);
                    cmd.Parameters.AddWithValue("@tsalary", tsalary);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        Console.WriteLine("Data inserted..");
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
        }
    }

}
