using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schelendar.Models;
using Schelendar.CourseForms;

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
            //CourseTest();
            //TaskTest();
            //CourseTableAddTest();
            MainTest();
            //CourseTemplateTest();


        }

        static void DBTest()
        {
            SchUserDBHelper dbHelper = new SchUserDBHelper();
            dbHelper.CreateUsersDB();
            dbHelper.CreateTasksDB();
            dbHelper.CreateCoursesDB();
            dbHelper.CreateTaskGroupsDB();
        }

        static void CourseTest()
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

            SchUserManager.AddCourse(new SchCourse("计算机系统", "3", "1", "416", "zj", 1, 16, 4, 3, 1, 2));

            SchUserManager.GetCourses().ForEach(o =>{Console.WriteLine(o);});
            Console.WriteLine("\n");
            SchUserManager.GetCourses(4).ForEach(o =>{Console.WriteLine(o);});
            
            
        }

        static void TaskTest()
        {
            SchUserDBHelper dbHelper = new SchUserDBHelper();
            //dbHelper.CreateUsersDB();
            //dbHelper.CreateTasksDB();
            //try
            //{
            //    SchUserManager.AddUser(new SchUser("fs", "123"));
            //}
            //catch (Exception e)
            //{

            //}

            //SchUserManager.ReadUser("fs", "123");
            //SchUserManager.AddTask(new SchTask("荒野乱斗", null, DateTime.Now, DateTime.Now + TimeSpan.FromHours(1)));
            //SchUserManager.AddTask(new SchTask("c#组", null, DateTime.Now, DateTime.Now + TimeSpan.FromHours(1)),1);
            //SchUserManager.DeleteTask(4);
            //SchUserManager.DeleteTask(5);
            //SchUserManager.DeleteTask(6);
            //SchUserManager.DeleteTask(7);

            try
            {
                SchUserManager.AddUser(new SchUser("sf", "456"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                SchUserManager.AddUser(new SchUser("fs", "123"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            SchUserManager.ReadUser("sf", "456");
            SchUserManager.AddTask(new SchTask("c#组", null, DateTime.Now, DateTime.Now + TimeSpan.FromHours(1)));



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm());
            //Application.Run(new FarmForm());
            //Application.Run(new MainForm());
            //Application.Run(new CourseTableAddTimeSettingForm(11));
        }

        static void CourseTemplateTest()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CourseTemplateForm(-1));
        }

        static void CourseTableAddTest()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CourseTableAddForm());
        }

        static void MainTest()
        {
            SchUserDBHelper dbHelper = new SchUserDBHelper();
            dbHelper.initDB();
            try
            {
                SchUserManager.AddUser(new SchUser("sf", "456"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            SchUserManager.ReadUser("sf", "456");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(SchUserManager.CurrentUser.SchUserID));
        }
    }
}