using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntroToStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            // prompt for and read in gamertag
            //String is a class, string (with a small "s") is a datatype
            // strings are immutable -- we can change the string object

            Console.Write("Enter gamertag: ");
            string gamertag = Console.ReadLine();

            // prompt for and read in level
            Console.Write("Enter level: ");
            int level = int.Parse(Console.ReadLine()); // "Parse" converts a string representation to a number

            // extract the first character of the gamertag
            char firstGamertagCharacter = gamertag[0];

            // print out values
            Console.WriteLine();
            Console.WriteLine("Gamertag: " + gamertag);
            Console.WriteLine("Level: " + level);
            Console.WriteLine("First gamertag character: " + firstGamertagCharacter);

        }
    }
}
