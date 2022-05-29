using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Text.RegularExpressions;


namespace Schelendar.Models
{
    [Serializable]
    [XmlInclude(typeof(SchTask))]
    [XmlInclude(typeof (SchCourse))]
    public class SchUser
    {
        /// <summary>
        /// 用户ID,最小为1
        /// </summary>
        public int SchUserID { get; set; }  
        
        /// <summary>
        /// 用户名称
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 用户经验值
        /// </summary>
        public int UserExperience { get; set; }
        
        /// <summary>
        /// 账户密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 记住我字段
        /// </summary>
        public int IsRmbMe { get; set; }
        /// <summary>
        /// 记住密码字段
        /// </summary>
        public int IsRmbPasswd { get; set; }
        
        /// <summary>
        /// 自动登录字段
        /// </summary>
        public int IsAutoLogin { get; set; }
        /// <summary>
        /// 个人的事件
        /// </summary>
        [XmlIgnore]
        public ConcurrentBag<SchTask> SchEvents { set; get; }

        /// <summary>
        /// 个人的课程
        /// </summary>
        [XmlIgnore]
        public ConcurrentBag<SchCourse> SchClasses { get; set; }

        public SchUser( string userName, string password, int schUserID = 0, int isRmbMe = 0, int isRmbPasswd = 0, int isAutoLogin = 0)
        {
            try
            {
                ///TODO:用户名检测， 正则表达式为^[\u4E00-\u9FA5A-Za-z\s]+(·[\u4E00-\u9FA5A-Za-z]+)*$, 支持的为中文、英文、·连接符，不支持数字
                if (!Regex.IsMatch(userName, @"^[\u4E00-\u9FA5A-Za-z\s]+(·[\u4E00-\u9FA5A-Za-z]+)*$"))
                {
                    throw new ArgumentException("用户名格式不正确，请重新输入");
                }
                this.SchUserID = schUserID;
                this.UserName = userName;
                this.Password = password;
                this.UserExperience = 0;
                this.IsRmbMe = isRmbMe;
                this.IsRmbPasswd = isRmbPasswd;
                this.IsAutoLogin = isAutoLogin;
                this.SchEvents = new ConcurrentBag<SchTask>();
                this.SchClasses = new ConcurrentBag<SchCourse>();
            }
            catch(InsufficientMemoryException e1)
            {
                throw new Exception($"Memory Insufficient when create {schUserID} 's {e1.Source}.\nPlease retry later");
            }
            catch(OutOfMemoryException e2)
            {
                throw new Exception($"Run out of Memory when create {schUserID} 's {e2.Source}.\nPlease retry later");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        
        public SchUser() {
            SchUserID = -1;
            UserName = "";
            UserExperience = 0;
        }

        /// <summary>
        /// CopyConstructor
        /// </summary>
        /// <param name="previousUser"></param>
        public SchUser(SchUser previousUser)
        {
            SchUserID = previousUser.SchUserID;
            UserName = previousUser.UserName;
            UserExperience = previousUser.UserExperience;
            IsRmbMe = previousUser.IsRmbMe;
            IsRmbPasswd = previousUser.IsRmbPasswd;
            IsAutoLogin = previousUser.IsAutoLogin;
            SchEvents = new ConcurrentBag<SchTask>();
            SchClasses = new ConcurrentBag<SchCourse>();
            foreach(SchCourse schClass in previousUser.SchClasses)
            {
                SchClasses.Add(schClass);
            }
            foreach(SchTask schEvent in previousUser.SchEvents)
            {
                SchEvents.Add(schEvent);
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("{0}:{1}", SchUserID, UserName);
            if(SchEvents != null)
            {
                stringBuilder.AppendFormat(" E:{0}", SchEvents.Count);
            }
            if(SchClasses != null)
            {
                stringBuilder.AppendFormat(" C:{0}",SchClasses.Count);
            }
            return stringBuilder.ToString();
        }
    }
}
