using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment01
{
    /// <summary>
    /// The program calculates the average gold-collecting performance
    /// </summary>
    class Program
    {
        /// <summary>
        /// The program calculates the average gold-collecting performance
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            // Set background color to DarkBlue
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            // Greetings
            Console.WriteLine("Hello! This application will calculate your average gold-collecting performance");
            Console.WriteLine();

            // Prompting for total gold gained and time spent
            Console.Write("Please input the total amount of gold you've collected in the game ");
            int gold = int.Parse(Console.ReadLine());

            Console.Write("Please input the total number of hours you've played the game ");
            float hours = float.Parse(Console.ReadLine());
            Console.WriteLine();

            // Convert the hours to minutes
            const int SECONDS_PER_MINUTE = 60;
            float minutes = hours * SECONDS_PER_MINUTE;

            // Print out the gold collected
            float goldPerMinute = gold / minutes;

            Console.Write("You have collected ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(gold);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" gold");

            // Print out the hours played
            Console.Write("You have played ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(hours);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" hours");

            // Print out the gold per minute statistics  
            Console.Write("Your gold per minute statistics is ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(goldPerMinute);
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine();

        }
    }
}
