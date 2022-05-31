using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schelendar.Models;

namespace Schelendar
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            //DBTest();
            UserManagerTest();

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            ////Application.Run(new LoginForm());
            ////Application.Run(new FarmForm());
            //Application.Run(new MainForm());

        }

        static void DBTest()
        {
            SchUserDBHelper dbHelper = new SchUserDBHelper();
            dbHelper.CreateUsersDB();
            dbHelper.CreateTasksDB();
            dbHelper.CreateCoursesDB();
        }

        static void UserManagerTest()
        {
            SchUserDBHelper dbHelper = new SchUserDBHelper();
            dbHelper.CreateUsersDB();
            dbHelper.CreateCoursesDB();
            try
            {
                SchUserManager.AddUser(new SchUser("fs", "123"));
            }
            catch (Exception e)
            {

            }
            
            SchUserManager.ReadUser("fs", "123");

            SchUserManager.UpdateCourse("计算机系统",new SchCourse("计算机系统", "3", "1", "416", "zj", 1, 16, 4, 3, "10:35", "11:25"));

            SchUserManager.GetCourses().ForEach(o =>{Console.WriteLine(o);});
            Console.WriteLine("\n");
            SchUserManager.GetCourses(4).ForEach(o =>{Console.WriteLine(o);});
            
            
        }
    }
}