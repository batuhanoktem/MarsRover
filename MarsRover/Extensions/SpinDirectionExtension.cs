using MarsRover.Models;
using MarsRover.Models.Exceptions;

namespace MarsRover.Extensions
{
    /// <summary>
    /// Extensions for spin direction
    /// </summary>
    public static class SpinDirectionExtension
    {
        /// <summary>
        /// Convert symbol to spin direction
        /// </summary>
        /// <param name="symbol">Symbol</param>
        /// <returns>Spin Direction</returns>
        public static SpinDirection ToSpinDirection(this char symbol)
        {
            symbol = char.ToUpper(symbol);

            switch (symbol)
            {
                case 'L':
                    return SpinDirection.Left;
                case 'R':
                    return SpinDirection.Right;
                default:
                    throw new InvalidInputException($"{symbol} is not a valid input.");
            }
        }

        /// <summary>
        /// Convert symbol to spin direction
        /// </summary>
        /// <param name="symbol">Symbol</param>
        /// <returns>Spin Direction</returns>
        public static SpinDirection ToSpinDirection(this string symbol)
        {
            symbol = symbol.Trim();
            if (symbol.Length != 1)
                throw new InvalidInputException($"{symbol} is not a valid input.");

            return ToSpinDirection(symbol[0]);
        }

        /// <summary>
        /// Convert spin direction to symbol
        /// </summary>
        /// <param name="spinDirection">Spin Direction</param>
        /// <returns>Symbol</returns>
        public static char ToSymbol(this SpinDirection spinDirection)
        {
            return spinDirection.ToString()[0];
        }
    }
}
