using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Xml.Serialization;
using System.IO;
using System.Text.RegularExpressions;
using System.Data.SQLite;

namespace Schelendar.Models
{
    public static class SchUserManager
    {
        public static SchUser CurrentUser { get; set; }
        public static string UserDBFile { get; set; }
        public static string CourseDBFile { get; set; }
        public static string TaskDBFile { get; set; }
        /// <summary>
        /// 学生集合
        /// </summary>

        static SchUserManager()
        {
            CurrentUser = new SchUser();

            UserDBFile = config.UserDBFile;
            CourseDBFile = config.CourseDBFile;
            TaskDBFile = config.TaskDBFile;

        }


        #region 待完成
        //public ConcurrentBag<SchUser> SchUsers { get; set; }

        /////TODO：根据添加的课程联想添加事件（考试、大作业...

        /////TODO：根据删除的时间联想删除事件

        /////TODO：事件组 事件的一种组织方式 里面的时间全部完成后才算整体完成

        /////TODO: Txt2Event
        ///// 文本处理？可以先写个处理格式化文本的
        /////"5月20号5点跑步"->SchEvent(...)
        //public void Txt2Event(string msg)
        //{
        //    List<string> fmts = new List<string>();
        //    fmts.Add("明天");

        //}


        /////TODO:每次操作的信息，持久化起来。->C# log

        #endregion

    #region 用户

