using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Net;

namespace DatabaseConnectivity
{
     class Insert1
    {
       
        public void insert()
        {

            // creating connection string;
            string cs = "Data Source =LAPTOP-8KI500RH\\SQLEXPRESS;Initial Catalog = db_swsc; Integrated Security = true;";
            //here data Source is servername, initial catalog is db name,
            //integrated security refers to windows  authentication

            try
            {
                // creation
                SqlConnection sc = new SqlConnection(cs);

                if (sc.State == ConnectionState.Open)
                {
                    Console.WriteLine("server connected");
                }
                sc.Open();
                string tblquery = "create table tbl_teacher(id int primary key, " + " tname varchar(50)," + " tgender varchar(50)," + " taddress varchar(50)," + "  deprtment varchar(50)," + "  tspecialization varchar(50), " + " tsalary varchar(50))";
                SqlCommand cmd = new SqlCommand(tblquery, sc);

                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("table created");
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
        }
    }

    }

    