using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Data.SQLite;

namespace Schelendar.Models
{
    [Serializable]
    /// <summary>
    /// classes, derived from events
    /// </summary>
    public class SchCourse : SchTask, IEquatable<SchCourse>
    {
        /// <summary>
        /// 课程ID
        /// </summary>
		public int SchCourseID { get; set; }

        /// <summary>
        /// 课程名
        /// </summary>
        public string SchCourseName { get; set; }

        /// <summary>
        /// 上课教室的信息
        /// </summary>
        public ClassLocation ClassLocation { get; set; }

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
        public int Semester { set; get; }

        /// <summary>
        /// 上课时间第几节
        /// </summary>
        public int StartTime { get; set; }

        /// <summary>
        /// 下课时的节数
        /// </summary>
        public int EndTime { get; set; }

        public SchCourse()
        {
        }

        
        /// <summary>
        /// 用来添加课表时传递
        /// </summary>
        /// <param name="schCourseName"></param>
        /// <param name="district"></param>
        /// <param name="building"></param>
        /// <param name="classroom"></param>
        /// <param name="teacherName"></param>
        /// <param name="startWeek"></param>
        /// <param name="endWeek"></param>
        /// <param name="dayofWeek"></param>
        /// <param name="semester"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        public SchCourse(string schCourseName, string district, string building, string classroom, string teacherName,
            int startWeek, int endWeek, int dayofWeek, int semester, int startTime, int endTime, int schCourseID = -1, int userID = 0, int schTaskGroupID=0):base(schCourseName, district+building+classroom, DateTime.Now, DateTime.Now, 1,0, schTaskGroupID, schCourseID, userID)
        {
            this.SchCourseID = schCourseID;
            this.SchCourseName = schCourseName;
            this.ClassLocation = new ClassLocation(district, building, classroom);
            this.TeacherName = teacherName;
            this.StartWeek = startWeek;
            this.EndWeek = endWeek;
            this.DayofWeek = dayofWeek;
            this.Semester = semester;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }


        /// <summary>
        /// 用来保存旧的时间信息来更新显示
        /// </summary>
        public SchCourse(int dayofWeek, int startTime, int endTime)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.DayofWeek = dayofWeek;
        }


        public override bool Equals(object obj)
        {
            return Equals(obj as SchCourse);
        }

        public bool Equals(SchCourse other)
        {
            return !(other is null) &&
                   UserID == other.UserID &&
                   SchCourseID == other.SchCourseID;
        }

        public override string ToString() => SchCourseID + SchCourseName;

        public override int GetHashCode()
        {
            int hashCode = -1737701667;
            hashCode = hashCode * -1521134295 + UserID.GetHashCode();
            hashCode = hashCode * -1521134295 + SchCourseID.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(SchCourse left, SchCourse right)
        {
            return EqualityComparer<SchCourse>.Default.Equals(left, right);
        }

        public static bool operator !=(SchCourse left, SchCourse right)
        {
            return !(left == right);
        }

		/// <summary>
		/// copy constructor
		/// </summary>
		/// <param name="previous"></param>
		public SchCourse(SchCourse previous)
        {
			SchCourseID = previous.SchCourseID;
			SchCourseName = previous.SchCourseName;
			ClassLocation = previous.ClassLocation;
			TeacherName = previous.TeacherName;
			StartWeek = previous.StartWeek;
			EndWeek = previous.EndWeek;
			DayofWeek = previous.DayofWeek;
			Semester = previous.Semester;
			StartTime = previous.StartTime;
			EndTime = previous.EndTime;
            SchTaskGroupID = previous.SchTaskGroupID;
		}

		/// <summary>
		/// 检测课程见冲突情况
		/// </summary>
		/// <returns>
		/// 2种情况：0：不冲突， 1：c1开始早于c2开始，结束早于c2开始而晚于c2结束 2：c1包含于c2 3：
		/// </returns>
		public static int isConflicted(SchCourse c1, SchCourse c2)
        {
			if(c1==null || c2 == null)
            {
				throw new ArgumentNullException($"使用未初始化变量{c1}和{c2}");
            }
            if (!c1.Semester.Equals(c2.Semester))//学期不同
            {
				return 0;
            }
			if(c1.StartWeek > c2.EndWeek || c1.EndWeek < c1.StartWeek)//周数不同
            {
				return 0;
            }
            if (c1.StartTime >= c2.EndTime || c1.EndTime <= c2.StartTime)//周数有重叠，时间不同
            {
				return 0;
            }
            else
            {
				return 1;
            }
        }


    }
	public struct ClassLocation {
		public string District;
		public string Building;
		public string Classroom;
		public override string ToString()
        {
            if (District.Equals(null) || Building.Equals(null) || Classroom.Equals(null))
            {
                throw new ArgumentNullException("请完善课程地址信息");
            }

            return District + " " + Building + " " + Classroom;
        }

        public ClassLocation(string district, string building, string classroom)
        {
            District = district;
            Building = building;
            Classroom = classroom;
        }
    }
}