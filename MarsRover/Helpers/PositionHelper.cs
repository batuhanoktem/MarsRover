using MarsRover.Models;

namespace MarsRover.Helpers
{
    /// <summary>
    /// Helper methods for position
    /// </summary>
    public static class PositionHelper
    {
        /// <summary>
        /// Returns is position in coordinates of plateau
        /// </summary>
        /// <param name="lowerLeftPosition">Lower-left coordinates</param>
        /// <param name="upperRightPosition">Upper-right coordinates</param>
        /// <param name="position">Position to be checked</param>
        /// <returns>Is position in coordinates</returns>
        public static bool IsPositionInsidePositions(IPosition lowerLeftPosition, IPosition upperRightPosition, IPosition position)
        {
            return !(position.X > upperRightPosition.X || position.Y > upperRightPosition.Y || position.X < lowerLeftPosition.X || position.Y < lowerLeftPosition.Y);
        }
    }
}
