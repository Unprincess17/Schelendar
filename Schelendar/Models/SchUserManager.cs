using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Xml.Serialization;
using System.IO;
using System.Text.RegularExpressions;

namespace Schelendar.Models
{
    public class SchUserManager
    {
        /// <summary>
        /// 学生集合
        /// </summary>
        public ConcurrentBag<SchUser> SchUsers { get; set; }

        public SchUserManager()
        {
            SchUsers = new ConcurrentBag<SchUser>();
        }

        /// <summary>
        /// 添加用户。若用户已存在则抛出ArgumentException
        /// </summary>
        /// <param name="user"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public void AddUser(SchUser user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("user");
            }
            if (SchUsers.Any(u => u.Equals(user)))
            {
                throw new ArgumentException($"已添加用户{user}");
            }
            SchUsers.Add(user);
        }

        /// <summary>
        /// 尝试删除用户，若查询不到则抛出ArgumentException
        /// </summary>
        /// <param name="userID"></param>
        /// <exception cref="ArgumentException"></exception>
        public void TryDeleteUser(int userID)
        {
            if (!SchUsers.Any(o => o.SchUserID.Equals(userID)))
            {
                throw new ArgumentException("没有符合条件的用户");
            }
            SchUser u = SchUsers.FirstOrDefault(o => o.SchUserID.Equals(userID));
            SchUsers.TryTake(out u);
        }
        
        /// <summary>
        /// 更新指定用户信息
        /// 若指定用户不存在则抛出ArgumentException
        /// 若更新用户名格式不正确则抛出ArgumentException
        /// </summary>
        /// <param name="oldUserName">指定用户的用户名</param>
        /// <param name="newUser">更新的用户信息</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public bool UpdateUserByName(string oldUserName, SchUser newUser)
        {
            if(newUser == null)
            {
                return false;
            }
            if (!Regex.IsMatch(newUser.UserName, @"^[\u4E00-\u9FA5A-Za-z\s]+(·[\u4E00-\u9FA5A-Za-z]+)*$"))
            {
                throw new ArgumentException("更改的用户名格式不正确，用户名只能包括汉字和英文。请重新输入");
            }
            try
            {
                SchUser u = SchUsers.FirstOrDefault(o => o.UserName.Equals(oldUserName));
                u=newUser;
                return true;
            }
            catch(ArgumentException e)
            {
                throw new ArgumentException($"未找到名称为{oldUserName}的用户，请重新检查输入");
            }
        }

        /// <summary>
        /// 查询指定用户名的用户
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public SchUser GetUserByName(string Name)
        {
            if (SchUsers.All(o => o.UserName.Equals(Name)))
            {
                return SchUsers.FirstOrDefault(o => o.UserName.Equals(Name));
            }
            throw new ArgumentException($"未查询到名称为{Name}的用户，请检查输入");
        }

        /// <summary>
        /// 根据用户ID和学期号获取课程
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="semasterID">学期号</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public List<SchClass> GetUserSemasterClasses(int userID, int semasterID)
        {
            try
            {
                return SchUsers.First(o => o.SchUserID.Equals(userID)).SchClasses.Where(c => c.Semaster.Equals(semasterID)).ToList();
            }
            catch(ArgumentNullException e)
            {
                throw new ArgumentException($"未查询到ID为{userID}的用户，请检查输入");
            }
        }

        /// <summary>
        /// 根据用户名和学期号获取课程
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="semasterID"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public List<SchClass> GetUserSemasterClasses(string userName, int semasterID)
        {
            try
            {
                return GetUserSemasterClasses(SchUsers.First(o => o.UserName.Equals(userName)).SchUserID, semasterID);
            }
            catch(ArgumentException e)
            {
                throw new ArgumentException($"未查询到名为{userName}的用户，请检查输入");
            }
        }

        ///这两个功能应该蛮常用的？或者说怎么样维护一个运行时的用户信息？
        /// 1.当main运行的时候，维护一个用户（信息的持久化、信息的更改）。每次修改课程、事件等信息时，实际是修改该用户的指定信息--->那他妈不就是不需要一个用户管理类的管理列表了吗？（既然每次都肯定是对指定用户的操作）--->或者说维护的这个管理列表里只有一个用户，其他用户想要被管理需要登出当前的（删除列表元素），登入新的（添加进列表中）
        ///TODO：为用户增加课程
        ///TODO：根据添加的课程联想添加事件（考试、大作业...
        
        ///TODO: 删除用户指定课程
        ///TODO：根据删除的时间联想删除事件
        
        ///TODO：事件组 事件的一种组织方式 里面的时间全部完成后才算整体完成

        ///TODO: Txt2Event
        /// 文本处理？可以先写个处理格式化文本的
        ///"5月20号 17:00 跑步"->SchEvent(...)
        
        ///TODO: ShareEventByEmails
        
        ///TODO: GetEventByEmail
        ///这个功能隔一段时间调用一次
        ///需要用户的邮箱权限？
        ///

        ///TODO:每次操作的信息，持久化起来。->C# log

        ///TODO: path的赋值的检测
        /// <summary>
        /// 从path导入指定ID的用户
        /// </summary>
        /// <param name="path"></param>
        /// <param name="userID"></param>
        /// <exception cref="Exception"></exception>
        public void ImportUser(ref SchUser user, string path)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(SchUser));
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    user = ((SchUser)xmlSerializer.Deserialize(fs));
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Exception when importing, please check the correctness of the path: {path}");
            }
        }

        /// TODO: importusers
        /// <summary>
        /// 导入全部用户基本信息,刨除Event和Class
        /// </summary>
        /// <param name="path">到SchUsers级</param>
        /// <exception cref="Exception"></exception>
        public void ImportUsers(string path = "./SchUsers")
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(SchUser));
                foreach (object d in Directory.EnumerateDirectories(path)) 
                {
                    string dir = d as string;
                    string XmltoExecute = Path.Combine(dir, dir.Substring(dir.LastIndexOf("\\")+1).Substring(0,dir.LastIndexOf("\\")),".xml");
                    Console.WriteLine(XmltoExecute);
                    //using (FileStream fs = new FileStream(d.ToString(), FileMode.Open))
                    //{
                    //    SchUsers.Add((SchUser)xmlSerializer.Deserialize(fs));
                    //}
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Exception when importing, please check the correctness of the path: {path}");
            }
        }


        ///TODO: path的赋值的检测
        /// <summary>
        /// 从path导入指定ID的用户的课程
        /// </summary>
        /// <param name="path"></param>
        /// <param name="userID"></param>
        /// <exception cref="Exception"></exception>
        public void ImportClasses(ref SchUser user, string path)
        {
            try
            {
                ///HACK:类型问题。Bag不能被序列化
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ConcurrentBag<SchEvent>));
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    user.SchClasses = (ConcurrentBag<SchClass>)xmlSerializer.Deserialize(fs);
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Exception when importing, please check the correctness of the path: {path}");
            }
        }

        ///TODO: path的赋值的检测
        /// <summary>
        /// 从path导入指定ID的用户的事件
        /// </summary>
        /// <param name="path"></param>
        /// <param name="userID"></param>
        /// <exception cref="Exception"></exception>
        public void ImportEvents(ref SchUser user, string path)
        {
            try
            {
                ///HACK:类型问题。Bag不能被序列化
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ConcurrentBag<SchEvent>));
                ConcurrentBag<SchEvent> events;
                if (!File.Exists(path))
                {
                    throw new ArgumentException($"Exception when importing, please check the correctness of the path: {path}");
                }
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    events = (ConcurrentBag<SchEvent>)xmlSerializer.Deserialize(fs);
                }
                foreach(SchEvent e in events)
                {
                    user.SchEvents.Add(e);
                }
            }
            catch (ArgumentException e1)
            {
                throw e1;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        ///TODO: path路径指向SchUsers/{userID}/.xml
        ///HACK: 用户名字段作文件夹名不安全，需要创建或修改时检测
        /// <summary>
        /// 导出学生基本数据
        /// </summary>
        /// <param name="path">导出路径</param>
        /// <param name="userID">学生ID信息</param>
        /// <exception cref="Exception"></exception>
        public void ExportBasicInfos(int userID, string path)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(SchUser));
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    xmlSerializer.Serialize(fs, this.SchUsers.First(o=>o.SchUserID.Equals(userID)));
                }
            }
            catch(NullReferenceException e1)
            {
                //throw new Exception("Please check userID");
                Console.WriteLine($"Exception when exporting, please check the correctness of the path: {path}");
            }
            catch (Exception e)
            {
                throw new Exception($"{e.Message}");
            }
        }
        ///TODO: path路径指向SchUsers/{userID}/.xml
        /// <summary>
        /// 存储用户的事件
        /// </summary>
        /// <param name="userID">用户ID字段</param>
        /// <param name="path">输出路径</param>
        /// <exception cref="Exception"></exception>
        public void ExportEvents(int userID, string path) {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<SchEvent>));
                using (FileStream fs = new FileStream(path/* + schuser.FirstOrDefault().UserName + "_Events.xml"*/, FileMode.Create))
                {
                    xmlSerializer.Serialize(fs, this.SchUsers.Where(o => o.SchUserID.Equals(userID)).First().SchEvents.ToList());
                }
            }
            catch (NullReferenceException e1)
            {
                //throw new Exception("Please check userID");
                Console.WriteLine(e1.Message + "\n" + e1.InnerException.Message);
            }
            catch (Exception e)
            {
                throw new Exception($"Exception when Exporting, please check the path or anything\n{e.Message}");
            }
        }
        ///TODO: path路径指向SchUsers/{userID}/.xml
        /// <summary>
        /// 存储用户的课程
        /// </summary>
        /// <param name="userID">用户ID字段</param>
        /// <param name="path">输出路径</param>
        /// <exception cref="Exception"></exception>
        public void ExportClasses(int userID, string path)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<SchClass>));
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    xmlSerializer.Serialize(fs, this.SchUsers.Where(o => o.SchUserID.Equals(userID)).First().SchClasses.ToList());
                }
            }
            catch (NullReferenceException e1)
            {
                //throw new Exception("Please check userID");
                Console.WriteLine($"Exception when Exporting, please check the correctness of the path: {path}");
            }
            catch (Exception e)
            {
                throw new Exception($"{e.Message}");
            }
        }
    }
}
