namespace MarsRover.Models
{
    /// <summary>
    /// Plateau on Mars
    /// </summary>
    public interface IPlateau
    {
        /// <summary>
        /// Lower-left coordinates
        /// </summary>
        IPosition LowerLeftPosition { get; set; }

        /// <summary>
        /// Upper-right coordinates
        /// </summary>
        IPosition UpperRightPosition { get; set; }

        /// <summary>
        /// Returns is position in coordinates of plateau
        /// </summary>
        /// <param name="position">Position</param>
        /// <returns>Is position in coordinates of plateau</returns>
        bool IsInsidePlateau(IPosition position);
    }
}
