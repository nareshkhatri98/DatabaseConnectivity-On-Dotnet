using System;
using System.Data;

using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectivity
{

    class DeleteTeacherData
    {
        public void Delete()
        {
            try
            {
                string cs = "Data Source=LAPTOP-8KI500RH\\SQLEXPRESS;Initial Catalog=db_swsc;Integrated Security=true;";

                using (SqlConnection sc = new SqlConnection(cs))
                {
                    sc.Open();
                    // delete query..
                    Console.WriteLine("Enter the id do you want to delete the record of the teacher ");
                    string delid = Console.ReadLine();

                    string delquery = "delete from tbl_teacher where id = @id";
                    SqlCommand cmd = new SqlCommand(delquery, sc);
                    cmd.Parameters.AddWithValue("id", delid);
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        Console.WriteLine("Data is delete..");
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
