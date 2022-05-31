using System;
using System.Collections.Generic;

namespace Schelendar.Models
{
    public class CourseTime:IEquatable<CourseTime>
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

        public CourseTime()
        {
            Hour = 0;
            Minute = 0;
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

        bool IEquatable<CourseTime>.Equals(CourseTime other)
        {
            return other.Equals(this);
        }

        public static bool operator ==(CourseTime left, CourseTime right)
        {
            return EqualityComparer<CourseTime>.Default.Equals(left, right);
        }

        public static bool operator !=(CourseTime left, CourseTime right)
        {
            return !(left == right);
        }

        public static bool operator >(CourseTime l, CourseTime r)
        {
            return (l.Hour > r.Hour) || (l.Hour == r.Hour && l.Minute > r.Minute);
        }

        public static bool operator >=(CourseTime l, CourseTime r)
        {
            return !(l < r);
        }

        public static bool operator <(CourseTime l, CourseTime r)
        {
            return !((l > r) || l==r); 
        }
        public static bool operator <=(CourseTime l, CourseTime r)
        {
            return !(l > r);
        }


        public static implicit operator CourseTime(string time)
        {
            return new CourseTime(time);
        }
    }
}