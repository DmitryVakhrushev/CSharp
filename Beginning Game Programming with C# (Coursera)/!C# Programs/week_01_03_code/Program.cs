using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace FirstCSharpProgram
{
    /// <summary>
    /// Demonstrate integer data types
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrate integer data types
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
            
        {
            // Declare an integer variable and constant
            int totalSecondsPlayed = 100;
            const int SECONDS_PER_MINUTE = 60;

            // Claculate minutes and seconds
            int minutes = totalSecondsPlayed / SECONDS_PER_MINUTE;
            int seconds = totalSecondsPlayed % SECONDS_PER_MINUTE; // print a remainder

            // Print results
            Console.WriteLine("Minutes: " + minutes);
            Console.WriteLine("Seconds: " + seconds);

            // print a message to the screen
            //Console.WriteLine("Hi, smart n00b!");
            Console.WriteLine();


        }
    }
}
