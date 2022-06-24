using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schelendar.Models
{
    public static class config
    {
        public static string UserDBFile { get; set; }
        public static string CourseDBFile { get; set; }
        public static string TaskDBFile { get; set; }
        public static string FarmDBFile { get; set; }
        public static string TaskGroupDBFile { get; set; }

        public static String CourseTableFile { get; set; }
        public static int MAX_USER_NUM { get; set; }


        static config()
        {
            UserDBFile = "SchInfos.db";
            CourseDBFile = "SchInfos.db";
            TaskDBFile = "SchInfos.db";
            TaskGroupDBFile = "SchInfos.db";
            CourseTableFile = "SchInfos.db";
            FarmDBFile = "FarmUsers.db";
            MAX_USER_NUM = 10;

        }

    }
}
