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

        static void CourseTest()
        {
            SchUserDBHelper.initDB();
            try
            {
                SchUserManager.AddUser(new SchUser("fs", "123"));
            }
            catch (Exception e)
            {

            }
            
            SchUserManager.ReadUser("fs", "123");

            //SchUserManager.AddCourse(new SchCourse("计算机系统", "3", "1", "416", "zj", 1, 16, 4, 3, 1, 2));

            SchUserManager.GetCourses().ForEach(o =>{Console.WriteLine(o);});
            Console.WriteLine("\n");
            SchUserManager.GetCourses(4).ForEach(o =>{Console.WriteLine(o);});
            
            
        }

        static void TaskTest()
        {
            SchUserDBHelper.initDB();

            try
            {
                SchUserManager.AddUser(new SchUser("sf", "456"));
            }
            catch (Exception e)
            {

            }

            SchUserManager.ReadUser("sf", "456");
            Console.WriteLine(SchUserManager.GetTasks());
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
            SchUserDBHelper.initDB();
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