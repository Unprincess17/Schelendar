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
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm());
            SchUserManager schUserManager = new SchUserManager();

            //SchUser sf = new SchUser(0, "Gong Shufan");
            //sf.SchEvents.Add(new SchEvent(0, "sleep", "dorm", DateTime.Now, DateTime.Now + TimeSpan.FromHours(1), 0, 0));
            //sf.SchClasses.Add(new SchClass(0, "数据库", 3.ToString(), 2.ToString(), 106.ToString(), "", 1, 16, 1, DateTime.Parse("08:00"), DateTime.Parse("10:35")));
            //schUserManager.SchUsers.Add(sf);
            //schUserManager.ExportBasicInfos(sf.SchUserID, "./SchUsers/Gong Shufan.xml");
            //schUserManager.ExportEvents(sf.SchUserID, "./SchUsers/Gong Shufan_Event.xml");

            SchUser sf = new SchUser();
            schUserManager.SchUsers.Add(sf);
            schUserManager.ImportUser(ref sf, "./SchUsers/Gong Shufan.xml");
            schUserManager.ImportEvents(ref sf, "./SchUsers/Gong Shufan_Event.xml");

            Console.WriteLine(sf);
            Console.ReadKey();
        }
    }
}
