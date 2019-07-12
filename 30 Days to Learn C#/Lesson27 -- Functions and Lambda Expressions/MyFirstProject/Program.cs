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
            List<string> names = new List<string>
            {
                "Jeremy",
                "Jeffrey",
                "John",
                "Jennifer",
                "Jackie",
                "Julianne"
            };

            // Functions always return a value
            // string as a parameter and bool as a return value. "fn" function name
            Func<string, bool> fn = FindNamesWithE;

            // to call the Function
            bool result = fn("ae"); // this will return TRUE (as the second letter is "e")


            // Lambda expressions are the shorten version of the deligate syntax
            // let's use "n" for "name"
            
            Predicate<string> pred = n => n.IndexOf("e") == 1;

            var namesWithE = names.FindAll(n => n.IndexOf("e") == 1);

            foreach (var name in namesWithE)
            {
                Console.WriteLine(name);
            }
        }

        public static bool FindNamesWithE(string name)
        {
            return name.IndexOf("e") == 1;
        }
    }
}
