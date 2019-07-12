using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FloatingPointNumbers
{
    /// <summary>
    /// Demonstartes Floating Point Numbers
    /// </summary>
    class Program
    {
        /// <summary>
        ///  Demonstartes Floating Point Numbers
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int score = 1356;
            int totalSecondsPlayed = 10000;

            // Calculate and display results
            // Temporarily convert "score" variable to float data type
            float pointsPerSecond = (float)score / totalSecondsPlayed;
            

            Console.WriteLine("Points Per Second " + pointsPerSecond);
            Console.WriteLine();

        }
    }
}
