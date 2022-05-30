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
        public static SchUser User { get; set; }
        public static string UserDBFile { get; set; }
        public static string CourseDBFile { get; set; }
        public static string TaskDBFile { get; set; }
        /// <summary>
        /// 学生集合
        /// </summary>

        static SchUserManager()
        {
            User = new SchUser();

            UserDBFile = "SchInfos.db";
            CourseDBFile = "SchInfos.db";
            TaskDBFile = "SchInfos.db";

        }


        #region 非数据库连接
        //public ConcurrentBag<SchUser> SchUsers { get; set; }

        ///// <summary>
        ///// 尝试删除用户，若查询不到则抛出ArgumentException
        ///// </summary>
        ///// <param name="userID"></param>
        ///// <exception cref="ArgumentException"></exception>
        //public void TryDeleteUser(int userID)
        //{
        //    if (!SchUsers.Any(o => o.SchUserID.Equals(userID)))
        //    {
        //        throw new ArgumentException("没有符合条件的用户");
        //    }
        //    SchUser u = SchUsers.FirstOrDefault(o => o.SchUserID.Equals(userID));
        //    SchUsers.TryTake(out u);
        //}


        ///// <summary>
        ///// 查询指定用户名的用户
        ///// </summary>
        ///// <param name="Name"></param>
        ///// <returns></returns>
        ///// <exception cref="ArgumentException"></exception>
        //public SchUser GetUserByName(string Name)
        //{
        //    if (SchUsers.All(o => o.UserName.Equals(Name)))
        //    {
        //        return SchUsers.FirstOrDefault(o => o.UserName.Equals(Name));
        //    }
        //    throw new ArgumentException($"未查询到名称为{Name}的用户，请检查输入");
        //}

        ///// <summary>
        ///// 根据用户ID和学期号获取课程
        ///// </summary>
        ///// <param name="userID"></param>
        ///// <param name="semasterID">学期号</param>
        ///// <returns></returns>
        ///// <exception cref="ArgumentException"></exception>
        //public List<SchCourse> GetUserSemasterClasses(int userID, int semasterID)
        //{
        //    try
        //    {
        //        return SchUsers.First(o => o.SchUserID.Equals(userID)).SchClasses.Where(c => c.Semaster.Equals(semasterID)).ToList();
        //    }
        //    catch(ArgumentNullException e)
        //    {
        //        throw new ArgumentException($"未查询到ID为{userID}的用户，请检查输入");
        //    }
        //}

        ///// <summary>
        ///// 根据用户名和学期号获取课程
        ///// </summary>
        ///// <param name="userName"></param>
        ///// <param name="semasterID"></param>
        ///// <returns></returns>
        ///// <exception cref="ArgumentException"></exception>
        //public List<SchCourse> GetUserSemasterClasses(string userName, int semasterID)
        //{
        //    try
        //    {
        //        return GetUserSemasterClasses(SchUsers.First(o => o.UserName.Equals(userName)).SchUserID, semasterID);
        //    }
        //    catch(ArgumentException e)
        //    {
        //        throw new ArgumentException($"未查询到名为{userName}的用户，请检查输入");
        //    }
        //}

        /////这两个功能应该蛮常用的？或者说怎么样维护一个运行时的用户信息？
        ///// 1.当main运行的时候，维护一个用户（信息的持久化、信息的更改）。每次修改课程、事件等信息时，实际是修改该用户的指定信息--->不需要一个用户管理类的管理列表了吗？（既然每次都肯定是对指定用户的操作）--->或者说维护的这个管理列表里只有一个用户，其他用户想要被管理需要登出当前的（删除列表元素），登入新的（添加进列表中）
        /////TODO：为用户增加课程
        //public void AddClass(int userID, SchCourse c)
        //{
        //    try
        //    {
        //        SchUsers.First(o=>o.SchUserID.Equals(userID)).SchClasses.Add(c);
        //    }
        //    catch(ArgumentNullException e)
        //    {
        //        throw new ArgumentNullException($"未找到ID为{userID}的用户，请重新检查输入");
        //    }
        //}
        /////TODO：根据添加的课程联想添加事件（考试、大作业...

        /////TODO: 删除用户指定课程
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

        /////TODO: ShareEventByEmails

        /////TODO: GetEventByEmail
        /////这个功能隔一段时间调用一次
        /////需要用户的邮箱权限？
        /////

        /////TODO:每次操作的信息，持久化起来。->C# log

        /////TODO: path的赋值的检测
        ///// <summary>
        ///// 从path导入指定ID的用户
        ///// </summary>
        ///// <param name="path"></param>
        ///// <param name="userID"></param>
        ///// <exception cref="Exception"></exception>
        //public void ImportUser(ref SchUser user, string path)
        //{
        //    try
        //    {
        //        XmlSerializer xmlSerializer = new XmlSerializer(typeof(SchUser));
        //        using (FileStream fs = new FileStream(path, FileMode.Open))
        //        {
        //            user = ((SchUser)xmlSerializer.Deserialize(fs));
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception($"Exception when importing, please check the correctness of the path: {path}");
        //    }
        //}

        ///// <summary>
        ///// 导入全部用户基本信息,刨除Event和Class
        ///// </summary>
        ///// <param name="path">到SchUsers级</param>
        ///// <exception cref="Exception"></exception>
        //public void ImportUsers(string path = "./SchUsers")
        //{
        //    try
        //    {
        //        XmlSerializer xmlSerializer = new XmlSerializer(typeof(SchUser));
        //        foreach (object d in Directory.EnumerateDirectories(path)) 
        //        {
        //            string dir = d as string;
        //            string XmltoExecute = dir + "\\" + dir.Substring(dir.LastIndexOf("\\")+1) + ".xml";
        //            //Console.WriteLine(XmltoExecute);
        //            using (FileStream fs = new FileStream(XmltoExecute, FileMode.Open))
        //            {

        //                SchUsers.Add((SchUser)xmlSerializer.Deserialize(fs));
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception($"Exception when importing, please check the correctness of the path: {path}");
        //    }
        //}


        /////TODO: path的赋值的检测
        ///// <summary>
        ///// 从path导入指定ID的用户的课程
        ///// </summary>
        ///// <param name="path"></param>
        ///// <param name="userID"></param>
        ///// <exception cref="Exception"></exception>
        //public void ImportClasses(int userID, string path)
        //{
        //    try
        //    {
        //        ///HACK:类型问题。Bag不能被序列化
        //        XmlSerializer xmlSerializer = new XmlSerializer(typeof(ConcurrentBag<SchTask>));
        //        SchUser user = SchUsers.First(o => o.SchUserID.Equals(userID));
        //        using (FileStream fs = new FileStream(path, FileMode.Open))
        //        {
        //            user.SchClasses = (ConcurrentBag<SchCourse>)xmlSerializer.Deserialize(fs);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception($"Exception when importing, please check the correctness of the path: {path}");
        //    }
        //}

        /////TODO: path的赋值的检测
        ///// <summary>
        ///// 从path导入指定ID的用户的事件
        ///// </summary>
        ///// <param name="userID">eg. 0</param>
        ///// <param name="path">Users Directory. Eg. "./SchUsers/</param>
        ///// <exception cref="Exception"></exception>
        //public void ImportEvents(int userID, string _path)
        //{
        //    try
        //    {
        //        ///HACK:类型问题。Bag不能被序列化
        //        SchUser user = SchUsers.First(o => o.SchUserID.Equals(userID));
        //        if(user == null)
        //        {
        //            throw new ArgumentNullException($"未找到ID为{userID}的用户，请重新检查输入");
        //        }
        //        List<SchTask> events_list = new List<SchTask>();
        //        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<SchTask>));
        //        string path = _path + "\\" + user.UserName + "\\" + user.UserName + ".xml";
        //        //ConcurrentBag<SchEvent> events;
        //        if (!File.Exists(path))
        //        {
        //            throw new ArgumentException($"Exception when importing, please check the correctness of the path: {path}");
        //        }
        //        using (FileStream fs = new FileStream(path, FileMode.Open))
        //        {
        //            events_list = xmlSerializer.Deserialize(fs) as List<SchTask>;
        //        }
        //        foreach(SchTask e in events_list)
        //        {
        //            user.SchEvents.Add(e);
        //        }
        //    }
        //    catch (ArgumentException e1)
        //    {
        //        throw e1;
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message);
        //    }
        //}

        /////TODO: path路径指向SchUsers/{userID}/.xml
        /////HACK: 用户名字段作文件夹名不安全，需要创建或修改时检测
        ///// <summary>
        ///// 导出学生基本数据
        ///// </summary>
        ///// <param name="path">导出路径</param>
        ///// <param name="userID">学生ID信息</param>
        ///// <exception cref="Exception"></exception>
        //public void ExportBasicInfos(int userID, string path)
        //{
        //    try
        //    {
        //        XmlSerializer xmlSerializer = new XmlSerializer(typeof(SchUser));
        //        using (FileStream fs = new FileStream(path, FileMode.Create))
        //        {
        //            xmlSerializer.Serialize(fs, this.SchUsers.First(o=>o.SchUserID.Equals(userID)));
        //        }
        //    }
        //    catch(NullReferenceException e1)
        //    {
        //        //throw new Exception("Please check userID");
        //        Console.WriteLine($"Exception when exporting, please check the correctness of the path: {path}");
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception($"{e.Message}");
        //    }
        //}

        /////TODO: path路径指向SchUsers/{userID}/.xml
        ///// <summary>
        ///// 存储用户的事件
        ///// </summary>
        ///// <param name="userID">用户ID字段</param>
        ///// <param name="path">输出路径</param>
        ///// <exception cref="Exception"></exception>
        //public void ExportEvents(int userID, string path) {
        //    try
        //    {
        //        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<SchTask>));
        //        using (FileStream fs = new FileStream(path/* + schuser.FirstOrDefault().UserName + "_Events.xml"*/, FileMode.Create))
        //        {
        //            xmlSerializer.Serialize(fs, this.SchUsers.Where(o => o.SchUserID.Equals(userID)).First().SchEvents.ToList());
        //        }
        //    }
        //    catch (NullReferenceException e1)
        //    {
        //        //throw new Exception("Please check userID");
        //        Console.WriteLine(e1.Message + "\n" + e1.InnerException.Message);
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception($"Exception when Exporting, please check the path or anything\n{e.Message}");
        //    }
        //}

        /////TODO: path路径指向SchUsers/{userID}/.xml
        ///// <summary>
        ///// 存储用户的课程
        ///// </summary>
        ///// <param name="userID">用户ID字段</param>
        ///// <param name="path">输出路径</param>
        ///// <exception cref="Exception"></exception>
        //public void ExportClasses(int userID, string path)
        //{
        //    try
        //    {
        //        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<SchCourse>));
        //        using (FileStream fs = new FileStream(path, FileMode.Create))
        //        {
        //            xmlSerializer.Serialize(fs, this.SchUsers.Where(o => o.SchUserID.Equals(userID)).First().SchClasses.ToList());
        //        }
        //    }
        //    catch (NullReferenceException e1)
        //    {
        //        //throw new Exception("Please check userID");
        //        Console.WriteLine($"Exception when Exporting, please check the correctness of the path: {path}");
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception($"{e.Message}");
        //    }
        //}
        #endregion

        #region 数据库连接

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
                cmd.CommandText = $"INSERT INTO SchUsers VALUES('{result}','{user.UserName}', '{user.Password}', '{user.UserExperience}','{user.IsRmbMe}','{user.IsRmbPasswd}','{user.IsAutoLogin}');";
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

            //if(result == null)
            //{
            //    throw new ArgumentNullException($"未查询到名称为{UserName}的用户，请检查输入");
            //}

            if (!password.Equals(result))
            {
                throw new ArgumentException($"用户名或密码错误");
            }
            else
            {//登陆成功
                User.UserName = userName;
                using(SQLiteConnection cn = new SQLiteConnection("data source=" + UserDBFile))
                {
                    cn.Open();
                    SQLiteCommand cmd = cn.CreateCommand();
                    cmd.CommandText = $"SELECT SchUserID FROM SchUsers WHERE UserName='{userName}'";
                    User.SchUserID = Convert.ToInt32(cmd.ExecuteScalar());
                    //cmd.CommandText = $"SELECT UserExperience FROM SchUsers WHERE UserName='{UserName}'";
                    cmd.CommandText = $"SELECT Password FROM SchUsers WHERE UserName='{userName}'";
                    User.Password = (string)cmd.ExecuteScalar();
                    cmd.CommandText = $"SELECT IsRmbMe FROM SchUsers WHERE UserName='{userName}'";
                    User.IsRmbMe = (int)cmd.ExecuteScalar();
                    cmd.CommandText = $"SELECT IsRmbPasswd FROM SchUsers WHERE UserName='{userName}'";
                    User.IsRmbPasswd = (int)cmd.ExecuteScalar();
                    cmd.CommandText = $"SELECT IsAutoLogin FROM SchUsers WHERE UserName='{userName}'";
                    User.IsAutoLogin = (int)cmd.ExecuteScalar();
                    cn.Close();
                }
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
                    cmd.CommandText = $"UPDATE SchUsers SET UserName='{newUser.UserName}', Password='{newUser.Password}', UserExperience='{newUser.UserExperience}',IsRmbMe='{newUser.IsRmbMe}',IsRmbPasswd='{newUser.IsRmbPasswd}',IsAutoLogin=='{newUser.IsAutoLogin}' WHERE SchUserID='{User.SchUserID}';";
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    return true;
                }
            }
            catch (ArgumentException e)
            {
                throw new ArgumentException($"未找到名称为{User.UserName}的用户或更新用户格式有误");
            }
        }

        /// <summary>
        /// 登录用户添加指定课程
        /// </summary>
        /// <param name="schCourse"></param>
        public static void AddCourse(SchCourse course)
        {
            if (course == null)
            {
                throw new ArgumentNullException($"添加失败：课程{course.SchCourseName}状态异常");
            }

            object result;
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection("data source=" + CourseDBFile))
                {
                    cn.Open();
                    SQLiteCommand cmd = cn.CreateCommand();
                    cmd.CommandText = $"SELECT * FROM SchCourses WHERE SchUserID='{User.SchUserID}' AND SchCourseName='{course.SchCourseName}'";
                    result = cmd.ExecuteScalar();
                    cn.Close();
                }
            }
            catch (Exception e)
            {
                e.Source += "课程添加失败";
                throw e;
            }
            ///是否重复
            if (result != null)
            {
                throw new ArgumentException($"添加失败：已存在用课程{course.SchCourseName}");
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
                cmd.CommandText = $"INSERT INTO SchCourses VALUES(NULL, '{course.SchCourseName}', '{course.ClassLocation.District}', '{course.ClassLocation.Building}', '{course.ClassLocation.Classroom}', '{course.TeacherName}', '{course.StartWeek}','{course.EndWeek}','{course.DayofWeek}','{course.Semaster}','{course.StartTime}','{course.EndTime}','{User.SchUserID}');";
                cn.Open();
                //cmd.ExecuteNonQueryAsync();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        /// <summary>
        /// 返回登录用户的课程列表
        /// </summary>
        /// <returns></returns>
        public static List<SchCourse> GetCourses()
        {
            List<SchCourse> CourseList = new List<SchCourse>();
            using (SQLiteConnection cn = new SQLiteConnection("data source=" + CourseDBFile))
            {
                SQLiteCommand cmd = cn.CreateCommand();

                cmd.CommandText = $"SELECT * FROM SchCourses WHERE SchUserID='{User.SchUserID}';";
                cn.Open();
                using(SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CourseList.Add(new SchCourse(reader["SchCourseName"].ToString(), reader["District"].ToString(), reader["Building"].ToString(), reader["Classroom"].ToString(), reader["TeacherName"].ToString(), Convert.ToInt32(reader["StartWeek"]), Convert.ToInt32(reader["EndWeek"]), Convert.ToInt32(reader["Semaster"]), Convert.ToInt32(reader["StartWeek"]), reader["StartTime"].ToString(), reader["EndTime"].ToString(),Convert.ToInt32(reader["SchCourseID"])));
                    }
                }

                cn.Close();
            }
            return CourseList;
        }

        /// <return>
        /// 返回登录用户指定学期的课程列表
        /// </return>
        public static List<SchCourse> GetCourses(int semaster)
        {
            object result;
            List<SchCourse> CourseList = new List<SchCourse>();
            using (SQLiteConnection cn = new SQLiteConnection("data source=" + CourseDBFile))
            {
                SQLiteCommand cmd = cn.CreateCommand();

                cmd.CommandText = $"SELECT * FROM SchCourses WHERE SchUserID='{User.SchUserID}' AND Semaster='{semaster}';";
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

        public static void DeleteCourse(SchCourse schCourse)
        {
            throw new NotImplementedException();
        }

        #endregion 

        public static new string ToString()
        {
            return User.ToString();
        }
    }
}
