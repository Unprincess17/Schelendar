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
        public SchClassTable(int classTableId, String classTableName)
        {
            DayClassNumber = 11;
            ClassTableId = classTableId;
            ClassTableName = classTableName;
            WeekLength = 20;

            EveryClassTime = new List<Dictionary<string, ClassTime>>()
            {
                new Dictionary<string, ClassTime>()
                    {{"StartTime", new ClassTime(08, 00)}, {"EndTime", new ClassTime(08, 45)}},
                new Dictionary<string, ClassTime>()
                    {{"StartTime", new ClassTime(08, 50)}, {"EndTime", new ClassTime(09, 35)}},
                new Dictionary<string, ClassTime>()
                    {{"StartTime", new ClassTime(09, 50)}, {"EndTime", new ClassTime(10, 35)}},
                new Dictionary<string, ClassTime>()
                    {{"StartTime", new ClassTime(10, 40)}, {"EndTime", new ClassTime(11, 25)}},
                new Dictionary<string, ClassTime>()
                    {{"StartTime", new ClassTime(11, 30)}, {"EndTime", new ClassTime(12, 15)}},
                new Dictionary<string, ClassTime>()
                    {{"StartTime", new ClassTime(14, 05)}, {"EndTime", new ClassTime(14, 50)}},
                new Dictionary<string, ClassTime>()
                    {{"StartTime", new ClassTime(14, 55)}, {"EndTime", new ClassTime(15, 40)}},
                new Dictionary<string, ClassTime>()
                    {{"StartTime", new ClassTime(15, 45)}, {"EndTime", new ClassTime(16, 30)}},
                new Dictionary<string, ClassTime>()
                    {{"StartTime", new ClassTime(18, 30)}, {"EndTime", new ClassTime(19, 15)}},
                new Dictionary<string, ClassTime>()
                    {{"StartTime", new ClassTime(19, 20)}, {"EndTime", new ClassTime(20, 05)}},
                new Dictionary<string, ClassTime>()
                    {{"StartTime", new ClassTime(20, 10)}, {"EndTime", new ClassTime(20, 55)}},
            };
        }


        /// TODO: 返回当前课程本事开始时间与结束时间的比较和与前一节课时间信息的比较
        /// <summary>
        /// 判断要添加的课程时间是否符合逻辑，如开始时间是否早于结束时间
        /// </summary>
        /// <param name="classPosition">要添加课程是第几节</param>
        /// <returns></returns>
        public bool IsTimeRule(int classPosition)
        {
            return true;
        }

    }
}