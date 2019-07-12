using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MyFirstProject.MyFirstDataTypes;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Old class-related code
            //Person john = new Person("John","Doe");
            //Person jane = new Person("Jane");

            //string greetings = john.SayHello(jane);
            //Console.WriteLine(greetings + "\n"); 
            #endregion

            // != ; == ; <= ; < ; > ; >=

            bool result = 6 > 5; // TRUE

            bool str1 = string.IsNullOrEmpty("Test"); // FALSE
            bool str2 = string.IsNullOrEmpty(""); // TRUE
            bool str3 = string.IsNullOrEmpty(string.Empty); // TRUE
            bool str4 = string.IsNullOrEmpty(null); // TRUE


            // we can test against "null" values
            string nullString = null;
            bool str5 = nullString == null;

            // Compare two objects with the same names
            Person bob = new Person("Bob", "Bob");
            Person bob2 = new Person("Bob", "Bob");

            Console.WriteLine("Compare two objects with the same fisrt and last names: " + (bob == bob2).ToString());
            Console.WriteLine(bob.FtNm == bob2.FtNm);
            Console.WriteLine("----------------------------------");

            // Logical AND: &&
            // Both conditions have to be TRUE to return TRUE
            Console.WriteLine (
                                (bob.FtNm == bob2.FtNm) && (bob.LtNm == bob2.LtNm)
                              );

            // Logical OR: ||
            // At LEAST ONE of the conditions have to be TRUE to return TRUE

            // Logical NOT: !
            // NOT True = False, NOT False = True


            Console.WriteLine(result);
            Console.WriteLine(str1);

            string myStr = "test";

            if (myStr != "test")
            {
                Console.WriteLine("This is true");
            }
            else
            {
                Console.WriteLine("This is false");
            }


            // Another Compariosn operator -- SWITCH
            // It tests just "equality". Not >, < , etc.
            // Whenever it finds a match the code in switch statement stops executing
            string myStr2 = "hTest";
            switch (myStr2)
            {
                case "test":
                    Console.WriteLine(@"The value is ""test""");
                    break;

                case "tEst":
                    Console.WriteLine(@"The value is ""tEst""");
                    break;

                case "Test":
                    Console.WriteLine(@"The value is ""Test""");
                    break;

                default:
                    Console.WriteLine("No value was found \n");
                    break;
            }


        }
    }
}
