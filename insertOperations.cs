using System;
using System.Data;
using System.Data.SqlClient;

// to connect with external data source (sql server, xml file etc)we need to import System.Data.SqlClient package.
// to connect eith server SQL connection class is used and to execute qiery SQLCommand classs is used.
//step1: create connection string that contians all the parameter required
//to connect with database .it contains server name,dbname and security.
//step2: Create object of SQLConection class and haldle SQLEXception
//step3: write appropriate query.
// step4: ececute sql query usin object of SQLCOmmand class.
// step 5: close connection..
namespace DatabaseConnectivity
{
    internal class insertOperations
    {
        public void insert()
        {

            // creating connection string;
            string cs = "Data Source =LAPTOP-8KI500RH\\SQLEXPRESS;Initial Catalog = db_swsc; Integrated Security = true;";
            //here data Source is servername, initial catalog is db name,
            //integrated security refers to windows  authentication

            try
            {
                // creatin
                SqlConnection sc = new SqlConnection(cs);

                if(sc.State == ConnectionState.Open) 
                {
                    Console.WriteLine("server connected");
                }
                sc.Open();// opening a connection..
                          // writing  query
                          //creating table..
                          // string tblquery = "create table tbl_reg(id int primary key, " + " username varchar(50), password varchar(50)," +
                          //   "repassword varchar(50), gender varchar(50), course varchar(50), country varchar(50) )";
                          //insert query
                          //String insQuery = "insert into tbl_reg values(2,'Hari','abcd','abcd', 'male', 'bbs','Nepal')";
                          //inserting data by taking user input prepared statement or using parameter;
                Console.WriteLine("Enter your id:");
                string id = Console.ReadLine();
                Console.WriteLine("Enter your name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your password:");
                string  password= Console.ReadLine();
                Console.WriteLine("Enter your repasword:");
                string repassword = Console.ReadLine();
                Console.WriteLine("Enter your gender:");
                string gender = Console.ReadLine();
                Console.WriteLine("Enter your course:");
                string course = Console.ReadLine();
                Console.WriteLine("Enter your country:");
                string country = Console.ReadLine();

                //query 
                string insQuery = "insert into tbl_reg values(@id,@username,@password,@repassword,@gender,@course,@country)";
                SqlCommand cmd = new SqlCommand(insQuery, sc);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@username", name);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@repassword", repassword);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@country", country);

                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Data inserted");
                }
                sc.Close();
            }
            catch (SqlException s)
            {
                Console.WriteLine(s);
            }
        }
    }
}
