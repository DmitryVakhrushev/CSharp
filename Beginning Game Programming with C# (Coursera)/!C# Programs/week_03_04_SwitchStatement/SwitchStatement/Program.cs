using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask for and get user answer
            Console.Write("Pick up the shiny thing? (y, n) ");
            char answer = Console.ReadLine()[0];

            // print appropriate message
            switch (answer)
            { 
                case 'y':
                case 'Y':
                    Console.WriteLine("You have a shiny thing");
                    break;

                case 'n':
                case 'N':
                    Console.WriteLine("You DO NOT have a shiny thing");
                    break;

                default:
                    Console.WriteLine("You are a n00b");
                    break;
            }

            Console.WriteLine();
        }
    }
}
