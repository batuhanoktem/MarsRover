using MarsRover.Models;
using MarsRover.Models.Exceptions;

namespace MarsRover.Extensions
{
    /// <summary>
    /// Extensions for spin direction
    /// </summary>
    public static class CardinalDirectionExtension
    {
        /// <summary>
        /// Convert symbol to cardinal direction
        /// </summary>
        /// <param name="symbol">Symbol</param>
        /// <returns>Cardinal Direction</returns>
        public static CardinalDirection ToCardinalDirection(this char symbol)
        {
            symbol = char.ToUpper(symbol);

            switch (symbol)
            {
                case 'N':
                    return CardinalDirection.North;
                case 'E':
                    return CardinalDirection.East;
                case 'S':
                    return CardinalDirection.South;
                case 'W':
                    return CardinalDirection.West;
                default:
                    throw new InvalidInputException($"{symbol} is not a valid input.");
            }
        }

        /// <summary>
        /// Convert symbol to cardinal direction
        /// </summary>
        /// <param name="symbol">Symbol</param>
        /// <returns>Cardinal Direction</returns>
        public static CardinalDirection ToCardinalDirection(this string symbol)
        {
            symbol = symbol.Trim();
            if (symbol.Length != 1)
                throw new InvalidInputException($"{symbol} is not a valid input.");

            return ToCardinalDirection(symbol[0]);
        }

        /// <summary>
        /// Convert cardinal direction to symbol
        /// </summary>
        /// <param name="cardinalDirection">Cardinal Dircetion</param>
        /// <returns>Symbol</returns>
        public static char ToSymbol(this CardinalDirection cardinalDirection)
        {
            return cardinalDirection.ToString()[0];
        }
    }
}
