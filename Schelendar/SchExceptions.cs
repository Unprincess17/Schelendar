using System;

namespace Schelendar
{
    public class RepeatCourseException : Exception
    {
        public RepeatCourseException(string Message)
            : base(Message) { }
    }
}
