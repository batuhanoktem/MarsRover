using MarsRover.Helpers;
using System.IO;
using System.Text;
using Xunit;

namespace MarsRover.Tests
{
    /// <summary>
    /// Instruction Tests
    /// </summary>
    public class InstructionTest
    {
        /// <summary>
        /// Returns same output after calling start instructions
        /// </summary>
        /// <param name="inputPath">Input file path</param>
        /// <param name="outputPath">Expected output file path</param>
        [Theory]
        [InlineData("Instructions/Input1.txt", "Instructions/Output1.txt")]
        [InlineData("Instructions/Input2.txt", "Instructions/Output2.txt")]
        [InlineData("Instructions/Input3.txt", "Instructions/Output3.txt")]
        public void ReturnSameOutput(string inputPath, string outputPath)
        {
            string input = File.ReadAllText(inputPath, Encoding.UTF8);
            string expected = File.ReadAllText(outputPath, Encoding.UTF8);

            string actual = RoverHelper.StartInstructions(input);
            Assert.Equal(expected, actual);
        }
    }
}
