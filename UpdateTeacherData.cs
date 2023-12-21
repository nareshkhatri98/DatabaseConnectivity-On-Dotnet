using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectivity
{
     class UpdateTeacherData
    {
        public void UpdateTeacher()
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
                //update Query
                string updatquery = "update tbl_teacher set tspecialization ='Networkng', tsalary ='30000'";
                SqlCommand cmd = new SqlCommand(updatquery, sc);
                int res = cmd.ExecuteNonQuery();
                if(res > 0)
                {
                    Console.WriteLine("data is updated....");
                }

            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
