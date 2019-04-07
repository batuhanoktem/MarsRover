using System;

namespace MarsRover.Models.Exceptions
{
    /// <summary>
    /// Invalid Input Exception
    /// </summary>
    public class InvalidInputException : Exception
    {
        /// <summary>
        /// Creates exception object
        /// </summary>
        /// <param name="message">Exception Message</param>
        public InvalidInputException(string message) : base(message) { }
    }
}
