using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Schelendar.Models
{
    /// <summary>
    /// events, basic item
    /// </summary>
    [Serializable]
    public class SchEvent : IEquatable<SchEvent>/*, IXmlSerializable*/
    {
        /// <summary>
        /// 事件ID
        /// </summary>
        [XmlElementAttribute("EventID")]
        public int SchEventID { get; set; }
        /// <summary>
        /// 事件描述信息
        /// </summary>
        public string SchEventInfo { get; set; }  
        /// <summary>
        /// 事件地点
        /// </summary>
        public string SchEventLocation { get; set; }

        /// <summary>
        /// 事件起始时间
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// 事件结束时间
        /// </summary>
        public DateTime EndDate { get; set; }
        /// <summary>
        /// 事件重复信息
        /// 0为不重复，1为每周重复
        /// </summary>
        public int isRepeat { get; set; }
        /// <summary>
        /// 事件是否已完成
        /// </summary>
        public int isDone { get; set; }
        /// <summary>
        /// 事件属主ID
        /// </summary>
        public int UserID { get; set; }

        public SchEvent(int schEventID, string schEventInfo, string schEventLocation, DateTime startDate, DateTime endDate, int isRepeat, int isDone)
        {
            SchEventID = schEventID;
            SchEventInfo = schEventInfo;
            SchEventLocation = schEventLocation;
            StartDate = startDate;
            EndDate = endDate;
            this.isRepeat = isRepeat;
            this.isDone = isDone;
        }
        public SchEvent()
        {
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as SchEvent);
        }

        public bool Equals(SchEvent other)
        {
            return !(other is null) &&
                   SchEventID == other.SchEventID &&
                   UserID == other.UserID;
        }

        public override int GetHashCode()
        {
            int hashCode = 539429797;
            hashCode = hashCode * -1521134295 + SchEventID.GetHashCode();
            hashCode = hashCode * -1521134295 + UserID.GetHashCode();
            return hashCode;
        }

        //public XmlSchema GetSchema()
        //{
        //    return(null);
        //}

        //public void ReadXml(XmlReader reader)
        //{
        //    throw new NotImplementedException();
        //}

        //public void WriteXml(XmlWriter writer)
        //{
        //    writer.WriteElementStringAsync("EventID", "SchEventID", "Schelendar.Models", SchEventID.ToString());
        //}

        public static bool operator ==(SchEvent left, SchEvent right)
        {
            return EqualityComparer<SchEvent>.Default.Equals(left, right);
        }

        public static bool operator !=(SchEvent left, SchEvent right)
        {
            return !(left == right);
        }
    }
}
