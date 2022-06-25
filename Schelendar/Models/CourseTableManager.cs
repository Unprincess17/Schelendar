using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Data.SQLite;

namespace Schelendar.Models
{
    public static class CourseTableManager
    {
        public static string UserDBFile = config.UserDBFile;
        public static string CourseTableDBFile = config.CourseTableFile;


        public static int AddCourseTable(/*int userID,*/ SchCourseTable table)
        {
            //生成插入字符串
            StringBuilder sbitems = new StringBuilder($"INSERT INTO SchCourseTables (CourseTableID, CourseTableName, DayCourseNumber, WeekLength"), 
                sbvalues = new StringBuilder($"VALUES(NULL, '{table.CourseTableName}', '{table.DayCourseNumber}',  '{table.WeekLength}' ");//没有用户名称字段
            for (int i = 0; i < table.EveryCourseTime.Count(); i++)
            {
                sbitems.Append($", c{i+1}_StartTime, c{i+1}_EndTime");
                sbvalues.Append($",'{table.EveryCourseTime[i]["StartTime"]}','{table.EveryCourseTime[i]["EndTime"]}'");
            }
            
            object result;
            using (SQLiteConnection cn = new SQLiteConnection("data source=" + CourseTableDBFile))
            {
                SQLiteCommand cmd = cn.CreateCommand();
                cmd.CommandText = sbitems.ToString() + ") " + sbvalues.ToString() + ");";
                cn.Open();
                //cmd.ExecuteNonQueryAsync(); 
                cmd.ExecuteNonQuery();
                cn.Close();
                cmd.CommandText = $"SELECT CourseTableID FROM SchCourseTables WHERE CourseTableName='{table.CourseTableName}';";
                cn.Open();
                result = cmd.ExecuteScalar();
                cn.Close();
            }
            return Convert.ToInt32(result);
        }

        
        public static void DeleteCourseTable(/*int userID, */int CourseTableID)
        {
            using (SQLiteConnection cn = new SQLiteConnection("data source=" + CourseTableDBFile))
            {
                SQLiteCommand cmd = cn.CreateCommand();
                cmd.CommandText = $"DELETE FROM SchCourseTables WHERE CourseTableID='{CourseTableID}';";
                cn.Open();
                //cmd.ExecuteScalarAsync();
                cmd.ExecuteScalar();
                cn.Close();
            }
        }


        public static SchCourseTable GetSchCourseTable(/*int schUserID,*/ int courseTableID)
        {
            SchCourseTable rctbl = null;
            using (SQLiteConnection cn = new SQLiteConnection("data source=" + CourseTableDBFile))
            {
                SQLiteCommand cmd = cn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM SchCourseTables WHERE CourseTableID='{courseTableID}'";
                cn.Open();
                using(SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read() == false)
                    {
                        throw new ArgumentException($"未查询到ID为{courseTableID}的课表");
                    }

                    List<Dictionary<String, CourseTime>> EveryCourseTime = new List<Dictionary<string, CourseTime>>();
                    for (int i = 0; i < Convert.ToInt32(reader["DayCourseNumber"]); i++)
                    {
                        EveryCourseTime.Add(new Dictionary<string, CourseTime>(){{"StartTime", new CourseTime(Convert.ToDateTime(reader[$"c{i + 1}_StartTime"]).Hour, Convert.ToDateTime(reader[$"c{i + 1}_StartTime"]).Minute) }, {"EndTime", new CourseTime(Convert.ToDateTime(reader[$"c{i + 1}_EndTime"]).Hour, Convert.ToDateTime(reader[$"c{i + 1}_EndTime"]).Minute) } });
                    }

                    rctbl = new SchCourseTable(
                        courseTableId: Convert.ToInt32(reader["CourseTableID"]),
                        courseTableName: reader["CourseTableName"].ToString(),
                        dayCourseNumber: Convert.ToInt32(reader["DayCourseNumber"]),
                        weekLength: Convert.ToInt32(reader["WeekLength"]),
                        everyCourseTime:EveryCourseTime);
                }
                cn.Close();
            }
            return rctbl;
        }

        public static List<SchCourseTable> GetSchCourseTables(int except)
        {
            List<SchCourseTable> rctbls = new List<SchCourseTable>();
            using (SQLiteConnection cn = new SQLiteConnection("data source=" + CourseTableDBFile))
            {
                SQLiteCommand cmd = cn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM SchCourseTables";
                cn.Open();
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (Convert.ToInt32(reader["CourseTableID"]).Equals(except)){
                            continue;
                        }
                        List<Dictionary<String, CourseTime>> EveryCourseTime = new List<Dictionary<string, CourseTime>>();
                        for (int i = 0; i < Convert.ToInt32(reader["DayCourseNumber"]); i++)
                        {
                            EveryCourseTime.Add(new Dictionary<string, CourseTime>() { { "StartTime", new CourseTime(Convert.ToDateTime(reader[$"c{i + 1}_StartTime"]).Hour, Convert.ToDateTime(reader[$"c{i + 1}_StartTime"]).Minute) }, { "EndTime", new CourseTime(Convert.ToDateTime(reader[$"c{i + 1}_EndTime"]).Hour, Convert.ToDateTime(reader[$"c{i + 1}_EndTime"]).Minute) } });
                        }
                        rctbls.Add(new SchCourseTable(
                            courseTableId: Convert.ToInt32(reader["CourseTableID"]),
                            courseTableName: reader["CourseTableName"].ToString(),
                            dayCourseNumber: Convert.ToInt32(reader["DayCourseNumber"]),
                            weekLength: Convert.ToInt32(reader["WeekLength"]),
                            everyCourseTime: EveryCourseTime));
                    }
                }


                cn.Close();
            }


            return rctbls;

        }
    }
}
