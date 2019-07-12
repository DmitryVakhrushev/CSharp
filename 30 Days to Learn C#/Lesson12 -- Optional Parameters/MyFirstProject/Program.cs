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
            Person john = new Person("John","Doe");
            Person jane = new Person("Jane");

            string greetings = john.SayHello(jane);
            Console.WriteLine(greetings + "\n");
        }
    }
}
