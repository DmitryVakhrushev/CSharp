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
            Person john = new Person("John","Brown");
            Person jane = new Person("Jane", "Green");

            // SayHello Overload 1
            Console.WriteLine(john.SayHello("Chebika" + "\n"));

            // SayHello Overload 2
            string greetings = john.SayHello(jane);
            Console.WriteLine(greetings);
        }
    }
}
