using System;
using System.Collections.Generic;

namespace Schelendar.Models
{
    public class SchCourseTable
    {
        /// <summary>
        /// 该课表每天的课程总节数
        /// </summary>
        public int DayCourseNumber { set; get; }
        
        /// <summary>
        /// 课表或学期的ID
        /// </summary>
        public int CourseTableId { set; get; }
        
        /// <summary>
        /// 课表的名字
        /// </summary>
        public String CourseTableName { set; get; }
        
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
        public List<Dictionary<String, CourseTime>> EveryCourseTime;


        /// <summary>
        /// 
        /// </summary>
        public SchCourseTable(int courseTableId, String courseTableName, int dayCourseNumber, int weekLength, List<Dictionary<string, CourseTime>> everyCourseTime)
        {
            DayCourseNumber = dayCourseNumber;
            CourseTableId = courseTableId;
            CourseTableName = courseTableName;
            WeekLength = weekLength;
            EveryCourseTime = everyCourseTime;
            /*
            EveryCourseTime = new List<Dictionary<string, CourseTime>>()
            {
                new Dictionary<string, CourseTime>()
                    {{"StartTime", new CourseTime(08, 00)}, {"EndTime", new CourseTime(08, 45)}},
                new Dictionary<string, CourseTime>()
                    {{"StartTime", new CourseTime(08, 50)}, {"EndTime", new CourseTime(09, 35)}},
                new Dictionary<string, CourseTime>()
                    {{"StartTime", new CourseTime(09, 50)}, {"EndTime", new CourseTime(10, 35)}},
                new Dictionary<string, CourseTime>()
                    {{"StartTime", new CourseTime(10, 40)}, {"EndTime", new CourseTime(11, 25)}},
                new Dictionary<string, CourseTime>()
                    {{"StartTime", new CourseTime(11, 30)}, {"EndTime", new CourseTime(12, 15)}},
                new Dictionary<string, CourseTime>()
                    {{"StartTime", new CourseTime(14, 05)}, {"EndTime", new CourseTime(14, 50)}},
                new Dictionary<string, CourseTime>()
                    {{"StartTime", new CourseTime(14, 55)}, {"EndTime", new CourseTime(15, 40)}},
                new Dictionary<string, CourseTime>()
                    {{"StartTime", new CourseTime(15, 45)}, {"EndTime", new CourseTime(16, 30)}},
                new Dictionary<string, CourseTime>()
                    {{"StartTime", new CourseTime(18, 30)}, {"EndTime", new CourseTime(19, 15)}},
                new Dictionary<string, CourseTime>()
                    {{"StartTime", new CourseTime(19, 20)}, {"EndTime", new CourseTime(20, 05)}},
                new Dictionary<string, CourseTime>()
                    {{"StartTime", new CourseTime(20, 10)}, {"EndTime", new CourseTime(20, 55)}},
                
            };*/
        }
    }
}