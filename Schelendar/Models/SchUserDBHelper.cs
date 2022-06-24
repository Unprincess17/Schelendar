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
        public void CreateUsersDB()
        {
            string fileName = config.UserDBFile;
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
                "[SchUserID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                "[UserName] varchar(10)," +
                "[Password] varchar(100)," +
                "[UserExperience] INTEGER," +
                "[IsRmbMe] INTEGER," +
                "[IsRmbPasswd] INTEGER," +
                "[IsAutoLogin] INTEGER," +
                "[DefaultGroupID] INTEGER," +
                "[DefaultSemester] INTERGER" +
                ")";
            cn.Open();//连接
            cmd.ExecuteNonQuery();
            cn.Close();//关闭连接

            //Trigger for update defaultGroupID
            //"CREATE TRIGGER SET_DEFAULT_GROUP " +
            //"AFTER INSERT ON SchTaskGroups " +
            //"BEGIN " +
            //"UPDATE SchUsers SET DefaultGroupID=New.SchTaskGroupID WHERE SchUsers.SchUserID=OLD.SchUserID AND OLD.DefaultGroupID=NULL" +
            //"END" +

        }


        public void CreateCoursesDB()
        {
            string fileName = config.CourseDBFile;
            if (File.Exists(fileName) == false)//不存在课程文件
            {
                SQLiteConnection.CreateFile(fileName);
            }

            using (SQLiteConnection cn = new SQLiteConnection("data source=" + fileName))
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText =
                    "CREATE TABLE IF NOT EXISTS [SchCourses](" +
                    "[SchCourseID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                    "[SchCourseName] varchar(100) NOT NULL," +
                    "[District] varchar(100)," +
                    "[Building] varchar(100)," +
                    "[Classroom] varchar(100)," +
                    "[TeacherName] varchar(100)," +
                    "[StartWeek] int," +
                    "[EndWeek] int," +
                    "[DayofWeek] int," +
                    "[Semester] int," +
                    "[StartTime] INTEGER," +
                    "[EndTime] INTEGER," +
                    /*"FOREIGN KEY (SchCourseID)," +*/
                    "[SchUserID] int NOT NULL," +
                    "FOREIGN KEY(SchUserID) REFERENCES SchUsers(SchUserID)" +
                    ");";
                cmd.ExecuteNonQuery();
                cn.Close();//关闭连接

            }
        }

        /// <summary>
        /// 创建任务表，同时创建任务组表
        /// </summary>
        public void CreateTasksDB()
        {
            string fileName = config.TaskDBFile;
            if (File.Exists(fileName) == false)//不存在任务文件
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
                    "CREATE TABLE IF NOT EXISTS [SchTasks](" +
                    "[SchTaskID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                    "[SchTaskInfo] varchar(100) NOT NULL," +
                    "[SchTaskLocation] varchar(100)," +
                    "[StartDate] datetime," +
                    "[EndDate] datetime," +
                    "[isRepeat] INTEGER," +
                    "[isDone] INTEGER," +
                    "[SchTaskGroupID] INTEGER NOT NULL," +
                    "[SchUserID] INTEGER NOT NULL," +
                    "FOREIGN KEY(SchTaskGroupID) REFERENCES SchTaskGroups(SchTaskGroupID)" +
                    "FOREIGN KEY(SchUserID) REFERENCES SchUsers(SchUserID)" +
                    ")";

                cmd.ExecuteNonQuery();
                cn.Close();//关闭连接

            }
            this.CreateTaskGroupsDB();
        }

        public void CreateTaskGroupsDB()
        {
            string fileName = config.TaskGroupDBFile;
            if (File.Exists(fileName) == false)//不存在任务组文件
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
                    "CREATE TABLE IF NOT EXISTS [SchTaskGroups](" +
                    "[SchTaskGroupID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                    "[SchGroupInfo] varchar(100)," +
                    "[SchUserID] INTEGER NOT NULL," +
                    "[TomatoNum] INTEGER," +
                    "FOREIGN KEY(SchUserID) REFERENCES SchUsers(SchUserID)" +
                    ")";

                cmd.ExecuteNonQuery();
                cn.Close();//关闭连接
            }
        }


        public void CreateCourseTableDB()
        {
            string fileName = config.CourseTableFile;
            if (File.Exists(fileName) == false)//不存在任务组文件
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
                    "CREATE TABLE IF NOT EXISTS [SchCourseTables](" +
                    "[CourseTableID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                    "[CourseTableName] varchar(100)," +
                    "[DayCourseNumber] INTEGER," +
                    //"[StartDateTime] DATETIME," +
                    "[WeekLength] INTEGER," +
                    "[c1_StartTime] varchar(100)," + 
                    "[c1_EndTime] varchar(100)," + 
                    "[c2_StartTime] varchar(100)," + 
                    "[c2_EndTime] varchar(100)," + 
                    "[c3_StartTime] varchar(100)," + 
                    "[c3_EndTime] varchar(100)," + 
                    "[c4_StartTime] varchar(100)," + 
                    "[c4_EndTime] varchar(100)," + 
                    "[c5_StartTime] varchar(100)," + 
                    "[c5_EndTime] varchar(100)," + 
                    "[c6_StartTime] varchar(100)," + 
                    "[c6_EndTime] varchar(100)," + 
                    "[c7_StartTime] varchar(100)," + 
                    "[c7_EndTime] varchar(100)," + 
                    "[c8_StartTime] varchar(100)," + 
                    "[c8_EndTime] varchar(100)," + 
                    "[c9_StartTime] varchar(100)," + 
                    "[c9_EndTime] varchar(100)," + 
                    "[c10_StartTime] varchar(100)," + 
                    "[c10_EndTime] varchar(100)," + 
                    "[c11_StartTime] varchar(100)," + 
                    "[c11_EndTime] varchar(100)," + 
                    "[c12_StartTime] varchar(100)," + 
                    "[c12_EndTime] varchar(100)," + 
                    "[c13_StartTime] varchar(100)," + 
                    "[c13_EndTime] varchar(100)," + 
                    "[c14_StartTime] varchar(100)," + 
                    "[c14_EndTime] varchar(100)," + 
                    "[c15_StartTime] varchar(100)," + 
                    "[c15_EndTime] varchar(100)," + 
                    "[c16_StartTime] varchar(100)," + 
                    "[c16_EndTime] varchar(100)," + 
                    "[c17_StartTime] varchar(100)," + 
                    "[c17_EndTime] varchar(100)," + 
                    "[c18_StartTime] varchar(100)," + 
                    "[c18_EndTime] varchar(100)," + 
                    "[c19_StartTime] varchar(100)," + 
                    "[c19_EndTime] varchar(100)," + 
                    "[c20_StartTime] varchar(100)," + 
                    "[c20_EndTime] varchar(100)" + 
                    ")";

                cmd.ExecuteNonQuery();
                cn.Close();//关闭连接
            }
        }

        public void initDB()
        {
            this.CreateUsersDB();
            this.CreateTasksDB();
            this.CreateCoursesDB();
            this.CreateCourseTableDB();
        }
    }
    public class FarmDBHelper
        {
            public void create()
            {
                var fileName = config.FarmDBFile;
                if (File.Exists(fileName) == false)//不存在用户文件
                {
                    SQLiteConnection.CreateFile(fileName);//创建数据库
                }
                SQLiteConnection cn = new SQLiteConnection("data source=" + fileName);//建立连接对象
                SQLiteCommand cmd = new SQLiteCommand();

                //当没有用户表时建立用户表
                cn.Open();//连接
                cmd.Connection = cn;
                cmd.CommandText =
                    "CREATE TABLE IF NOT EXISTS FarmUsers(" +
                    "username varchar(10) UNIQUE," +
                    "password varchar(100)," +
                    "lv int," +
                    "expnow int," +
                    "expmax int," +
                    "gold int," +
                    "seed1 int,seed2 int,seed3 int,seed4 int,seed5 int,seed6 int,seed7 int,seed8 int,seed9 int,seed10 int,seed11 int,seed12 int,seed13 int,seed14 int,seed15 int,seed16 int," +
                    "unlocked1 int,unlocked2 int,unlocked3 int,unlocked4 int,unlocked5 int,unlocked6 int,unlocked7 int,unlocked8 int,unlocked9 int,unlocked10 int,unlocked11 int,unlocked12 int," +
                    "planted1 int,planted2 int,planted3 int,planted4 int,planted5 int,planted6 int,planted7 int,planted8 int,planted9 int,planted10 int,planted11 int,planted12 int," +
                    "ts1 int,ts2 int,ts3 int,ts4 int,ts5 int,ts6 int,ts7 int,ts8 int,ts9 int,ts10 int,ts11 int,ts12 int" +
                    ")";
                cmd.ExecuteNonQuery();
                cn.Close();//关闭连接

            }
        }
}

