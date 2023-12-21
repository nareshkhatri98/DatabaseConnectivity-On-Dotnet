using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectivity
{
    internal class DeleteOperation
    {
        public void Delete()
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
                //deleting the user information based on user input..
                //query..
                Console.WriteLine("enter id of a person which you want to delete record..");
                string delid = Console.ReadLine();

                string deleteQuery = "delete from tbl_reg where id =@id";
                SqlCommand cmd = new SqlCommand(deleteQuery, sc);
                cmd.Parameters.AddWithValue("@id", delid);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("data is delete");
                }

            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
        }
    }

}
