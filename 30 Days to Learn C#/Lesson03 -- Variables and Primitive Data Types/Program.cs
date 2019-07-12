using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_myFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Wohoo";

            Console.WriteLine("Hello World!");
            
            //Primitive data types (int, float, double, decimal, char, bool)
            //declare and initialize a variable  
            int foo = 10;

            int bar; // declare a variable
            bar = 17; // initialize with a value

            // declare several variable of THE SAME type using a comma ','
            int x = 12
                , y = 14
                , hello = foo
                , world = bar;

            // use "f" to explicitly convert double to float -- Inaccurate type
            float x1 = 3.14f;

            double x2 = 3.14;

            // use "m" to explicitly convert double to decimal -- Accurate type
            // we can use "decimal" data type for currency as it's very accurate.
            decimal x3 = 3.14m;

            char x4 = 's'; // Must contain just ONE character

            bool x5 = false; // true or false

            int x6 = 3;

            Console.WriteLine(foo.ToString() + ' ' + bar.ToString());
            Console.ReadLine();

            //-----------------------------------------------------------
            // 30 Days to Learn C# - Lesson 5 
            //-----------------------------------------------------------

            // Strings methods

            // \ -- Escape character
            string myString1 = "I asked, \"Isn't this a string?\"";
            Console.WriteLine(myString1);
            Console.WriteLine();

            // \t -- Tabulation
            string myString2 = "Using tabulation \t in the text";
            Console.WriteLine(myString2);
            Console.WriteLine();

            // \n -- New line
            string myString3 = "Using new line \n as a separate line";
            Console.WriteLine(myString3);
            Console.WriteLine();

            // @ -- Verbatum string --> Display everyting that's in this string
            string myString4 = @"Using @ sign to make it a verbatum string";
            Console.WriteLine(myString4);

            // to explicitly say it's an EMPTY STRING instead of ""
            string myString5 = string.Empty;
            Console.WriteLine();

            // Concatenate strings with "+" operator
            string myString6 = "This is a " + "string" + "!" + 7 + true + "\n";
            Console.WriteLine(myString6);

            // we split one line of code into the multiple lines
            string myString7 = "This is a "
                             + "string" // add a string
                             + "!"      // a character will be converted to a string
                             + 7        // a number will be converted to a string
                             + true     // a boolen value will be converted to a string
                             + "\n";
            Console.WriteLine(myString7);

            //----------------------------
            // Using Math class
            double t1;
            t1 = Math.Pow(3,2);

            Console.WriteLine(t1); ;

            Console.ReadLine();
        }
    }
}