        /// <summary>
        /// 添加新注册用户。若用户已存在则抛出ArgumentException
        /// </summary>
        /// <param name="user"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static void AddUser(SchUser user)
        {
            if (user == null)
            {
                throw new ArgumentNullException($"注册失败：用户{user.UserName}状态异常");
            }

            object result;
            //检查是否超过最大用户数量
            using (SQLiteConnection cn = new SQLiteConnection("data source=" + UserDBFile))
            {
                cn.Open();
                SQLiteCommand cmd = cn.CreateCommand();
                cmd.CommandText = $"SELECT COUNT(*) FROM SchUsers";
                result = cmd.ExecuteScalar();
                cn.Close();
                if (Convert.ToInt32(result) > config.MAX_USER_NUM)
                {
                    throw new ArgumentOutOfRangeException($"注册失败：已达到最大用户数量'{config.MAX_USER_NUM}',请删除不需要用户后重试，或修改配置文件");
                }
            }
            //检查重复
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection("data source=" + UserDBFile))
                {
                    cn.Open();
                    SQLiteCommand cmd = cn.CreateCommand();
                    cmd.CommandText = $"SELECT UserName FROM SchUsers where UserName='{user.UserName}'";
                    result = cmd.ExecuteScalar();
                    cn.Close();
                }
            }
            catch (Exception e)
            {
                e.Source += "用户数据连接失败";
                throw e;
            }
            ///是否重复
            if (result != null)
            {
                throw new ArgumentException($"注册失败：已存在用户名{user.UserName}");
            }
            //不重复，则添加用户至数据库
            using (SQLiteConnection cn = new SQLiteConnection("data source=" + UserDBFile))
            {
                SQLiteCommand cmd = cn.CreateCommand();
                cmd.CommandText = $"SELECT COUNT(*)";
                cn.Open();
                result = cmd.ExecuteScalar();
                cn.Close();
                user.SchUserID = Convert.ToInt32(result);//userID start from 1
                cmd.CommandText = $"INSERT INTO SchUsers VALUES(NULL,'{user.UserName}', '{user.Password}', '{user.UserExperience}','{user.IsRmbMe}','{user.IsRmbPasswd}','{user.IsAutoLogin}','{user.SchUserID/*DefaultGroupID = user.SchUserID*/}');";
                cn.Open();
                //cmd.ExecuteNonQueryAsync();
                cmd.ExecuteNonQuery();

                cn.Close();
            }
        }
        public static void ReadUser(string userName, string password)
        {
            object result;
            using (SQLiteConnection cn = new SQLiteConnection("data source=" + UserDBFile))
            {
                cn.Open();
                SQLiteCommand cmd = cn.CreateCommand();
                cmd.CommandText = $"SELECT Password FROM SchUsers where UserName='{userName}'";
                result = cmd.ExecuteScalar();
                cn.Close();
            }

            if (!password.Equals(result))
            {
                throw new ArgumentException($"用户名或密码错误");
            }
            //登陆成功
            CurrentUser.UserName = userName;
            using (SQLiteConnection cn = new SQLiteConnection("data source=" + UserDBFile))
            {
                cn.Open();
                SQLiteCommand cmd = cn.CreateCommand();
                cmd.CommandText = $"SELECT SchUserID FROM SchUsers WHERE UserName='{userName}'";
                CurrentUser.SchUserID = Convert.ToInt32(cmd.ExecuteScalar());
                //cmd.CommandText = $"SELECT UserExperience FROM SchUsers WHERE UserName='{UserName}'";
                cmd.CommandText = $"SELECT Password FROM SchUsers WHERE UserName='{userName}'";
                CurrentUser.Password = (string)cmd.ExecuteScalar();
                cmd.CommandText = $"SELECT IsRmbMe FROM SchUsers WHERE UserName='{userName}'";
                CurrentUser.IsRmbMe = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.CommandText = $"SELECT IsRmbPasswd FROM SchUsers WHERE UserName='{userName}'";
                CurrentUser.IsRmbPasswd = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.CommandText = $"SELECT IsAutoLogin FROM SchUsers WHERE UserName='{userName}'";
                CurrentUser.IsAutoLogin = Convert.ToInt32(cmd.ExecuteScalar());
                cn.Close();
            }
        }

        /// <summary>
        /// 更新指定用户信息
        /// 若指定用户不存在则抛出ArgumentException
        /// 若更新用户名格式不正确则抛出ArgumentException
        /// </summary>
        /// <c>不更新用户ID</c>
        /// <param name="oldUserName">指定用户的用户名</param>
        /// <param name="newUser">更新的用户信息</param>
        /// <exception cref="ArgumentException"></exception>
        public static bool UpdateUser(SchUser newUser)
        {
            if (newUser == null)
            {
                return false;
            }
            if (!Regex.IsMatch(newUser.UserName, @"^[\u4E00-\u9FA5A-Za-z\s]+(·[\u4E00-\u9FA5A-Za-z]+)*$"))
            {
                throw new ArgumentException("更改的用户名格式不正确，用户名只能包括汉字和英文。请重新输入");
            }//用户名检测
            //TODO:密码检测
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection("data source=" + UserDBFile))
                {
                    object result;
                    SQLiteCommand cmd = cn.CreateCommand();
                    cn.Close();
                    cmd.CommandText = $"UPDATE SchUsers SET UserName='{newUser.UserName}', Password='{newUser.Password}', UserExperience='{newUser.UserExperience}',IsRmbMe='{newUser.IsRmbMe}',IsRmbPasswd='{newUser.IsRmbPasswd}',IsAutoLogin=='{newUser.IsAutoLogin}' ,DefaultGroupID='{newUser.DefaultGroupID}' WHERE SchUserID='{CurrentUser.SchUserID}';";
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    return true;
                }
            }
            catch (ArgumentException e)
            {
                throw new ArgumentException($"未找到名称为{CurrentUser.UserName}的用户或更新用户格式有误");
            }
        }

        #endregion

    #region 课程
        /// <summary>
        /// 登录用户添加指定课程
        /// </summary>
        /// <param name="schCourse"></param>
        public static void AddCourse(SchCourse course)
        {
            SchCourseManager.AddCourse(CurrentUser.SchUserID, course);
        }

        ///TODO:update course
        public static void UpdateCourse(string oldCourseName, SchCourse course)
        {
            SchCourseManager.UpdateCourse(CurrentUser.SchUserID, oldCourseName, course);
        }

        /// <summary>
        /// 返回登录用户的课程列表
        /// </summary>
        /// <returns></returns>
        public static List<SchCourse> GetCourses()
        {
            return SchCourseManager.GetCourses(CurrentUser.SchUserID);
        }

        /// <summary>
        /// 返回登录用户指定学期的课程列表
        /// </summary>
        /// /// <returns></returns>
        public static List<SchCourse> GetCourses(int semester)
        {
            return SchCourseManager.GetCourses(CurrentUser.SchUserID, semester);           
        }

        /// <summary>
        /// 删除用户的课程
        /// </summary>
        /// <param name="courseName"></param>
        public static void DeleteCourse(string courseName)
        {
            SchCourseManager.DeleteCourse(CurrentUser.SchUserID, courseName);
        }

        #endregion

    #region 任务

        #region 单任务
        /// <summary>
        /// 将任务添加至指定组。若未指定，则添加至0组。若选择force，将创建的之前未创建的任务组
        /// </summary>
        /// <param name="task"></param>
        /// <param name="TaskGroupID"></param>
        /// <param name="force">若任务组未创建，则创建任务组。此项为0时若任务组未创建则抛出异常</param>
        public static void AddTask(SchTask task, int TaskGroupID=0, int force = 0)
        {
            SchTaskManager.AddTask(CurrentUser.SchUserID, task, TaskGroupID, force);
        }

        /// <summary>
        /// 删除指定任务
        /// </summary>
        /// <param name="taskName"></param>
        public static void DeleteTask(string taskName)
        {
            SchTaskManager.DeleteTask(CurrentUser.SchUserID, taskName);
        }
        
        public static void DeleteTask(int taskID)
        {
            SchTaskManager.DeleteTask(CurrentUser.SchUserID, taskID);
        }

        /// <summary>
        /// 更新指定任务
        /// </summary>
        /// <param name="oldTaskName"></param>
        /// <param name="newTask"></param>
        public static void UpdateTask(string oldTaskName, SchTask newTask)
        {
            SchTaskManager.UpdateTask(CurrentUser.SchUserID, oldTaskName, newTask);
        }

        /// <summary>
        /// 将所选事件更换组，可用于将未分类事件归类
        /// </summary>
        /// <param name="taskID"></param>
        /// <param name="newGroupID"></param>
        public static void ChangeGroup(int taskID, int newGroupID)
        {
            SchTaskManager.changeGroup(CurrentUser.SchUserID, taskID, newGroupID);           
        }

        public static void GetTasks()
        {   
            SchTaskManager.GetTasks(CurrentUser.SchUserID);
        }

        #endregion 

        #region 任务组
        /// <summary>
        /// 获取事件所属事件组
        /// </summary>
        /// <param name="taskID"></param>
        /// <returns></returns>
        public static List<SchTask> GetGroupofTask(int taskID, int notDone = 0)
        {
            return SchTaskManager.GetGroup(CurrentUser.SchUserID, taskID, notDone);
        }
        /// <summary>
        /// 获取事件所属事件组的事件列表
        /// </summary>
        /// <param name="taskName"></param>
        public static List<SchTask> GetGroupofTask(string taskName, int notDone = 0)
        {
            return SchTaskManager.GetGroup(CurrentUser.SchUserID, taskName, notDone);
        }

        /// <summary>
        /// 返回事件组列表
        /// </summary>
        /// <returns></returns>
        public static List<SchTaskGroup> GetGroups()
        {   
           return SchTaskManager.GetGroups(CurrentUser.SchUserID);
        }

        public static void UpdateGroup(int groupID, SchTaskGroup newgroup)
        {
            SchTaskManager.UpdateGroup(CurrentUser.SchUserID, groupID, newgroup);
        }
        #endregion

        #endregion

        public static new string ToString()
        {
            return CurrentUser.ToString();
        }
    }
}
