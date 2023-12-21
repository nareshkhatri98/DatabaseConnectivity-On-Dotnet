using System;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseConnectivity
{
    internal class UpdateOperation
    {
        public void update()
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
                //update username to sarmila   course to csit gender to femal.
                //for studnet whose id =1;
                //query..
                string upQuery = "update tbl_reg set username = 'sarmila', gender ='female', course='csit' where id =1";
                SqlCommand cmd = new SqlCommand(upQuery, sc);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("data is updated");
                }

            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
    
