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
 Events_and_Classes
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm());
            SchUserManager schUserManager = new SchUserManager();

            SchUser sf = new SchUser(0, "Gong Shufan");
            sf.SchEvents.Add(new SchEvent(0, "sleep", "dorm", DateTime.Now, DateTime.Now + TimeSpan.FromHours(1), 0, 0));
            sf.SchClasses.Add(new SchClass(0, "数据库", 3.ToString(), 2.ToString(), 106.ToString(), "", 1, 16, 1, 4, "08:00", "10:35"));
            sf.SchClasses.Add(new SchClass(0, "计算机网络", 3.ToString(), 1.ToString(), 416.ToString(), "", 1, 16, 2, 4, "14:05", "16:30"));
            sf.SchClasses.Add(new SchClass(0, "操作系统", 3.ToString(), 2.ToString(), 112.ToString(), "", 1, 13, 1, 2, "08:00", "10:35"));
            sf.SchClasses.Add(new SchClass(0, "大学物理", 3.ToString(), 2.ToString(), 106.ToString(), "", 1, 16, 1, 3, "08:00", "10:35"));
            
            schUserManager.SchUsers.Add(sf);


            //schUserManager.ExportBasicInfos(sf.SchUserID, "./SchUsers/Gong Shufan.xml");
            //schUserManager.ExportEvents(sf.SchUserID, "./SchUsers/Gong Shufan_Event.xml");

            //SchUser sf = new SchUser();
            //schUserManager.SchUsers.Add(sf);
            //schUserManager.ImportUser(ref sf, "./SchUsers/Gong Shufan.xml");
            //schUserManager.ImportEvents(ref sf, "./SchUsers/Gong Shufan_Event.xml");

            Console.WriteLine(sf);
            Console.ReadKey();
=======
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm());
            Application.Run(new MainForm());
 UI_ClassTable
        }
    }
}