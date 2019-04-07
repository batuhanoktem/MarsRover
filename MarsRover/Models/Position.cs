namespace MarsRover.Models
{
    /// <summary>
    /// Position in x and y coordinates
    /// </summary>
    public class Position : IPosition
    {
        /// <summary>
        /// Creates position object
        /// </summary>
        /// <param name="x">Initial x coordinate</param>
        /// <param name="y">Initial y coordinate</param>
        public Position(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// X coordinate
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Y coordinate
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Returns position info
        /// </summary>
        /// <returns>Position info</returns>
        public override string ToString()
        {
            return $"{X} {Y}";
        }
    }
}
