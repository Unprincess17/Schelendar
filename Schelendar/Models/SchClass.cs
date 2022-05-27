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
		public int SchClassID { get; set; }

		/// <summary>
		/// 课程名
		/// </summary>
		public string SchClassName { get; set; }

		/// <summary>
		/// 上课教室的信息
		/// </summary>
		public ClassLocation SchClassLocation { get; set; }
		
		/// <summary>
		/// 教师信息
		/// </summary>
		public String TeacherName { get; set; }
		/// <summary>
		/// 课程开始的周
		/// </summary>
		public int StartWeek { set; get; }
		/// <summary>
		/// 课程结束的周
		/// </summary>
		public int EndWeek { set; get; }
		/// <summary>
		/// 周几上课
		/// </summary>
		public int DayofWeek { set; get; }

		/// <summary>
		/// 上该课程的学期
		/// </summary>
		public int Semaster { set; get; }

		/// <summary>
		/// 上课时间
		/// </summary>
		public ClassTime StartTime { get; set; }

		/// <summary>
		/// 下课时间
		/// </summary>
		public ClassTime EndTime { get; set; }

		/// <summary>
		/// Class的构造函数
		/// </summary>
		/// <param name="schClassID"></param>
		/// <param name="schClassName"></param>
		/// <param name="district">校区</param>
		/// <param name="building"></param>
		/// <param name="classroom"></param>
		/// <param name="teacherName"></param>
		/// <param name="startWeek"></param>
		/// <param name="endWeek"></param>
		/// <param name="dayofWeek"></param>
		/// <param name="semaster"></param>
		/// <param name="startTime">上课时间，格式为"HH:MM"</param>
		/// <param name="endTime">下课时间，格式为"HH:MM"</param>
		public SchClass(int schClassID, string schClassName, string district, string building, string classroom, string teacherName, int startWeek, int endWeek, int dayofWeek, int semaster, string startTime, string endTime):base(schClassID, schClassName, district+building+classroom, DateTime.Now, DateTime.Now, 1, 0)
        {
            SchClassID = schClassID;
            SchClassName = schClassName;
            SchClassLocation = new ClassLocation(district, building, classroom);
            TeacherName = teacherName;
            StartWeek = startWeek;
            EndWeek = endWeek;
            DayofWeek = dayofWeek;
			Semaster = semaster;
			StartTime = startTime;
			EndTime = endTime;
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
