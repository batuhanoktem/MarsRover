namespace MarsRover.Models
{
    /// <summary>
    /// Position in x and y coordinates
    /// </summary>
    public interface IPosition
    {
        /// <summary>
        /// X coordinate
        /// </summary>
        int X { get; set; }

        /// <summary>
        /// Y coordinate
        /// </summary>
        int Y { get; set; }

        /// <summary>
        /// Returns position info
        /// </summary>
        /// <returns>Position info</returns>
        string ToString();
    }
}
