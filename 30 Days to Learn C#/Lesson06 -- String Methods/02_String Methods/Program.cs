using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_String_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string foo = "Hello, world!";

            int len = foo.Length;

            int inx1 = foo.IndexOf("e");
            int inx2 = foo.LastIndexOf("l");

            Console.WriteLine(foo);
            Console.WriteLine(len);
            Console.WriteLine("index of letter 'e' = " + inx1.ToString());
            Console.WriteLine("index of the LAST letter 'l' = " + inx2.ToString());

            // starts from index 3 with the len =5
            string part1 = foo.Substring(3, 5);
            Console.WriteLine("Substring part1 = " + part1);

            // remove 7 characters staring from 0
            // doesn't change "foo"
            string part2 = foo.Remove(0, 7); 
            Console.WriteLine("Substring part2 = " + part2);

            // we can do the same with "Replace" method
            string bar = foo.Replace("Hello, ", string.Empty);
            Console.WriteLine(bar);

            // replace "l" with "123"
            string part3 = foo.Replace("l", "123");
            Console.WriteLine(part3);

            // If we want to  change th actual value of foo
            foo = foo.Replace("l", "123");
            Console.WriteLine(foo);
        }
    }
}
