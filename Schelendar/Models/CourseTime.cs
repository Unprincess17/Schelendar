using System;


namespace Schelendar.Models
{
    public class CourseTime
    {
        public int Hour { get; set; }
        public int Minute { get; set; }

        public CourseTime(int hour, int minute)
        {
            Hour = hour;
            Minute = minute;
        }

        public CourseTime(DateTime d)
        {
            Hour = d.Hour;
            Minute = d.Minute;
        }

        public CourseTime(string time)
        {
            DateTime d = DateTime.Parse(time);
            Hour = d.Hour;
            Minute= d.Minute;
        }

        public override bool Equals(object obj)
        {
            return obj is CourseTime time &&
                   Hour == time.Hour &&
                   Minute == time.Minute;
        }

        public override string ToString()
        {
            return Hour.ToString() + ":" + Minute.ToString();
        }

        public static implicit operator CourseTime(string time)
        {
            return new CourseTime(time);
        }
    }
}