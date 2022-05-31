using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schelendar.Models
{
    public static class SchTaskManager
    {
        public static string UserDBFile = config.UserDBFile;
        public static string TaskDBFile = config.TaskDBFile;

        public static void AddTask(int UserID, SchCourse course)
        {
            throw new NotImplementedException();    
        }

        public static List<SchCourse> GetTasks(int UserID) {
            throw new NotImplementedException();
        }

        public static List<SchCourse> GetGroup(int UserID, int semaster) {
            throw new NotImplementedException();
        }

        public static void DeleteTask(int UserID, string courseName) {
            throw new NotImplementedException();
        }
    }
}
