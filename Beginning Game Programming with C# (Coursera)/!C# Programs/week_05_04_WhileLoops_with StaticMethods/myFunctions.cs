using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhileLoops
{
    class myFunctions
    {
        // Method returns Hello + name as a parameter
        public static string PntHello(string name)
        {
            return "Hello " + name;
        }

        //Method adds two numbers
        public static double AddNum(double x, double y)
        {
            return x + y;
        }


        public static char PrintMenu()
        {
            // print menu
            Console.WriteLine("J - Jump");
            Console.WriteLine("C - Crouch");
            Console.WriteLine("Q - Quit");
            Console.WriteLine();

            Console.Write("Enter choice: ");

            string inp = Console.ReadLine().ToUpper();
            return inp[0];

        }


        public static void InvalidInput()
        {
            // print an error mesage
            Console.WriteLine("\n" + "Invalid input, must be 'J','C', or 'Q'" + "\n");
        }
    }
}
