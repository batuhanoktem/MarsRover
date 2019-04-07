using MarsRover.Helpers;
using System;
using System.IO;
using System.Text;

namespace MarsRover.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            string path;
            path = GetPath(args);

            string input = File.ReadAllText(path, Encoding.UTF8);

            string output = RoverHelper.StartInstructions(input);
            Console.WriteLine(output);
        }

        /// <summary>
        /// Gets path from user or arguments
        /// </summary>
        /// <param name="args">Arguments</param>
        /// <returns>Path</returns>
        private static string GetPath(string[] args)
        {
            string path;
            if (args.Length == 0)
            {
                Console.Write("Please enter input file path: ");
                path = Console.ReadLine();
            }
            else
                path = args[0];

            return path;
        }
    }
}
