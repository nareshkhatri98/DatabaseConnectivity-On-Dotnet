using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectivity
{
    internal class DisplayTeacherDAta
    {
        public void TeacherDetails()
        {
            string cs = "Data Source=LAPTOP-8KI500RH\\SQLEXPRESS;Initial Catalog=db_swsc;Integrated Security=true;";
            try
            {
                using (SqlConnection  sc = new SqlConnection(cs))
                {
                    sc.Open();
                    // select Query...
                    string DisplayQuery = "select *from tbl_teacher";
                    SqlCommand cmd = new SqlCommand(DisplayQuery, sc);
                    SqlDataReader row = cmd.ExecuteReader();
                    while(row.Read())
                    {
                        Console.WriteLine("id is: " +row["id"]);
                        Console.WriteLine("Tname is :" + row["tname"]);
                        Console.WriteLine("Tgender is " + row["tgender"]);
                        Console.WriteLine("Taddress is :" + row["taddress"]);
                        Console.WriteLine("Tdepartment is: " + row["deprtment"]);
                        Console.WriteLine("Tspecilization is :" + row["tspecialization"]);
                        Console.WriteLine("tsalary is " + row["tsalary"]);
                        Console.WriteLine("------------------------");
                    }

                }

            }catch(SqlException e)
            {
                Console.WriteLine(e);
            }
        }
    

    public void showTeacher()
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

                // select query for condition..
                string selquery = "select *from tbl_teacher where tgender = 'female'";
                SqlCommand cmd = new SqlCommand(selquery, sc);
                SqlDataReader row = cmd.ExecuteReader();
                while(row.Read())
                {
                    Console.WriteLine("id is: " + row["id"]);
                    Console.WriteLine("Tname is :" + row["tname"]);
                    Console.WriteLine("Tgender is " + row["tgender"]);
                    Console.WriteLine("Taddress is :" + row["taddress"]);
                    Console.WriteLine("Tdepartment is: " + row["deprtment"]);
                    Console.WriteLine("Tspecilization is :" + row["tspecialization"]);
                    Console.WriteLine("tsalary is " + row["tsalary"]);
                    Console.WriteLine("------------------------");
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

    }
}
}
