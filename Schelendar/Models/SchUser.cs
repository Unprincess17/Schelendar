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
    [Serializable]
    public class SchUser
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public int SchUserID;
        
        /// <summary>
        /// 用户名称
        /// </summary>
        public string UserName;

        /// <summary>
        /// 用户经验值
        /// </summary>
        public int UserExperience;

        /// <summary>
        /// 个人的事件
        /// key:事件ID
        /// value:事件
        /// </summary>
        public ConcurrentBag<SchEvent> SchEvents { set; get; }

        /// <summary>
        /// 个人的课程
        /// key:课程ID
        /// value:课程
        /// </summary>
        public ConcurrentBag<SchClass> SchClasses { get; set; }

        public SchUser(int schUserID, string userName)
        {
            try
            {
                this.SchUserID = schUserID;
                this.UserName = userName;
                this.UserExperience = 0;
                this.SchEvents = new ConcurrentBag<SchEvent>();
                this.SchClasses = new ConcurrentBag<SchClass>();
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
            this.SchUserID = -1;
            this.UserName = "";
            this.UserExperience = -1;
            this.SchEvents = new ConcurrentBag<SchEvent>();
            this.SchClasses = new ConcurrentBag<SchClass>();
        }
               
    }
}
