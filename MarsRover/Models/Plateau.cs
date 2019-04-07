using MarsRover.Helpers;

namespace MarsRover.Models
{
    /// <summary>
    /// Plateau on Mars
    /// </summary>
    public class Plateau : IPlateau
    {
        /// <summary>
        /// Creates plateau object
        /// </summary>
        /// <param name="upperRightX">Initial upper-right x coordinate of plateau</param>
        /// <param name="upperRightY">Initial upper-right y coordinate of plateau</param>
        /// <param name="lowerLeftX">Initial lower-left x coordinate of plateau</param>
        /// <param name="lowerLeftY">Initial lower-left y coordinate of plateau</param>
        public Plateau(int upperRightX = 0, int upperRightY = 0, int lowerLeftX = 0, int lowerLeftY = 0)
        {
            LowerLeftPosition = new Position(lowerLeftX, lowerLeftY);
            UpperRightPosition = new Position(upperRightX, upperRightY);
        }

        /// <summary>
        /// Lower-left coordinates
        /// </summary>
        public IPosition LowerLeftPosition { get; set; }

        /// <summary>
        /// Upper-right coordinates
        /// </summary>
        public IPosition UpperRightPosition { get; set; }

        /// <summary>
        /// Returns is position in coordinates of plateau
        /// </summary>
        /// <param name="position">Position</param>
        /// <returns>Is position in coordinates of plateau</returns>
        public bool IsInsidePlateau(IPosition position)
        {
            return PositionHelper.IsPositionInsidePositions(LowerLeftPosition, UpperRightPosition, position);
        }
    }
}
