using MarsRover.Extensions;
using MarsRover.Models;
using MarsRover.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace MarsRover.Helpers
{
    /// <summary>
    /// Helper methods for rover
    /// </summary>
    public static class RoverHelper
    {
        /// <summary>
        /// Starts instructions and returns output
        /// </summary>
        /// <param name="input">Input</param>
        /// <returns>Output</returns>
        public static string StartInstructions(string input)
        {
            // Removes empty lines
            input = Regex.Replace(input, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);

            StringReader stringReader = new StringReader(input);

            Plateau plateau = CreatePlateau(stringReader);

            List<Rover> rovers = new List<Rover>();

            // Create all rovers
            while (CreateRover(rovers, plateau, stringReader));

            string output = "";
            for (int i = 0; i < rovers.Count; i++)
            {
                Rover rover = rovers[i];
                output += rover.GetInfo();

                if (i != rovers.Count - 1)
                    output += Environment.NewLine;
            }

            return output;
        }

        /// <summary>
        /// Creates plateau object
        /// </summary>
        /// <param name="stringReader">StringReader for input</param>
        /// <returns>Plateau</returns>
        private static Plateau CreatePlateau(StringReader stringReader)
        {
            string plateauPositionLine = stringReader.ReadLine();

            string[] plateauPositions = plateauPositionLine.Split(' ');

            if (plateauPositions.Length != 2)
                throw new InvalidInputException("Plateau position is not a valid input.");

            int plateauPositionX = int.Parse(plateauPositions[0]);
            int plateauPositionY = int.Parse(plateauPositions[1]);

            return new Plateau(plateauPositionX, plateauPositionY);
        }

        /// <summary>
        /// Creates rover object and run instructions
        /// </summary>
        /// <param name="rovers">Rovers</param>
        /// <param name="plateau">Plateau</param>
        /// <param name="stringReader">StringReader for input</param>
        /// <returns>Is rover created</returns>
        private static bool CreateRover(IList<Rover> rovers, IPlateau plateau, StringReader stringReader)
        {
            string roverPositionLine = stringReader.ReadLine();
            if (roverPositionLine == null)
                return false;

            string[] roverPositions = roverPositionLine.Split(' ');

            if (roverPositions.Length != 3)
                throw new InvalidInputException("Rover position is not a valid input.");

            int roverPositionX = int.Parse(roverPositions[0]);
            int roverPositionY = int.Parse(roverPositions[1]);
            CardinalDirection roverDirection = roverPositions[2].ToCardinalDirection();

            Rover rover = new Rover(plateau, roverPositionX, roverPositionY, roverDirection);

            string roverCommandsLine = stringReader.ReadLine();
            if (roverCommandsLine == null)
                throw new InvalidInputException("Rover commands is not a valid input.");

            foreach (Instruction command in roverCommandsLine)
            {
                switch (command)
                {
                    case Instruction.Left:
                        rover.Spin(SpinDirection.Left);
                        break;
                    case Instruction.Right:
                        rover.Spin(SpinDirection.Right);
                        break;
                    case Instruction.Move:
                        rover.Move();
                        break;
                    default:
                        throw new InvalidInputException("Rover commands is not a valid input.");
                }
            }

            if (!rover.IsInsidePlateau())
                throw new LandingException($"Rover cannot be landed to X={rover.Position.X}, Y={rover.Position.Y} coordinates.");

            rovers.Add(rover);
            return true;
        }
    }
}
