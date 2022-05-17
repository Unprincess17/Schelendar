using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Schelendar.Models
{
	[Serializable]
	/// <summary>
	/// classes, derived from events
	/// </summary>
	public class SchClass : SchEvent, IEquatable<SchClass>
    {
		/// <summary>
		/// 课程ID
		/// </summary>
		int SchClassID { get; set; }

		/// <summary>
		/// 课程名
		/// </summary>
		string SchClassName { get; set; }

		/// <summary>
		/// 上课教室的信息
		/// </summary>
		ClassLocation SchClassLocation { get; set; }
		
		/// <summary>
		/// 教师信息
		/// </summary>
		String TeacherName { get; set; }
		/// <summary>
		/// 课程开始的周
		/// </summary>
		int StartWeek { set; get; }
		/// <summary>
		/// 课程结束的周
		/// </summary>
		int EndWeek { set; get; }
		/// <summary>
		/// 周几上课
		/// </summary>
		int DayofWeek { set; get; }

		public SchClass(int schClassID, string schClassName, string district, string building, string classroom, string teacherName, int startWeek, int endWeek, int dayofWeek, DateTime startDate, DateTime endDate):base(schClassID, schClassName, district+building+classroom, startDate, endDate, 1, 0)
        {
            SchClassID = schClassID;
            SchClassName = schClassName;
            SchClassLocation = new ClassLocation(district, building, classroom);
            TeacherName = teacherName;
            StartWeek = startWeek;
            EndWeek = endWeek;
            DayofWeek = dayofWeek;
        }
		public SchClass() 
        {
		}

		
        public override bool Equals(object obj)
        {
            return Equals(obj as SchClass);
        }

        public bool Equals(SchClass other)
        {
            return !(other is null) &&
                   UserID == other.UserID &&
                   SchClassID == other.SchClassID;
        }

        public override int GetHashCode()
        {
            int hashCode = -1737701667;
            hashCode = hashCode * -1521134295 + UserID.GetHashCode();
            hashCode = hashCode * -1521134295 + SchClassID.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(SchClass left, SchClass right)
        {
            return EqualityComparer<SchClass>.Default.Equals(left, right);
        }

        public static bool operator !=(SchClass left, SchClass right)
        {
            return !(left == right);
        }
    }
	public struct ClassLocation {
		string District;
		string Building;
		string Classroom;
		public override string ToString()
        {
			if(District.Equals(null)|| Building.Equals(null) || Classroom.Equals(null))
            {
				throw new ArgumentNullException("请完善课程地址信息");
            }
			return District+ " " + Building + " " + Classroom;
        }

		public ClassLocation(string district, string building, string classroom)
        {
			District = district;
			Building = building;
			Classroom = classroom;
        }
	}
}
