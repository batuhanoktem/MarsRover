using System;

namespace MarsRover.Models.Exceptions
{
    /// <summary>
    /// Move Exception
    /// </summary>
    public class MoveException : Exception
    {
        /// <summary>
        /// Creates exception object
        /// </summary>
        /// <param name="message">Exception Message</param>
        public MoveException(string message) : base(message) { }
    }
}
