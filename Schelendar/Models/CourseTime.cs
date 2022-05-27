using System;


namespace Schelendar.Models
{
    public class ClassTime
    {
        public int Hour { get; set; }
        public int Minute { get; set; }

        public ClassTime(int hour, int minute)
        {
            Hour = hour;
            Minute = minute;
        }

        public ClassTime(DateTime d)
        {
            Hour = d.Hour;
            Minute = d.Minute;
        }

        public ClassTime(string time)
        {
            DateTime d = DateTime.Parse(time);
            Hour = d.Hour;
            Minute= d.Minute;
        }

        public override bool Equals(object obj)
        {
            return obj is ClassTime time &&
                   Hour == time.Hour &&
                   Minute == time.Minute;
        }

        public override string ToString()
        {
            return Hour.ToString() + ":" + Minute.ToString();
        }

        public static implicit operator ClassTime(string time)
        {
            return new ClassTime(time);
        }
    }
}