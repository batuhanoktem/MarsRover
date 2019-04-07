namespace MarsRover.Models
{
    /// <summary>
    /// Rover
    /// </summary>
    public interface IRover
    {
        /// <summary>
        /// Plateau on Mars
        /// </summary>
        IPlateau Plateau { get; set; }

        /// <summary>
        /// Current position of rover
        /// </summary>
        IPosition Position { get; set; }

        /// <summary>
        /// Current cardinal direction of rover
        /// </summary>
        CardinalDirection CardinalDirection { get; set; }

        /// <summary>
        /// Returns current info of rover
        /// </summary>
        /// <returns>Current info of rover</returns>
        string GetInfo();

        /// <summary>
        /// Returns is rover in coordinates of plateau
        /// </summary>
        /// <returns>Is rover in coordinates of plateau</returns>
        bool IsInsidePlateau();

        /// <summary>
        /// Spins rover
        /// </summary>
        /// <param name="spinDirection">Spin direction of rover</param>
        void Spin(SpinDirection spinDirection);

        /// <summary>
        /// Moves rover in cardinal direction 
        /// </summary>
        void Move();
    }
}
