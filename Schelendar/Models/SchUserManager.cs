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
        ///TODO: 考虑管理UserID，即在哪里自增一，存储需要什么类型的集合
        /// <summary>
        /// 学生集合
        /// </summary>
        public ConcurrentBag<SchUser> SchUsers { get; set; }

        public SchUserManager()
        {
            SchUsers = new ConcurrentBag<SchUser>();
        }

        ///TODO:AddUser
        public void AddUser(SchUser user)
        {
            if(user == null)
            {
                throw new ArgumentNullException("user");
            }
            SchUsers.Add(user);
        }
        
        ///TODO:DeleteUser
        public void TryDeleteUser(int userID)
        {
            if (!SchUsers.Any(o => o.SchUserID.Equals(userID)))
            {
                throw new ArgumentException("没有符合条件的用户");
            }
            SchUser u = SchUsers.FirstOrDefault(o => o.SchUserID.Equals(userID));
            SchUsers.TryTake(out u);
        }
        ///TODO:UpdateUserByName
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

        ///TODO:GetUserByName


        ///TODO: path的赋值
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



        ///TODO: path的赋值
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
        ///TODO: path的赋值
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

        ///TODO: 用户名字段作文件夹名不安全，需要创建或修改时检测
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
                ///TODO: raw UserName here might be unsafe, need to detect when create or edit
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
                ///TODO: raw UserName here might be unsafe, need to detect when create or edit
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
