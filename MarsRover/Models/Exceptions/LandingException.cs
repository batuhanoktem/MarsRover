using System;

namespace MarsRover.Models.Exceptions
{
    /// <summary>
    /// Landing Exception
    /// </summary>
    public class LandingException : Exception
    {
        /// <summary>
        /// Creates exception object
        /// </summary>
        /// <param name="message">Exception Message</param>
        public LandingException(string message) : base(message) { }
    }
}
