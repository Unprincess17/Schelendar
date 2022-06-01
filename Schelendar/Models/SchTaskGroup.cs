using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Schelendar.Models
{
    public class SchTaskGroup
    {
        /// <summary>
        /// 任务组号
        /// </summary>
        public int GroupID { get; set; }
        /// <summary>
        /// 任务组描述
        /// </summary>
        public string GroupInfo { get; set; }
        /// <summary>
        /// 任务组属主
        /// </summary>
        public int SchUserID { get; set; }
        /// <summary>
        /// 任务组所对应番茄数
        /// </summary>
        public int TomatoNum { get; set; }
    }
}
