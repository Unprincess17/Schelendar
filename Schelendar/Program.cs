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

            //UserManagerTest();
            //DBTest();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm());
            //Application.Run(new FarmForm());
            Application.Run(new MainForm());

        }

        static void DBTest()
        {
            SchUserDBHelper dbHelper = new SchUserDBHelper();
            dbHelper.CreateUsersDB();
        }

        static void UserManagerTest()
        {
            SchUserDBHelper dbHelper = new SchUserDBHelper();
            dbHelper.CreateUsersDB();
            SchUserManager.AddUser(new SchUser("fs","123"));



            //SchUser sf = new SchUser(0, "Gong Shufan");
            //sf.SchClasses.Add(new SchClass(0, "数据库", 3.ToString(), 2.ToString(), 106.ToString(), "", 1, 16, 1, 4, "08:00", "10:35"));
            //sf.SchClasses.Add(new SchClass(0, "计算机网络", 3.ToString(), 1.ToString(), 416.ToString(), "", 1, 16, 2, 4, "14:05", "16:30"));
            //sf.SchClasses.Add(new SchClass(0, "操作系统", 3.ToString(), 2.ToString(), 112.ToString(), "", 1, 13, 1, 2, "08:00", "10:35"));
            //sf.SchClasses.Add(new SchClass(0, "大学物理", 3.ToString(), 2.ToString(), 106.ToString(), "", 1, 16, 1, 3, "08:00", "10:35"));
            //sf.SchEvents.Add(new SchEvent(0, "sleep", "dorm", DateTime.Now, DateTime.Now + TimeSpan.FromHours(1), 0, 0));

            //SchUser gf = new SchUser(1, "Shu Gongfan");
            //gf.SchEvents.Add(new SchEvent(0, "sleep", "dorm", DateTime.Now, DateTime.Now + TimeSpan.FromHours(1), 0, 0));
            //gf.SchEvents.Add(new SchEvent(0, "wakeup", "dorm", DateTime.Now + TimeSpan.FromHours(1), DateTime.Now + TimeSpan.FromHours(2), 0, 0));

            //schUserManager.SchUsers.Add(sf);
            //schUserManager.SchUsers.Add(gf);


            //schUserManager.ExportBasicInfos(sf.SchUserID, "./SchUsers/Gong Shufan/Gong Shufan.xml");
            //schUserManager.ExportEvents(sf.SchUserID, "./SchUsers/Gong Shufan/Gong Shufan_Events.xml");
            //schUserManager.ExportBasicInfos(gf.SchUserID, "./SchUsers/Shu Gongfan/Shu Gongfan.xml");
            //schUserManager.ExportEvents(gf.SchUserID, "./SchUsers/Shu Gongfan/Shu Gongfan_Events.xml");


            //schUserManager.ImportUsers();
            //System.Console.WriteLine(schUserManager);
            //schUserManager.ImportEvents(1, "./SchUsers/");

            //Console.WriteLine(typeof(List<SchEvent>));
            //Console.ReadKey();
        }
    }
}