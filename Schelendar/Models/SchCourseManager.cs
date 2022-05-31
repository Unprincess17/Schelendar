﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Data.SQLite;

namespace Schelendar.Models
{
    /// <summary>
    /// 对课程的管理
    /// </summary>
    public static class SchCourseManager
    {
        public static string UserDBFile = config.UserDBFile;
        public static string CourseDBFile = config.CourseDBFile;

        public static void AddCourse(int UserID, SchCourse course)
        {
            if (course == null)
            {
                throw new ArgumentNullException($"添加失败：课程{course.SchCourseName}状态异常");
            }

            object result;
            try
            {
                SchCourse tmpCourse = null;
                //判断是否有重名课程、是否有时间冲突课程
                using (SQLiteConnection cn = new SQLiteConnection("data source=" + CourseDBFile))
                {
                    SQLiteCommand cmd = cn.CreateCommand();
                    cn.Open();
                    cmd.CommandText = $"SELECT * FROM SchCourses WHERE SchUserID='{UserID}'";
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //只根据课程名判断是否有课程重复
                            //TODO: 重写course类的Equals，并在这里使用。Equals判断名字、时间等更多信息
                            if (reader["SchCourseName"].ToString().Equals(course.SchCourseName))
                            {
                                throw new ArgumentException($"添加失败：已存在课程{course.SchCourseName}");
                            }
                            tmpCourse = new SchCourse(reader["SchCourseName"].ToString(), reader["District"].ToString(), reader["Building"].ToString(), reader["Classroom"].ToString(), reader["TeacherName"].ToString(), Convert.ToInt32(reader["StartWeek"]), Convert.ToInt32(reader["EndWeek"]), Convert.ToInt32(reader["DayofWeek"]), Convert.ToInt32(reader["Semaster"]), reader["StartTime"].ToString(), reader["EndTime"].ToString(), Convert.ToInt32(reader["SchCourseID"]));
                            if (SchCourse.isConflicted(course, tmpCourse) == 1)
                            {
                                throw new ArgumentException(message: $"添加失败：课程{course.SchCourseName}与{tmpCourse.SchCourseName}时间重复", paramName: $"{course.SchCourseName}");
                            }
                        }
                    }

                    cn.Close();
                }
            }
            catch (ArgumentException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                e.Source += "添加失败";
                throw e;
            }

            //不重复，则添加课程至数据库
            using (SQLiteConnection cn = new SQLiteConnection("data source=" + CourseDBFile))
            {
                SQLiteCommand cmd = cn.CreateCommand();
                cmd.CommandText = $"SELECT COUNT(*)";
                cn.Open();
                result = cmd.ExecuteScalar();
                cn.Close();
                course.SchCourseID = Convert.ToInt32(result);//courseID start from 1
                cmd.CommandText = $"INSERT INTO SchCourses VALUES(NULL, '{course.SchCourseName}', '{course.ClassLocation.District}', '{course.ClassLocation.Building}', '{course.ClassLocation.Classroom}', '{course.TeacherName}', '{course.StartWeek}','{course.EndWeek}','{course.DayofWeek}','{course.Semaster}','{course.StartTime}','{course.EndTime}','{UserID}');";
                cn.Open();
                //cmd.ExecuteNonQueryAsync();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public static List<SchCourse> GetCourses(int UserID)
        {
            List<SchCourse> CourseList = new List<SchCourse>();
            using (SQLiteConnection cn = new SQLiteConnection("data source=" + CourseDBFile))
            {
                SQLiteCommand cmd = cn.CreateCommand();

                cmd.CommandText = $"SELECT * FROM SchCourses WHERE SchUserID='{UserID}';";
                cn.Open();
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CourseList.Add(new SchCourse(reader["SchCourseName"].ToString(), reader["District"].ToString(), reader["Building"].ToString(), reader["Classroom"].ToString(), reader["TeacherName"].ToString(), Convert.ToInt32(reader["StartWeek"]), Convert.ToInt32(reader["EndWeek"]), Convert.ToInt32(reader["Semaster"]), Convert.ToInt32(reader["StartWeek"]), reader["StartTime"].ToString(), reader["EndTime"].ToString(), Convert.ToInt32(reader["SchCourseID"])));
                    }
                }

                cn.Close();
            }
            return CourseList;
        }

        public static List<SchCourse> GetCourses(int UserID, int semaster)
        {
            try
            {
                List<SchCourse> CourseList = new List<SchCourse>();
                using (SQLiteConnection cn = new SQLiteConnection("data source=" + CourseDBFile))
                {
                    SQLiteCommand cmd = cn.CreateCommand();

                    cmd.CommandText = $"SELECT * FROM SchCourses WHERE SchUserID='{UserID}' AND Semaster='{semaster}';";
                    cn.Open();
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CourseList.Add(new SchCourse(reader["SchCourseName"].ToString(), reader["District"].ToString(), reader["Building"].ToString(), reader["Classroom"].ToString(), reader["TeacherName"].ToString(), Convert.ToInt32(reader["StartWeek"]), Convert.ToInt32(reader["EndWeek"]), Convert.ToInt32(reader["Semaster"]), Convert.ToInt32(reader["StartWeek"]), reader["StartTime"].ToString(), reader["EndTime"].ToString(), Convert.ToInt32(reader["SchCourseID"])));
                        }
                    }

                    cn.Close();
                }
                return CourseList;
            }catch(Exception e)
            {
                e.Source += "获取课程时异常";
                throw e;
            }
        }

        public static void DeleteCourse(int UserID, string courseName)
        {
            object result;
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection("data source=" + CourseDBFile))
                {
                    cn.Open();
                    SQLiteCommand cmd = cn.CreateCommand();
                    cmd.CommandText = $"DELETE FROM SchCourses WHERE SchUserID='{UserID}' AND SchCourseName='{courseName}'";
                    result = cmd.ExecuteScalar();
                    cn.Close();
                }
            }
            catch (Exception e)
            {
                e.Source += $"课程{courseName}删除失败";
                throw e;
            }
        }

    }
}
