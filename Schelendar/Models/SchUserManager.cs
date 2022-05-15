using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Xml.Serialization;
using System.IO;

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

        /// <summary>
        /// 从path导入指定ID的用户
        /// </summary>
        /// <param name="path"></param>
        /// <param name="userID"></param>
        /// <exception cref="Exception"></exception>
        public void ImportUser(string path, int userID)
        {
            
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(SchUser));
///TODO: path的赋值
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    SchUser schUser = (SchUser)xmlSerializer.Deserialize(fs);
                }
            }
            catch(Exception e)
            {
                throw new Exception($"Exception when Exporting, please check the path or anything\n{e.Message}");
            }
        }

        /// <summary>
        /// 导出学生数据
        /// </summary>
        /// <param name="path">导出路径</param>
        /// <param name="userID">学生ID信息</param>
        /// <exception cref="Exception"></exception>
        public void Export(int userID, string path = "../Users/")
        {
            ///TODO: 序列化未完成
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(SchUser));
            try
            {
                var schuser = from u in SchUsers
                              where u.SchUserID == userID
                              select u;
                using (FileStream fs = new FileStream(path + schuser.FirstOrDefault().UserName, FileMode.Create))
                {
                    xmlSerializer.Serialize(fs, this);
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Exception when Exporting, please check the path or anything\n{e.Message}");
            }
        }
    }
}
