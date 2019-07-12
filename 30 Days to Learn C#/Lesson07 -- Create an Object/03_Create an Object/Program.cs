using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_Create_an_Object
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder();

            DateTime dt = new DateTime(); // just another example
            
            StringBuilder x = new StringBuilder()
                         ,y = x;          // Contains a reference to the object

            // two variable (x and y) are pointing to the same object
            // any changes in y we will see in x and vice versa
            x.Append("Hello, ");
            y.Append("world!");

            Console.WriteLine(x.ToString());

            // assign NULL -- can be used with reference types (not value types)
            // create a nullable datatype using "?". Useful for databases.
            x = null;
            int? foo = null;

            // another example: if we put "int myInt = 5; myInt = null;" it wouldn't work
            // creating a NULLABLE INT
            int? myInt = 5;
            myInt = null;


            Console.WriteLine(x); // it will be converted to an empty string. Prints a blank line
            Console.WriteLine(y.ToString());
            Console.WriteLine("foo = " + foo);
        }
    }
}
