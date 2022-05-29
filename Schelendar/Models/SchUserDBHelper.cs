using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System.Data.SQLite;

namespace Schelendar.Models
{
    public class SchUserDBHelper
    {
        /// <summary>
        /// 创建用户表
        /// </summary>
        public void CreateUsersDB(string fileName = "SchUsers.db")
        {
            if (File.Exists(fileName) == false)//不存在用户文件
            {
                SQLiteConnection.CreateFile(fileName);//创建数据库
            }
            SQLiteConnection cn = new SQLiteConnection("data source=" + fileName);//建立连接对象
            SQLiteCommand cmd = new SQLiteCommand();

            //当没有用户表时建立用户表
            cmd.Connection = cn;
            cmd.CommandText =
                "CREATE TABLE IF NOT EXISTS SchUsers(" +
                "SchUserID int PRIMARY KEY," +
                "UserName varchar(10)," +
                "Password varchar(100)," +
                "UserExperience int," +
                "IsRmbMe int," +
                "IsRmbPasswd int," +
                "IsAutoLogin int" +
                ")";
            cn.Open();//连接
            cmd.ExecuteNonQuery();
            cn.Close();//关闭连接

        }

        public void CreateCoursesDB(string fileName = "Courses.db")
        {
            if (File.Exists(fileName) == false)//不存在课程文件
            {
                SQLiteConnection.CreateFile(fileName);
            }

            //当没有用户表时建立用户表
            using (SQLiteConnection cn = new SQLiteConnection("data source=" + fileName))
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText =
                    "SchCourseID int NOT NULL," +
                    "SchUserID int," +
                    "SchCourseName varchar(100) NOT NULL," +
                    "District varchar(100)," +
                    "Building varchar(100)," +
                    "Classroom varchar(100)," +
                    "TeacherName varchar(100)," +
                    "StartWeek int," +
                    "EndWeek int," +
                    "DayofWeek int," +
                    "Semaster int," +
                    "StartTime varchar(100)," +
                    "EndTime varchar(100)," +
                    "FOREIGN KEY (SchCourseID)," +
                    "FOREIGN KEY (SchUserID) REFERENCES SchUsers(SchUserID)" +
                    ")";
                cmd.ExecuteNonQuery();
                cn.Close();//关闭连接

            }
        }
        
        public void CreateTasksDB(string fileName = "Tasks.db")
        {
            if (File.Exists(fileName) == false)//不存在任务文件
            {
                SQLiteConnection.CreateFile(fileName);
            }
            
            //当没有用户表时建立用户表
            using(SQLiteConnection cn = new SQLiteConnection("data source=" + fileName))
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText =
                    "SchTaskID int NOT NULL," +
                    "SchTaskGroupID int," +
                    "SchUserID int," +
                    "SchTaskInfo varchar(100) NOT NULL," +
                    "SchTaskLocation varchar(100)," +
                    "StartDate datetime," +
                    "EndDate datetime," +
                    "isRepeat int," +
                    "isDone int," +
                    "FOREIGN KEY (SchTaskID)," +
                    "FOREIGN KEY (SchUserID) REFERENCES SchUsers(SchUserID)" +
                    ")";
                
                cmd.ExecuteNonQuery();
                cn.Close();//关闭连接

            }
        }
    }
}
