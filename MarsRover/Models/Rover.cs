using MarsRover.Extensions;

namespace MarsRover.Models
{
    /// <summary>
    /// Rover
    /// </summary>
    public class Rover : IRover
    {
        /// <summary>
        /// Creates rover object
        /// </summary>
        /// <param name="plateau">Plateau on Mars</param>
        /// <param name="x">Initial x coordinate of rover</param>
        /// <param name="y">Initial y coordinate of rover</param>
        /// <param name="cardinalDirection">Initial cardinal direction of rover</param>
        public Rover(IPlateau plateau, int x = 0, int y = 0, CardinalDirection cardinalDirection = CardinalDirection.North)
        {
            Plateau = plateau;
            Position = new Position(x, y);
            CardinalDirection = cardinalDirection;
        }

        /// <summary>
        /// Plateau on Mars
        /// </summary>
        public IPlateau Plateau { get; set; }

        /// <summary>
        /// Current position of rover
        /// </summary>
        public IPosition Position { get; set; }

        /// <summary>
        /// Current cardinal direction of rover
        /// </summary>
        public CardinalDirection CardinalDirection { get; set; }

        /// <summary>
        /// Returns current info of rover
        /// </summary>
        /// <returns>Current info of rover</returns>
        public string GetInfo()
        {
            return $"{Position} {CardinalDirection.ToSymbol()}";
        }

        /// <summary>
        /// Returns is rover in coordinates of plateau
        /// </summary>
        /// <returns>Is rover in coordinates of plateau</returns>
        public bool IsInsidePlateau()
        {
            return Plateau.IsInsidePlateau(Position);
        }

        /// <summary>
        /// Spins rover
        /// </summary>
        /// <param name="spinDirection">Spin direction of rover</param>
        public void Spin(SpinDirection spinDirection)
        {
            int angle = (int)CardinalDirection + (int)spinDirection;

            if (angle < 0)
                angle = 360 + angle;
            else if (angle >= 360)
                angle %= 360;

            CardinalDirection = (CardinalDirection)angle;
        }

        /// <summary>
        /// Moves rover in cardinal direction 
        /// </summary>
        public void Move()
        {
            switch (CardinalDirection)
            {
                case CardinalDirection.North:
                    Position.Y++;
                    break;
                case CardinalDirection.East:
                    Position.X++;
                    break;
                case CardinalDirection.South:
                    Position.Y--;
                    break;
                case CardinalDirection.West:
                    Position.X--;
                    break;
            }
        }
    }
}
