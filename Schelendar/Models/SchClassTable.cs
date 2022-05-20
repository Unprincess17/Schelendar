using System;
using System.Collections.Generic;

namespace Schelendar.Models
{
    public class SchClassTable
    {
        /// <summary>
        /// 该课表每天的课程总节数
        /// </summary>
        public int DayClassNumber { set; get; }
        
        /// <summary>
        /// 课表或学期的ID
        /// </summary>
        public int ClassTableId { set; get; }
        
        /// <summary>
        /// 课表的名字
        /// </summary>
        public String ClassTableName { set; get; }
        
        /// <summary>
        /// 课表的开始时间
        /// </summary>
        public DateTime StartDateTime { set; get; }
        
        /// <summary>
        /// 课表持续的周数
        /// </summary>
        public int WeekLength { get; set; }

        /// <summary>
        /// 课表中每天课程的开始与结束时间，字典包含开始与结束
        /// </summary>
        public List<Dictionary<String, ClassTime>> EveryClassTime;

        /// <summary>
        /// 本学期课表要包含的课程Id
        /// </summary>
        public List<int> ClassId;


        /// <summary>
        /// 默认情况下的特别设置
        /// </summary>
        public SchClassTable(int classTableId, String classTableName, DateTime startDateTime)
        {
            DayClassNumber = 13;
            ClassTableId = classTableId;
            ClassTableName = classTableName;
            StartDateTime = startDateTime;
            WeekLength = 20;

            EveryClassTime = new List<Dictionary<string, ClassTime>>()
            {
                new Dictionary<string, ClassTime>()
                    {{"StartTime", new ClassTime(8, 0)}, {"EndTime", new ClassTime(8, 45)}},
                new Dictionary<string, ClassTime>()
                    {{"StartTime", new ClassTime(8, 50)}, {"EndTime", new ClassTime(9, 35)}},
                new Dictionary<string, ClassTime>()
                    {{"StartTime", new ClassTime(9, 50)}, {"EndTime", new ClassTime(10, 35)}},
                new Dictionary<string, ClassTime>()
                    {{"StartTime", new ClassTime(10, 40)}, {"EndTime", new ClassTime(11, 25)}},
                new Dictionary<string, ClassTime>()
                    {{"StartTime", new ClassTime(11, 30)}, {"EndTime", new ClassTime(12, 15)}},
                new Dictionary<string, ClassTime>()
                    {{"StartTime", new ClassTime(14, 5)}, {"EndTime", new ClassTime(14, 50)}},
                new Dictionary<string, ClassTime>()
                    {{"StartTime", new ClassTime(14, 55)}, {"EndTime", new ClassTime(15, 40)}},
                new Dictionary<string, ClassTime>()
                    {{"StartTime", new ClassTime(15, 45)}, {"EndTime", new ClassTime(16, 30)}},
                new Dictionary<string, ClassTime>()
                    {{"StartTime", new ClassTime(18, 30)}, {"EndTime", new ClassTime(19, 15)}},
                new Dictionary<string, ClassTime>()
                    {{"StartTime", new ClassTime(19, 20)}, {"EndTime", new ClassTime(20, 5)}},
                new Dictionary<string, ClassTime>()
                    {{"StartTime", new ClassTime(20, 10)}, {"EndTime", new ClassTime(20, 55)}},
            };

        }
    }
}