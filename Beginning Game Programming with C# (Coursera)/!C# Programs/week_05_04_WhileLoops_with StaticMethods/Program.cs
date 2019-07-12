using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhileLoops
{
    /// <summary>
    /// Demonstrates while loops for input validation
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates while loops for input validation
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {

            //Console.WriteLine(myFunctions.PntHello("Kitty"));
            //Console.WriteLine(myFunctions.AddNum(3.4, 5.72));

            char choice;

            // prompt for and get menu choice
            choice = myFunctions.PrintMenu();

            //validate input
            while (choice != 'J' && choice != 'C' && choice != 'Q')
            {
                // print an error mesage and then menu
                myFunctions.InvalidInput();
                myFunctions.PrintMenu();
            }
            
            Console.WriteLine();

        }
    }
}
