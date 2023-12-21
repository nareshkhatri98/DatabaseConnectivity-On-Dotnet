using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            insertOperations obj = new insertOperations();
            obj.insert();
            DisplayOperations obj2 = new DisplayOperations();
            obj2.display();
            UpdateOperation obj3 = new UpdateOperation();

            obj3.update();
           
            DeleteOperation obj4 = new DeleteOperation();
            obj4.Delete();
            Console.ReadKey();
            */
            // teacher details...........
            //Insert1 inser1 = new Insert1();
             //inser1.insert(); // crete table..
            Userdatainsert obj = new Userdatainsert();
            obj.DataInsert();
            DeleteTeacherData del = new DeleteTeacherData();
            //del.Delete();
            DisplayTeacherDAta dis = new DisplayTeacherDAta();
           
            UpdateTeacherData update = new UpdateTeacherData();
            //update.UpdateTeacher();
            dis.TeacherDetails();
            dis.showTeacher();
            Console.ReadKey();
        }
    }
}
// create a table tbl_teacher (tid pk, tname, tgender,taddress,tdepartment,tspecialization ,tsalary)
// after creating table insert 10 record of teacher by taking input from user
//display all the teacher record  
// display record of teacher  whose gender is female..
//  upadate specialization to networking and salary  to 30000 of teacher whose id is 2
// delete record of teacher based on user input id..

